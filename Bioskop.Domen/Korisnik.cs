using System;

namespace Bioskop.Domen
{
    public class Korisnik : IEntitet
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Telefon { get; set; }
        public Pol Pol { get; set; }
        public TipKorisnika TipKorisnika { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public bool DaLiJeRegistrovan { get; set; }
        public Korisnik()
        {

        }

        public Korisnik(int id, string ime, string prezime, DateTime datumRodjenja, string telefon, 
            Pol pol, TipKorisnika tipKorisnika, string korisnickoIme, string lozinka, bool daLiJeRegistrovan)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumRodjenja = datumRodjenja;
            this.Telefon = telefon;
            this.Pol = pol;
            this.TipKorisnika = tipKorisnika;
            this.KorisnickoIme = korisnickoIme;
            this.Lozinka = lozinka;
            this.DaLiJeRegistrovan = daLiJeRegistrovan;
        }
    }
}
