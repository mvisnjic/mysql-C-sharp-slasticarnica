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
    public partial class IzdaniRacuniUC : UserControl
    {
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=slastika;user=manager;Pwd=manager;SslMode=none");

        public IzdaniRacuniUC()
        {
            InitializeComponent();
            FillData();
        }
        void FillData()
        {
            connection.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM racun;", connection);
            DataTable t = new DataTable();
            sda.Fill(t);
            dataGridView_racuni.DataSource = t;
        }
        private DataTable PrikazPrekoID()
        {
            DataTable tablica = new DataTable();
            string upit = "select * from racun WHERE id_zaposlenik = '" + textBox_idzapo.Text + "'";
            using (MySqlCommand cmd = new MySqlCommand(upit,connection))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                tablica.Load(reader);
            }
            return tablica;

        }

        private void button_prikazizaodredenog_Click(object sender, EventArgs e)
        {
            dataGridView_racuni.DataSource = PrikazPrekoID();
        }
    }
}
