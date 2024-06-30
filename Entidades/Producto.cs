using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Producto
    {

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        public decimal PrecioBruto
        {
            get
            {
                return this.PrecioCosto + Convert.ToDecimal(this.Margen);
            }
        }
        public decimal PrecioVenta
        {
            get
            {

                return this.PrecioBruto + Convert.ToDecimal(this.IVA);

            }
        }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }



        public Producto(string nombre, string descripcion, decimal preciocosto, double margen, double iva, string proveedor, string categoria, string subtcat)
        {
            this.Nombre = nombre;
            this.IVA = iva;
            this.Descripcion = descripcion;
            this.Categoria = categoria;
            this.PrecioCosto = preciocosto;
            this.Margen = margen;
            this.Proveedor = proveedor;
            this.SubCategoria = subtcat;
        }
    }


}
