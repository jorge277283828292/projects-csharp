using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    internal class Producto_Perecedero : Producto
    {
        public DateTime FechaVencimiento {  get; set; }
        
        public Producto_Perecedero(string nombre, string codigo, double precio, DateTime fechaVencimiento) 
            :base(nombre, codigo, precio)
        {
            FechaVencimiento = fechaVencimiento;
        }
    
        public override void DescontandoProducto()
        {
            double descuento = Precio * 0.02;

            base.DescontandoProducto();
            Console.WriteLine($"Los productos perecederos tienen un 2% de descuento");
            Console.WriteLine($"- El descuento de este producto es de {descuento}");
            Precio -= descuento;
        }


        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"- Fecha de vencimiento: {FechaVencimiento}");
        }
    }
}
