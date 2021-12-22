using Bioskop.DAL;
using Bioskop.Domen;
using Bioskop.Util.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioskop.Servisi.RezervacijaServis
{
    public class RezervacijaServis
    {
        private GlobalniFajlMenadzer<Rezervacija> globalniFajlMenadzer;
        private string putanja = @"C:\Users\WINDOWS 10\source\repos\PrviProjekatTVP\Bioskop.Util\JsonFajlovi\ReservationsJsonFile.json";
        private ProjekcijaServis.ProjekcijaServis projekcijaServis;

        public RezervacijaServis()
        {
            globalniFajlMenadzer = new GlobalniFajlMenadzer<Rezervacija>();
            projekcijaServis = new ProjekcijaServis.ProjekcijaServis();
        }

        public void DodajRezervaciju(Rezervacija rezervacija)
        {
            if (rezervacija.BrojSedista <= 0)
            {
                throw new ArgumentException("Rezervacija mora sadrzati makar 1 kupljenu kartu.");
            }

            Projekcija projekcija = this.projekcijaServis.VratiProjekcijuPoId(rezervacija.IdProjekcija);
            if (projekcija.BrojSlobodnihMesta < rezervacija.BrojSedista)
            {
                throw new ArgumentException("Nema dovoljno slobodnih mesta.");
            }
            projekcija.BrojSlobodnihMesta = projekcija.BrojSlobodnihMesta - rezervacija.BrojSedista;
            this.projekcijaServis.AzurirajProjekciju(projekcija, false);

            this.globalniFajlMenadzer.Upisi(rezervacija, putanja);
        }

        public List<Rezervacija> VratiSveRezervacije()
        {
            return this.globalniFajlMenadzer.Procitaj(putanja);
        }
        public List<Rezervacija> VratiSveRezervacijePoId()
        {
            List<Rezervacija> sveRezervacije = this.VratiSveRezervacije();
            List<Rezervacija> listaZaUpis = new List<Rezervacija>();

            foreach (Rezervacija trenutnaRezervacija in sveRezervacije)
            {
                if (trenutnaRezervacija.IdKorisnika == KorisnickaSesijaSinglton.KorisnickaSesija.UlogovaniKorisnik.Id)
                {
                    listaZaUpis.Add(trenutnaRezervacija);
                }
            }

            return listaZaUpis;
        }

        public void ObrisiRezervaciju(Rezervacija rezervacija)
        {
            Projekcija projekcija = this.projekcijaServis.VratiProjekcijuPoId(rezervacija.IdProjekcija);
            projekcija.BrojSlobodnihMesta = projekcija.BrojSlobodnihMesta + rezervacija.BrojSedista;
            this.projekcijaServis.AzurirajProjekciju(projekcija, false);
            this.globalniFajlMenadzer.Obrisi(rezervacija, putanja);
        }
    }
}
