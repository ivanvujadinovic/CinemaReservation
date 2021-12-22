
namespace Bioskop.UI.Admin.Filmovi
{
    partial class FrmAzurirajFilm
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
            this.cmbZanr = new System.Windows.Forms.ComboBox();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.txtStarosnaGranica = new System.Windows.Forms.TextBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbZanr
            // 
            this.cmbZanr.FormattingEnabled = true;
            this.cmbZanr.Location = new System.Drawing.Point(143, 38);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(142, 21);
            this.cmbZanr.TabIndex = 18;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Location = new System.Drawing.Point(6, 131);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(280, 40);
            this.btnAzuriraj.TabIndex = 17;
            this.btnAzuriraj.Text = "Azuriraj film";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // txtStarosnaGranica
            // 
            this.txtStarosnaGranica.Location = new System.Drawing.Point(143, 105);
            this.txtStarosnaGranica.Name = "txtStarosnaGranica";
            this.txtStarosnaGranica.Size = new System.Drawing.Size(143, 20);
            this.txtStarosnaGranica.TabIndex = 16;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(143, 72);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(143, 20);
            this.txtTrajanje.TabIndex = 15;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(143, 5);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(143, 20);
            this.txtNaziv.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Trajanje: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Starosna granica: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Zanr: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Naziv: ";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(5, 177);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(280, 40);
            this.btnObrisi.TabIndex = 19;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // FrmAzurirajFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 219);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.cmbZanr);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.txtStarosnaGranica);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAzurirajFilm";
            this.Text = "FrmAzurirajFilm";
            this.Load += new System.EventHandler(this.FrmAzurirajFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbZanr;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.TextBox txtStarosnaGranica;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisi;
    }
}