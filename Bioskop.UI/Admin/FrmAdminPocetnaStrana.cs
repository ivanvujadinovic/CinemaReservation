using Bioskop.UI.Admin.Filmovi;
using Bioskop.UI.Admin.Projekcije;
using Bioskop.UI.Admin.Sale;
using Bioskop.UI.Korisnik.PravljenjeRezervacije;
using Bioskop.Util.Cache;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bioskop.UI.Admin
{
    public partial class FrmAdminPocetnaStrana : Form
    {
        public FrmAdminPocetnaStrana()
        {
            InitializeComponent();
        }

        private void FrmAdminPocetnaStrana_Load(object sender, EventArgs e)
        {
            try
            {
                this.label1.Text = $"Ulogovani korisnik: {KorisnickaSesijaSinglton.KorisnickaSesija.UlogovaniKorisnik.Ime} {KorisnickaSesijaSinglton.KorisnickaSesija.UlogovaniKorisnik.Prezime}";
            }
            catch (Exception ex)
            {

            }
            PostaviHoverZaDugmad(this.panel);
        }

        private void btnKorisniciForm_Click(object sender, EventArgs e)
        {
            KreirajPanelZaKorisnike kreirajPanelZaKorisnike = new KreirajPanelZaKorisnike(pnlRadnaPovrsina);
        }

        private void btnFilmoviForm_Click(object sender, EventArgs e)
        {
            KreirajPanelZaFilmove kreirajPanelZaFilmove = new KreirajPanelZaFilmove(pnlRadnaPovrsina);
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            KreirajPanelZaSale kreirajPanelZaSale = new KreirajPanelZaSale(pnlRadnaPovrsina);
        }

        private void btnProjekcije_Click(object sender, EventArgs e)
        {
            KreirajPanelZaProjekcije kreirajPanelZaProjekcije = new KreirajPanelZaProjekcije(pnlRadnaPovrsina);
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            KreirajPanelZaPrikazRezervacija kreirajPanelZaPrikazRezervacija = new KreirajPanelZaPrikazRezervacija(pnlRadnaPovrsina);
        }
        public static void PostaviHoverZaDugmad(Panel panel)
        {
            foreach (var item in panel.Controls)
            {
                if (item is Button)
                {
                    var color = (item as Button).BackColor;
                    (item as Button).Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                    (item as Button).MouseEnter += (object s, EventArgs ea) =>
                    {
                        (item as Button).BackColor = Color.FromArgb(51, 204, 51);
                        (item as Button).Cursor = Cursors.Hand;
                    };

                    (item as Button).MouseLeave += (object s, EventArgs ea) =>
                    {
                        (item as Button).BackColor = color;
                    };
                }
            }
        }

        
    }
}
