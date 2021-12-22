
namespace Bioskop.UI.Admin.Sale
{
    partial class FrmAzurirajSalu
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
            this.btnAzurirajSalu = new System.Windows.Forms.Button();
            this.txtBrojSedista = new System.Windows.Forms.TextBox();
            this.txtBrojSale = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnObrisiSalu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAzurirajSalu
            // 
            this.btnAzurirajSalu.Location = new System.Drawing.Point(5, 61);
            this.btnAzurirajSalu.Name = "btnAzurirajSalu";
            this.btnAzurirajSalu.Size = new System.Drawing.Size(240, 37);
            this.btnAzurirajSalu.TabIndex = 9;
            this.btnAzurirajSalu.Text = "Azuriraj salu";
            this.btnAzurirajSalu.UseVisualStyleBackColor = true;
            this.btnAzurirajSalu.Click += new System.EventHandler(this.btnAzurirajSalu_Click);
            // 
            // txtBrojSedista
            // 
            this.txtBrojSedista.Location = new System.Drawing.Point(98, 31);
            this.txtBrojSedista.Name = "txtBrojSedista";
            this.txtBrojSedista.Size = new System.Drawing.Size(148, 20);
            this.txtBrojSedista.TabIndex = 8;
            // 
            // txtBrojSale
            // 
            this.txtBrojSale.Location = new System.Drawing.Point(98, 5);
            this.txtBrojSale.Name = "txtBrojSale";
            this.txtBrojSale.Size = new System.Drawing.Size(148, 20);
            this.txtBrojSale.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Broj sedista: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Broj sale: ";
            // 
            // btnObrisiSalu
            // 
            this.btnObrisiSalu.Location = new System.Drawing.Point(5, 104);
            this.btnObrisiSalu.Name = "btnObrisiSalu";
            this.btnObrisiSalu.Size = new System.Drawing.Size(240, 37);
            this.btnObrisiSalu.TabIndex = 10;
            this.btnObrisiSalu.Text = "Obrisi salu";
            this.btnObrisiSalu.UseVisualStyleBackColor = true;
            this.btnObrisiSalu.Click += new System.EventHandler(this.btnObrisiSalu_Click);
            // 
            // FrmAzurirajSalu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 146);
            this.Controls.Add(this.btnObrisiSalu);
            this.Controls.Add(this.btnAzurirajSalu);
            this.Controls.Add(this.txtBrojSedista);
            this.Controls.Add(this.txtBrojSale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "FrmAzurirajSalu";
            this.Text = "FrmAzurirajSalu";
            this.Load += new System.EventHandler(this.FrmAzurirajSalu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAzurirajSalu;
        private System.Windows.Forms.TextBox txtBrojSedista;
        private System.Windows.Forms.TextBox txtBrojSale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnObrisiSalu;
    }
}