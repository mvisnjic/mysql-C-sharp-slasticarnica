using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace PrijavaKorisnika
{
    public partial class PrikaziMeni : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=slastika;user=manager;Pwd=manager;SslMode=none");

        public PrikaziMeni()
        {
            InitializeComponent();
        }
        public static DataTable Meni()
        {
            MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=slastika;user=manager;Pwd=manager;SslMode=none");
            connection.Open();
            DataTable tablica = new DataTable();
            string pokazimeni = "SELECT * FROM meni;";

            using (MySqlCommand command = new MySqlCommand(pokazimeni, connection))
            {

                MySqlDataReader reader = command.ExecuteReader();
                tablica.Load(reader);
                connection.Close();
            }

            return tablica;

        }

        private void PrikaziMeni_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Meni();
        }

    }
}
