using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionEjercito
{
    public class Unidad : IUnidad
    {
        public double Blindaje { get; set; }
        public double PotenciaFuego { get; set; }
        public double Precio { get; set; }
        public double Vel { get; set; }
    }
}