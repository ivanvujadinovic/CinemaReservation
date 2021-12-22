using Bioskop.Servisi.KorisnikServis;
using Bioskop.UI.Admin;
using Bioskop.UI.Korisnik;
using Bioskop.Util.Cache;
using System;
using System.Windows.Forms;

namespace Bioskop.UI.LogIn
{
    public partial class FrmLogIn : Form
    {
        private KorisnikServis korisnikServis;

        public FrmLogIn()
        {
            InitializeComponent();
            this.korisnikServis = new KorisnikServis();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            try
            {
                this.korisnikServis.UlogujKorisnika(txtKorisnickoIme.Text, txtLozinka.Text);
                
                if (KorisnickaSesijaSinglton.KorisnickaSesija.UlogovaniKorisnik.TipKorisnika == 0)
                {
                    this.Hide(); //sakrije login formu
                    FrmAdminPocetnaStrana registracijaForm = new FrmAdminPocetnaStrana(); //napravi objekat Form1
                    registracijaForm.Closed += (s, args) => this.Show(); // kada zatvorim form1, zatvorim i login
                    registracijaForm.Show(); //prikazi form1
                }
                else
                {
                    this.Hide(); //sakrije login formu
                    FrmKorisnikPocetna frmKorisnikPocetna = new FrmKorisnikPocetna(); //napravi objekat Form1
                    frmKorisnikPocetna.Closed += (s, args) => this.Show(); // kada zatvorim form1, zatvorim i login
                    frmKorisnikPocetna.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.IsprazniTextBoxove();
            }
        }

        private void IsprazniTextBoxove()
        {
            txtKorisnickoIme.Text = "";
            txtLozinka.Text = "";
        }

        private void lblRegistracija_Click(object sender, EventArgs e)
        {
            this.Hide(); //sakrije login formu
            FrmRegistracija registracijaForm = new FrmRegistracija(); //napravi objekat Form1
            registracijaForm.Closed += (s, args) => this.Show(); // kada zatvorim form1, zatvorim i login
            registracijaForm.Show(); //prikazi form1
        }
    }
}
