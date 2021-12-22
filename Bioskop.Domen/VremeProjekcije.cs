
using System;

namespace Bioskop.Domen
{
    public class VremeProjekcije
    {
        public TimeSpan PocetakProjekcije { get; set; }
        public TimeSpan KrajProjekcije { get; set; }

        public VremeProjekcije()
        {

        }

        public void PostaviKrajProjekcije(float vremeTrajanja)
        {
            int ostatakMinuta = (int)vremeTrajanja % 60;
            int produzetakProjekcije = (int)Math.Floor(vremeTrajanja / 60);

            if (ostatakMinuta <= 15)
            {
                this.KrajProjekcije = new TimeSpan((this.PocetakProjekcije.Hours + produzetakProjekcije), this.PocetakProjekcije.Minutes +  30, 0);
            }
            else if (ostatakMinuta <= 40)
            {
                this.KrajProjekcije = new TimeSpan((this.PocetakProjekcije.Hours + produzetakProjekcije) + 1, this.PocetakProjekcije.Minutes, 0);
            }
            else
            {
                this.KrajProjekcije = new TimeSpan((this.PocetakProjekcije.Hours + produzetakProjekcije) + 1, this.PocetakProjekcije.Minutes + 30, 0);
            }
        }
    }
}
