
namespace Bioskop.UI.Korisnik
{
    partial class FrmKorisnikPocetna
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
            this.pnlRadnaPovrsina = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.btnNapraviRezervaciju = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRadnaPovrsina
            // 
            this.pnlRadnaPovrsina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlRadnaPovrsina.Location = new System.Drawing.Point(230, 0);
            this.pnlRadnaPovrsina.Name = "pnlRadnaPovrsina";
            this.pnlRadnaPovrsina.Size = new System.Drawing.Size(657, 445);
            this.pnlRadnaPovrsina.TabIndex = 3;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel.Controls.Add(this.btnNapraviRezervaciju);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.btnRezervacije);
            this.panel.Location = new System.Drawing.Point(1, 1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(223, 444);
            this.panel.TabIndex = 2;
            // 
            // btnNapraviRezervaciju
            // 
            this.btnNapraviRezervaciju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNapraviRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNapraviRezervaciju.Location = new System.Drawing.Point(6, 93);
            this.btnNapraviRezervaciju.Name = "btnNapraviRezervaciju";
            this.btnNapraviRezervaciju.Size = new System.Drawing.Size(214, 51);
            this.btnNapraviRezervaciju.TabIndex = 2;
            this.btnNapraviRezervaciju.Text = "Napravi rezervaciju";
            this.btnNapraviRezervaciju.UseVisualStyleBackColor = false;
            this.btnNapraviRezervaciju.Click += new System.EventHandler(this.btnNapraviRezervaciju_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervacije.Location = new System.Drawing.Point(6, 36);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(214, 51);
            this.btnRezervacije.TabIndex = 0;
            this.btnRezervacije.Text = "Rezervacije";
            this.btnRezervacije.UseVisualStyleBackColor = false;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            // 
            // FrmKorisnikPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(894, 449);
            this.Controls.Add(this.pnlRadnaPovrsina);
            this.Controls.Add(this.panel);
            this.Name = "FrmKorisnikPocetna";
            this.Text = "FrmKorisnikPocetna";
            this.Load += new System.EventHandler(this.FrmKorisnikPocetna_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRadnaPovrsina;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnNapraviRezervaciju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRezervacije;
    }
}