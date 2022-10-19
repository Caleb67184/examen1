using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_CalebSilman.Examen1_CalebSilman
{
    internal class Vendedor2 : Ivendedor2
    {
        string nombre { get; set; } 
        public Vendedor2(string nombre)
        {
            this.nombre = "Juan";
        }

        public string VentasCredito()
        {
            string mensaje = "Venta hecha";
            return mensaje;
        }

    }
}
