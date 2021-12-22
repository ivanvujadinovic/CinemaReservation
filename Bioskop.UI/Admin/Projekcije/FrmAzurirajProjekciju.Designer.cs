
namespace Bioskop.UI.Admin.Projekcije
{
    partial class FrmAzurirajProjekciju
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
            this.btnAzurirajProjekciju = new System.Windows.Forms.Button();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.dtpVreme = new System.Windows.Forms.DateTimePicker();
            this.txtCenaKarte = new System.Windows.Forms.TextBox();
            this.cmbSale = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiProjekciju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAzurirajProjekciju
            // 
            this.btnAzurirajProjekciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajProjekciju.Location = new System.Drawing.Point(4, 153);
            this.btnAzurirajProjekciju.Name = "btnAzurirajProjekciju";
            this.btnAzurirajProjekciju.Size = new System.Drawing.Size(299, 45);
            this.btnAzurirajProjekciju.TabIndex = 21;
            this.btnAzurirajProjekciju.Text = "Azuriraj projekciju";
            this.btnAzurirajProjekciju.UseVisualStyleBackColor = true;
            this.btnAzurirajProjekciju.Click += new System.EventHandler(this.btnAzurirajProjekciju_Click);
            // 
            // cmbFilm
            // 
            this.cmbFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(136, 119);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(167, 21);
            this.cmbFilm.TabIndex = 20;
            // 
            // dtpVreme
            // 
            this.dtpVreme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVreme.Location = new System.Drawing.Point(136, 90);
            this.dtpVreme.Name = "dtpVreme";
            this.dtpVreme.Size = new System.Drawing.Size(167, 20);
            this.dtpVreme.TabIndex = 19;
            // 
            // txtCenaKarte
            // 
            this.txtCenaKarte.Location = new System.Drawing.Point(136, 55);
            this.txtCenaKarte.Name = "txtCenaKarte";
            this.txtCenaKarte.Size = new System.Drawing.Size(167, 20);
            this.txtCenaKarte.TabIndex = 18;
            // 
            // cmbSale
            // 
            this.cmbSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSale.FormattingEnabled = true;
            this.cmbSale.Location = new System.Drawing.Point(136, 27);
            this.cmbSale.Name = "cmbSale";
            this.cmbSale.Size = new System.Drawing.Size(167, 21);
            this.cmbSale.TabIndex = 17;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(136, 0);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(167, 20);
            this.dtpDatum.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Film:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Vreme projekcije:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cena karte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sala:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Datum projekcije:";
            // 
            // btnObrisiProjekciju
            // 
            this.btnObrisiProjekciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiProjekciju.Location = new System.Drawing.Point(3, 204);
            this.btnObrisiProjekciju.Name = "btnObrisiProjekciju";
            this.btnObrisiProjekciju.Size = new System.Drawing.Size(299, 45);
            this.btnObrisiProjekciju.TabIndex = 22;
            this.btnObrisiProjekciju.Text = "Obrisi projekciju";
            this.btnObrisiProjekciju.UseVisualStyleBackColor = true;
            this.btnObrisiProjekciju.Click += new System.EventHandler(this.btnObrisiProjekciju_Click);
            // 
            // FrmAzurirajProjekciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 254);
            this.Controls.Add(this.btnObrisiProjekciju);
            this.Controls.Add(this.btnAzurirajProjekciju);
            this.Controls.Add(this.cmbFilm);
            this.Controls.Add(this.dtpVreme);
            this.Controls.Add(this.txtCenaKarte);
            this.Controls.Add(this.cmbSale);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAzurirajProjekciju";
            this.Text = "FrmAzurirajProjekciju";
            this.Load += new System.EventHandler(this.FrmAzurirajProjekciju_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAzurirajProjekciju;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.DateTimePicker dtpVreme;
        private System.Windows.Forms.TextBox txtCenaKarte;
        private System.Windows.Forms.ComboBox cmbSale;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiProjekciju;
    }
}