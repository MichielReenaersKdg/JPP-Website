using JPP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.DAL.EF
{
    public class ContactRepository : IContactRepository
    {
        private EFDbContext edc;

        public ContactRepository()
        {
            edc = new EFDbContext();

        }


        public IEnumerable<Contactpersoon> ReadContactpersonen()
        {
            IEnumerable<Contactpersoon> contactpersonen = edc.contactpersonen.ToList();
            return contactpersonen;
        }

        public Contactpersoon ReadContactpersoon(int id)
        {
            Contactpersoon contactpersoon = edc.contactpersonen.Find(id);

            return contactpersoon;
        }

        public void DeleteContactpersoon(int id)
        {
            Contactpersoon contactpersoon = edc.contactpersonen.Find(id);
            edc.contactpersonen.Remove(contactpersoon);
            edc.SaveChanges();
        }


    }
}
