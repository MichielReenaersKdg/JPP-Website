using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPP.Domain;

namespace JPP.BL
{
    public interface IAdminManager
    {
        IEnumerable<Recensie> GetRecensies();
        IEnumerable<Bericht> GetBerichten();

        Bericht GetBericht(int id);
        Recensie GetRecensie(int id);
        void ChangeRecensie(Recensie recensie);
        void RemoveRecensie(int id);
        void RemoveBericht(int id);
    }
}
