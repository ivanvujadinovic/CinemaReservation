using System;

namespace Bioskop.Domen
{
    public class Projekcija : IEntitet
    {
        public int Id { get; set; }
        public DateTime DatumProjekcije { get; set; }
        public int SalaId { get; set; }
        public int BrojSlobodnihMesta { get; set; }
        public float CenaKarta { get; set; }
        public VremeProjekcije VremeProjekcije { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; }

        public Projekcija()
        {

        }

        public Projekcija(int id, DateTime datumProjekcije, int salaId, float cenaKarte, VremeProjekcije vremeProjekcije, int filmId)
        {
            this.Id = id;
            this.DatumProjekcije = datumProjekcije;
            this.SalaId = salaId;
            this.CenaKarta = cenaKarte;
            this.VremeProjekcije = vremeProjekcije;
            this.FilmId = filmId;
        }

        public override string ToString()
        {
            return $"{this.Id}, \"{Film.Naziv}\" {Film.Trajanje}, Cena Karte: {CenaKarta}, Datum i vreme: " +
                $"{DatumProjekcije.ToShortDateString()} - {VremeProjekcije.PocetakProjekcije}, " +
                $"Sala: {SalaId}, Broj dostupnih sedista: {BrojSlobodnihMesta}";
        }
    }
}
