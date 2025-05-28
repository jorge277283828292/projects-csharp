using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_project
{
    internal class sala
    {
        public int NumeroSala { get; set; }
        public int Capacidad { get; set; }
        public String Proyector { get; set; }
        public String Pantalla { get; set; }

        public sala(int numeroSala, int capacidad, string tipoProyector, string tipoPantalla)
        {
            NumeroSala = numeroSala;
            Capacidad = capacidad;
            Proyector = tipoProyector;
            Pantalla = tipoPantalla;
        }

        public void MostrarInformacionSala() 
        {
            Console.WriteLine($"- Numero de sala: {NumeroSala}\n- Capacidad: {Capacidad}\n- Tipo de Proyector: {Proyector}\n- tipo de Pantalla: {Pantalla}");
        }
    }
}
