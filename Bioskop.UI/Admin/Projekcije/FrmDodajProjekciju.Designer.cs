
namespace Bioskop.UI.Admin.Projekcije
{
    partial class FrmDodajProjekciju
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
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.cmbSale = new System.Windows.Forms.ComboBox();
            this.txtCenaKarte = new System.Windows.Forms.TextBox();
            this.dtpVreme = new System.Windows.Forms.DateTimePicker();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.btnDodajProjekciju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum projekcije:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sala:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cena karte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vreme projekcije:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Film:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(138, 3);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(167, 20);
            this.dtpDatum.TabIndex = 5;
            // 
            // cmbSale
            // 
            this.cmbSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSale.FormattingEnabled = true;
            this.cmbSale.Location = new System.Drawing.Point(138, 30);
            this.cmbSale.Name = "cmbSale";
            this.cmbSale.Size = new System.Drawing.Size(167, 21);
            this.cmbSale.TabIndex = 6;
            // 
            // txtCenaKarte
            // 
            this.txtCenaKarte.Location = new System.Drawing.Point(138, 58);
            this.txtCenaKarte.Name = "txtCenaKarte";
            this.txtCenaKarte.Size = new System.Drawing.Size(167, 20);
            this.txtCenaKarte.TabIndex = 7;
            // 
            // dtpVreme
            // 
            this.dtpVreme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVreme.Location = new System.Drawing.Point(138, 93);
            this.dtpVreme.Name = "dtpVreme";
            this.dtpVreme.Size = new System.Drawing.Size(167, 20);
            this.dtpVreme.TabIndex = 8;
            // 
            // cmbFilm
            // 
            this.cmbFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(138, 122);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(167, 21);
            this.cmbFilm.TabIndex = 9;
            // 
            // btnDodajProjekciju
            // 
            this.btnDodajProjekciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProjekciju.Location = new System.Drawing.Point(6, 156);
            this.btnDodajProjekciju.Name = "btnDodajProjekciju";
            this.btnDodajProjekciju.Size = new System.Drawing.Size(299, 45);
            this.btnDodajProjekciju.TabIndex = 10;
            this.btnDodajProjekciju.Text = "Dodaj projekciju";
            this.btnDodajProjekciju.UseVisualStyleBackColor = true;
            this.btnDodajProjekciju.Click += new System.EventHandler(this.btnDodajProjekciju_Click);
            // 
            // FrmDodajProjekciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 205);
            this.Controls.Add(this.btnDodajProjekciju);
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
            this.Name = "FrmDodajProjekciju";
            this.Text = "FrmDodajProjekciju";
            this.Load += new System.EventHandler(this.FrmDodajProjekciju_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ComboBox cmbSale;
        private System.Windows.Forms.TextBox txtCenaKarte;
        private System.Windows.Forms.DateTimePicker dtpVreme;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.Button btnDodajProjekciju;
    }
}