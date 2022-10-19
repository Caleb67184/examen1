using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_CalebSilman.Examen1_CalebSilman
{
    static class Menu  
    {
        static Menu() { }

        //Menu principal del sistema
        public static void mostrarMenu() {

            string opcion = "";
            do
            {
                Console.Write("a- ");
                Console.WriteLine("Vehículos");
                Console.Write("b- ");
                Console.WriteLine("Ventas");
                Console.Write("c- ");
                Console.WriteLine("Reportes");
                Console.Write("d- ");
                Console.WriteLine("Salir");
                Console.Write("Digite una opcion: ");
                opcion = Console.ReadLine();
                Console.Clear();

                switch (opcion) {

                    case "a":
                        Menu.SubMenuVehiculos();
                        break;
                    case "b":
                        Vehiculos.VerificacionVehiculos();
                        Vehiculos.CategoriaVehiculo();
                        Console.WriteLine("Ingrese el código del vendedor: ");
                        string codigo = Console.ReadLine();
                        Vendedores.CodigoVendedor(codigo);
                        Console.Read();

                        Vehiculos.ComprarVehiculo();
                        
                        Console.Clear();
                        break;
                    case "c":
                        Vendedores.ListadoVendedores();
                        Console.WriteLine("*************************");
                        Tipo.TipoVehiculos();
                        Console.WriteLine("*************************");
                        Vehiculos.MostrarVehiculos();
                        Console.WriteLine("*************************");
                        Console.Read();

                        break;
                    case "d":
                        Console.WriteLine("Hasta luego, gracias");
                        Console.Read();
                        break;
                    default:
                        break;
                }

            } while (opcion != "d");
  
        }

        //Menu secundario para administrar vehiculos
        public static void SubMenuVehiculos()
        {
            string opcion = "";
            do
            {
                Console.WriteLine("******** SubMenú Vehículos ********");
                Console.WriteLine("a- Agregar vehículo");
                Console.WriteLine("b- Modificar vehículo");
                Console.WriteLine("c- Consultar vehículo");
                Console.WriteLine("d- Atrás");
                Console.Write("Digite una opcion: ");
                opcion = Console.ReadLine();
                Console.Clear();

                switch (opcion) {
                    case "a":
                        Vehiculos.AgregarVehiculos();
                        break;
                    case "b":
                        Vehiculos.ModificarVehiculos();
                        break;
                    case "c":
                        Vehiculos.ConsultarArticulos();
                        break;
                    case "d":
                        Menu.mostrarMenu();break;
                    default:
                        break;

                }

            } while (opcion != "d");


        }

    }
}
