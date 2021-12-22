using Bioskop.DAL;
using Bioskop.Domen;
using System;
using System.Collections.Generic;

namespace Bioskop.Servisi.ProjekcijaServis
{
    public class ProjekcijaServis
    {
        private GlobalniFajlMenadzer<Projekcija> globalniFajlMenadzer;
        private string putanja = @"C:\Users\WINDOWS 10\source\repos\PrviProjekatTVP\Bioskop.Util\JsonFajlovi\ProjectionsJsonFile.json";
        private FilmServis.FilmServis filmServis;
        private SalaServis.SalaServis salaServis;
        public ProjekcijaServis()
        {
            globalniFajlMenadzer = new GlobalniFajlMenadzer<Projekcija>();
            this.filmServis = new FilmServis.FilmServis();
            this.salaServis = new SalaServis.SalaServis();
        }

        public List<Projekcija> VratiSveProjekcije()
        { 
            return this.globalniFajlMenadzer.Procitaj(this.putanja);
        }

        public void DodajProjekciju(Projekcija projekcija)
        {
            Film film = this.filmServis.VratiFilmPoId(projekcija.FilmId);
            projekcija.VremeProjekcije.PostaviKrajProjekcije(film.Trajanje);

            Sala sala = this.salaServis.VratiSaluPoId(projekcija.SalaId);
            projekcija.BrojSlobodnihMesta = sala.BrojSedista;

            this.ValidirajProjekciju(projekcija);
            this.globalniFajlMenadzer.Upisi(projekcija, this.putanja);
        }

        public void ObrisiProjekciju(Projekcija projekcija)
        {
            this.globalniFajlMenadzer.Obrisi(projekcija, putanja);
        }

        public void AzurirajProjekciju(Projekcija projekcija, bool ukljuciProveruZaSalu = true) //todo: namestiti da mogu da se azuriraju projekcije za koje ne postoje rezervacije
        {
            Film film = this.filmServis.VratiFilmPoId(projekcija.FilmId);
            projekcija.VremeProjekcije.PostaviKrajProjekcije(film.Trajanje);

            if (ukljuciProveruZaSalu)
            {
                Sala sala = this.salaServis.VratiSaluPoId(projekcija.SalaId);
                projekcija.BrojSlobodnihMesta = sala.BrojSedista;
            }

            this.ValidirajProjekciju(projekcija);
            this.globalniFajlMenadzer.Azuriraj(projekcija, putanja);
        }

        public List<string> VratiFiltriraneProjekcije(Filter filter)
        {
            if (filter.PocetniDatum < DateTime.Now.Date || filter.PocetniDatum > filter.KrajnjiDatum)
            {
                throw new ArgumentException("Izaberite validan pocetni i krajnji datum.");
            }
            List<string> filtriraneProjekcije = new List<string>();

            foreach(Projekcija projekcija in this.PopuniPodatkeOFilmu(this.VratiSveProjekcije()))
            {
                if ((projekcija.DatumProjekcije.Date >= filter.PocetniDatum &&
                    projekcija.DatumProjekcije.Date <= filter.KrajnjiDatum) &&
                    (filter.SalaId == 0 || projekcija.SalaId == filter.SalaId) &&
                    (filter.FilmId == 0 || projekcija.FilmId == filter.FilmId))
                {
                    filtriraneProjekcije.Add(projekcija.ToString());
                }
            }

            return filtriraneProjekcije;
        }

        public Projekcija VratiProjekcijuPoId(int id)
        {
            return this.globalniFajlMenadzer.DohvatiPoId(id, putanja);
        }
        private void ValidirajProjekciju(Projekcija projekcija)
        {
            if (projekcija.DatumProjekcije.Date < DateTime.Now.Date)
            {
                throw new ArgumentException("Datum projekcije ne moze biti u proslosti.");
            }

            List<Projekcija> projekcijeZaOdredjenuSaluPoDatumu = this.VratiProjekcijePoDatumuIIdSale(projekcija);
            foreach(var trenutnaProjekcija in projekcijeZaOdredjenuSaluPoDatumu)
            {
                if (!(projekcija.Id == trenutnaProjekcija.Id && projekcija.VremeProjekcije.PocetakProjekcije == trenutnaProjekcija.VremeProjekcije.PocetakProjekcije && projekcija.VremeProjekcije.KrajProjekcije == trenutnaProjekcija.VremeProjekcije.KrajProjekcije)
                    && (this.DaLiJeTerminIzmedjuVremenaProjekcije(projekcija.VremeProjekcije.PocetakProjekcije, trenutnaProjekcija.VremeProjekcije) 
                    || this.DaLiJeTerminIzmedjuVremenaProjekcije(projekcija.VremeProjekcije.KrajProjekcije, trenutnaProjekcija.VremeProjekcije)))
                {
                    throw new ArgumentException("U izabranom terminu vec postoji projekcija.");
                }
            }
        }

        private List<Projekcija> VratiProjekcijePoDatumuIIdSale(Projekcija projekcija)
        {
            List<Projekcija> projekcijeZaOdredjenuSaluPoDatumu = new List<Projekcija>();

            foreach (Projekcija trenutnaProjekcija in this.VratiSveProjekcije())
            {
                if (trenutnaProjekcija.SalaId == projekcija.SalaId && trenutnaProjekcija.DatumProjekcije.Date == projekcija.DatumProjekcije.Date)
                {
                    projekcijeZaOdredjenuSaluPoDatumu.Add(trenutnaProjekcija);
                }
            }

            return projekcijeZaOdredjenuSaluPoDatumu;
        }

        private bool DaLiJeTerminIzmedjuVremenaProjekcije(TimeSpan termin, VremeProjekcije vremeProjekcije)
        {
            return termin >= vremeProjekcije.PocetakProjekcije && termin <= vremeProjekcije.KrajProjekcije;
        }

        private List<Projekcija> PopuniPodatkeOFilmu(List<Projekcija> projekcije)
        {
            List<Projekcija> projekcijeSaPodatkomOFilmu = new List<Projekcija>();

            for (int i = 0; i < projekcije.Count; i++)
            {
                projekcije[i].Film = this.filmServis.VratiFilmPoId(projekcije[i].FilmId);
                projekcijeSaPodatkomOFilmu.Add(projekcije[i]);
            }

            return projekcijeSaPodatkomOFilmu;
        }
    }
}
