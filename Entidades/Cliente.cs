using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }


    public Cliente(string nombre, string CUIT, string Email, string Telefono, string Direccion)
    {
        this.Nombre = nombre;
        this.CUIT = CUIT;
        this.Email = Email;
        this.Telefono = Telefono;
        this.Direccion = Direccion;
    }
    }
}
