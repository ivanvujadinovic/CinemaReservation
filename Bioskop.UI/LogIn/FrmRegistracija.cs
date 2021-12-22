using Bioskop.Domen;
using Bioskop.Servisi.KorisnikServis;
using Bioskop.Util;
using System;
using System.Windows.Forms;

namespace Bioskop.UI.LogIn
{
    public partial class FrmRegistracija : Form
    {
        private KorisnikServis korisnikServis; 
        public FrmRegistracija()
        {
            InitializeComponent();
            this.korisnikServis = new KorisnikServis();
        }

        private void Registracija_Load(object sender, EventArgs e)
        {
            this.cmbPol.DataSource = Enum.GetValues(typeof(Pol));
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.ValidacijaLozinke()))
            {
                Bioskop.Domen.Korisnik korisnik = new Bioskop.Domen.Korisnik()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    DatumRodjenja = dateTimePicker1.Value.Date,
                    Telefon = txtTelefon.Text,
                    Pol = (Pol)cmbPol.SelectedIndex,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Lozinka = txtLozinka.Text,
                };
                try
                {
                    this.korisnikServis.RegistrujKorisnika(korisnik);
                    MessageBox.Show("Uspesno ste se registrovali.");
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(this.ValidacijaLozinke());
            }
        }

        private string ValidacijaLozinke()
        {
            string porukaOGresci = "";
            if (Validacija.DaLiStringSadrziBroj(txtIme.Text))
            {
                porukaOGresci += "Ime ne moze da sadrzi broj." + Environment.NewLine;
            }

            if (Validacija.DaLiStringSadrziBroj(txtPrezime.Text))
            {
                porukaOGresci += "Prezime ne moze da sadrzi broj." + Environment.NewLine;
            }

            if (!Validacija.DaLiJeTelefonIspravan(txtTelefon.Text))
            {
                porukaOGresci += "Unesite ispravan telefon." + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtIme.Text))
            {
                porukaOGresci += "Unesite ime." + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                porukaOGresci += "Unesite ispravno prezime." + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtTelefon.Text))
            {
                porukaOGresci += "Unesite telefon." + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(cmbPol.Text))
            {
                porukaOGresci += "Unesite pol." + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtKorisnickoIme.Text))
            {
                porukaOGresci += "Unesite korisnicko ime." + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtLozinka.Text))
            {
                porukaOGresci += "Unesite lozinku." + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txtPotvrdiLozinku.Text))
            {
                porukaOGresci += "Potvrdite lozinku." + Environment.NewLine;
            }

            if (!string.IsNullOrEmpty(txtLozinka.Text) && !string.IsNullOrEmpty(txtPotvrdiLozinku.Text) && 
                txtLozinka.Text != txtPotvrdiLozinku.Text)
            {
                porukaOGresci += "Lozinke se ne podudaraju." + Environment.NewLine;
            }

            return porukaOGresci;
        }
    }
}
