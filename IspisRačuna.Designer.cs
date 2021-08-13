
namespace PrijavaKorisnika
{
    partial class IspisRačuna
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_upisitestol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_idzaposlenika = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_prikazinarud = new System.Windows.Forms.Button();
            this.button_ispisracuna = new System.Windows.Forms.Button();
            this.comboBox_brojstola = new System.Windows.Forms.ComboBox();
            this.textBox_brisinarudz = new System.Windows.Forms.TextBox();
            this.label_brisinarud = new System.Windows.Forms.Label();
            this.button_brisinarudz = new System.Windows.Forms.Button();
            this.button_uredinarudz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_upisitestol
            // 
            this.label_upisitestol.AutoSize = true;
            this.label_upisitestol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_upisitestol.Location = new System.Drawing.Point(131, 122);
            this.label_upisitestol.Name = "label_upisitestol";
            this.label_upisitestol.Size = new System.Drawing.Size(151, 20);
            this.label_upisitestol.TabIndex = 11;
            this.label_upisitestol.Text = "Odaberite broj stola:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID trenutnog zaposlenika:\r\n";
            // 
            // textBox_idzaposlenika
            // 
            this.textBox_idzaposlenika.Location = new System.Drawing.Point(349, 57);
            this.textBox_idzaposlenika.Name = "textBox_idzaposlenika";
            this.textBox_idzaposlenika.ReadOnly = true;
            this.textBox_idzaposlenika.Size = new System.Drawing.Size(37, 20);
            this.textBox_idzaposlenika.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(871, 288);
            this.dataGridView1.TabIndex = 15;
            // 
            // button_prikazinarud
            // 
            this.button_prikazinarud.Location = new System.Drawing.Point(135, 177);
            this.button_prikazinarud.Name = "button_prikazinarud";
            this.button_prikazinarud.Size = new System.Drawing.Size(92, 30);
            this.button_prikazinarud.TabIndex = 16;
            this.button_prikazinarud.Text = "Prikaži";
            this.button_prikazinarud.UseVisualStyleBackColor = true;
            this.button_prikazinarud.Click += new System.EventHandler(this.button_prikazinarud_Click);
            // 
            // button_ispisracuna
            // 
            this.button_ispisracuna.Enabled = false;
            this.button_ispisracuna.Location = new System.Drawing.Point(251, 177);
            this.button_ispisracuna.Name = "button_ispisracuna";
            this.button_ispisracuna.Size = new System.Drawing.Size(92, 30);
            this.button_ispisracuna.TabIndex = 17;
            this.button_ispisracuna.Text = "Ispiši račun";
            this.button_ispisracuna.UseVisualStyleBackColor = true;
            this.button_ispisracuna.Click += new System.EventHandler(this.button_ispisracuna_Click);
            // 
            // comboBox_brojstola
            // 
            this.comboBox_brojstola.FormattingEnabled = true;
            this.comboBox_brojstola.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_brojstola.Location = new System.Drawing.Point(288, 122);
            this.comboBox_brojstola.Name = "comboBox_brojstola";
            this.comboBox_brojstola.Size = new System.Drawing.Size(110, 21);
            this.comboBox_brojstola.TabIndex = 18;
            // 
            // textBox_brisinarudz
            // 
            this.textBox_brisinarudz.Location = new System.Drawing.Point(759, 57);
            this.textBox_brisinarudz.Name = "textBox_brisinarudz";
            this.textBox_brisinarudz.Size = new System.Drawing.Size(100, 20);
            this.textBox_brisinarudz.TabIndex = 19;
            this.textBox_brisinarudz.Visible = false;
            // 
            // label_brisinarud
            // 
            this.label_brisinarud.AutoSize = true;
            this.label_brisinarud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_brisinarud.Location = new System.Drawing.Point(459, 57);
            this.label_brisinarud.Name = "label_brisinarud";
            this.label_brisinarud.Size = new System.Drawing.Size(285, 20);
            this.label_brisinarud.TabIndex = 20;
            this.label_brisinarud.Text = "Upišite ID narudžbe koju želite izbrisati:";
            this.label_brisinarud.Visible = false;
            // 
            // button_brisinarudz
            // 
            this.button_brisinarudz.Location = new System.Drawing.Point(759, 83);
            this.button_brisinarudz.Name = "button_brisinarudz";
            this.button_brisinarudz.Size = new System.Drawing.Size(100, 30);
            this.button_brisinarudz.TabIndex = 21;
            this.button_brisinarudz.Text = "Briši narudžbu";
            this.button_brisinarudz.UseVisualStyleBackColor = true;
            this.button_brisinarudz.Visible = false;
            this.button_brisinarudz.Click += new System.EventHandler(this.button_brisinarudz_Click);
            // 
            // button_uredinarudz
            // 
            this.button_uredinarudz.Location = new System.Drawing.Point(365, 177);
            this.button_uredinarudz.Name = "button_uredinarudz";
            this.button_uredinarudz.Size = new System.Drawing.Size(92, 30);
            this.button_uredinarudz.TabIndex = 22;
            this.button_uredinarudz.Text = "Uredi artikle";
            this.button_uredinarudz.UseVisualStyleBackColor = true;
            this.button_uredinarudz.Click += new System.EventHandler(this.button_uredinarudz_Click);
            // 
            // IspisRačuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_uredinarudz);
            this.Controls.Add(this.button_brisinarudz);
            this.Controls.Add(this.label_brisinarud);
            this.Controls.Add(this.textBox_brisinarudz);
            this.Controls.Add(this.comboBox_brojstola);
            this.Controls.Add(this.button_ispisracuna);
            this.Controls.Add(this.button_prikazinarud);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_idzaposlenika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_upisitestol);
            this.Name = "IspisRačuna";
            this.Size = new System.Drawing.Size(1034, 585);
            this.Load += new System.EventHandler(this.IspisRačuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_upisitestol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_idzaposlenika;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_prikazinarud;
        private System.Windows.Forms.Button button_ispisracuna;
        private System.Windows.Forms.ComboBox comboBox_brojstola;
        private System.Windows.Forms.TextBox textBox_brisinarudz;
        private System.Windows.Forms.Label label_brisinarud;
        private System.Windows.Forms.Button button_brisinarudz;
        private System.Windows.Forms.Button button_uredinarudz;
    }
}
