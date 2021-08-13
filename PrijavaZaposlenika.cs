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
    public partial class PrijavaKorisnika : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=slastika;user=manager;Pwd=manager;SslMode=none");
        public static string ime_zaposlenika = "";
        public PrijavaKorisnika()
        {
            InitializeComponent();

  
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void button_1_Click(object sender, EventArgs e)
        {
            string upit = "SELECT ime,id FROM zaposlenik WHERE sifra_z = '" + textbox_prijava.Text+"'";
            string manager = "SELECT ime,id FROM manager WHERE sifra_m = '" + textbox_prijava.Text + "'";

            MySqlDataAdapter sda = new MySqlDataAdapter(upit, connection);

            DataTable tablica = new DataTable();

            sda.Fill(tablica);

            MySqlDataAdapter sda2 = new MySqlDataAdapter(manager, connection);

            DataTable tablica2 = new DataTable();

            sda2.Fill(tablica2);

            if (tablica.Rows.Count == 1)
            {
                string sqlidzapo = tablica.Rows[0][1].ToString();
                idzaposlenik.idzapo = Int32.Parse(sqlidzapo);
                
                infozaposlenik.imezapo = tablica.Rows[0][0].ToString();             
                GlavnoSučelje x = new GlavnoSučelje();
                x.Show();
                this.Hide();
                MessageBox.Show("Prijavljeni ste kao zaposlenik "+infozaposlenik.imezapo+", sa IDem: "+idzaposlenik.idzapo);
            }
            else if (tablica2.Rows.Count == 1)
            {
                string test = tablica2.Rows[0][1].ToString();
                idmanager.idmana = Int32.Parse(test);
                
                infomanager.imemana = tablica2.Rows[0][0].ToString();
                GlavnoSučelje x = new GlavnoSučelje();
                x.Show();
                this.Hide();
              MessageBox.Show("Prijavljeni ste kao manager " +infomanager.imemana+ ", dobro došli!");
                
            }
            else if (textbox_prijava.Text == "")
            {
                MessageBox.Show("Niste upisali šifru!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Kriva šifra konobara!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            textbox_prijava.Clear();


        }
         

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               button_1_Click (sender, e);
            }
        }

        private void PrijavaKorisnika_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void PrijavaKorisnika_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_sat.Text = DateTime.Now.ToString("F");
        }

       
    }

}
