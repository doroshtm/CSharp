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
using ONG_Animal;
using _3Bimestre.Properties;


namespace _3Bimestre.ONG_Animal
{
    public partial class FrmAnimal : Form, Menu
    {
        NpgsqlConnection conexao;
        Util Utilidade = new Util();
        int IdAnimal = 0;

        public FrmAnimal()
        {
            InitializeComponent();
            conexao = Utilidade.ConectarComDB();

            CarregarDados(null);
        }

       /* private void TsmiAnimais_Click(object sender, EventArgs e)
        {
            FrmAnimal frmAnimal = new FrmAnimal();
            frmAnimal.ShowDialog();
        }*/

        private void TsmiAdotante_Click(object sender, EventArgs e)
        {
            FrmAdotante frmAdotante = new FrmAdotante();
            frmAdotante.ShowDialog();
        }

        private void TsmiAjuda_Click(object sender, EventArgs e)
        {
            FrmAjuda frmAjuda = new FrmAjuda();
            frmAjuda.ShowDialog();
        }

        private void CarregarDados(string comando)
        {
            string query = comando != null
                           ? comando
                           : "SELECT * FROM animal";

            try
            {
                conexao.Open();

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        DtgAnimal.DataSource = dt;
                    }
                }
                tslAnimal.Text = "Pronto!";

                conexao.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
                tslAnimal.Text = ex.Message;
            }


        }

        private void BtnBusca_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM animal WHERE nome LIKE '%{TxtBusca.Text}%'";
            CarregarDados(query);
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (Utilidade.nenhumCampoVazio(TxtAnimalNome.Text,
                TxtGenero.Text, TxtAnimalTipo.Text, TxtSituacao.Text,
                TxtVacinacao.Text))
            {
                try
                {
                    Adicionar();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    tslAnimal.Text = ex.Message;
                }
            }
            else
            {
                List<dynamic> campos = new List<dynamic>() { TxtAnimalNome.Text,
                TxtGenero.Text, TxtAnimalTipo.Text, TxtSituacao.Text,
                TxtVacinacao.Text, chDisponivelAdocao.Checked };
                MessageBox.Show("Campos obrigatórios não preenchidos!");
                foreach(dynamic campo in campos)
                {
                    if (string.IsNullOrEmpty(campo))
                        Utilidade.mudarFonteParaNegrito(campo);
                }
            }
        }
        public void Adicionar()
        {
            //Tratamento da data de adoção
            var data = DtpDataNascimento.Value;
            string tipo = TxtAnimalTipo.Text;
            string nome = TxtAnimalNome.Text;
            string genero = TxtGenero.Text;
            string status = TxtSituacao.Text;
            string vacinacao = TxtVacinacao.Text;
            bool disponivel = chDisponivelAdocao.Checked;

            var query = "INSERT INTO animal (nome,tipo,genero,data_nascimento,vacinacao,disponibilidade_adocao,status)" +
                " VALUES " +
                $"('{nome}','{tipo}','{genero}','{data}','{vacinacao}','{disponivel}','{status}');";

            conexao.Query(sql: query);
            MessageBox.Show("Animal inserido com sucesso!");
            LimpaCampos();
            CarregarDados(null); //Carrega lista atualizada com o novo registro
        }
        private void LimpaCampos()
        {
            TxtAnimalNome.ResetText();
            TxtAnimalTipo.ResetText();
            TxtGenero.Clear();
            TxtSituacao.ResetText();
            TxtVacinacao.Clear();
            chDisponivelAdocao.Checked = false;
        }

        private void DtgAnimal_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.IdAnimal = (int)DtgAnimal.SelectedRows[0].Cells[0].Value;

                var nomeAnimal = DtgAnimal.SelectedRows[0].Cells[1].Value;
                var tipoAnimal = DtgAnimal.SelectedRows[0].Cells[2].Value;
                var generoAnimal = DtgAnimal.SelectedRows[0].Cells[3].Value;
                var data_nascimento = DtgAnimal.SelectedRows[0].Cells[4].Value;
                var vacinaAnimal = DtgAnimal.SelectedRows[0].Cells[5].Value;
                var disponivelAnimal = DtgAnimal.SelectedRows[0].Cells[6].Value;
                var situacaoAnimal = DtgAnimal.SelectedRows[0].Cells[7].Value;

                var newDate = data_nascimento.ToString().Split('/');
                int d = int.Parse(newDate[0]);
                int m = int.Parse(newDate[1]);
                int y = int.Parse(newDate[2].Split(' ')[0]);

                DtpDataNascimento.Value = new DateTime(y, m, d);

                TxtAnimalNome.Text = nomeAnimal.ToString();
                TxtAnimalTipo.Text = tipoAnimal.ToString();

                TxtSituacao.Text = situacaoAnimal.ToString();
                TxtGenero.Text = generoAnimal.ToString();
                chDisponivelAdocao.Checked = (bool)disponivelAnimal;
                TxtVacinacao.Text = vacinaAnimal.ToString();
                TxtGenero.Text = generoAnimal.ToString();

                BtnEditar.Visible = true;
                BtnExcluir.Visible = true;
                BtnCancelar.Visible = true;
                BtnNovo.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                tslAnimal.Text = ex.Message;
            }
        }
        public void Cancelar()
        {
            BtnNovo.Visible = true;
            BtnEditar.Visible = false;
            BtnExcluir.Visible = false;
            BtnCancelar.Visible = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            Cancelar();
            CarregarDados(null);
        }
        public void Editar()
        {
            string nome = TxtAnimalNome.Text;
            string tipo = TxtAnimalTipo.Text;
            string genero = TxtGenero.Text;
            string vacinacao = TxtVacinacao.Text;
            string status = TxtSituacao.Text;
            bool disponibilidade = chDisponivelAdocao.Checked;
            var data = DtpDataNascimento.Value.Date;

            var update = $"UPDATE animal SET nome = '{nome}', tipo = '{tipo}', genero = '{genero}'," +
                $"data_nascimento = '{data}', vacinacao = '{vacinacao}', disponibilidade_adocao = '{disponibilidade}'," +
                $"status = '{status}' WHERE id = {this.IdAnimal};"; 
            conexao.Query(sql: update);
            MessageBox.Show("Dados atualizados com sucesso!!!");
            LimpaCampos();
            Cancelar();
            CarregarDados(null);
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                tslAnimal.Text = ex.Message;
            }
        }
        private bool ConcordouComPopup(string texto, string titulo)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir este registro?",
                                         "Atenção!!!",
                                         MessageBoxButtons.YesNo);
            return resultado == DialogResult.Yes;
        }
        public void Excluir()
        {
            var delete = $"DELETE FROM animal WHERE id = {this.IdAnimal}";
            conexao.Query(sql: delete);
            MessageBox.Show("Animal excluído com sucesso!!!"); 
            LimpaCampos();
            Cancelar();
            CarregarDados(null);
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir este registro?",
                                                     "Atenção!!!",
                                                     MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    Excluir();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    tslAnimal.Text = ex.Message;
                }
            }
        }
    }
}