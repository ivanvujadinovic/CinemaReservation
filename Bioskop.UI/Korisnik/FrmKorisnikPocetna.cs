using Bioskop.UI.Admin;
using Bioskop.UI.Korisnik.PravljenjeRezervacije;
using Bioskop.Util.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioskop.UI.Korisnik
{
    public partial class FrmKorisnikPocetna : Form
    {
        public FrmKorisnikPocetna()
        {
            InitializeComponent();
        }

        private void btnNapraviRezervaciju_Click(object sender, EventArgs e)
        {
            KreirajPanelZaRezervaciju kreirajPanelZaRezervaciju = new KreirajPanelZaRezervaciju(pnlRadnaPovrsina);
        }

        private void FrmKorisnikPocetna_Load(object sender, EventArgs e)
        {
            try
            {
                this.label1.Text = $"Ulogovani korisnik: {KorisnickaSesijaSinglton.KorisnickaSesija.UlogovaniKorisnik.Ime} {KorisnickaSesijaSinglton.KorisnickaSesija.UlogovaniKorisnik.Prezime}";
            }
            catch (Exception ex)
            {

            }
            FrmAdminPocetnaStrana.PostaviHoverZaDugmad(panel);
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            KreirajPanelZaPrikazRezervacija kreirajPanelZaPrikazRezervacija = new KreirajPanelZaPrikazRezervacija(pnlRadnaPovrsina);
        }
    }
}
