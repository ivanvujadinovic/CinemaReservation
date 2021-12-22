using Bioskop.DAL;
using Bioskop.Domen;
using System;
using System.Collections.Generic;

namespace Bioskop.Servisi.FilmServis
{
    public class FilmServis
    {
        private string putanja = @"C:\Users\WINDOWS 10\source\repos\PrviProjekatTVP\Bioskop.Util\JsonFajlovi\MoviesJsonFile.json";
        private GlobalniFajlMenadzer<Film> filmFajlMenadzer;

        public FilmServis()
        {
            this.filmFajlMenadzer = new GlobalniFajlMenadzer<Film>();
        }

        public void DodajFilm(Film film) 
        {
            this.ValidirajFilm(film);
            this.filmFajlMenadzer.Upisi(film, putanja);
        }

        public List<Film> VratiSveFilmove()
        {
            return this.filmFajlMenadzer.Procitaj(putanja);
        }

        public Film VratiFilmPoId(int id)
        {
            return this.filmFajlMenadzer.DohvatiPoId(id, putanja);
        }

        public void AzurirajFilm(Film film)
        {
            this.ValidirajFilm(film);
            this.filmFajlMenadzer.Azuriraj(film, putanja);
        }

        public void ObrisiFilm(Film film)
        {
            this.filmFajlMenadzer.Obrisi(film, putanja);
        }

        public List<string> VratiFilmoveUFormatuZaIspis()
        {
            List<string> filmoviUFormatuZaIspis = new List<string>();

            foreach (Film film in this.VratiSveFilmove())
            {
                filmoviUFormatuZaIspis.Add(film.ToString());
            }

            return filmoviUFormatuZaIspis;
        }

        public List<string> VratiNaziveFilmova()
        {
            List<string> filmovi = new List<string>();

            foreach (Film film in this.VratiSveFilmove())
            {
                filmovi.Add($"{film.Id} - {film.Naziv}");
            }

            return filmovi;
        }
        private void ValidirajFilm(Film film)
        {
            string porukaOGresci = "";
            if (string.IsNullOrEmpty(film.Naziv))
            {
                porukaOGresci += "Unesite ime filma.";
            }

            if (film.Zanr.ToString() == "-1")
            {
                porukaOGresci += "Unesite zanr filma.";
            }

            if (film.Trajanje <= 0)
            {
                porukaOGresci += "Film mora da ima trajanje.";
            }

            if (!string.IsNullOrEmpty(porukaOGresci))
            {
                throw new ArgumentException(porukaOGresci);
            }
        }
    }
}
