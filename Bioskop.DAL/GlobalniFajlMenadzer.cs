using Bioskop.Domen;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Bioskop.DAL
{
    public class GlobalniFajlMenadzer<T> where T : IEntitet
    {
        public GlobalniFajlMenadzer()
        {
        }

        public List<T> Procitaj(string putanja)
        {
            List<T> listaObjekti;
            using (StreamReader citac = new StreamReader(putanja))
            {
                string jsonString = citac.ReadToEnd();
                listaObjekti = JsonConvert.DeserializeObject<List<T>>(jsonString);
            }
            return listaObjekti;
        }

        public T DohvatiPoId(int id, string putanja)
        {
            List<T> listaObjekti = this.Procitaj(putanja);

            foreach (T objekat in listaObjekti)
            {
                if (objekat.Id == id)
                {
                    return objekat;
                }
            }

            throw new ArgumentException("Entitet sa trazenim id ne postoji u bazi.");
        }

        public void Upisi(T objekat, string putanja)
        {
            List<T> postojeciObjekti = this.Procitaj(putanja);
            int maxId = 1;
            if (postojeciObjekti == null)
            {
                postojeciObjekti = new List<T>();
            }
            else
            {
                maxId = this.VratiNajveciId(postojeciObjekti) + 1;
            }

            objekat.Id = maxId;
            postojeciObjekti.Add(objekat);

            this.UpisiListu(postojeciObjekti, putanja);
        }

        private void UpisiListu(List<T> objekti, string putanja)
        {
            string jsonString = JsonConvert.SerializeObject(objekti);
            using (StreamWriter upis = new StreamWriter(putanja))
            {
                upis.Write(jsonString);
            }
        }

        private int VratiNajveciId(List<T> postojeciObjekti)
        {
            int maximalniId = postojeciObjekti[0].Id;

            foreach (T objekat in postojeciObjekti)
            {
                if (maximalniId < objekat.Id)
                {
                    maximalniId = objekat.Id;
                }
            }

            return maximalniId;
        }

        public void Azuriraj(T objekat, string putanja)
        {
            List<T> postojeciObjekti = this.Procitaj(putanja);
            List<T> azuriraniObjekti = new List<T>();

            foreach (T trenutniObjekat in postojeciObjekti)
            {
                if (objekat.Id == trenutniObjekat.Id)
                {
                    azuriraniObjekti.Add(objekat);
                }
                else
                {
                    azuriraniObjekti.Add(trenutniObjekat);
                }
            }

            this.UpisiListu(azuriraniObjekti, putanja);
        }

        public void Obrisi(T objekat, string putanja)
        {
            List<T> postojeciObjekti = this.Procitaj(putanja);
            int index = 0;
            bool daLiJeObrisan = false;
            foreach (T trenutniObjekat in postojeciObjekti.ToList())
            {
                if (objekat.Id == trenutniObjekat.Id)
                {
                    postojeciObjekti.RemoveAt(index);
                    daLiJeObrisan = true;
                    break;
                }
                index++;
            }

            if (!daLiJeObrisan)
            {
                throw new InvalidOperationException("Brisanje nije uspelo, entitet sa zadatim id ne postoji u bazi.");
            }
            this.UpisiListu(postojeciObjekti, putanja);
        }
    }
}
