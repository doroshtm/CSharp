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
    public partial class FormMain : Form
    {
        NpgsqlConnection connection;
        int IdAnimal = 0;
        int IdAdopter = 0;
        int IdAdoption = 0;
        public FormMain()
        {
            InitializeComponent();
            connection = new NpgsqlConnection(
                connectionString: "Server = localhost; Port = 5432; User ID = postgres; Password = postgres; Database = Windows Forms; Pooling = true");
            executeDBQuery("SELECT * FROM adocao;");
            AnimalAdopterList();
        }


        private void executeDBQuery(string v)
        {
            try
            {
                this.connection.Open();
                var query = $"SELECT * FROM ANIMAL;";

                using(NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dtgAnimal.DataSource = dt;
                    }
                }
                this.connection.Close();
            }catch(NpgsqlException ex) { }
        }
        private void btnSearch_Click()
        {
            string search = this.txtSearch.Text;
            string query = "SELECT an.name AS animal, an.type, ad.name AS adopter, ac.adoption_date, ac.status, ac.info FROM adoption AS ac INNER JOIN animal AS an ON ac.animal = an.id INNER JOIN adopter AS ad ON ac.adopter = ad.id WHERE ad.name LIKE '%a%' or an.name LIKE '%a%';";
            
        }
        // Animal = pessoa que adotou - situação da adoção - informações
        private void NewAdopter()
        {
            string animal = this.cblAnimal.Text;
            string adopter = this.cblAdopter.Text;
            string situation = this.txtAdoptionSituation.Text;
            string info = this.txtInfoAnimal.Text;
            string query = "INSERT INTO adoption(animal, adopter, status, info)" + $"VALUES ('{animal}','{adopter}','{situation}', '{info}')";
        }
        private void AnimalAdopterList()
        {
            try
            {
                var queryAdopter = "SELECT name FROM adopter";
                var queryAnimal = "SELECT name FROM animal;";
                dynamic adopters, animals;


                using (connection)
                {
                    adopters = connection.Query<Adopter>(sql: queryAdopter);
                    animals = connection.Query<Animal>(sql: queryAnimal);
                    cblAdopter.Items.Add(adopters);
                }
                foreach (dynamic adopter in adopters) cblAdopter.Items.Add(adopter.Name);
                foreach (dynamic animal in animals) cblAnimal.Items.Add(animal.Name);
            }
            catch (NpgsqlException ex) { MessageBox.Show("Erro: " + ex); }
        }
        private void btnNewAnimal_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
