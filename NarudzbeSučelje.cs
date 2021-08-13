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
    
    public partial class NarudzbeSučelje : UserControl
    {
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=slastika;user=manager;Pwd=manager;SslMode=none");
        
        public NarudzbeSučelje()
        {
            InitializeComponent();
            FillData();
        }
        void FillData()
        {
            connection.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from aktivne_narudzbe", connection);
            DataTable t = new DataTable();
            sda.Fill(t);
            dataGridView_aktivnenarudzbe.DataSource = t;
            
 
        }

        private void button_dodajnarudzbu_Click(object sender, EventArgs e)
        {
            string kolicina = textBox_kolicina.Text;
            string idart = textBox_idartikla.Text;

          
           
            MySqlCommand naruci = new MySqlCommand();
            naruci.Connection = connection;
            naruci.CommandType = CommandType.StoredProcedure;
            naruci.CommandText = "naruci";
            
            int valuemeni;
            int.TryParse(textBox_idartikla.Text, out valuemeni);
            int valuekolicina;
            int.TryParse(textBox_kolicina.Text, out valuekolicina);

  
            if (valuemeni < 1)
            {
                MessageBox.Show("ID artikla ne smije biti manji od 1!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (valuekolicina < 1)
            {
                MessageBox.Show("Količina ne smije biti manja od 1!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                naruci.Parameters.Add(new MySqlParameter("@p_id_stol", MySqlDbType.Int32)).Value = comboBox_brojstola.SelectedItem;
                naruci.Parameters.Add(new MySqlParameter("@p_id_meni", MySqlDbType.Int32)).Value = idart;
                naruci.Parameters.Add(new MySqlParameter("@p_kolicina", MySqlDbType.Int32)).Value = kolicina;

                int query = naruci.ExecuteNonQuery();
                

                if (query >= 0 )
                {
                    MessageBox.Show("Narudžba uspješna!");
                    connection.Close();
                    FillData();
                    

                   
                }
                else
                {
                    MessageBox.Show("Greška!");
                }
                
            }
            
            textBox_idartikla.Clear();
            textBox_kolicina.Clear();
            
        }

        private void button_brisi_Click(object sender, EventArgs e)
        {
            textBox_idartikla.Clear();
            textBox_kolicina.Clear();
        }

        private void pictureBox1_nazad_Click(object sender, EventArgs e)
        {  
            this.Hide();
        }

        private void button_prikazimeni_Click(object sender, EventArgs e)
        {
            PrikaziMeni x = new PrikaziMeni();
            x.Show();
        }

    }
}
