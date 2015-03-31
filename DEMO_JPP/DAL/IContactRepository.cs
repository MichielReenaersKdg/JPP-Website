using JPP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.DAL
{
    public interface IContactRepository
    {

        IEnumerable<Contactpersoon> ReadContactpersonen();
        Contactpersoon ReadContactpersoon(int id);
        void DeleteContactpersoon(int id);
    }
}
