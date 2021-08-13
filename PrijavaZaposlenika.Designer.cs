
namespace PrijavaKorisnika
{
    partial class PrijavaKorisnika
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrijavaKorisnika));
            this.label_upisitesifrukonobara = new System.Windows.Forms.Label();
            this.textbox_prijava = new System.Windows.Forms.TextBox();
            this.button_prijava = new System.Windows.Forms.Button();
            this.label_sat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_upisitesifrukonobara
            // 
            this.label_upisitesifrukonobara.AutoSize = true;
            this.label_upisitesifrukonobara.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_upisitesifrukonobara.Location = new System.Drawing.Point(109, 119);
            this.label_upisitesifrukonobara.Name = "label_upisitesifrukonobara";
            this.label_upisitesifrukonobara.Size = new System.Drawing.Size(201, 23);
            this.label_upisitesifrukonobara.TabIndex = 0;
            this.label_upisitesifrukonobara.Text = "Upišite šifru zaposlenika:";
            // 
            // textbox_prijava
            // 
            this.textbox_prijava.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_prijava.Location = new System.Drawing.Point(122, 159);
            this.textbox_prijava.Name = "textbox_prijava";
            this.textbox_prijava.PasswordChar = '*';
            this.textbox_prijava.Size = new System.Drawing.Size(159, 25);
            this.textbox_prijava.TabIndex = 1;
            this.textbox_prijava.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button_prijava
            // 
            this.button_prijava.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_prijava.Location = new System.Drawing.Point(164, 205);
            this.button_prijava.Name = "button_prijava";
            this.button_prijava.Size = new System.Drawing.Size(75, 23);
            this.button_prijava.TabIndex = 3;
            this.button_prijava.Text = "Prijava";
            this.button_prijava.UseVisualStyleBackColor = true;
            this.button_prijava.Click += new System.EventHandler(this.button_1_Click);
            // 
            // label_sat
            // 
            this.label_sat.AutoSize = true;
            this.label_sat.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sat.Location = new System.Drawing.Point(92, 341);
            this.label_sat.Name = "label_sat";
            this.label_sat.Size = new System.Drawing.Size(214, 23);
            this.label_sat.TabIndex = 4;
            this.label_sat.Text = "                                                   ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PrijavaKorisnika
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(414, 373);
            this.Controls.Add(this.label_sat);
            this.Controls.Add(this.button_prijava);
            this.Controls.Add(this.textbox_prijava);
            this.Controls.Add(this.label_upisitesifrukonobara);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrijavaKorisnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRIJAVA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrijavaKorisnika_FormClosing);
            this.Load += new System.EventHandler(this.PrijavaKorisnika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_upisitesifrukonobara;
        private System.Windows.Forms.TextBox textbox_prijava;
        private System.Windows.Forms.Button button_prijava;
        private System.Windows.Forms.Label label_sat;
        private System.Windows.Forms.Timer timer1;
    }
}

