using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasolinera_json
{
    internal class RecargarFuerzas
    {
       public string Gasolina { get; set; }
        public int Litro { get; set; }
        public RecargarFuerzas(string nombre, int nit, int litro)
        {
            Gasolina = nombre;
            Litro = litro;
        }
    }
}
