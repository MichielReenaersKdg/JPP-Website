using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
