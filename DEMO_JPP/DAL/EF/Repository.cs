using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPP.Domain;

namespace JPP.DAL.EF
{
    public class Repository : IAdminRespository
    {

        private EFDbContext edc;

        public Repository()
        {
            edc = new EFDbContext();

        }


        public IEnumerable<Recensie> ReadRecensies()
        {

            IEnumerable<Recensie> recensies = edc.recensies.ToList();
            return recensies;
        }
        public IEnumerable<Bericht> ReadBerichten()
        {

            IEnumerable<Bericht> berichten = edc.berichten.ToList();
            return berichten;

        }

        public Bericht ReadBericht(int id)
        {
            Bericht bericht = edc.berichten.Find(id);
            if (bericht.ipAddress == null)
            {
                bericht.ipAddress = "Niet beschikbaar";
            }
            return bericht;

        }
        public Recensie ReadRecensie(int id)
        {
            Recensie recensie = edc.recensies.Find(id);
            if (recensie.ipAddress == null)
            {
                recensie.ipAddress = "Niet beschikbaar";
            }
            return recensie;
        }

        public void UpdateRecensie(Recensie recensie)
        {
            edc.Entry(recensie).State = System.Data.Entity.EntityState.Modified;
            edc.SaveChanges();
        }
        public void DeleteRecensie(int id)
        {
            Recensie recensie = edc.recensies.Find(id);
            edc.recensies.Remove(recensie);
            edc.SaveChanges();
        }
        public void DeleteBericht(int id)
        {
            Bericht bericht = edc.berichten.Find(id);
            edc.berichten.Remove(bericht);
            edc.SaveChanges();

        }


    }
}
