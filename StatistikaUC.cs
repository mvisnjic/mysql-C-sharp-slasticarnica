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
    public partial class StatistikaUC : UserControl
    {
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=slastika;user=manager;Pwd=manager;SslMode=none");
        public StatistikaUC()
        {
            InitializeComponent();
     
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            PrikaziMeni pm = new PrikaziMeni();
            pm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable tablica = new DataTable();
            connection.Open();
            MySqlCommand prikazi = new MySqlCommand();

            prikazi.Connection = connection;
            prikazi.CommandType = CommandType.StoredProcedure;
            prikazi.CommandText = "kolicina_prodanog";

            prikazi.Parameters.Add(new MySqlParameter("@p_id_meni", MySqlDbType.Int32)).Value = textBox_idartikla.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(prikazi);
            sda.Fill(tablica);


            int query = prikazi.ExecuteNonQuery();

            if (query >= 0)
            {
                connection.Close();
                dataGridView1.DataSource = tablica;
            }
            else
            {
                MessageBox.Show("Došlo je do pogreške!");
                connection.Close();
            }

        }

        private void button_prikazizaposlenike_Click(object sender, EventArgs e)
        {
            DataTable tablica = new DataTable();
            connection.Open();
            MySqlCommand prikazizaposlenike = new MySqlCommand();

            prikazizaposlenike.Connection = connection;
            prikazizaposlenike.CommandType = CommandType.StoredProcedure;
            prikazizaposlenike.CommandText = "naj_zaposlenik";

            prikazizaposlenike.Parameters.Add(new MySqlParameter("", MySqlDbType.String)).Value = "";
            MySqlDataAdapter sda = new MySqlDataAdapter(prikazizaposlenike);
            sda.Fill(tablica);

            int query = prikazizaposlenike.ExecuteNonQuery();

            if(query >= 0)
            {
                connection.Close();
                dataGridView1.DataSource = tablica;
            }
            else
            {
                MessageBox.Show("Došlo je do pogreške!");
                connection.Close();
            }


        }
    }
}
