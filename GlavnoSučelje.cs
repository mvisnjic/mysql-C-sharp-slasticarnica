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
    public partial class GlavnoSučelje : Form
    {
        static GlavnoSučelje _obj;


        public static GlavnoSučelje Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new GlavnoSučelje();
                }
                return _obj;
            }
        }
        public Panel pnlsucelje
        {
            get { return panel_sucelje; }
            set { pnlsucelje = value; }
        }
        public GlavnoSučelje()
        {
            InitializeComponent();
        }


        private void GlavnoSučelje_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            infozaposlenik.imezapo = "";
            infomanager.imemana = "";
            idmanager.idmana = 0;
            idzaposlenik.idzapo = 0;
        }

        private void button_odjava_Click(object sender, EventArgs e)
        {
            PrijavaKorisnika x = new PrijavaKorisnika();
            this.Close();
            x.Show();
        }

        private void GlavnoSučelje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_sat.Text = DateTime.Now.ToString("F");
            label_imekonobara.Visible = true;
            label_imekonobara.Text = infozaposlenik.imezapo.ToString().ToUpper();
            
            if(infozaposlenik.imezapo == "")
            {
                label_imekonobara.Text = infomanager.imemana.ToString().ToUpper();
            }
        }

        private void GlavnoSučelje_Load(object sender, EventArgs e)
        {
            timer1.Start();
            _obj = this;
        }

        private void button_narudzba_Click_1(object sender, EventArgs e)
        {
            NarudzbeSučelje x = new NarudzbeSučelje();
            x.Dock = DockStyle.Fill;
            panel_sucelje.Controls.Add(x);
            x.BringToFront();
            label_dobrodosli.Visible = false;
        }

        private void button_ispisracuna_Click_1(object sender, EventArgs e)
        {
            IspisRačuna x = new IspisRačuna();
            x.Dock = DockStyle.Fill;
            panel_sucelje.Controls.Add(x);
            x.BringToFront();
            label_dobrodosli.Visible = false;
        }

        private void button_izdaniracuni_Click_1(object sender, EventArgs e)
        {
            IzdaniRacuniUC irc = new IzdaniRacuniUC();
            irc.Dock = DockStyle.Fill;
            panel_sucelje.Controls.Add(irc);
            irc.BringToFront();
            label_dobrodosli.Visible = false;
        }

        private void button_statistika_Click_1(object sender, EventArgs e)
        {
            StatistikaUC su = new StatistikaUC();
            su.Dock = DockStyle.Fill;
            panel_sucelje.Controls.Add(su);
            su.BringToFront();
            label_dobrodosli.Visible = false;
        }

        private void button_postavke_Click_1(object sender, EventArgs e)
        {
            PostavkeUC pu = new PostavkeUC();
            pu.Dock = DockStyle.Fill;
            panel_sucelje.Controls.Add(pu);
            pu.BringToFront();
            label_dobrodosli.Visible = false;
        }
    }       
}

