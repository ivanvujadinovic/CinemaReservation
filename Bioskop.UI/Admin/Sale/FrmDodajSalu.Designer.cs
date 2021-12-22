
namespace Bioskop.UI.Admin.Sale
{
    partial class FrmDodajSalu
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrojSale = new System.Windows.Forms.TextBox();
            this.txtBrojSedista = new System.Windows.Forms.TextBox();
            this.btnDodajSalu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Broj sale: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Broj sedista: ";
            // 
            // txtBrojSale
            // 
            this.txtBrojSale.Location = new System.Drawing.Point(102, 5);
            this.txtBrojSale.Name = "txtBrojSale";
            this.txtBrojSale.Size = new System.Drawing.Size(148, 20);
            this.txtBrojSale.TabIndex = 2;
            // 
            // txtBrojSedista
            // 
            this.txtBrojSedista.Location = new System.Drawing.Point(102, 31);
            this.txtBrojSedista.Name = "txtBrojSedista";
            this.txtBrojSedista.Size = new System.Drawing.Size(148, 20);
            this.txtBrojSedista.TabIndex = 3;
            // 
            // btnDodajSalu
            // 
            this.btnDodajSalu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSalu.Location = new System.Drawing.Point(9, 54);
            this.btnDodajSalu.Name = "btnDodajSalu";
            this.btnDodajSalu.Size = new System.Drawing.Size(240, 37);
            this.btnDodajSalu.TabIndex = 4;
            this.btnDodajSalu.Text = "Dodaj salu";
            this.btnDodajSalu.UseVisualStyleBackColor = true;
            this.btnDodajSalu.Click += new System.EventHandler(this.btnDodajSalu_Click);
            // 
            // FrmDodajSalu
            // 
            this.ClientSize = new System.Drawing.Size(253, 94);
            this.Controls.Add(this.btnDodajSalu);
            this.Controls.Add(this.txtBrojSedista);
            this.Controls.Add(this.txtBrojSale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "FrmDodajSalu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBrojSale;
        private System.Windows.Forms.TextBox txtBrojSedista;
        private System.Windows.Forms.Button btnDodajSalu;
    }
}