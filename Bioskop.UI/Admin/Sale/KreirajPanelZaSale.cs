using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Bioskop.Servisi.SalaServis;

namespace Bioskop.UI.Admin.Sale
{
    public class KreirajPanelZaSale
    {
        private Panel panel;
        private DataGridView dataGridViewSale;
        private Button dugme;
        private SalaServis salaServis;

        public KreirajPanelZaSale(Panel panel)
        {
            this.panel = panel;
            this.dataGridViewSale = new DataGridView();
            this.dugme = new Button();
            this.salaServis = new SalaServis();
            this.OcistiPanel();
            this.PostaviKomponente();
            FrmAdminPocetnaStrana.PostaviHoverZaDugmad(this.panel);
        }

        private void OcistiPanel()
        {
            this.panel.Controls.Clear();
        }
        private void PostaviKomponente()
        {
            this.dataGridViewSale.Location = new Point(10, 10);
            this.dataGridViewSale.Width = this.panel.Width - 20;
            this.dataGridViewSale.Height = (int)(this.panel.Height * 0.8);
            this.dataGridViewSale.BackgroundColor = Color.FromArgb(255, 192, 128);
            this.dataGridViewSale.CellClick += DataGridViewSale_CellClick;
            this.dataGridViewSale.DataSource = this.salaServis.VratiSveSale();
            this.panel.Controls.Add(this.dataGridViewSale);

            this.panel.Controls.Add(dugme);
            this.dugme.Name = "btnDodajSalu";
            this.dugme.Text = "Dodaj salu";
            this.dugme.Location = new Point(10, this.dataGridViewSale.Height + 20);
            this.dugme.Width = this.panel.Width - 20;
            this.dugme.Height = 50;
            this.dugme.Click += btnDodajSalu_Click;
            this.dugme.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void DataGridViewSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection kolekcijaCelija = this.dataGridViewSale.Rows[e.RowIndex].Cells;
            FrmAzurirajSalu frmAzurirajSalu = new FrmAzurirajSalu(kolekcijaCelija);
            frmAzurirajSalu.Show();
        }

        private void btnDodajSalu_Click(object sender, EventArgs e)
        {
            FrmDodajSalu frmDodajSalu = new FrmDodajSalu();
            frmDodajSalu.Show();
        }
    }
}
