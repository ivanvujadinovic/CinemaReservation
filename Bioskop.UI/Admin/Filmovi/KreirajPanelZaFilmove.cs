using System;
using System.Drawing;
using System.Windows.Forms;
using Bioskop.Servisi.FilmServis;

namespace Bioskop.UI.Admin.Filmovi
{
    public class KreirajPanelZaFilmove
    {
        private Panel panel;
        private DataGridView dataGridViewFilmovi;
        private Button dugme;
        private FilmServis filmServis;

        public KreirajPanelZaFilmove(Panel panel)
        {
            this.panel = panel;
            this.dataGridViewFilmovi = new DataGridView();
            this.dugme = new Button();
            this.filmServis = new FilmServis();
            this.OcistiPanel();
            this.PostaviKomponente();
            FrmAdminPocetnaStrana.PostaviHoverZaDugmad(this.panel);
        }

        private void OcistiPanel()
        {
            this.panel.Controls.Clear();
        }

        public void PostaviKomponente()
        {
            //panel
            this.dataGridViewFilmovi.Location = new Point(10, 10);
            this.dataGridViewFilmovi.Width = this.panel.Width - 20;
            this.dataGridViewFilmovi.Height = (int)(this.panel.Height * 0.8);
            this.dataGridViewFilmovi.BackgroundColor = Color.FromArgb(255, 192, 128);
            this.dataGridViewFilmovi.CellClick += DataGridViewFilmovi_CellClick;
            this.dataGridViewFilmovi.DataSource = this.filmServis.VratiSveFilmove();
            this.panel.Controls.Add(this.dataGridViewFilmovi);

            //dugme
            this.panel.Controls.Add(dugme);
            dugme.Name = "btnDodajFilm";
            dugme.Text = "Dodaj film";
            dugme.Location = new Point(10, this.dataGridViewFilmovi.Height + 20);
            dugme.Width = this.panel.Width - 20;
            dugme.Height = 50;
            this.dugme.Click += btnDodajFilm_Click;
            this.dugme.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void DataGridViewFilmovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection kolekcijaCelija = this.dataGridViewFilmovi.Rows[e.RowIndex].Cells;
            FrmAzurirajFilm frmAzurirajFilm = new FrmAzurirajFilm(kolekcijaCelija);
            frmAzurirajFilm.Show();
        }

        private void btnDodajFilm_Click(object sender, EventArgs e)
        {
            FrmDodajFilm frmDodajFilm = new FrmDodajFilm();
            frmDodajFilm.Show();
        }
    }
}
