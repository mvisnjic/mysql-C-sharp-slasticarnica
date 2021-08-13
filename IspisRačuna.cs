using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace PrijavaKorisnika

{
    public partial class IspisRačuna : UserControl
    {
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=slastika;user=manager;Pwd=manager;SslMode=none");
        
        public IspisRačuna()
        {
           InitializeComponent();
        }
        

        private void IspisRačuna_Load(object sender, EventArgs e)
        {
            textBox_idzaposlenika.Text = idzaposlenik.idzapo.ToString();

            if(idzaposlenik.idzapo == 0)
            {
                textBox_idzaposlenika.Text = idmanager.idmana.ToString();
            }
            
        }

        private void pictureBox_nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
        //    this.Visible = false;
            
            
        }

        private void button_prikazinarud_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Prikazinarudzbe();
            button_ispisracuna.Enabled = true;
      
        }
        private DataTable Prikazinarudzbe()
        {
            connection.Open();
            DataTable tablica = new DataTable();
            string pokazimeni = "SELECT * FROM narudzba n INNER JOIN meni m ON n.id_meni = m.id WHERE id_stol = '" + comboBox_brojstola.SelectedItem + "'";

            using (MySqlCommand command = new MySqlCommand(pokazimeni, connection))
            {
                
                MySqlDataReader reader = command.ExecuteReader();
                tablica.Load(reader);
                connection.Close();
            }

            return tablica;
            
        }

        private void button_ispisracuna_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand ispis = new MySqlCommand();
            ispis.Connection = connection;
            ispis.CommandType = CommandType.StoredProcedure;
            ispis.CommandText = "ispis_racun";

           

            ispis.Parameters.Add(new MySqlParameter("@p_id_zaposlenik", MySqlDbType.Int32)).Value = textBox_idzaposlenika.Text;
            ispis.Parameters.Add(new MySqlParameter("@p_id_stol", MySqlDbType.Int32)).Value = comboBox_brojstola.SelectedItem;

            int query = ispis.ExecuteNonQuery();

            if(query >= 0)
            {
                connection.Close();
                MessageBox.Show("Racun istipkan!");
                dataGridView1.DataSource = Prikazinarudzbe();
                button_ispisracuna.Enabled = false;
            }
            else
            {
                MessageBox.Show("Došlo je do pogreške!");
            }
            
            connection.Close();
        }

        private void button_uredinarudz_Click(object sender, EventArgs e)
        {
            label_brisinarud.Visible = true;
            button_brisinarudz.Visible = true;
            textBox_brisinarudz.Visible = true;
        }

        private void button_brisinarudz_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand obrisi = new MySqlCommand();
            obrisi.Connection = connection;
            obrisi.CommandType = CommandType.StoredProcedure;
            obrisi.CommandText = "obrisi_narudzbu";



            obrisi.Parameters.Add(new MySqlParameter("@p_id", MySqlDbType.Int32)).Value = textBox_brisinarudz.Text;

            int query = obrisi.ExecuteNonQuery();

            if (query >= 0)
            {
                connection.Close();
                MessageBox.Show("Uspješno obrisano!", "", MessageBoxButtons.OK);
                dataGridView1.DataSource = Prikazinarudzbe();
                label_brisinarud.Visible = false;
                button_brisinarudz.Visible = false;
                textBox_brisinarudz.Visible = false;
            }
            else
            {
                MessageBox.Show("Došlo je do pogreške!");
            }

            connection.Close();
        }
    }
}

