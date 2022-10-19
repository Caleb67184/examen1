using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_CalebSilman.Examen1_CalebSilman
{
    internal class Tipo
    {

        //Lista de los tipos de vehiculos validos en el sistema
        static List<string> tipoDeVehiculos = new List<string>()
        {
            "Motocicleta",
            "Automovil",
            "Dron"
        };

        //Metodo que muestra los 3 tipos de vehiculos validos
        public static void TipoVehiculos()
        {

            Console.WriteLine("Existen diferentes tipos de vehículos: ");
            foreach (var item in tipoDeVehiculos)
            {
                Console.WriteLine(item);
            }
        }

        //Metodo que muestra la funcion de cada vehiculo
        public static void ListadoVehiculos() 
        {
            Automovil.ListadoVehiculos();
            Dron.ListadoVehiculos();
            Motocicleta.ListadoVehiculos();
        }

        //Metodo que verifica si la categoria del usuario es valida con las del sistema
        public static void ExisteONo(string valor)
        { 
            Boolean existe = tipoDeVehiculos.Contains(valor);
            if (existe == true) { Console.WriteLine("Categoría valida"); }
            else { Console.WriteLine("Categoría invalida"); }
            
        }


    }
}
