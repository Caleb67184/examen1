using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_CalebSilman.Examen1_CalebSilman
{
    internal class Vendedores
    {

        public Vendedores() { }

        //Dictionario con el codigo y nombre de vendedor disponible
        static Dictionary<string, string> LosVendedores = new Dictionary<string, string>() {

            {"1","Pedro" },
            {"2","Juan" }

            };
        
        //Metodo que muestra al usuario los vendedores disponibles
        public static void ListadoVendedores()
        {
            Console.WriteLine("Vendedores disponibles");
            foreach  (var item in LosVendedores)
            {
                Console.WriteLine(item);
            }
        }

        //El usuario manda el codigo y el metodo dice si existe un vendedor
        public static string CodigoVendedor(string value)
        {
            string result;
            if (LosVendedores.TryGetValue(value, out result)) 
            {
                Console.WriteLine("Nombre: "+result);
            }
            return value;
        }

        

    }
}
