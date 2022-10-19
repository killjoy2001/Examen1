using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Tipo
    {

        
        public string tip { get; set; }
        public void ListadoVehiculo()
        {
            Console.WriteLine("Existen tres tipos de vehículos");
            List<String> list = new List<String>();
            list.Add("Motocicleta");
            list.Add("Automóvil");
            list.Add("Dron");

        }
            // no entendí el el punto d. de la parte 3

        

        public void TipoVehiculo()
        {
            if (tip == "Automovil")
            {
                Console.WriteLine("Vehiculo de cuatro ruedas”");
            } else if (tip == "Motocicleta")
            {
                Console.WriteLine("Vehiculo de dos ruedas”");
            } else
            {
                Console.WriteLine("Vehiculo volador");
            }
        }

        class Automovil : Tipo
        {
            public Automovil(string tip)
            {
                this.tip = "Automovil";

            }
        }
        class Motocicleta : Tipo
        {
            public Motocicleta(string tip)
            {
                this.tip = "Motocicleta";
            }
            
        }
        class Dron : Tipo
        {
            public Dron(string tip)
            {
                this.tip = "Dron";
            }
        }
    }
}
