using Bioskop.DAL;
using Bioskop.Domen;
using Bioskop.Util;
using Bioskop.Util.Cache;
using System;
using System.Collections.Generic;

namespace Bioskop.Servisi.KorisnikServis
{
    public class KorisnikServis
    {
        private string putanja = @"C:\Users\WINDOWS 10\source\repos\PrviProjekatTVP\Bioskop.Util\JsonFajlovi\Korisnici.json";
        private GlobalniFajlMenadzer<Korisnik> korisnikFajlMenadzer;

        public KorisnikServis()
        {
            this.korisnikFajlMenadzer = new GlobalniFajlMenadzer<Korisnik>();
        }

        public void UlogujKorisnika(string korisnickoIme, string lozinka)
        {
            if (string.IsNullOrEmpty(korisnickoIme))
            {
                throw new ArgumentException("Unesite korisnicko ime.");
            }
            if (string.IsNullOrEmpty(lozinka))
            {
                throw new ArgumentException("Unesite lozinku.");
            }

            List<Korisnik> korisnici = this.korisnikFajlMenadzer.Procitaj(putanja);

            foreach (Korisnik korisnik in korisnici)
            {
                if (korisnik.KorisnickoIme == korisnickoIme && korisnik.Lozinka == lozinka)
                {
                    KorisnickaSesijaSinglton.KorisnickaSesija.UlogujKorisnika(korisnik);
                }
            }

            if (!KorisnickaSesijaSinglton.KorisnickaSesija.DaLiPostojiUlogovaniKorisnik())
            {
                throw new ArgumentException("Trazeni korisnik ne postoji u sistemu.");
            }

            if (!KorisnickaSesijaSinglton.KorisnickaSesija.UlogovaniKorisnik.DaLiJeRegistrovan)
            {
                KorisnickaSesijaSinglton.KorisnickaSesija.IzlogujKorisnika();
                throw new InvalidOperationException("Korisnik nije registrovan. Sacekajte da admin potvrdi vasu registaciju.");
            }
        }

        public void RegistrujKorisnika(Korisnik korisnik)
        {
            korisnik.TipKorisnika = TipKorisnika.Kupac;
            korisnik.DaLiJeRegistrovan = false;
            this.korisnikFajlMenadzer.Upisi(korisnik, this.putanja);
        }

        public List<Korisnik> VratiSveKorisnike()
        {
            return this.korisnikFajlMenadzer.Procitaj(this.putanja);
        }

        public List<Korisnik> VratiRegistoraneKorisnike()
        {
            List<Korisnik> sviKorisnici = this.VratiSveKorisnike();
            List<Korisnik> registrovaniKorisnici = new List<Korisnik>();

            foreach (Korisnik korisnik in sviKorisnici)
            {
                if (korisnik.DaLiJeRegistrovan)
                {
                    registrovaniKorisnici.Add(korisnik);
                }
            }

            return registrovaniKorisnici;
        }

        public List<Korisnik> VratiNeregistovaneKorisnike()
        {
            List<Korisnik> sviKorisnici = this.VratiSveKorisnike();
            List<Korisnik> neregistrovaniKorisnici = new List<Korisnik>();

            foreach (Korisnik korisnik in sviKorisnici)
            {
                if (!korisnik.DaLiJeRegistrovan)
                {
                    neregistrovaniKorisnici.Add(korisnik);
                }
            }

            return neregistrovaniKorisnici;
        }

        public void AzurirajKorisnika(Korisnik korisnik)
        {
            string porukaOGresci = "";

            if (Validacija.DaLiStringSadrziBroj(korisnik.Ime))
            {
                porukaOGresci += "Ime ne moze da sadrzi broj." + Environment.NewLine;
            }

            if (Validacija.DaLiStringSadrziBroj(korisnik.Prezime))
            {
                porukaOGresci += "Prezime ne moze da sadrzi broj." + Environment.NewLine;
            }

            if (!Validacija.DaLiJeTelefonIspravan(korisnik.Telefon))
            {
                porukaOGresci += "Unesite ispravan telefon." + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(korisnik.Ime))
            {
                porukaOGresci += "Unesite ime." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(korisnik.Prezime))
            {
                porukaOGresci += "Unesite prezime." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(korisnik.Telefon))
            {
                porukaOGresci += "Unesite telefon." + Environment.NewLine;
            }
            if (korisnik.Pol.ToString() == "-1")
            {
                porukaOGresci += "Unesite pol." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(korisnik.KorisnickoIme))
            {
                porukaOGresci += "Unesite korisnicko ime." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(korisnik.Lozinka))
            {
                porukaOGresci += "Unesite lozinku." + Environment.NewLine;
            }
            if (korisnik.TipKorisnika.ToString() == "-1")
            {
                porukaOGresci += "Unesite tip korisnika." + Environment.NewLine;
            }

            if (!string.IsNullOrEmpty(porukaOGresci))
            {
                throw new ArgumentException(porukaOGresci);
            }

            this.korisnikFajlMenadzer.Azuriraj(korisnik, this.putanja);
        }

        public void ObrisiKorisnika(Korisnik korisnik)
        {
            this.korisnikFajlMenadzer.Obrisi(korisnik, this.putanja);
        }
    }
}
