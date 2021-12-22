
namespace Bioskop.Util.Cache
{
    public class KorisnickaSesijaSinglton
    {
        private static KorisnickaSesija korisnickaSesija = null;

        public static KorisnickaSesija KorisnickaSesija
        {
            get
            {
                if (korisnickaSesija == null)
                {
                    korisnickaSesija = new KorisnickaSesija();
                }
                return korisnickaSesija;
            }
        }
    }
}
