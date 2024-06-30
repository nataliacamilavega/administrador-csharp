using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteIndividuo : Cliente
    {
        public string Apellido { get; set; }




        public ClienteIndividuo(string nombre, string apellido, string CUIT, string Email, string Telefono, string Direccion) : base(nombre, CUIT, Email, Telefono, Direccion)
        {
            this.Apellido = apellido;

        }
    }
}
