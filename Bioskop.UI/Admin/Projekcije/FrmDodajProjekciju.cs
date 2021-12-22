using Bioskop.Domen;
using Bioskop.Servisi.FilmServis;
using Bioskop.Servisi.ProjekcijaServis;
using Bioskop.Servisi.SalaServis;
using System;
using System.Windows.Forms;

namespace Bioskop.UI.Admin.Projekcije
{
    public partial class FrmDodajProjekciju : Form
    {
        private ProjekcijaServis projekcijaServis;
        private SalaServis salaServis;
        private FilmServis filmServis;

        public FrmDodajProjekciju()
        {
            InitializeComponent();
            projekcijaServis = new ProjekcijaServis();
            salaServis = new SalaServis();
            filmServis = new FilmServis();
        }

        private void FrmDodajProjekciju_Load(object sender, EventArgs e)
        {
            this.cmbFilm.DataSource = this.filmServis.VratiFilmoveUFormatuZaIspis();
            this.cmbSale.DataSource = this.salaServis.VratiSaleUFormatuZaIspis();
        }

        private void btnDodajProjekciju_Click(object sender, EventArgs e)
        {
            float cenaKarte = 0f;

            if (float.TryParse(txtCenaKarte.Text, out cenaKarte))
            {
                try
                {
                    this.projekcijaServis.DodajProjekciju(new Projekcija()
                    {
                        DatumProjekcije = dtpDatum.Value.Date,
                        SalaId = this.VratiIdIzFormataZaIspis(cmbSale.Text),
                        CenaKarta = Math.Abs(cenaKarte),
                        VremeProjekcije = new VremeProjekcije() { PocetakProjekcije = new TimeSpan(dtpVreme.Value.Hour, dtpVreme.Value.Minute, 0) },
                        FilmId = this.VratiIdIzFormataZaIspis(cmbFilm.Text)
                    });
                    MessageBox.Show("Uspesno dodata projekcija.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Pogresno uneta cena karte.");
            }
        }

        private int VratiIdIzFormataZaIspis(string formatZaIspis)
        {
            return int.Parse(formatZaIspis.Split(' ')[0]);
        }
    }
}
