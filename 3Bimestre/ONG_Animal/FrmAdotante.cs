using _3Bimestre.Properties;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Bimestre.ONG_Animal
{
    public partial class FrmAdotante : Form , Menu
    {
        int ID = 0;
        Util Utilidade = new Util();
        NpgsqlConnection conexao;
        List<dynamic> campos = new List<dynamic>();
        public FrmAdotante()
        {
            InitializeComponent();
            campos.Add(TxtCidade.Text);
            campos.Add(TxtCpf.Text);
            campos.Add(TxtEndereco.Text);
            campos.Add(TxtEstado.Text);
            campos.Add(TxtNome.Text);
            campos.Add(TxtRg.Text);
            campos.Add(TxtTelefone.Text);
            conexao = new NpgsqlConnection(
                connectionString: "Server = localhost; Port = 5432; User ID = postgres; Password = postgres; Database = projeto_2b; Pooling = true");
            Utilidade.fillDataGrid("",conexao,DtgAdotante,"adotante");
        }
        private void BtnNovoAdotante_Click(object sender, EventArgs e)
        {
            if (Utilidade.nenhumCampoVazio(campos))
            {
                Adicionar();
            }
            else
            {
                MessageBox.Show("Campos obrigatorios não preenchidos!!");
                foreach(dynamic campo in campos)
                {
                    if(string.IsNullOrEmpty(campo))
                    {
                        Utilidade.mudarFonteParaNegrito(campo);
                    }
                }
            }
        }
        public void Adicionar()
        {

            string nome = TxtNome.Text;
            string cpf = TxtCpf.Text;
            string rg = TxtRg.Text;
            string endereco = TxtEndereco.Text;
            string estado = TxtEstado.Text;
            string telefone = TxtTelefone.Text;
            string cidade = TxtCidade.Text;
            var date = DtpDataNascimento.Value.Date;
            string query = "INSERT INTO adopter(nome, rg, cpf, data_nascimento, endereco, cidade, estado, telefone)" +
                              $"VALUES('{nome}', '{rg}', '{cpf}', '{date}', '{endereco}', " +
                              $"'{cidade}', '{estado}', '{telefone}')";
            Utilidade.executarComandoDB(query,conexao);
            Utilidade.fillDataGrid("", conexao, DtgAdotante, "adotante");
            Limpar();
        }

        private void DtgAdotante_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.ID = (int)DtgAdotante.SelectedRows[0].Cells[0].Value;

                var nome = DtgAdotante.SelectedRows[0].Cells[1].Value;
                var rg = DtgAdotante.SelectedRows[0].Cells[2].Value;
                var cpf = DtgAdotante.SelectedRows[0].Cells[3].Value;
                var data_nascimento = DtgAdotante.SelectedRows[0].Cells[4].Value;
                var endereco = DtgAdotante.SelectedRows[0].Cells[5].Value;
                var cidade = DtgAdotante.SelectedRows[0].Cells[6].Value;
                var estado = DtgAdotante.SelectedRows[0].Cells[7].Value;
                var telefone = DtgAdotante.SelectedRows[0].Cells[8].Value;

                var dataNascimento = data_nascimento.ToString().Split('/');
                int d = int.Parse(dataNascimento[0]);
                int m = int.Parse(dataNascimento[1]);
                int Y = int.Parse(dataNascimento[2].Split(' ')[0]);

                DtpDataNascimento.Value = new DateTime(Y, m, d);

                TxtNome.Text = nome.ToString();
                TxtRg.Text = rg.ToString();
                TxtCpf.Text = cpf.ToString();
                TxtEndereco.Text = endereco.ToString();
                TxtCidade.Text = cidade.ToString();
                TxtEstado.Text = estado.ToString();
                TxtTelefone.Text = telefone.ToString();

                BtnEditar.Visible = true;
                BtnDelete.Visible = true;
                BtnCancelar.Visible = true;
                BtnNovoAdotante.Visible = false;

            }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
        }

        private void BtnBusca_Click(object sender, EventArgs e)
        {
            this.conexao.Open();
            string query = $"SELECT * FROM adotante WHERE nome LIKE '%{TxtBusca.Text}%';";
            Utilidade.fillDataGrid(query, conexao, DtgAdotante, "adotante");
            this.conexao.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (Utilidade.nenhumCampoVazio(campos))
            {
                Editar();
            }
            else
            {
                MessageBox.Show("Campos obrigatorios não preenchidos!!");
                List<dynamic> campos_forms = new List<dynamic>()
                { 
                    TxtCidade,
                    TxtCpf,
                    TxtEndereco,
                    TxtEstado,
                    TxtNome,
                    TxtRg,
                    TxtTelefone
                };
                foreach (string campo in campos_forms)
                {
                    if (string.IsNullOrEmpty(campo))
                    {
                        Utilidade.mudarFonteParaNegrito(campo);
                    }
                }

            }
        }

        public void Editar()
        {
            string nome = TxtNome.Text;
            string cpf = TxtCpf.Text;
            string rg = TxtRg.Text;
            string endereco = TxtEndereco.Text;
            string estado = TxtEstado.Text;
            string telefone = TxtTelefone.Text;
            string cidade = TxtCidade.Text;
            var date = DtpDataNascimento.Value.Date;
            string query = $"UPDATE adopter SET nome = '{nome}', rg = '{rg}', cpf = '{cpf}', data_nascimento = '{date}', endereco = '{endereco}', cidade = '{cidade}', estado = '{estado}', telefone = '{telefone}' WHERE id = {this.ID}";
            Utilidade.executarComandoDB(query,conexao);
            Utilidade.fillDataGrid("", conexao, DtgAdotante, "adotante");
            Limpar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

            // Se quiser fazer um popup de verificação, basta inserir o código abaixo
            if(Utilidade.ConcordouComPopup("Você deseja excluir esse adotante?", "Essa ação é irreversível!"))
            Excluir();
        }
        public void Excluir()
        {
            string query = $"DELETE FROM adopter WHERE id = {this.ID}";
            Utilidade.executarComandoDB(query,conexao);
            Utilidade.fillDataGrid("", conexao, DtgAdotante, "adotante");
            Limpar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public void Limpar()
        {
            TxtNome.Text = "";
            TxtCpf.Text = "";
            TxtRg.Text = "";
            TxtEndereco.Text = "";
            TxtEstado.Text = "";
            TxtTelefone.Text = "";
            TxtCidade.Text = "";
            DtpDataNascimento.Value = DateTime.Now;
            BtnEditar.Visible = false;
            BtnDelete.Visible = false;
            BtnCancelar.Visible = false;
            BtnNovoAdotante.Visible = true;
        }
    }
}