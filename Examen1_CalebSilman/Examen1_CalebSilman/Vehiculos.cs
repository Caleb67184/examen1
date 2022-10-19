using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_CalebSilman.Examen1_CalebSilman
{
    internal class Vehiculos
    {
        static int codigo { get; set; }
        static string marca {get; set; }
        static int costo {get; set; }
        static string modelo {get; set; }

        static int cont = 0;
        static int precio = 0;
        public Vehiculos() { }

        public Vehiculos (int codigos, string marcas, int costos, string modelos)
        {
            codigo = codigos;
            marca = marcas;
            costo = costos;
            modelo = modelos;
        }

         static int[] codigos = new int[5];
         static int[] costos = new int[5];
         static string[] marcas = new string[5];
         static string[] modelos = new string[5];

        //Metodo para crear vehiculos con sus atributos
        public static void AgregarVehiculos() 
        {
            
            Console.WriteLine("Digite el código: "); 
            codigos[cont] = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("Digite el costo: "); 
            costos[cont] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite la marca: ");
            marcas[cont] = Console.ReadLine();

            Console.WriteLine("Digite el modelo: ");
            modelos[cont] = Console.ReadLine();

            Console.WriteLine("El vehículo ha sido agregado");
            Console.Read();
            Console.Clear();
            cont++;
        }

        //Metodo para modificar un vehiculo ya creado
        public static void ModificarVehiculos() 
        {
            int codigo;
            Boolean existe = false;
            Console.WriteLine("Ingrese el codigo del vehiculo a modificar");
            codigo = int.Parse(Console.ReadLine());

            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigo == codigos[i])
                {
                Console.WriteLine("Digite el código: ");
                codigos[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite el costo: ");
                costos[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite la marca: ");
                marcas[i] = Console.ReadLine();

                Console.WriteLine("Digite el modelo: ");
                modelos[i] = Console.ReadLine();

                Console.WriteLine("El vehículo ha sido modificado");
                Console.Read();
                Console.Clear();
                }
            }
            if (!existe) { Console.WriteLine("El vehiculo no existe"); }
        }

        //Metodo para buscar entre los vehiculos ya creados y mostrarlo
        public static void ConsultarArticulos() 
        {
            int codigo;
            Boolean existe = false;
            Console.WriteLine("Ingrese el codigo del vehiculo a consultar");
            codigo = int.Parse(Console.ReadLine());
            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigo == codigos[i])
                {
                    Console.WriteLine("Marca: " + marcas[i]);
                    Console.WriteLine("Modelo: " + modelos[i]);
                    Console.WriteLine("Costo: " + costos[i]);
                    existe = true;
                }
            }
            if (!existe) { Console.WriteLine("El vehiculo no existe"); }
            Console.Read();
        }

        //Metodo para mostrar TODOS los vehiculos que se hayan creado
        public static void MostrarVehiculos()
        {
            if (cont == 0) { Console.WriteLine("No hay vehículos agregados");}
            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine($"Vehiculo \nCódigo: {codigos[i]}\nMarca: {marcas[i]} \nModelo: {modelos[i]} \nCosto: {costos[i]} \n");
            }
        }

        //Metodo que verifica si hay un vehiculo con el codigo del usuario
        public static void VerificacionVehiculos()
        {
            int codigo;
            Boolean existe = false;
            Console.WriteLine("Ingrese el codigo del vehiculo a verificar");
            codigo = int.Parse(Console.ReadLine());
            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigo == codigos[i])
                {
                    Console.WriteLine("Marca: " + marcas[i]);
                    Console.WriteLine("Modelo: " + modelos[i]);
                    Console.WriteLine("Costo: " + costos[i]);
                    precio = costos[i];
                    existe = true;
                }
            }
            if (!existe) { Console.WriteLine("El vehiculo no existe"); }
        }

        //Metodo para verificar si la categoria del usuario es valida
        public static void CategoriaVehiculo()
        {
            string categoria = "";
            Console.WriteLine("Digite la categoría del vehículo: ");
            categoria = Console.ReadLine();
            Tipo.ExisteONo(categoria);
            
        }

        //Metodo para comprar el vehiculo
        public static void ComprarVehiculo()
        {
            int pago = 0;
            Console.WriteLine("Con cuanto desea pagar el vehículo: ");
            pago = int.Parse(Console.ReadLine());

            int vuelto = pago - precio;
            Console.WriteLine($"Su vuelto es de {vuelto}");
            Console.WriteLine("Vehiculo comprado con éxito, Gracias por su compra");
            
        }
    }
}
