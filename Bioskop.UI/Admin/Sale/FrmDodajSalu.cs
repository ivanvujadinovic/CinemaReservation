using Bioskop.Domen;
using Bioskop.Servisi.SalaServis;
using System;
using System.Windows.Forms;

namespace Bioskop.UI.Admin.Sale
{
    public partial class FrmDodajSalu : Form
    {
        private SalaServis salaServis;
        public FrmDodajSalu()
        {
            InitializeComponent();
            salaServis = new SalaServis();
        }

        private void btnDodajSalu_Click(object sender, EventArgs e)
        {
            int brojSale = 0;
            int brojSedista = 0;

            if (int.TryParse(this.txtBrojSale.Text, out brojSale) && int.TryParse(this.txtBrojSedista.Text, out brojSedista))
            {
                try
                {
                    this.salaServis.DodajSalu(new Sala() { BrojSale = brojSale, BrojSedista = brojSedista });
                    MessageBox.Show("Uspesno ste dodali salu.");
                    this.Close();                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nepravilno unete vrednosti za broj sale ili broj sedista.");
            }
        }
    }
}
