using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Vendedores
    {
        public string nombre { get; set; }
        public Vendedores() { }
        public void VentasContado() { }
        public void VentasCredito() { }

        class Vendedor1 : Vendedores
        {

            public Vendedor1(string nombre)
            {
                this.nombre = "Kenny";
            }   
        }
            
        class Vendedor2 : Vendedores
        {
            public Vendedor2(string nombre)
            {
                this.nombre = "Josué";
            }
        }
       
        
        
       
        


        public static void ListadoVendedores()
        {
            VentasMenu.VendedorDiccionario();
            VentasMenu.ConvalidacionDatos();
        }

    }
    
}
