using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }




        public Vendedor(string nombre, string apellido, string DNI)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = DNI;

        }
    }
}
