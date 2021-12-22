
namespace Bioskop.UI.Admin.Filmovi
{
    partial class FrmDodajFilm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtStarosnaGranica = new System.Windows.Forms.TextBox();
            this.btnDodajFilm = new System.Windows.Forms.Button();
            this.cmbZanr = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zanr: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Starosna granica: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trajanje: ";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(143, 5);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(143, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(143, 72);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(143, 20);
            this.txtTrajanje.TabIndex = 6;
            // 
            // txtStarosnaGranica
            // 
            this.txtStarosnaGranica.Location = new System.Drawing.Point(143, 105);
            this.txtStarosnaGranica.Name = "txtStarosnaGranica";
            this.txtStarosnaGranica.Size = new System.Drawing.Size(143, 20);
            this.txtStarosnaGranica.TabIndex = 7;
            // 
            // btnDodajFilm
            // 
            this.btnDodajFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajFilm.Location = new System.Drawing.Point(6, 131);
            this.btnDodajFilm.Name = "btnDodajFilm";
            this.btnDodajFilm.Size = new System.Drawing.Size(280, 45);
            this.btnDodajFilm.TabIndex = 8;
            this.btnDodajFilm.Text = "Dodaj film";
            this.btnDodajFilm.UseVisualStyleBackColor = true;
            this.btnDodajFilm.Click += new System.EventHandler(this.btnDodajFilm_Click);
            // 
            // cmbZanr
            // 
            this.cmbZanr.FormattingEnabled = true;
            this.cmbZanr.Location = new System.Drawing.Point(143, 38);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(142, 21);
            this.cmbZanr.TabIndex = 9;
            // 
            // FrmDodajFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 182);
            this.Controls.Add(this.cmbZanr);
            this.Controls.Add(this.btnDodajFilm);
            this.Controls.Add(this.txtStarosnaGranica);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDodajFilm";
            this.Text = "FrmDodajFilm";
            this.Load += new System.EventHandler(this.FrmDodajFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtStarosnaGranica;
        private System.Windows.Forms.Button btnDodajFilm;
        private System.Windows.Forms.ComboBox cmbZanr;
    }
}