using Bioskop.Domen;
using Bioskop.Servisi.FilmServis;
using System;
using System.Windows.Forms;

namespace Bioskop.UI.Admin.Filmovi
{
    public partial class FrmAzurirajFilm : Form
    {
        private FilmServis filmServis;
        private DataGridViewCellCollection kolekcijaCelija;

        public FrmAzurirajFilm()
        {
            InitializeComponent();
            filmServis = new FilmServis();
        }

        public FrmAzurirajFilm(DataGridViewCellCollection kolekcijaCelija) : this()
        {
            this.kolekcijaCelija = kolekcijaCelija;
        }

        private void FrmAzurirajFilm_Load(object sender, EventArgs e)
        {
            this.txtNaziv.Text = this.kolekcijaCelija["Naziv"].Value.ToString();
            this.txtTrajanje.Text = this.kolekcijaCelija["Trajanje"].Value.ToString();
            this.txtStarosnaGranica.Text = this.kolekcijaCelija["StarosnaGranica"].Value.ToString();

            this.cmbZanr.DataSource = Enum.GetValues(typeof(Zanr));
            this.cmbZanr.SelectedItem = this.cmbZanr.Items[(int)this.kolekcijaCelija["Zanr"].Value];
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            float trajanje = 0f;
            int starosnaGranica = 0;

            if (float.TryParse(this.txtTrajanje.Text, out trajanje) &&
                int.TryParse(this.txtStarosnaGranica.Text, out starosnaGranica))
            {
                try
                {
                    this.filmServis.AzurirajFilm(new Film()
                    {
                        Id = (int)(this.kolekcijaCelija["Id"].Value),
                        Naziv = txtNaziv.Text,
                        Zanr = (Zanr)cmbZanr.SelectedIndex,
                        Trajanje = trajanje,
                        StarosnaGranica = starosnaGranica
                    });
                    MessageBox.Show("Uspesno ste azurirali film.");
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

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                this.filmServis.ObrisiFilm(new Film()
                {
                    Id = (int)(this.kolekcijaCelija["Id"].Value)
                });
                MessageBox.Show("Uspesno brisanje.");
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
