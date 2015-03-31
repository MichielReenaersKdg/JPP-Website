using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.Domain
{
    public class Bericht
    {
        public int id { get; set; }
        public string naam { get; set; }
        public string onderwerp { get; set; }
        public string email { get; set; }
        public string telefoonNr { get; set; }
        public string inhoud { get; set; }
        public DateTime datumVerzending { get; set; }
        public string ipAddress { get; set; }

    }
}
