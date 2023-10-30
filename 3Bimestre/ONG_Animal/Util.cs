using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Bimestre.ONG_Animal
{
    internal class Util
    {
        public dynamic ConectarComDB()
        {
            return new NpgsqlConnection(
                connectionString: "Server = localhost; Port = 5432; User ID = postgres; Password = postgres; Database = projeto_2b; Pooling = true");
        }
        public bool nenhumCampoVazio(params dynamic[] campos)
        {
            bool ret = true;
            foreach (dynamic campo in campos)
            {
                ret = ret && !string.IsNullOrEmpty(campo);
            }
            return ret;
        }
        public void mudarFonteParaNegrito(ref System.Windows.Forms.Label campo)
        {
            campo.Font = new Font(campo.Font, FontStyle.Bold);
        }
        public void fillDataGrid(string query, dynamic conexao, dynamic datagrid)
        {
            try
            {
                this.conexao.Open();
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        datagrid.DataSource = dt;
                    }
                }
                this.conexao.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void executarComandoDB(string query, dynamic conexao)
        {
            try
            {
                this.conexao.Open();
                conexao.Query(sql: query);
                this.conexao.Close();

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
    }
}
