
namespace PrijavaKorisnika
{
    partial class IzdaniRacuniUC
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
            this.dataGridView_racuni = new System.Windows.Forms.DataGridView();
            this.button_prikazizaodredenog = new System.Windows.Forms.Button();
            this.textBox_idzapo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_racuni)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_racuni
            // 
            this.dataGridView_racuni.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_racuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_racuni.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_racuni.Location = new System.Drawing.Point(159, 247);
            this.dataGridView_racuni.Name = "dataGridView_racuni";
            this.dataGridView_racuni.Size = new System.Drawing.Size(710, 288);
            this.dataGridView_racuni.TabIndex = 0;
            // 
            // button_prikazizaodredenog
            // 
            this.button_prikazizaodredenog.Location = new System.Drawing.Point(349, 134);
            this.button_prikazizaodredenog.Name = "button_prikazizaodredenog";
            this.button_prikazizaodredenog.Size = new System.Drawing.Size(75, 23);
            this.button_prikazizaodredenog.TabIndex = 1;
            this.button_prikazizaodredenog.Text = "Prikaži";
            this.button_prikazizaodredenog.UseVisualStyleBackColor = true;
            this.button_prikazizaodredenog.Click += new System.EventHandler(this.button_prikazizaodredenog_Click);
            // 
            // textBox_idzapo
            // 
            this.textBox_idzapo.Location = new System.Drawing.Point(349, 95);
            this.textBox_idzapo.Name = "textBox_idzapo";
            this.textBox_idzapo.Size = new System.Drawing.Size(100, 20);
            this.textBox_idzapo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Upišite ID zaposlenika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prikaz istipkanih računa za određenog zaposlenika";
            // 
            // IzdaniRacuniUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_idzapo);
            this.Controls.Add(this.button_prikazizaodredenog);
            this.Controls.Add(this.dataGridView_racuni);
            this.Name = "IzdaniRacuniUC";
            this.Size = new System.Drawing.Size(1034, 585);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_racuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_racuni;
        private System.Windows.Forms.Button button_prikazizaodredenog;
        private System.Windows.Forms.TextBox textBox_idzapo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
