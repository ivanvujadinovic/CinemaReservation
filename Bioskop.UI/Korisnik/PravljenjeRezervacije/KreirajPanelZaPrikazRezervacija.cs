using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Bioskop.Servisi.RezervacijaServis;
using Bioskop.Domen;
using System.Data;
using Bioskop.Servisi.KorisnikServis;
using Bioskop.Util.Cache;

namespace Bioskop.UI.Korisnik.PravljenjeRezervacije
{
    public class KreirajPanelZaPrikazRezervacija
    {
        private Panel panel;
        private DataGridView dataGridRezervacija;
        private RezervacijaServis rezervacijaServis;
        private KorisnikServis korisnikServis;

        public KreirajPanelZaPrikazRezervacija(Panel panel)
        {
            this.panel = panel;
            this.dataGridRezervacija = new DataGridView();
            rezervacijaServis = new RezervacijaServis();
            korisnikServis = new KorisnikServis();
            this.OcistiPanel();
            this.PostaviKomponente();
        }

        private void OcistiPanel()
        {
            this.panel.Controls.Clear();
        }

        private void PostaviKomponente()
        {
            this.dataGridRezervacija.Location = new Point(10, 10);
            this.dataGridRezervacija.Width = this.panel.Width - 20;
            this.dataGridRezervacija.Height = (int)(this.panel.Height * 0.8);
            this.dataGridRezervacija.BackgroundColor = Color.FromArgb(255,192,128);
            if (KorisnickaSesijaSinglton.KorisnickaSesija.UlogovaniKorisnik.TipKorisnika == 0)
            {
                this.dataGridRezervacija.DataSource = rezervacijaServis.VratiSveRezervacije();
                this.dataGridRezervacija.CellClick += DataGridRezervacija_CellClick;
            }
            else
            {
                this.dataGridRezervacija.DataSource = rezervacijaServis.VratiSveRezervacijePoId();
                this.dataGridRezervacija.CellClick += DataGridRezervacija_CellClick;
            }
            this.panel.Controls.Add(this.dataGridRezervacija);
            
        }

        private void DataGridRezervacija_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection kolekcijaCelija = this.dataGridRezervacija.Rows[e.RowIndex].Cells;

            DialogResult dialogResult = MessageBox.Show("Da li zelite da obrisete rezervaciju?", "Brisanje rezervacije", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.rezervacijaServis.ObrisiRezervaciju(new Rezervacija()
                {
                    Id = (int)kolekcijaCelija["Id"].Value,
                    IdKorisnika = (int)kolekcijaCelija["IdKorisnika"].Value,
                    IdProjekcija = (int)kolekcijaCelija["IdProjekcija"].Value,
                    IdSale = (int)kolekcijaCelija["IdSale"].Value,
                    BrojSedista = (int)kolekcijaCelija["BrojSedista"].Value,
                    UkupnaCena = (decimal)kolekcijaCelija["UkupnaCena"].Value
                });
            }
        }
    }
}
