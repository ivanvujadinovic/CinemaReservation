using System;
using System.Windows.Forms;
using System.Drawing;
using Bioskop.Servisi.KorisnikServis;
using Bioskop.UI.LogIn;

namespace Bioskop.UI.Admin
{
    class KreirajPanelZaKorisnike
    {
        private Panel panel;
        private DataGridView dataGridViewKorisnici;
        private Button[] dugmad;
        private KorisnikServis korisnikServis;
        public KreirajPanelZaKorisnike(Panel panel)
        {
            this.panel = panel;
            this.dataGridViewKorisnici = new DataGridView();
            this.dugmad = new Button[3];
            this.korisnikServis = new KorisnikServis();
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
            // da postavis data grid view
            this.dataGridViewKorisnici.Location = new Point(10, 10);
            this.dataGridViewKorisnici.Width = this.panel.Width - 20;
            this.dataGridViewKorisnici.Height = (int)(this.panel.Height * 0.8);
            this.dataGridViewKorisnici.BackgroundColor = Color.FromArgb(255, 192, 128);
            this.dataGridViewKorisnici.CellClick += DataGridViewKorisnici_CellClick;
            //this.dataGridViewKorisnici.DataSource = this.korisnikServis.DohvatiSveKorisnike();
            this.panel.Controls.Add(this.dataGridViewKorisnici);

            // da postavis dugmice
            for (int i = 0; i < this.dugmad.Length; i++)
            {
                this.dugmad[i] = new Button();
                this.dugmad[i].BackColor = Color.FromArgb(192, 255, 192);
                this.panel.Controls.Add(this.dugmad[i]);
            }
            this.dugmad[0].Text = "Prikazi registoravane korisnike";
            this.dugmad[0].Name = "btnPrikaziRegistrovane";
            this.dugmad[0].Location = new Point(10, this.dataGridViewKorisnici.Height + 20);
            this.dugmad[0].Width = this.panel.Width / 3 - 8;
            this.dugmad[0].Height = 50;
            this.dugmad[0].Click += btnPrikaziRegistrovane_Click;

            this.dugmad[1].Text = "Prikazi neregistrovane korisnike";
            this.dugmad[1].Name = "btnPrikaziNeregistorvane";
            this.dugmad[1].Location = new Point(this.dugmad[0].Width + 10, this.dataGridViewKorisnici.Height + 20);
            this.dugmad[1].Width = this.panel.Width / 3 - 8;
            this.dugmad[1].Height = 50;
            this.dugmad[1].Click += btnPrikaziNeregistrovane_Click;

            this.dugmad[2].Text = "Dodaj korisnika";
            this.dugmad[2].Name = "btnDodajKorisnika";
            this.dugmad[2].Location = new Point(this.dugmad[1].Width * 2 + 10, this.dataGridViewKorisnici.Height+20);
            this.dugmad[2].Width = this.panel.Width / 3 - 8;
            this.dugmad[2].Height = 50;
            this.dugmad[2].Click += btnDodajKorisnika_Click;
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            FrmRegistracija registracija = new FrmRegistracija();
            registracija.Show();
        }

        private void DataGridViewKorisnici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection kolekcijaCelija = this.dataGridViewKorisnici.Rows[e.RowIndex].Cells;
            FrmAzurirajKorisnika frmAzurirajKorisnika = new FrmAzurirajKorisnika(kolekcijaCelija);
            frmAzurirajKorisnika.Show();
        }

        private void btnPrikaziRegistrovane_Click(object sender, EventArgs e)
        {
            this.dataGridViewKorisnici.DataSource = this.korisnikServis.VratiRegistoraneKorisnike();
        }

        private void btnPrikaziNeregistrovane_Click(object sender, EventArgs e)
        {
            this.dataGridViewKorisnici.DataSource = this.korisnikServis.VratiNeregistovaneKorisnike();
        }
    }
}
