using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    internal class Productos_Limpieza : Producto
    {
        public string IngredienteProducto { get; set; }

        public Productos_Limpieza(string nombre, string codigo, double precio, string ingredienteProducto)
            : base(nombre, codigo, precio)
        {
            IngredienteProducto = ingredienteProducto;
        }

        public override void DescontandoProducto()
        {
            double descuento = Precio * 0.01;

            base.DescontandoProducto();
            Console.WriteLine($"Los productos perecederos tienen un 2% de descuento");
            Console.WriteLine($"- El descuento de este producto es de {descuento}");
            Precio -= descuento;
        }


        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"- Ingrediente del producto de limpieza: {IngredienteProducto}");
        }
    }
}
