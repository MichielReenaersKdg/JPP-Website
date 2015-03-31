using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.Domain
{
    public class Recensie
    {
        public int id { get; set; }
        public string naam { get; set; }
        public string titel { get; set; }
        public string tekst { get; set; }
        public DateTime datumPost { get; set; }
        public int rating { get; set; }
        public string gemeente { get; set; }
        public int status { get; set; }
        public string ipAddress { get; set; }

    }
}
