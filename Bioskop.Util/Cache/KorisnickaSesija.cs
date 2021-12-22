using Bioskop.Domen;

namespace Bioskop.Util.Cache
{
    public class KorisnickaSesija
    {
        private Korisnik ulogovaniKorisnik;

        public Korisnik UlogovaniKorisnik { get => this.ulogovaniKorisnik; }

        public KorisnickaSesija()
        {
            this.ulogovaniKorisnik = null;
        }

        public void UlogujKorisnika(Korisnik korisnik)
        {
            this.ulogovaniKorisnik = korisnik;
        }

        public void IzlogujKorisnika()
        {
            this.ulogovaniKorisnik = null; 
        }

        public bool DaLiPostojiUlogovaniKorisnik()
        {
            return this.ulogovaniKorisnik != null;
        }
    }
}
