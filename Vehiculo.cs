using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Vehiculo
    {
        public Vehiculo() { }



        protected static string[] modelo = new string[5];
        protected static string[] marca = new string[5];
        protected static string[] codigo = new string[5];
        protected static int[] precio = new int[5];

        
        
        // método para agregar datos de vehiculos
        public static void AgregarVehiculo()
        {
            for (int i = 0; i < modelo.Length; i++)
            {

                byte opcion;
                Console.WriteLine("Ingrese el modelo del vehículo");
                modelo[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la marca del vehículo");
                marca[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el código del vehículo");
                codigo[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el precio del vehículo");
                precio[i]=int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Desea agregar otro vehiculo?");
                Console.WriteLine("1. Sí");
                Console.WriteLine("2. No");
                opcion = byte.Parse(Console.ReadLine());
                if (opcion > 1)
                {
                    Console.Clear();
                    Menu.MenuPrincipal();
                }

            }
            Console.WriteLine("Ha añadido correctamente los vehiculos!");
            Console.ReadKey();
            Console.Clear();
            Menu.SubMenuVehiculos();

        }
        // imprime toda la información de vehiculos ingresados
        public static void ConsultarVehiculo()
        {
            for (int i = 0; i < modelo.Length; i++)
            {
                Console.WriteLine("Modelo: " + modelo[i] + ". Marca: "  + marca[i] + ". Código: "+ codigo[i] + ". Precio:" + precio[i] + ".");
                
            }
            Console.ReadKey();
            Console.Clear();
            Menu.SubMenuVehiculos();
        }
        public static void ModificarVehiculo()
        {
            //pendiente
        }

        // verifica si el codigo coincide con uno en el registro
        public static void ValidacionCodigoVehiculo()
        {
            string verificacionCodigo;
            Console.WriteLine("Ingrese el código del vehículo");
            verificacionCodigo = Console.ReadLine();
            for (int i = 0; i < codigo.Length; i++)
            {
                if (codigo[i] == verificacionCodigo)
                {
                    Console.WriteLine("Modelo: " + marca[i] + ". Marca: " + modelo[i] + ". Código: " + codigo[i] + ". Precio:" + precio[i] + ".");
                    Console.ReadKey();
                    Console.Clear();
                    Menu.MenuPrincipal();
                } else
                {
                    Console.WriteLine("El código " + verificacionCodigo + " no se encuentra en nuestros registros.");
                    Console.ReadKey();
                    Console.Clear();
                    Menu.MenuPrincipal();
                }
            }

        }


    }
    
}
