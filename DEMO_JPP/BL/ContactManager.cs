using JPP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPP.DAL;

namespace JPP.BL
{
    public class ContactManager : IContactManager
    {
             //maak repo
        private readonly IContactRepository repo;

        public ContactManager()
        {

            repo = new JPP.DAL.EF.ContactRepository();
        }


        public IEnumerable<Contactpersoon> GetContactpersonen()
        {
            return repo.ReadContactpersonen();

        }
        public void RemoveContactpersoon(int id)
        {

            repo.DeleteContactpersoon(id);
        }
        public Contactpersoon GetContactpersoon(int id)
        {

            return repo.ReadContactpersoon(id);
        }

    }
}
