using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    internal class Producto
    {
        public string Nombre {  get; set; }
        public string Codigo { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, string codigo, double precio)
        {
            Nombre = nombre;
            Codigo = codigo;
            Precio = precio;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"- Nombre: {Nombre}\n- Codigo: {Codigo}\n- Precio:{Precio}");    
        }

        public virtual void DescontandoProducto()
        {
            // Lógica base opcional
        }
    }
}

