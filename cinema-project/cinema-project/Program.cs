//Sistema de cine sencillo, con POO.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sala_2D sala_2D = new Sala_2D(1, 50, "Digital", "Estandar", "Dolby surround");
            Sala_3D sala_3D = new Sala_3D(2, 55, "Dolby 3D", "Dolby 3D", "Gafas Polarizadas");

            Console.WriteLine("Informacion de la sala 2D");
            sala_2D.MostrarInformacionSala2D();

            Console.WriteLine("");

            Console.WriteLine("Informacion de la sala 3D");
            sala_3D.MostrarInformacionSala3D(); 
        }
    }
}
