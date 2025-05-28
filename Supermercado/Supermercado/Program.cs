//Es un programa sencillo de POO, en el cual hago referencia a productos de un supermercado.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto[] productosSupermercado = new Producto[6];

            productosSupermercado[0] = new Productos_Limpieza("Jabón", "001", 2, "Coco");
            productosSupermercado[1] = new Productos_No_Perecederos("Arroz", "002", 1.5, "Grano");
            productosSupermercado[2] = new Producto_Perecedero("Leche", "003", 1.2, new DateTime(2024, 09, 12));
            productosSupermercado[3] = new Producto_Perecedero("Leche", "004", 1.2, new DateTime(2024, 10, 01));
            productosSupermercado[4] = new Productos_No_Perecederos("Sopa Enlatada", "005", 3, "Enlatados");
            productosSupermercado[5] = new Productos_Limpieza("Detergente", "006", 2.7, "Sulfato de Sodio");

            
            for (int i = 0; i < productosSupermercado.Length; i++)
            {
                Console.WriteLine(new string('=', 100));
                productosSupermercado[i].DescontandoProducto();
                productosSupermercado[i].MostrarInfo();
                Console.WriteLine(new string('=', 100));
                Console.WriteLine("");
            }
        }
    }
}