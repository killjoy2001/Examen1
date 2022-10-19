using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Menu
    {

        
        static Menu() { }
        public static void MenuPrincipal()
        {
            int opcionMenu = 1;

            Console.WriteLine("******Bienvenido al menú de venta para vehiculos******");
            Console.WriteLine("Elija la acción que desea realizar");
            Console.WriteLine("1. Vehículos");
            Console.WriteLine("2. Ventas");
            Console.WriteLine("3. Reportes");
            Console.WriteLine("4. Salir");
            opcionMenu = int.Parse(Console.ReadLine());
            Console.Clear();

            if (opcionMenu > 3)
            {
                Console.WriteLine("Gracias por usar nuestros servicios");
                Console.ReadKey();
            }
            else if (opcionMenu > 2)
            {
                Reportes.MostrarInfo();
            }
            else if (opcionMenu > 1)
            {
                VentasMenu.ConvalidacionDatos();
            }
            else 
            {
                SubMenuVehiculos();
            }
                
            
        }
        public static void SubMenuVehiculos()
        {
            int opcionMenu = 1;

            Console.WriteLine("****Menú Vehículos****");
            Console.WriteLine("Seleccione la acción que desea hacer.");
            Console.WriteLine("1. Agregar vehículo");
            Console.WriteLine("2. Modificar vehículo");
            Console.WriteLine("3. Consultar vehículo");
            Console.WriteLine("4. Volver");
            opcionMenu = int.Parse(Console.ReadLine());
            Console.Clear();
            
            if (opcionMenu > 3)
            {
                MenuPrincipal();
            }
            else if (opcionMenu > 2)
            {
                Vehiculo.ConsultarVehiculo();
            }
            else if (opcionMenu > 1)
            {
                Vehiculo.ModificarVehiculo();
            }
            else
            {
                Vehiculo.AgregarVehiculo();
                
            }

        }

    }

}



    

