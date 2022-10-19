using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Reportes
    {
        public static void MostrarInfo() // mostrar lista de vendedores y vehiculos
        {
            VentasMenu.VendedorDiccionario();
            Vehiculo.ConsultarVehiculo();
        }
    }
}
