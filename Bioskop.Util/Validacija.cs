using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioskop.Util
{
    public static class Validacija
    {
        public static bool DaLiStringSadrziBroj(string rec)
        {
            for (int i = 0; i < rec.Length; i++)
            {
                if (Char.IsDigit(rec[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool DaLiJeTelefonIspravan(string broj)
        {
            int brojPluseva = 0;
            for (int i = 0; i < broj.Length; i++)
            {
                if (!Char.IsDigit(broj[i]))
                {
                    if (broj[i]=='+' && brojPluseva == 0)
                    {
                        brojPluseva++;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
