namespace Bioskop.Domen
{
    public class Film : IEntitet
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public Zanr Zanr { get; set; }
        public float Trajanje { get; set; }
        public int StarosnaGranica { get; set; }

        public Film()
        {

        }

        public Film(int id, string naziv, Zanr zanr, float trajanje, int starosnaGranica)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Zanr = zanr;
            this.Trajanje = trajanje;
            this.StarosnaGranica = starosnaGranica;
        }

        public override string ToString()
        {
            return $"{this.Id} - {this.Naziv}";
        }
    }
}
