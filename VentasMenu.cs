using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class VentasMenu
    {
        static String[] nombreVendedor = { "Kenny", "Josué", "María", "Warren" }; 
        
        static String[] codigoVendedor = { "15987", "45987", "85497", "85349" };

        public static void VendedorDiccionario()
        {
            Dictionary<String, String> vendedores = new Dictionary<String, String>();
            vendedores.Add("Kenny", "15987");
            vendedores.Add("Josué", "45987");
            vendedores.Add("María", "85497");
            vendedores.Add("Warren", "85349");



            foreach (var vendedor in vendedores)
            {
                Console.WriteLine($"Vendedor: {vendedor.Key} Código: {vendedor.Value}");
            }
            Console.ReadLine();
           
        }



        //Convalida que el codigo ingresado pertenezca a un vendedor registrado
        public static void ConvalidacionDatos()
        {
            string validacionCodigoVendedor;

            Console.WriteLine("Ingrese el código de vendedor");
            validacionCodigoVendedor = Console.ReadLine();
            Console.Clear();
            for (int i = 0; i < codigoVendedor.Length; i++)
            {
                if (validacionCodigoVendedor == codigoVendedor[i])
                {
                    Console.WriteLine("El código " + codigoVendedor[i] + " pertenece a " + nombreVendedor[i] + ".");
                    Vehiculo.ValidacionCodigoVehiculo();
                    Console.Clear();

                }
            }
            Console.WriteLine("El código no coincidide, vuelva a intentarlo");
            Console.ReadKey();
            Console.Clear();
            Menu.MenuPrincipal();



        }
        
    }
}
