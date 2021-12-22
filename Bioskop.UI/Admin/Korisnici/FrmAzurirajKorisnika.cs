using Bioskop.Domen;
using Bioskop.Servisi.KorisnikServis;
using System;
using System.Windows.Forms;

namespace Bioskop.UI.Admin
{
    public partial class FrmAzurirajKorisnika : Form
    {
        private KorisnikServis korisnikServis;
        private DataGridViewCellCollection kolekcijaCelija;

        public FrmAzurirajKorisnika()
        {
            InitializeComponent();
            this.korisnikServis = new KorisnikServis();
        }

        public FrmAzurirajKorisnika(DataGridViewCellCollection kolekcijaCelija) : this()
        {
            this.kolekcijaCelija = kolekcijaCelija;
        }

        private void FrmAzurirajKorisnika_Load(object sender, EventArgs e)
        {
            this.txtIme.Text = this.kolekcijaCelija["Ime"].Value.ToString();
            this.txtPrezime.Text = this.kolekcijaCelija["Prezime"].Value.ToString();
            this.dateTimePicker1.Value = DateTime.Parse(this.kolekcijaCelija["DatumRodjenja"].Value.ToString());
            this.txtTelefon.Text = this.kolekcijaCelija["Telefon"].Value.ToString();
            this.txtKorisnickoIme.Text = this.kolekcijaCelija["KorisnickoIme"].Value.ToString();
            this.txtLozinka.Text = this.kolekcijaCelija["Lozinka"].Value.ToString();
            
            //cmb za pol
            this.cmbPol.DataSource = Enum.GetValues(typeof(Pol));
            this.cmbPol.SelectedItem = this.cmbPol.Items[(int)this.kolekcijaCelija["Pol"].Value];

            //cmb za tip korisnika
            this.cmbTipKorisnika.DataSource = Enum.GetValues(typeof(TipKorisnika));
            this.cmbTipKorisnika.SelectedItem = this.cmbTipKorisnika.Items[(int)this.kolekcijaCelija["TipKorisnika"].Value];

            //radio za registraciju
            if ((bool)(this.kolekcijaCelija["DaLiJeRegistrovan"].Value))
            {
                this.rbRegistrovan.Checked = true;
            }
            else
            {
                this.rbNeregistrovan.Checked = true;
            }
        }

        private void btnAzurirajKorisnika_Click(object sender, EventArgs e)
        {
            try
            {
                this.korisnikServis.AzurirajKorisnika(new Bioskop.Domen.Korisnik() 
                { 
                    Id = (int)(this.kolekcijaCelija["Id"].Value),
                    Ime = txtIme.Text, 
                    Prezime = txtPrezime.Text,
                    DatumRodjenja = dateTimePicker1.Value.Date,
                    Telefon = txtTelefon.Text,
                    Pol = (Pol)cmbPol.SelectedIndex,
                    TipKorisnika = (TipKorisnika)cmbTipKorisnika.SelectedIndex,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Lozinka = txtLozinka.Text,
                    DaLiJeRegistrovan = rbRegistrovan.Checked ? true : false
                });
                MessageBox.Show("Azuriranje korisnika je uspelo.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void btnObrisiKorisnika_Click(object sender, EventArgs e)
        {
            try
            {
                this.korisnikServis.ObrisiKorisnika(new Bioskop.Domen.Korisnik()
                {
                    Id = (int)(this.kolekcijaCelija["Id"].Value)
                });
                MessageBox.Show("Brisanje je uspelo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
