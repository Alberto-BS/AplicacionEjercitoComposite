using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionEjercito
{
    public interface IUnidad
    {
        double Blindaje { get; set; }
        double PotenciaFuego { get; set; }
        double Precio { get; set; }
        double Vel { get; set; }

    }
}