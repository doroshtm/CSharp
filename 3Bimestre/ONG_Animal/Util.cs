using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3Bimestre.ONG_Animal;
using _3Bimestre.Properties;

namespace _3Bimestre.ONG_Animal
{
    internal class Util : Ferramentas
    {
        /* Manipulação de campos */

        /* Banco de Dados */

        public void fillDataGrid(string query, dynamic conexao,dynamic Datagrid, string nomeTabela )
        {
            if (string.IsNullOrEmpty(query))
            {
                query = $"SELECT * FROM {nomeTabela} ORDER BY id";
            }
            try
            {
                conexao.Open();
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        Datagrid.DataSource = dt;
                    }
                }
                conexao.Close();

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                conexao.Close();
            }
        }
        public void executarComandoDB(string query, dynamic conexao)
        {
            try
            {
                conexao.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, conexao);
                command.ExecuteNonQuery();
                conexao.Close();

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                conexao.Close();
            }

        }
        public dynamic ConectarComDB()
        {
            return new NpgsqlConnection(
                connectionString: "Server=localhost;" + "Port=5432;" +
                "User ID=postgres;" + "Password=postgres;" + "Database=projeto_2b;" + "Pooling=true;");
        }



        /* Outros */

        public bool ConcordouComPopup(string texto, string titulo)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir este registro?",
                                         "Atenção!!!",
                                         MessageBoxButtons.YesNo);
            return resultado == DialogResult.Yes;
        }
    }
}
