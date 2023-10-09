using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3Bimestre.ONG_Animal;
using Dapper;
using Npgsql;

namespace ONG_Pet_2a
{
    public partial class FrmPrincipal : Form
    {
        NpgsqlConnection connection;

        int IdAnimal = 0;
        int IdAdopter = 0;
        int IdAdoption = 0;

        public FrmPrincipal()
        {
            InitializeComponent();

            connection = new NpgsqlConnection(
                connectionString: "Server = localhost; Port = 5432; User ID = postgres; Password = postgres; Database = Windows Forms; Pooling = true");
            executeDBQuery("SELECT * FROM adoption;");

            executeDBQuery(null);
            CarregarListaDados();
        }

        private void TsmiAnimais_Click(object sender, EventArgs e)
        {
            FrmAnimal frmAnimal = new FrmAnimal();
            frmAnimal.ShowDialog();
        }

        private void TsmiAdopter_Click(object sender, EventArgs e)
        {
            FrmAdopter frmAdopter = new FrmAdopter();
            frmAdopter.ShowDialog();
        }

        private void TsmiAjuda_Click(object sender, EventArgs e)
        {
            FrmAjuda frmAjuda = new FrmAjuda();
            frmAjuda.ShowDialog();
        }

        private void executeDBQuery(string command)
        {
            string query = command != null
                           ? command
                           : "SELECT ac.id AS Id_Adoption, an.id AS Id_Animal, " +
                           "an.name AS animal, an.type, " +
                           "ad.id AS Id_Adopter, " +
                           "ad.name AS adopter, ac.adoption_date," +
                           "ac.status, ac.info " +
                           "FROM adoption AS ac " +
                           "INNER JOIN animal AS an ON ac.animal = an.id " +
                           "INNER JOIN adopter AS ad ON ac.adopter = ad.id;";

            try
            {
                connection.Open();

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        DtgAdoption.DataSource = dt;
                    }
                }


                connection.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }


        }

        private void BtnBusca_Click(object sender, EventArgs e)
        {
            string query = "SELECT an.name AS animal, an.type, " +
                "ad.name AS adopter," +
                "ac.adoption_date," +
                "ac.status," +
                "ac.info " +
                "FROM adoption AS ac " +
                "INNER JOIN animal AS an ON ac.animal = an.id " +
                "INNER JOIN adopter AS ad ON ac.adopter = ad.id " +
                $"WHERE ad.name LIKE '%{TxtBusca.Text}%' or an.name LIKE '%{TxtBusca.Text}%';";
            executeDBQuery(query);
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CblAnimal.Text) &&
                !string.IsNullOrEmpty(CblAdopter.Text) &&
                !string.IsNullOrEmpty(TxtStatus.Text) &&
                !string.IsNullOrEmpty(TxtInformacoes.Text))
            {
                try
                {
                    //Tratamento da data de adoção
                    var day = DtAdoption.Value.Day;
                    var month = DtAdoption.Value.Month;
                    var year = DtAdoption.Value.Year;
                    string dataAdoption = year + "/" + month + "/" + day;

                    if (this.IdAnimal != 0 && this.IdAdopter != 0)
                    {
                        var query = "INSERT INTO adoption (animal, adopter, " +
                            "data_adoption, status, informacoes) VALUES " +
                            $"({this.IdAnimal},{this.IdAdopter},'{dataAdoption}'," +
                            $"'{TxtStatus.Text}','{TxtInformacoes.Text}')";

                        var queryDisponibilidade = "UPDATE animal SET availabletoadoption = false " +
                                                   $"WHERE id={this.IdAnimal};";

                        connection.Query(sql: query); //Executa a inserção de dados
                        connection.Query(sql: queryDisponibilidade); //Executa a atualização de animal
                                                                  //para não disponível para
                                                                  //novas adoções
                        MessageBox.Show("Nova adoção feita com sucesso!");
                        LimpaCampos();
                        executeDBQuery(null); //Carrega lista atualizada com o novo registro
                    }
                    else
                    {
                        MessageBox.Show("Animal e/ou pessoa adopter não encontrados!");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!");
                if (string.IsNullOrEmpty(CblAnimal.Text))
                    LblAnimal.Font = new Font(this.Font, FontStyle.Bold);
                if (string.IsNullOrEmpty(CblAdopter.Text))
                    LblAdopter.Font = new Font(this.Font, FontStyle.Bold);
                if (string.IsNullOrEmpty(TxtStatus.Text))
                    LblStatus.Font = new Font(this.Font, FontStyle.Bold);
                if (string.IsNullOrEmpty(TxtInformacoes.Text))
                    LblInformacoes.Font = new Font(this.Font, FontStyle.Bold);
            }
        }

        private void CarregarListaDados()
        {
            try
            {
                var queryAnimal = "SELECT * FROM animal WHERE availabletoadoption = true;";
                var queryAdopter = "SELECT * FROM adopter;";

                var listaAnimal = connection.Query<Animal>(sql: queryAnimal);
                var listaAdopter = connection.Query<Adopter>(sql: queryAdopter);

                foreach (var animal in listaAnimal) CblAnimal.Items.Add(animal.Name);
                foreach (var pessoa in listaAdopter) CblAdopter.Items.Add(pessoa.Name);

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void LimpaCampos()
        {
            CblAdopter.ResetText();
            CblAnimal.ResetText();

            TxtInformacoes.Clear();
            TxtStatus.Clear();
            DtAdoption.ResetText();
        }

        private void CblAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var query = $"SELECT * FROM animal WHERE nome = '{CblAnimal.Text}';";
                dynamic resultado = connection.Query<Animal>(sql: query);

                this.IdAnimal = resultado[0].Id; //Atribui o animal selecionado ao ID

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void CblAdopter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var query = $"SELECT id FROM adopter WHERE nome = '{CblAdopter.Text}';";
                dynamic resultado = connection.Query<Adopter>(sql: query);

                this.IdAdopter = resultado[0].Id; //Atribui o adopter selecionado ao ID

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void DtgAdoption_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.IdAdoption = (int)DtgAdoption.SelectedRows[0].Cells[0].Value;
                this.IdAdopter = (int)DtgAdoption.SelectedRows[0].Cells[4].Value;
                this.IdAnimal = (int)DtgAdoption.SelectedRows[0].Cells[1].Value;

                var animalName = DtgAdoption.SelectedRows[0].Cells[2].Value;
                var adopterName = DtgAdoption.SelectedRows[0].Cells[5].Value;
                var adoptionDate = DtgAdoption.SelectedRows[0].Cells[6].Value;
                var adoptionStatus = DtgAdoption.SelectedRows[0].Cells[7].Value;
                var adoptionInfo = DtgAdoption.SelectedRows[0].Cells[8].Value;

                var newDate = adoptionDate.ToString().Split('/');
                int d = int.Parse(newDate[0]);
                int m = int.Parse(newDate[1]);
                int Y = int.Parse(newDate[2].Split(' ')[0]);

                DtAdoption.Value = new DateTime(Y, m, d);

                CblAnimal.Text = animalName.ToString();
                CblAdopter.Text = adopterName.ToString();

                TxtStatus.Text = adoptionStatus.ToString();
                TxtInformacoes.Text = adoptionInfo.ToString();

                BtnEditar.Visible = true;
                BtnExcluir.Visible = true;
                BtnCancelar.Visible = true;
                BtnNovo.Visible = false;

                CblAdopter.Enabled = false;
                CblAnimal.Enabled = false;

            }catch(Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
        }
    }
}
