
namespace PrijavaKorisnika
{
   
    partial class NarudzbeSučelje
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_idartikla = new System.Windows.Forms.TextBox();
            this.button_dodajnarudzbu = new System.Windows.Forms.Button();
            this.button_brisi = new System.Windows.Forms.Button();
            this.textBox_kolicina = new System.Windows.Forms.TextBox();
            this.label_kolicina = new System.Windows.Forms.Label();
            this.dataGridView_aktivnenarudzbe = new System.Windows.Forms.DataGridView();
            this.brojstolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivnenarudzbeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.slastikaDataSet1 = new slastikaDataSet1();
            this.aktivnenarudzbeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_brojstola = new System.Windows.Forms.ComboBox();
            this.button_prikazimeni = new System.Windows.Forms.Button();
            this.aktivne_narudzbeTableAdapter = new slastikaDataSet1TableAdapters.aktivne_narudzbeTableAdapter();
            this.label_aktivnenarduzbe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_aktivnenarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktivnenarudzbeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slastikaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktivnenarudzbeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj stola:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID artikla:";
            // 
            // textBox_idartikla
            // 
            this.textBox_idartikla.Location = new System.Drawing.Point(287, 148);
            this.textBox_idartikla.Name = "textBox_idartikla";
            this.textBox_idartikla.Size = new System.Drawing.Size(173, 20);
            this.textBox_idartikla.TabIndex = 6;
            // 
            // button_dodajnarudzbu
            // 
            this.button_dodajnarudzbu.Location = new System.Drawing.Point(287, 252);
            this.button_dodajnarudzbu.Name = "button_dodajnarudzbu";
            this.button_dodajnarudzbu.Size = new System.Drawing.Size(93, 23);
            this.button_dodajnarudzbu.TabIndex = 7;
            this.button_dodajnarudzbu.Text = "Dodaj narudžbu";
            this.button_dodajnarudzbu.UseVisualStyleBackColor = true;
            this.button_dodajnarudzbu.Click += new System.EventHandler(this.button_dodajnarudzbu_Click);
            // 
            // button_brisi
            // 
            this.button_brisi.Location = new System.Drawing.Point(398, 252);
            this.button_brisi.Name = "button_brisi";
            this.button_brisi.Size = new System.Drawing.Size(70, 23);
            this.button_brisi.TabIndex = 8;
            this.button_brisi.Text = "Očisti polja";
            this.button_brisi.UseVisualStyleBackColor = true;
            this.button_brisi.Click += new System.EventHandler(this.button_brisi_Click);
            // 
            // textBox_kolicina
            // 
            this.textBox_kolicina.Location = new System.Drawing.Point(287, 201);
            this.textBox_kolicina.Name = "textBox_kolicina";
            this.textBox_kolicina.Size = new System.Drawing.Size(173, 20);
            this.textBox_kolicina.TabIndex = 10;
            // 
            // label_kolicina
            // 
            this.label_kolicina.AutoSize = true;
            this.label_kolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kolicina.Location = new System.Drawing.Point(167, 201);
            this.label_kolicina.Name = "label_kolicina";
            this.label_kolicina.Size = new System.Drawing.Size(76, 20);
            this.label_kolicina.TabIndex = 11;
            this.label_kolicina.Text = "Količina:";
            // 
            // dataGridView_aktivnenarudzbe
            // 
            this.dataGridView_aktivnenarudzbe.AutoGenerateColumns = false;
            this.dataGridView_aktivnenarudzbe.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_aktivnenarudzbe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_aktivnenarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_aktivnenarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brojstolaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dataGridView_aktivnenarudzbe.DataSource = this.aktivnenarudzbeBindingSource1;
            this.dataGridView_aktivnenarudzbe.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_aktivnenarudzbe.Location = new System.Drawing.Point(495, 93);
            this.dataGridView_aktivnenarudzbe.Name = "dataGridView_aktivnenarudzbe";
            this.dataGridView_aktivnenarudzbe.Size = new System.Drawing.Size(443, 434);
            this.dataGridView_aktivnenarudzbe.TabIndex = 3;
            // 
            // brojstolaDataGridViewTextBoxColumn
            // 
            this.brojstolaDataGridViewTextBoxColumn.DataPropertyName = "broj_stola";
            this.brojstolaDataGridViewTextBoxColumn.HeaderText = "broj_stola";
            this.brojstolaDataGridViewTextBoxColumn.Name = "brojstolaDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // aktivnenarudzbeBindingSource1
            // 
            this.aktivnenarudzbeBindingSource1.DataMember = "aktivne_narudzbe";
            this.aktivnenarudzbeBindingSource1.DataSource = this.slastikaDataSet1;
            // 
            // slastikaDataSet1
            // 
            this.slastikaDataSet1.DataSetName = "slastikaDataSet1";
            this.slastikaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.comboBox_brojstola.Location = new System.Drawing.Point(287, 95);
            this.comboBox_brojstola.Name = "comboBox_brojstola";
            this.comboBox_brojstola.Size = new System.Drawing.Size(121, 21);
            this.comboBox_brojstola.TabIndex = 13;
            // 
            // button_prikazimeni
            // 
            this.button_prikazimeni.Location = new System.Drawing.Point(171, 252);
            this.button_prikazimeni.Name = "button_prikazimeni";
            this.button_prikazimeni.Size = new System.Drawing.Size(93, 23);
            this.button_prikazimeni.TabIndex = 14;
            this.button_prikazimeni.Text = "Prikaži meni";
            this.button_prikazimeni.UseVisualStyleBackColor = true;
            this.button_prikazimeni.Click += new System.EventHandler(this.button_prikazimeni_Click);
            // 
            // aktivne_narudzbeTableAdapter
            // 
            this.aktivne_narudzbeTableAdapter.ClearBeforeFill = true;
            // 
            // label_aktivnenarduzbe
            // 
            this.label_aktivnenarduzbe.AutoSize = true;
            this.label_aktivnenarduzbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_aktivnenarduzbe.Location = new System.Drawing.Point(639, 530);
            this.label_aktivnenarduzbe.Name = "label_aktivnenarduzbe";
            this.label_aktivnenarduzbe.Size = new System.Drawing.Size(148, 20);
            this.label_aktivnenarduzbe.TabIndex = 15;
            this.label_aktivnenarduzbe.Text = "Aktivne narudžbe";
            // 
            // NarudzbeSučelje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_aktivnenarduzbe);
            this.Controls.Add(this.button_prikazimeni);
            this.Controls.Add(this.comboBox_brojstola);
            this.Controls.Add(this.label_kolicina);
            this.Controls.Add(this.textBox_kolicina);
            this.Controls.Add(this.button_brisi);
            this.Controls.Add(this.button_dodajnarudzbu);
            this.Controls.Add(this.textBox_idartikla);
            this.Controls.Add(this.dataGridView_aktivnenarudzbe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NarudzbeSučelje";
            this.Size = new System.Drawing.Size(1034, 585);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_aktivnenarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktivnenarudzbeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slastikaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktivnenarudzbeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_idartikla;
        private System.Windows.Forms.Button button_dodajnarudzbu;
        private System.Windows.Forms.Button button_brisi;
        private System.Windows.Forms.TextBox textBox_kolicina;
        private System.Windows.Forms.Label label_kolicina;
        private System.Windows.Forms.DataGridView dataGridView_aktivnenarudzbe;
        private System.Windows.Forms.BindingSource aktivnenarudzbeBindingSource;
        private System.Windows.Forms.ComboBox comboBox_brojstola;
        private System.Windows.Forms.Button button_prikazimeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojstolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aktivnenarudzbeBindingSource1;
        private slastikaDataSet1 slastikaDataSet1;
        private slastikaDataSet1TableAdapters.aktivne_narudzbeTableAdapter aktivne_narudzbeTableAdapter;
        private System.Windows.Forms.Label label_aktivnenarduzbe;
    }
}
