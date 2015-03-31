using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPP.Domain;

namespace JPP.DAL
{
    public interface IAdminRespository
    {

        IEnumerable<Recensie> ReadRecensies();
        IEnumerable<Bericht> ReadBerichten();
		Bericht ReadBericht(int id);
		Recensie ReadRecensie(int id);
		void UpdateRecensie(Recensie recensie);
        void DeleteRecensie(int id);
        void DeleteBericht(int id);
        
    }
}
