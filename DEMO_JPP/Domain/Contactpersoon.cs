using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.Domain
{
    public class Contactpersoon
    {
        public int id { get; set; }
        public string naam { get; set; }
        public string straat { get; set; }
        public string gemeente { get; set; }
        public string email { get; set; }
        public string telefoonNr { get; set; }
        public string ipAddress { get; set; }


    }
}
