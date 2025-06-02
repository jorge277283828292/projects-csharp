using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_project
{
    internal class Sala_3D : sala
    {
        public string TipoGafas { get; set; }
        public Sala_3D(int numeroSala, int capacidad, string tipoProyector, string tipoPantalla, string tipoGafas)
            : base(numeroSala, capacidad, tipoProyector, tipoPantalla)
        {
            TipoGafas = tipoGafas;
        }
        public void MostrarInformacionSala3D()
        {
            MostrarInformacionSala();
            Console.WriteLine($"- Tipo de Gafas: {TipoGafas}");
        }
    }
}
