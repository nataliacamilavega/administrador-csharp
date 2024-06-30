namespace Entidades
{
    public class ClienteEmpresa : Cliente
    {
        public string Contacto { get; set; }


        public ClienteEmpresa(string nombre, string contacto, string CUIT, string Email, string Telefono, string Direccion) : base(nombre, CUIT, Email, Telefono, Direccion)
        {
            this.Contacto = contacto;

        }
    }
}