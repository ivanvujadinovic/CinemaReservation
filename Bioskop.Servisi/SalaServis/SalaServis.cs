using Bioskop.DAL;
using Bioskop.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioskop.Servisi.SalaServis
{
    public class SalaServis
    {
        private GlobalniFajlMenadzer<Sala> salaFajlMenadzer;
        private string putanja = @"C:\Users\WINDOWS 10\source\repos\PrviProjekatTVP\Bioskop.Util\JsonFajlovi\MovieTheatersJsonFile.json";

        public SalaServis()
        {
            this.salaFajlMenadzer = new GlobalniFajlMenadzer<Sala>();
        }

        public List<Sala> VratiSveSale()
        {
            return this.salaFajlMenadzer.Procitaj(putanja);
        }

        public Sala VratiSaluPoId(int id)
        {
            return this.salaFajlMenadzer.DohvatiPoId(id, putanja);
        }

        public void DodajSalu(Sala sala)
        {
            this.ValidirajSalu(sala);
            this.salaFajlMenadzer.Upisi(sala, putanja);
        }

        public void ObrisiSalu(Sala sala)
        {
            this.salaFajlMenadzer.Obrisi(sala, putanja);
        }

        public void AzurirajSalu(Sala sala)
        {
            this.ValidirajSalu(sala);
            this.salaFajlMenadzer.Azuriraj(sala, putanja);
        }

        public List<string> VratiSaleUFormatuZaIspis()
        {
            List<string> saleUFormatuZaIspis = new List<string>();

            foreach (Sala sala in this.VratiSveSale())
            {
                saleUFormatuZaIspis.Add(sala.ToString());
            }

            return saleUFormatuZaIspis;
        }
        private void ValidirajSalu(Sala sala)
        {
            string porukaOGresci = "";
            if (sala.BrojSale <=0)
            {
                porukaOGresci += "Sala mora da ima broj.";
            }

            if (sala.BrojSedista <=20)
            {
                porukaOGresci += "Sala mora da ime preko 20 sedista.";
            }

            if (!this.DaLiJeBrojSaleJedinstven(sala.BrojSale))
            {
                porukaOGresci += "Broj sale nije jedisntven";
            }

            if (!string.IsNullOrEmpty(porukaOGresci))
            {
                throw new ArgumentException(porukaOGresci);
            }
        }

        private bool DaLiJeBrojSaleJedinstven(int brojSale)
        {
            List<Sala> sveSale = this.VratiSveSale();

            foreach (Sala sale in sveSale)
            {
                if (sale.BrojSale == brojSale)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
