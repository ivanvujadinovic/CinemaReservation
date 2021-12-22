using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Bioskop.Servisi.ProjekcijaServis;
using System.Data;
using Bioskop.Domen;

namespace Bioskop.UI.Admin.Projekcije
{
    public class KreirajPanelZaProjekcije
    {
        private Panel panel;
        private DataGridView dataGridViewProjekcije;
        private Button dugme;
        private ProjekcijaServis projekcijaServis;

        public KreirajPanelZaProjekcije(Panel panel)
        {
            this.panel = panel;
            this.dataGridViewProjekcije = new DataGridView();
            this.dugme = new Button();
            this.projekcijaServis = new ProjekcijaServis();
            this.OcistiPanel();
            this.PostaviKomponente();
            FrmAdminPocetnaStrana.PostaviHoverZaDugmad(this.panel);
        }

        private void PostaviKomponente()
        {
            this.panel.Controls.Add(dataGridViewProjekcije);
            this.dataGridViewProjekcije.Location = new Point(10, 10);
            this.dataGridViewProjekcije.Width = this.panel.Width - 20;
            this.dataGridViewProjekcije.Height = (int)(this.panel.Height * 0.8);
            this.dataGridViewProjekcije.BackgroundColor = Color.FromArgb(255, 192, 128);
            this.dataGridViewProjekcije.CellClick += DataGridViewProjekcije_CellClick;
            this.dataGridViewProjekcije.DataSource = this.VratiDataTabeluZaProjekcije(projekcijaServis.VratiSveProjekcije());
            this.dataGridViewProjekcije.ReadOnly = true;

            this.panel.Controls.Add(dugme);
            this.dugme.Name = "btnDodajProjekciju";
            this.dugme.Text = "Dodaj projekciju";
            this.dugme.Location = new Point(10, this.dataGridViewProjekcije.Height + 20);
            this.dugme.Width = this.panel.Width - 20;
            this.dugme.Height = 50;
            this.dugme.Click += btnDodajProjekciju_Click;
            this.dugme.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void DataGridViewProjekcije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection kolekcijaCelja = this.dataGridViewProjekcije.Rows[e.RowIndex].Cells;
            FrmAzurirajProjekciju frmAzurirajProjekciju = new FrmAzurirajProjekciju(kolekcijaCelja);
            frmAzurirajProjekciju.Show();
        }

        private void btnDodajProjekciju_Click(object sender, EventArgs e)
        {
            FrmDodajProjekciju frmDodajProjekciju = new FrmDodajProjekciju();
            frmDodajProjekciju.Show();
        }

        private void OcistiPanel()
        {
            this.panel.Controls.Clear();
        }

        private DataTable VratiDataTabeluZaProjekcije(List<Projekcija> projekcije)
        {
            DataTable projekcijeTabela = new DataTable("Projekcije");
            
            projekcijeTabela.Columns.Add("Id");
            projekcijeTabela.Columns.Add("DatumProjekcije");
            projekcijeTabela.Columns.Add("SalaId");
            projekcijeTabela.Columns.Add("BrojMesta");
            projekcijeTabela.Columns.Add("CenaKarta");
            projekcijeTabela.Columns.Add("PocetakProjekcije");
            projekcijeTabela.Columns.Add("KrajProjekcije");
            projekcijeTabela.Columns.Add("FilmId");

            foreach (Projekcija projekcija in projekcije)
            {
                DataRow red = projekcijeTabela.NewRow();

                red["Id"] = projekcija.Id;
                red["DatumProjekcije"] = projekcija.DatumProjekcije.ToShortDateString();
                red["SalaId"] = projekcija.SalaId;
                red["BrojMesta"] = projekcija.BrojSlobodnihMesta;
                red["CenaKarta"] = projekcija.CenaKarta;
                red["PocetakProjekcije"] = projekcija.VremeProjekcije.PocetakProjekcije;
                red["KrajProjekcije"] = projekcija.VremeProjekcije.KrajProjekcije;
                red["FilmId"] = projekcija.FilmId;

                projekcijeTabela.Rows.Add(red);
            }

            return projekcijeTabela;
        }
    }
}
