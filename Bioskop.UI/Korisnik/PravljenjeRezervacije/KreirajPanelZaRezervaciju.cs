using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Bioskop.UI.Admin;
using Bioskop.Servisi.SalaServis;
using Bioskop.Servisi.FilmServis;
using Bioskop.Domen;
using Bioskop.Servisi.ProjekcijaServis;
using Bioskop.Servisi.RezervacijaServis;
using Bioskop.Util.Cache;

namespace Bioskop.UI.Korisnik.PravljenjeRezervacije
{
    public class KreirajPanelZaRezervaciju
    {
        private Panel panel;
        private Label[] labele;
        private DateTimePicker[] dateTimePickeri;
        private ComboBox[] comboBoxevi;
        private Button[] dugmad;
        private ListBox listBox;
        private TextBox textBox;
        private NumericUpDown numericUpDown;
        private SalaServis salaServis;
        private FilmServis filmSerivs;
        private ProjekcijaServis projekcijaServis;
        private RezervacijaServis rezervacijaServis;
        private static float globalnaCenaKarte;

        public KreirajPanelZaRezervaciju(Panel panel)
        {
            this.panel = panel;
            this.labele = new Label[9];
            this.dateTimePickeri = new DateTimePicker[2];
            this.comboBoxevi = new ComboBox[2];
            this.dugmad = new Button[2];
            this.listBox = new ListBox();
            this.textBox = new TextBox();
            this.numericUpDown = new NumericUpDown();
            filmSerivs = new FilmServis();
            salaServis = new SalaServis();
            rezervacijaServis = new RezervacijaServis();
            projekcijaServis = new ProjekcijaServis();
            this.OcistiPanel();
            this.PostaviKomponente();
            FrmAdminPocetnaStrana.PostaviHoverZaDugmad(panel);
        }

        private void PostaviKomponente()
        {
            
            for (int i = 0; i < labele.Length; i++)
            {
                labele[i] = new Label();
                this.panel.Controls.Add(this.labele[i]);
            }

            labele[0].Text = "Rezervacije projekcija";
            labele[0].Location = new Point(215, 5);
            labele[0].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            labele[0].AutoSize = true;

            labele[1].Text = "Filteri: ";
            labele[1].Location = new Point(10, 70);
            labele[1].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            labele[2].Text = "Pocetni datum: ";
            labele[2].Location = new Point(10, 95);
            labele[2].Font = new Font("Microsoft Sans Serif", 10);
            labele[2].AutoSize = true;

            labele[3].Text = "Krajnji datum: ";
            labele[3].Location = new Point(180, 95);
            labele[3].Font = new Font("Microsoft Sans Serif", 10);
            labele[3].AutoSize = true;

            labele[4].Text = "Sala: ";
            labele[4].Location = new Point(350, 95);
            labele[4].Font = new Font("Microsoft Sans Serif", 10);
            labele[4].AutoSize = true;

            labele[5].Text = "Naziv: ";
            labele[5].Location = new Point(520, 95);
            labele[5].Font = new Font("Microsoft Sans Serif", 10);
            labele[5].AutoSize = true;

            for (int i = 0; i < dateTimePickeri.Length; i++)
            {
                dateTimePickeri[i] = new DateTimePicker();
                this.panel.Controls.Add(dateTimePickeri[i]);
            }

            dateTimePickeri[0].Location = new Point(10, 115);
            dateTimePickeri[0].Width = 135;
            dateTimePickeri[0].Format = DateTimePickerFormat.Short;

            dateTimePickeri[1].Location = new Point(180, 115);
            dateTimePickeri[1].Width = 135;
            dateTimePickeri[1].Format = DateTimePickerFormat.Short;

            for (int i = 0; i < comboBoxevi.Length; i++)
            {
                this.comboBoxevi[i] = new ComboBox();
                this.comboBoxevi[i].DropDownStyle = ComboBoxStyle.DropDownList;
                this.panel.Controls.Add(comboBoxevi[i]);
            }

            comboBoxevi[0].Location = new Point(350, 115);
            List<string> sale = new List<string>() { "" };
            sale.AddRange(this.salaServis.VratiSaleUFormatuZaIspis());
            comboBoxevi[0].DataSource = sale;

            comboBoxevi[1].Location = new Point(520, 115);
            List<string> filmovi = new List<string>() { "" };
            filmovi.AddRange(this.filmSerivs.VratiNaziveFilmova());
            comboBoxevi[1].DataSource = filmovi;

            for (int i = 0; i < dugmad.Length; i++)
            {
                this.dugmad[i] = new Button();
                this.panel.Controls.Add(dugmad[i]);
            }

            dugmad[0].Location = new Point(10, 150);
            dugmad[0].Name = "btnPrikaziDosuptneProjekcije";
            dugmad[0].Text = "Prikazi dostupne projekcije";
            dugmad[0].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            dugmad[0].Width = this.panel.Width - 25;
            dugmad[0].Height = 40;
            dugmad[0].BackColor = Color.FromArgb(192, 255, 192);
            dugmad[0].Click += btnPrikaziDosuptneProjekcije_Click;

            labele[6].Text = "Repertoar bioskopa: ";
            labele[6].Location = new Point(10, 200);
            labele[6].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            labele[6].AutoSize = true;

            listBox = new ListBox();
            panel.Controls.Add(listBox);
            listBox.Location = new Point(10, 225);
            listBox.Width = this.panel.Width - 25;
            listBox.Height = 170;
            listBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;

            labele[7].Text = "Broj mesta: ";
            labele[7].Location = new Point(10, 390);
            labele[7].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            labele[7].AutoSize = true;

            labele[8].Text = "Ukupna cena: ";
            labele[8].Location = new Point(180, 390);
            labele[8].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            labele[8].AutoSize = true;

            numericUpDown = new NumericUpDown();
            panel.Controls.Add(numericUpDown);
            numericUpDown.Location = new Point(10, 415);
            numericUpDown.ValueChanged += NumericUpDown_ValueChanged;

            textBox = new TextBox();
            panel.Controls.Add(textBox);
            textBox.Location = new Point(180, 415);
            textBox.Width = 130;
            textBox.ReadOnly = true;

            dugmad[1].Name = "btnRezervisi";
            dugmad[1].Text = "Rezervisi";
            dugmad[1].Location = new Point(320, 390);
            dugmad[1].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            dugmad[1].Width = this.panel.Width - 335;
            dugmad[1].Height = 45;
            dugmad[1].BackColor = Color.FromArgb(192, 255, 192);
            dugmad[1].Click += btnRezervisi_Click;
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            try
            {
                this.rezervacijaServis.DodajRezervaciju(new Rezervacija()
                {
                    UkupnaCena = decimal.Parse(textBox.Text),
                    BrojSedista = (int)this.numericUpDown.Value,
                    IdSale = int.Parse(listBox.Text.Split(',')[4].Split(':')[1].Trim()),
                    IdKorisnika = KorisnickaSesijaSinglton.KorisnickaSesija.UlogovaniKorisnik.Id,
                    IdProjekcija = int.Parse(listBox.Text.Split(',')[0].Trim()),
                });
                MessageBox.Show("Uspesna rezervacija.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int brojKarata = (int)this.numericUpDown.Value;
            float cenKarte = globalnaCenaKarte;
            float suma = brojKarata * cenKarte;
            textBox.Text = suma.ToString();
        }

        private void btnPrikaziDosuptneProjekcije_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter()
            {
                PocetniDatum = dateTimePickeri[0].Value.Date,
                KrajnjiDatum = dateTimePickeri[1].Value.Date,
                SalaId = this.VratiIdIzFormataZaIspis(comboBoxevi[0].Text),
                FilmId = this.VratiIdIzFormataZaIspis(comboBoxevi[1].Text)
            };
            listBox.DataSource = null;
            try
            {
                listBox.DataSource = this.projekcijaServis.VratiFiltriraneProjekcije(filter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.numericUpDown.Value = 1;
            var item = (sender as ListBox);
            if (!string.IsNullOrEmpty(item.Text))
            {
                textBox.Text = item.Text.Split(',')[2].Split(':')[1].Trim();
                globalnaCenaKarte = float.Parse(textBox.Text);
            }
        }
        private void OcistiPanel()
        {
            this.panel.Controls.Clear();
        }

        private int VratiIdIzFormataZaIspis(string formatZaIspis)
        {
            if (string.IsNullOrEmpty(formatZaIspis))
            {
                return 0;
            }
            return int.Parse(formatZaIspis.Split(' ')[0]);
        }
    }
}
