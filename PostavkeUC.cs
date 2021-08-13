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
    public partial class PostavkeUC : UserControl
    {
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=slastika;user=manager;Pwd=manager;SslMode=none");

        public PostavkeUC()
        {
            InitializeComponent();
        }
        private DataTable PrikaziZaposlenike()
        {
            connection.Open();
            DataTable tablica = new DataTable();
            string pokazizaposlenike = "SELECT * FROM zaposlenik ORDER BY id DESC";

            using (MySqlCommand command = new MySqlCommand(pokazizaposlenike, connection))
            {

                MySqlDataReader reader = command.ExecuteReader();
                tablica.Load(reader);
                connection.Close();
            }

            return tablica;

        }
        private DataTable PrikaziArtikle()
        {
            connection.Open();
            DataTable tablica = new DataTable();
            string pokaziartikle = "Select * from meni";

            using (MySqlCommand cmd = new MySqlCommand(pokaziartikle, connection))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                tablica.Load(reader);
                connection.Close();
            }
            return tablica;
        }
        private DataTable Info()
        {
            connection.Open();
            DataTable tablica = new DataTable();
            string info = "SELECT * FROM info";

            using (MySqlCommand cmd = new MySqlCommand(info, connection))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                tablica.Load(reader);
                connection.Close();
            }
            return tablica;
        }
        private void button_dodajzaposlenika_Click(object sender, EventArgs e)
        {
            try
            {
                string p_sifra = textBox_sifrazaposlenika.Text;
            string p_oib = textBox_oibzaposlenika.Text;
            string p_ime = textBox_imezaposlenika.Text;
            string p_prezime = textBox_prezimezaposlenika.Text;
            string p_placa = textBox_placazaposlenika.Text;
            DataTable tablica = new DataTable();
            MySqlCommand dodajzaposlenika = new MySqlCommand();

            dodajzaposlenika.Connection = connection;
            dodajzaposlenika.CommandType = CommandType.StoredProcedure;
            dodajzaposlenika.CommandText = "dodaj_zaposlenika";



            int placa;
            int.TryParse(textBox_placazaposlenika.Text, out placa);

           /*if (p_sifra.Length > 10)
            {
                MessageBox.Show("Predugačka šifra!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
            else if (p_oib.Length > 11)
            {
                MessageBox.Show("Predugačak OIB!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
            else if (placa < 4500)
            {
                MessageBox.Show("Nešto nije uredu, pokušajte ponovno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }*/
            if (textBox_sifrazaposlenika.Text == "")
            {
                MessageBox.Show("Nešto nije uredu, pokušajte ponovno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
            else if (textBox_oibzaposlenika.Text == "")
            {
                MessageBox.Show("Nešto nije uredu, pokušajte ponovno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
            else if (textBox_imezaposlenika.Text == "")
            {
                MessageBox.Show("Nešto nije uredu, pokušajte ponovno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
            else if (textBox_prezimezaposlenika.Text == "")
            {
                MessageBox.Show("Nešto nije uredu, pokušajte ponovno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
            else if (textBox_placazaposlenika.Text == "")
            {
                MessageBox.Show("Nešto nije uredu, pokušajte ponovno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
 


                connection.Open();
                dodajzaposlenika.Parameters.Add(new MySqlParameter("@p_sifra_z", MySqlDbType.VarChar)).Value = p_sifra;
                dodajzaposlenika.Parameters.Add(new MySqlParameter("@p_oib", MySqlDbType.VarChar)).Value = p_oib;
                dodajzaposlenika.Parameters.Add(new MySqlParameter("@p_ime", MySqlDbType.VarChar)).Value = p_ime;
                dodajzaposlenika.Parameters.Add(new MySqlParameter("@p_prezime", MySqlDbType.VarChar)).Value = p_prezime;
                dodajzaposlenika.Parameters.Add(new MySqlParameter("@p_placa", MySqlDbType.Int32)).Value = p_placa;

                MySqlDataAdapter sda = new MySqlDataAdapter(dodajzaposlenika);
                sda.Fill(tablica);


                int query = dodajzaposlenika.ExecuteNonQuery();
                
                connection.Close();
                MessageBox.Show("Uspješno dodan novi zaposlenik!\nIme: " + p_ime + " Prezime: " + p_prezime);
                dataGridView1.DataSource = PrikaziZaposlenike();
                
                
                textBox_sifrazaposlenika.Clear();
                textBox_oibzaposlenika.Clear();
                textBox_imezaposlenika.Clear();
                textBox_prezimezaposlenika.Clear();
                textBox_placazaposlenika.Clear();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

            }
        
        private void PostavkeUC_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PrikaziZaposlenike();
        }

        private void button_brisizaposlenika_Click(object sender, EventArgs e)
        {
                
                string sifra = textBox_brisizaposlenika.Text;
                connection.Open();
                MySqlCommand brisi = new MySqlCommand();

                brisi.Connection = connection;
                brisi.CommandType = CommandType.StoredProcedure;
                brisi.CommandText = "obrisi_zaposlenika";

                brisi.Parameters.Add(new MySqlParameter("@p_sifra_z", MySqlDbType.VarChar)).Value = sifra;

                int query = brisi.ExecuteNonQuery();
                
            if(query >= 0)
            {
                connection.Close();
                dataGridView1.DataSource = PrikaziZaposlenike();
                MessageBox.Show("Uspješno obrisano!");
                textBox_brisizaposlenika.Clear();
            }
            else
            {
                MessageBox.Show("Došlo je do pogreške!");
                connection.Close();
            }
        }

        private void button_dodajartikl_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                string id = textBox_idartikla.Text;
                string ime = textBox_imeartikla.Text;
                string cijena = textBox_cijenaartikla.Text;

                MySqlCommand dodajartikl = new MySqlCommand();

                dodajartikl.Connection = connection;
                dodajartikl.CommandType = CommandType.StoredProcedure;
                dodajartikl.CommandText = "dodaj";

                dodajartikl.Parameters.Add(new MySqlParameter("@p_id", MySqlDbType.Int32)).Value = id;
                dodajartikl.Parameters.Add(new MySqlParameter("@p_vrsta", MySqlDbType.VarChar)).Value = comboBox_vrsta.SelectedItem;
                dodajartikl.Parameters.Add(new MySqlParameter("@p_ime", MySqlDbType.VarChar)).Value = ime;
                dodajartikl.Parameters.Add(new MySqlParameter("@p_cijena", MySqlDbType.Decimal)).Value = cijena;

                int query = dodajartikl.ExecuteNonQuery();

                connection.Close();
                dataGridView1.DataSource = PrikaziArtikle();
                MessageBox.Show("Uspješno dodan artikl:\nIme: " + ime + "\nVrsta: " + comboBox_vrsta.SelectedItem + "\nCijena: " + cijena);
                textBox_idartikla.Clear();
                comboBox_vrsta.Refresh();
                textBox_imeartikla.Clear();
                textBox_cijenaartikla.Clear();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
           /* if (query >= 0)
            {
                connection.Close();
                dataGridView1.DataSource = PrikaziArtikle();
                MessageBox.Show("Uspješno dodan artikl:\nIme: " + ime +"\nVrsta: " +vrsta+ "\nCijena: "+cijena);
                textBox_idartikla.Clear();
                textBox_vrstaartikla.Clear();
                textBox_imeartikla.Clear();
                textBox_cijenaartikla.Clear();
            }
            else
            {
                MessageBox.Show("Došlo je do pogreške!");
                connection.Close();
            }*/
        }

        private void button_brisiartikl_Click(object sender, EventArgs e)
        {
            connection.Open();
            string id = textBox_obrisiIDartikla.Text;
            if (textBox_obrisiIDartikla.Text == "")
            {
                MessageBox.Show("Nešto nije uredu, pokušajte ponovno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
            else
            {


                MySqlCommand brisiartikl = new MySqlCommand();

                brisiartikl.Connection = connection;
                brisiartikl.CommandType = CommandType.StoredProcedure;
                brisiartikl.CommandText = "obrisi_iz_meni";

                try
                {


                    brisiartikl.Parameters.Add(new MySqlParameter("@p_id", MySqlDbType.Int32)).Value = id;

                    int query = brisiartikl.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Obrisan je artikl s ID: " + id);
                    dataGridView1.DataSource = PrikaziArtikle();
                    textBox_obrisiIDartikla.Clear();
                    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("fail");
                    connection.Close();
                }

           /*     if (query >= 0)
                {
                    connection.Close();
                    MessageBox.Show("Obrisan je artikl s ID: " + id);
                    dataGridView1.DataSource = PrikaziArtikle();
                    textBox_obrisiIDartikla.Clear();
                }
                else
                {
                    MessageBox.Show("Došlo je do pogreške!");
                    connection.Close();
                }
*/
            }
        }
        private void button_povecaj_Click(object sender, EventArgs e)
        {
            connection.Open();
            string popust = textBox_popust.Text;
            MySqlCommand povecaj = new MySqlCommand();

            povecaj.Connection = connection;
            povecaj.CommandType = CommandType.StoredProcedure;
            povecaj.CommandText = "povecaj";

            MySqlParameter npr = new MySqlParameter("@p_popust", MySqlDbType.Decimal);
            npr.Precision = 10;
            npr.Scale = 2;
            
            
            povecaj.Parameters.Add(npr).Value = popust;


            int query = povecaj.ExecuteNonQuery();

           
            if(query >= 0)
            {
                connection.Close();
                MessageBox.Show("Povećali ste sve cijene!");
                textBox_popust.Clear();
                dataGridView1.DataSource=PrikaziArtikle();
            }
            else
            {
                MessageBox.Show("Došlo je do pogreške!");
                connection.Close();
            }
        }

        private void button_snizi_Click(object sender, EventArgs e)
        {
            connection.Open();
            string popust = textBox_popust.Text;

            MySqlCommand snizi = new MySqlCommand();

            snizi.Connection = connection;
            snizi.CommandType = CommandType.StoredProcedure;
            snizi.CommandText = "snizi";

            snizi.Parameters.Add(new MySqlParameter("@p_popust", MySqlDbType.Decimal)).Value = popust;

            int query = snizi.ExecuteNonQuery();

            if (query >= 0)
            {
                connection.Close();
                MessageBox.Show("Snizili ste sve cijene artikala!");
                textBox_popust.Clear();
                dataGridView1.DataSource = PrikaziArtikle();
            }
            else
            {
                MessageBox.Show("Došlo je do pogreške!");
                connection.Close();
            }

        }

        private void button_prikazisvezaposlenike_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PrikaziZaposlenike();
        }

        private void button_prikazisveartikle_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PrikaziArtikle();
        }

        private void button_prikaziinfo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Info();
        }
    }
}
