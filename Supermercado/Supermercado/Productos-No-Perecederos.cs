using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    internal class Productos_No_Perecederos : Producto
    {
        public string Tipo { get; set; }

        public Productos_No_Perecederos(string nombre, string codigo, double precio, string tipo)
            : base(nombre, codigo, precio)
        {
            Tipo = tipo;
        }

        public override void DescontandoProducto()
        {
            double descuento = Precio * 0.02;

            base.DescontandoProducto();
            Console.WriteLine($"Los productos perecederos tienen un 2% de descuento");
            Console.WriteLine($"-  descuento de este producto es de {descuento}");
            Precio -= descuento;
        }


        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"- Tipo de producto no perecedero: {Tipo}");
        }
    }
}
