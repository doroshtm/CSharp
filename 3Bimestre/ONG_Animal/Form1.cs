using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Dapper;

namespace _3Bimestre.ONG_Animal
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
            conexao = new NpgsqlConnection(
                connectionString: "Server = localhost; Port = 5432; User ID = postgres; Password = postgres; Database = Windows Forms; Pooling = true");
        }


        private void executeDBQuery()
        {
            try
            {
                this.conexao.Open();
                var query = $"SELECT * FROM ANIMAL;";

                using(NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dtgAnimal.DataSource = dt;
                    }
                }
                this.conexao.Close();
            }catch(NpgsqlException ex) { }
        }
        private void btnSearch_Click()
        {
            string search = this.txtSearch.Text;
            string query = "SELECT an.nome AS animal, an.type, ad.name AS adopter, ac.adoption_date, ac.status, ac.info FROM adoption AS ac INNER JOIN animal AS an ON ac.animal = an.id INNER JOIN adopter AS ad ON ac.adopter = ad.id WHERE ad.name LIKE '%a%' or an.name LIKE '%a%';";
            
        }
        // Animal = pessoa que adotou - situação da adoção - informações
        private void NewAdopter()
        {
            string animal = this.txtNameAnimal.Text;
            string adopter = this.txtAdopterName.Text;
            string situation = this.txtAdoptionSituation.Text;
            string info = this.txtInfoAnimal.Text;
            string query = "INSERT INTO adoption(animal, adopter, status, info)" + $"VALUES ('{animal}','{adopter}','{situation}', '{info}')";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
