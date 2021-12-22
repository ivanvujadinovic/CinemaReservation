using Bioskop.Domen;
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

namespace Bioskop.UI.Admin.Sale
{
    public partial class FrmAzurirajSalu : Form
    {
        private SalaServis salaServis;
        private DataGridViewCellCollection kolekcijaCelija;
        public FrmAzurirajSalu()
        {
            InitializeComponent();
            salaServis = new SalaServis();
        }

        public FrmAzurirajSalu(DataGridViewCellCollection kolekcijaCelija) : this()
        {
            this.kolekcijaCelija = kolekcijaCelija;
        }

        private void btnObrisiSalu_Click(object sender, EventArgs e)
        {
            try
            {
                this.salaServis.ObrisiSalu(new Sala() { Id = (int)(this.kolekcijaCelija["Id"].Value) });
                MessageBox.Show("Uspesno ste obrisali salu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmAzurirajSalu_Load(object sender, EventArgs e)
        {
            txtBrojSale.Text = this.kolekcijaCelija["BrojSale"].Value.ToString();
            txtBrojSedista.Text = this.kolekcijaCelija["BrojSedista"].Value.ToString();
        }

        private void btnAzurirajSalu_Click(object sender, EventArgs e)
        {
            int brojSale = 0;
            int brojSedista = 0;

            if (int.TryParse(txtBrojSale.Text, out brojSale) && int.TryParse(txtBrojSedista.Text, out brojSedista))
            {
                try
                {
                    this.salaServis.AzurirajSalu(new Sala()
                    {
                        Id = (int)(this.kolekcijaCelija["Id"].Value),
                        BrojSale = brojSale,
                        BrojSedista = brojSedista
                    });
                    MessageBox.Show("Azuriranje sale je uspelo");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Napravilno unete vrednosti za broj sale ili sedista.");
            }
        }
    }
}
