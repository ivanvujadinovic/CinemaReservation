using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioskop.Domen
{
    public class Filter
    {
        public DateTime PocetniDatum { get; set; }
        public DateTime KrajnjiDatum { get; set; }
        public int SalaId { get; set; }
        public int FilmId { get; set; }
    }
}
