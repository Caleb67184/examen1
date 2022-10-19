using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_CalebSilman.Examen1_CalebSilman
{
    internal class Vendedor1 : Ivendedor1
    {
        string nombre { get; set; }
        public Vendedor1(string nombre)
        {
            this.nombre = "Pedro";
        }
        public void VentasContado() { }

    }
}
