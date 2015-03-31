using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPP.Domain;
using JPP.DAL;
namespace JPP.BL
{
    public class AdminManager : IAdminManager
    {
        //maak repo
        private readonly IAdminRespository repo;

        public AdminManager()
        {

            repo = new JPP.DAL.EF.Repository();
        }

        public IEnumerable<Recensie> GetRecensies()
        {

            return repo.ReadRecensies();
        }
        public IEnumerable<Bericht> GetBerichten()
        {
            return repo.ReadBerichten();
        }

        public Bericht GetBericht(int id)
        {

            return repo.ReadBericht(id);
        }
        public Recensie GetRecensie(int id)
        {
            return repo.ReadRecensie(id);
        }

        public void ChangeRecensie(Recensie recensie)
        {
            repo.UpdateRecensie(recensie);
        }
        public void RemoveRecensie(int id)
        {
            repo.DeleteRecensie(id);
        }
        public void RemoveBericht(int id)
        {
            repo.DeleteBericht(id);
        }
    }
}
