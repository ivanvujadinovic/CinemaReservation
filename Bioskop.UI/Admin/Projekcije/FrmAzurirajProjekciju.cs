using Bioskop.Domen;
using Bioskop.Servisi.FilmServis;
using Bioskop.Servisi.ProjekcijaServis;
using Bioskop.Servisi.SalaServis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioskop.UI.Admin.Projekcije
{
    public partial class FrmAzurirajProjekciju : Form
    {
        private ProjekcijaServis projekcijaServis;
        private SalaServis salaServis;
        private FilmServis filmServis;
        private DataGridViewCellCollection kolekcijaCelija;
        public FrmAzurirajProjekciju()
        {
            InitializeComponent();
            projekcijaServis = new ProjekcijaServis();
            salaServis = new SalaServis();
            filmServis = new FilmServis();
        }

        public FrmAzurirajProjekciju(DataGridViewCellCollection kolekcijaCelija) : this()
        {
            this.kolekcijaCelija = kolekcijaCelija;
        }

        private void FrmAzurirajProjekciju_Load(object sender, EventArgs e)
        {
            dtpDatum.Value = DateTime.Parse(this.kolekcijaCelija["DatumProjekcije"].Value.ToString());
            dtpVreme.Value = DateTime.Parse( this.kolekcijaCelija["PocetakProjekcije"].Value.ToString());
            txtCenaKarte.Text = this.kolekcijaCelija["CenaKarta"].Value.ToString();

            this.cmbSale.DataSource = this.salaServis.VratiSaleUFormatuZaIspis();
            this.cmbSale.SelectedItem = this.cmbSale.Items[this.VratiIndexComboBoxItema(this.cmbSale.Items, this.kolekcijaCelija["SalaId"].Value.ToString())];
            
            this.cmbFilm.DataSource = this.filmServis.VratiFilmoveUFormatuZaIspis();
            this.cmbFilm.SelectedItem = this.cmbFilm.Items[this.VratiIndexComboBoxItema(this.cmbFilm.Items, this.kolekcijaCelija["FilmId"].Value.ToString())];

        }

        private int VratiIndexComboBoxItema(ComboBox.ObjectCollection kolekcija, string cmbTekst)
        {
            int indeks = 0;

            foreach(var item in kolekcija)
            {
                if (item.ToString().Split(' ')[0] == cmbTekst)
                {
                    return indeks;
                }
                indeks++;
            }

            return indeks;
        }

        private void btnAzurirajProjekciju_Click(object sender, EventArgs e)
        {
            float cenaKarte = 0f;

            if (float.TryParse(txtCenaKarte.Text, out cenaKarte))
            {
                try
                {
                    this.projekcijaServis.AzurirajProjekciju(new Projekcija()
                    {
                        Id = int.Parse(this.kolekcijaCelija["Id"].Value.ToString()),
                        DatumProjekcije = this.dtpDatum.Value.Date,
                        VremeProjekcije = new VremeProjekcije() { PocetakProjekcije = new TimeSpan(dtpVreme.Value.Hour, dtpVreme.Value.Minute, 0) },
                        CenaKarta = cenaKarte,
                        SalaId = this.VratiIdIzFormataZaIspis(cmbSale.Text),
                        FilmId = this.VratiIdIzFormataZaIspis(cmbFilm.Text)
                    });
                    MessageBox.Show("Uspesno ste azurirali projekciju.");
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

        private void btnObrisiProjekciju_Click(object sender, EventArgs e)
        {
            try
            {
                this.projekcijaServis.ObrisiProjekciju(new Projekcija()
                {
                    Id = int.Parse(this.kolekcijaCelija["Id"].Value.ToString())
                });
                MessageBox.Show("Uspesno ste obrisali projekciju.");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
