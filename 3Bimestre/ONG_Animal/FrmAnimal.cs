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
        string queryBusca = "";
        NpgsqlConnection conexao;
        Util Utilidade = new Util();
        int IdAnimal = 0;

        public FrmAnimal()
        {
            InitializeComponent();
            conexao = Utilidade.ConectarComDB();

            Utilidade.fillDataGrid("", conexao, DtgAnimal, "animal");
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


        private void BtnBusca_Click(object sender, EventArgs e)
        {
            queryBusca = $"SELECT * FROM animal WHERE nome LIKE '%{TxtBusca.Text}%' ORDER BY id";
            Utilidade.fillDataGrid(queryBusca, conexao, DtgAnimal, "animal");
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtAnimalNome.Text) &&
                !string.IsNullOrEmpty(TxtAnimalTipo.Text) &&
                !string.IsNullOrEmpty(TxtGenero.Text) &&
                !string.IsNullOrEmpty(TxtSituacao.Text) &&
                !string.IsNullOrEmpty(TxtVacinacao.Text))
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
                MessageBox.Show("Campos obrigatorios não preenchidos!!");

                if (string.IsNullOrEmpty(TxtAnimalNome.Text))
                    LblNomeAnimal.Font = new Font(this.Font, FontStyle.Bold);
                if (string.IsNullOrEmpty(TxtAnimalTipo.Text))
                    LblTipoAnimal.Font = new Font(this.Font, FontStyle.Bold);
                 if (string.IsNullOrEmpty(TxtGenero.Text))
                    LblGenero.Font = new Font(this.Font, FontStyle.Bold);
                 if (string.IsNullOrEmpty(TxtSituacao.Text))
                    LblStatusAnimal.Font = new Font(this.Font, FontStyle.Bold);
                 if (string.IsNullOrEmpty(TxtVacinacao.Text))
                    LblVacinacao.Font = new Font(this.Font, FontStyle.Bold);

            }
        }
        public void Adicionar()
        {
            //Tratamento da data de adoção
            var day = DtpDataNascimento.Value.Day;
            var month = DtpDataNascimento.Value.Month;
            var year = DtpDataNascimento.Value.Year;
            string dataAnimal = year + "/" + month + "/" + day;
            string tipo = TxtAnimalTipo.Text;
            string animal = TxtAnimalNome.Text;
            string genero = TxtGenero.Text;
            string status = TxtSituacao.Text;
            string vacinacao = TxtVacinacao.Text;
            bool disponivel = ChDisponivelAdocao.Checked;
            var query = "INSERT INTO animal (nome,tipo,genero,data_nascimento,vacinacao,disponibilidade_adocao,status) " +
                $"VALUES ('{animal}','{tipo}','{genero}','{dataAnimal}','{vacinacao}','{disponivel}','{status}')";

            conexao.Query(sql: query);
            MessageBox.Show("Novao animal adicionado com sucesso!");
            LimpaCampos();
            Utilidade.fillDataGrid(queryBusca, conexao, DtgAnimal, "animal");
        }
        private void LimpaCampos()
        {
            TxtAnimalNome.ResetText();
            TxtAnimalTipo.ResetText();
            TxtGenero.Clear();
            TxtSituacao.ResetText();
            TxtVacinacao.Clear();
            ChDisponivelAdocao.Checked = false;
        }

        private void DtgAnimal_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.IdAnimal = (int)DtgAnimal.SelectedRows[0].Cells[0].Value;

                var nomeAnimal = DtgAnimal.SelectedRows[0].Cells[1].Value;
                var tipoAnimal = DtgAnimal.SelectedRows[0].Cells[2].Value;
                var generoAnimal = DtgAnimal.SelectedRows[0].Cells[3].Value;
                var dataAnimal = DtgAnimal.SelectedRows[0].Cells[4].Value;
                var vacinaAnimal = DtgAnimal.SelectedRows[0].Cells[5].Value;
                var disponivelAnimal = DtgAnimal.SelectedRows[0].Cells[6].Value;
                var situacaoAnimal = DtgAnimal.SelectedRows[0].Cells[7].Value;

                var data = dataAnimal.ToString().Split('/');
                int d = int.Parse(data[0]);
                int m = int.Parse(data[1]);
                int Y = int.Parse(data[2].Split(' ')[0]);

                DtpDataNascimento.Value = new DateTime(Y, m, d);

                TxtAnimalNome.Text = nomeAnimal.ToString();
                TxtAnimalTipo.Text = tipoAnimal.ToString();

                TxtSituacao.Text = situacaoAnimal.ToString();
                TxtGenero.Text = generoAnimal.ToString();
                ChDisponivelAdocao.Checked = (bool)disponivelAnimal;
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
        public void Limpar()
        {
            BtnEditar.Visible = false;
            BtnExcluir.Visible = false;
            BtnCancelar.Visible = false;
            BtnNovo.Visible = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            Limpar();
            Utilidade.fillDataGrid(queryBusca, conexao, DtgAnimal, "animal");
        }
        public void Editar()
        {
            string nome = TxtAnimalNome.Text;
            string tipo = TxtAnimalTipo.Text;
            string genero = TxtGenero.Text;
            string vacinacao = TxtVacinacao.Text;
            string status = TxtSituacao.Text;
            bool disponibilidade = ChDisponivelAdocao.Checked;

            var update = $"UPDATE animal SET nome = '{nome}', tipo = '{tipo}', genero = '{genero}'," +
                $"vacinacao = '{vacinacao}', disponibilidade_adocao = '{disponibilidade}', status = '{status}'" +
                $"WHERE id = {this.IdAnimal}";
            conexao.Query(sql: update);
            MessageBox.Show("Dados atualizados com sucesso!!!");
            LimpaCampos();
            Limpar();
            Utilidade.fillDataGrid(queryBusca, conexao, DtgAnimal, "animal");
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
        public void Excluir()
        {
            var delete = $"DELETE FROM animal WHERE id = {this.IdAnimal}";
            conexao.Query(sql: delete);
            MessageBox.Show("Animal excluído com sucesso!!!"); 
            LimpaCampos();
            Limpar();
            Utilidade.fillDataGrid(queryBusca, conexao, DtgAnimal, "animal");
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (Utilidade.ConcordouComPopup("Deseja excluir esse registro?", "Atenção!!!"))
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