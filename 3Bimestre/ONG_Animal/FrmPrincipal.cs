using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Dapper;
using Npgsql;
using ONG_Animal;

namespace _3Bimestre.ONG_Animal
{
    public partial class FrmPrincipal : Form
    {
        NpgsqlConnection conexao;
        int IdAnimal = 0;
        int IdAdotante = 0;
        int IdAdocao = 0;
        public FrmPrincipal()
        {
            InitializeComponent();
            conexao = new NpgsqlConnection(
                connectionString: "Server=localhost;" + "Port=5432;" +
                "User ID=postgres;" + "Password=postgres;" + "Database=projeto_2b;" + "Pooling=true;");

            ExecutarComandoDB("SELECT * FROM adocao;");

            Listas();
        }



        private void TsmiAnimal_Click(object sender, EventArgs e)
        {
            FrmAnimal frmAnimal = new FrmAnimal();
            frmAnimal.ShowDialog();
        }

        private void TsmiAdotante_Click(object sender, EventArgs e)
        {
            FrmAdotante frmAdotante = new FrmAdotante();
            frmAdotante.ShowDialog();
        }

        private void TsmiAjuda_Click(object sender, EventArgs e)
        {
            FrmAjuda frmaAjuda = new FrmAjuda();
            frmaAjuda.ShowDialog();
        }


        private void ExecutarComandoDB(string query)
        {
            try
            {

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        DtgAdocao.DataSource = dt;
                    }
                }

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }



        private void Listas()
        {

            try
            {
                var queryAdotante = "SELECT nome FROM adotante;";
                var queryAnimal = "SELECT nome FROM animal";
                dynamic pessoas, animais;
                using (conexao)
                {
                    pessoas = conexao.Query<Adotante>(sql: queryAdotante);
                    animais = conexao.Query<Animal>(sql: queryAnimal);
                }
                foreach (dynamic p in pessoas) CblAdotante.Items.Add(p.Nome);
                foreach (dynamic a in animais) CblAnimal.Items.Add(a.Nome);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);


            }

        }
        //  private IEnumerable<Adotante> ListaAdotante()
        //    {
        //       try
        //    {

        //           var query = "SELECT nome FROM  adotante;";

        ///       using (conexao)
        //     {
        //         return conexao.Query<Adotante>(sql: query);

        //  }
        ///   }
        //   catch (NpgsqlException ex)
        //  {
        //   MessageBox.Show("Erro: " + ex.Message);
        //    return Enumerable.Empty<Adotante>();

        // }
        // }



        private void BtnNovaAdocao_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CblAnimal.Text) &&
               !string.IsNullOrEmpty(CblAdotante.Text) &&
               !string.IsNullOrEmpty(CblStatus.Text) &&
               !string.IsNullOrEmpty(CblInformaçoes.Text))
            {
                NovoAdocao();
            }
            else
            {
                MessageBox.Show("Campos obrigatorios não preenhidos!!");

                if (string.IsNullOrEmpty(CblAnimal.Text))
                    LblAnimal.Font = new Font(this.Font, FontStyle.Bold);
                if (string.IsNullOrEmpty(CblAdotante.Text))
                    LblAdotante.Font = new Font(this.Font, FontStyle.Bold);
                if (string.IsNullOrEmpty(CblStatus.Text))
                    LblStatus.Font = new Font(this.Font, FontStyle.Bold);
                if (string.IsNullOrEmpty(CblInformaçoes.Text))
                    LblInformacoes.Font = new Font(this.Font, FontStyle.Bold);

            }


        }


        private void BtnBusca_Click(object sender, EventArgs e)
        {
            //Pesquisa de Adoção 
            String busca = this.TxtBusca.Text;
            string query = "SELECT an.nome AS animal, an.tipo,ad.nome AS adotante,ac.data_adocao,ac.status,ac.informacoes ," +
                "FROM adocao AS ac ,INNER JOIN animal AS an ON ac.animal = an.id ,INNER JOIN adotante AS ad ON ac.adotante = ad.id," +
                $"WHERE ad.nome LIKE '%{busca}%' or an.nome LIKE '%{busca}%';";

            ExecutarComandoDB(query);
        }

        private void NovoAdocao()
        {

            string animal = this.CblAnimal.Text;
            string adotante = this.CblAdotante.Text;
            string Status = this.CblStatus.Text;
            string informacoes = this.CblInformaçoes.Text;
            string query = "INSERT INTO adotante(animal, adotante, status, informacoes)" +
                              $"VALUES('{animal}','{adotante}','{Status}','{informacoes}';";
            ExecutarComandoDB(query);
        }

        private void CblAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT id FROM animal" +
                    $"WHERE nome= '{CblAnimal.Text}';";
                dynamic animal = conexao.Query<Animal>(sql: query);
                this.IdAnimal = animal[0].Id;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
