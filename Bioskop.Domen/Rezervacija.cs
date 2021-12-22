namespace Bioskop.Domen
{
    public class Rezervacija : IEntitet
    {
        public int Id { get; set; }
        public int IdKorisnika { get; set; }
        public int IdSale { get; set; }
        public int BrojSedista { get; set; }
        public decimal UkupnaCena { get; set; }
        public int IdProjekcija { get; set; }

        public Rezervacija()
        {

        }

        public Rezervacija(int id, int customerId, int movieTheaterId, int numberOfSeat, decimal totalPrice)
        {
            this.Id = id;
            this.IdKorisnika = customerId;
            this.IdSale = movieTheaterId;
            this.BrojSedista = numberOfSeat;
            this.UkupnaCena = totalPrice;
        }
    }
}
