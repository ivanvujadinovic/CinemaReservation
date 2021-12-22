namespace Bioskop.Domen
{
    public class Sala : IEntitet
    {
        public int Id { get; set; }
        public int BrojSale { get; set; }
        public int BrojSedista { get; set; }

        public Sala()
        {

        }

        public Sala(int id, int brojSale, int brojSedista)
        {
            this.Id = id;
            this.BrojSale = brojSale;
            this.BrojSedista = brojSedista;
        }

        public override string ToString()
        {
            return $"{this.Id} - {this.BrojSale}";
        }
    }
}
