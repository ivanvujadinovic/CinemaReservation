using Bioskop.Domen;
using Bioskop.Servisi.FilmServis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioskop.UI.Admin.Filmovi
{
    public partial class FrmDodajFilm : Form
    {
        private FilmServis filmServis;

        public FrmDodajFilm()
        {
            InitializeComponent();
            filmServis = new FilmServis();
        }

        private void btnDodajFilm_Click(object sender, EventArgs e)
        {
            float trajanje = 0f;
            int starosnaGranica = 0;

            if (float.TryParse(this.txtTrajanje.Text, out trajanje) && 
                int.TryParse(this.txtStarosnaGranica.Text, out starosnaGranica))
            {
                try
                {
                    this.filmServis.DodajFilm(new Film()
                    {
                        Naziv = txtNaziv.Text,
                        Zanr = (Zanr)cmbZanr.SelectedIndex,
                        Trajanje = trajanje,
                        StarosnaGranica = starosnaGranica
                    });
                    MessageBox.Show("Uspesno ste dodali film.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Greska pri unosu trajanja filma ili starosne granice.");
            }
        }

        private void FrmDodajFilm_Load(object sender, EventArgs e)
        {
            this.cmbZanr.DataSource = Enum.GetValues(typeof(Zanr));
        }
    }
}
