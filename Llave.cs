using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasolinera_json
{
    internal class Llave
    {
        public string Name { get; set; }
        public string Nit { get; set; }

        public Llave(string name, string nit) { 
        
        Name = name;
        Nit = nit;
        
        }

    }
}
