using JPP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.BL
{
    interface IContactManager
    {
        IEnumerable<Contactpersoon> GetContactpersonen();
        void RemoveContactpersoon(int id);
        Contactpersoon GetContactpersoon(int id);
    }
}
