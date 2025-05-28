using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_project
{
    internal class Sala_2D : sala
    {
        public string Sistema_Sonido {  get; set; }
        public Sala_2D(int numeroSala, int capacidad, string tipoProyector, string tipoPantalla, string sistema_Sonido) 
            : base(numeroSala, capacidad, tipoProyector, tipoPantalla)
        {
            Sistema_Sonido = sistema_Sonido;
        }
        public void MostrarInformacionSala2D()
        {
            MostrarInformacionSala();
            Console.WriteLine($"- Sistema de sonido: {Sistema_Sonido}");
        }
    }
}
