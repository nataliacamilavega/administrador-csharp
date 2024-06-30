using System;
using System.Runtime.CompilerServices;
using Entidades;

namespace Consola
{
    class Program
    {

        static void Main(string[] args)
        {


            Producto prodUno = new Producto("Toallón", "100% algodón color fucsia", 100, .2, .1, "Arredo", "Hogar", "Baño");

            Console.WriteLine("    PRODUCTOS " + Environment.NewLine);

            Console.WriteLine("_______________________________ " + Environment.NewLine);
            Console.WriteLine("    Producto {0}", prodUno.Nombre);
            Console.WriteLine("        > {0}", prodUno.Categoria + " > " + prodUno.SubCategoria);
            Console.WriteLine("        Descripción: {0}", prodUno.Descripcion);
            Console.WriteLine("        Precio de costo: {0}", prodUno.PrecioCosto);
            Console.WriteLine("        Margen: {0}", prodUno.Margen);
            Console.WriteLine("        I.V.A: {0}", prodUno.IVA);
            Console.WriteLine("        Precio bruto: {0}", prodUno.PrecioBruto.ToString());
            Console.WriteLine("        Precio venta: {0}", prodUno.PrecioVenta.ToString());
            Console.WriteLine("        Proveedor: {0}", prodUno.Proveedor);


            Pausa("Clientes");

            ClienteIndividuo clienteUno = new ClienteIndividuo("Martín", "Wallace", "20415782449", "martinw@gmail.com", "1144225511", "Lavalle 123");

            Console.WriteLine("    CLIENTES " + Environment.NewLine);
            Console.WriteLine("_______________________________ " + Environment.NewLine);
            Console.WriteLine("    Cliente {0}", clienteUno.Nombre + " " + clienteUno.Apellido);
            Console.WriteLine("        CUIT: {0}", clienteUno.CUIT);
            Console.WriteLine("        Correo electrónico: {0}", clienteUno.Email);
            Console.WriteLine("        Teléfono: {0}", clienteUno.Telefono);
            Console.WriteLine("        Dirección: {0}", clienteUno.Direccion);


            Pausa("Empresas");


            ClienteEmpresa empresaUno = new ClienteEmpresa("Arredo", "1122544", "2948885449", "arredo@gmail.com", "11225544", "Arredo 123");

            Console.WriteLine("    EMPRESAS " + Environment.NewLine);
            Console.WriteLine("_______________________________ " + Environment.NewLine);
            Console.WriteLine("    Empresa {0}", empresaUno.Nombre );
            Console.WriteLine("        Contacto: {0}", empresaUno.Contacto);
            Console.WriteLine("        CUIT: {0}", empresaUno.CUIT);
            Console.WriteLine("        Correo electrónico: {0}", empresaUno.Email);
            Console.WriteLine("        Teléfono: {0}", empresaUno.Telefono);
            Console.WriteLine("        Dirección: {0}", empresaUno.Direccion);


            Pausa("Vendedores");

            Vendedor vendedorUno = new Vendedor("Juan", "Pietro", "20425714");

            Console.WriteLine("    VENDEDORES " + Environment.NewLine);
            Console.WriteLine("_______________________________ " + Environment.NewLine);
            Console.WriteLine("    Vendedor {0}", vendedorUno.Nombre + " " + vendedorUno.Apellido);

            Console.WriteLine("        DNI: {0}", vendedorUno.DNI);


            Pausa("FIN");
        }
        private static void Pausa(string seccion)
        {
            if (seccion == "FIN")
            {
                Console.WriteLine(Environment.NewLine + "> Pulsar una tecla para avanzar a terminar");
                Console.ReadKey();
                Console.Clear();

                return;
            }
            else
            {

                Console.WriteLine(Environment.NewLine + "> Pulsar una tecla para avanzar a " + seccion);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}