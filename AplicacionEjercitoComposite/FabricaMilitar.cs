using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionEjercito
{
    public class fabricaMilitar : IfabricaMilitar
    {
        public IUnidad CrearTropas(EnumEjercito Pepino)
        {
            switch (Pepino)
            {
                case EnumEjercito.Ametralladora: return new Unidad() { Vel = 4.5, Blindaje = 1.4, PotenciaFuego = 0, Precio = 4200 };
                case EnumEjercito.TransporteRapido: return new Unidad { Vel = 12, Blindaje = 0, PotenciaFuego = 0, Precio = 1600 };
                case EnumEjercito.TanqueDeAtaque: return new Unidad() { Vel = 7.3, Blindaje = 4.8, PotenciaFuego = 9.8, Precio = 15600 };
                case EnumEjercito.InfanteriaBasica: return new Unidad { Vel = 6, Blindaje = 0, PotenciaFuego = 7, Precio = 250 };
                case EnumEjercito.Sanitario: return new Unidad { Vel = 7, Blindaje = 5, PotenciaFuego = 0, Precio = 500 };
                case EnumEjercito.Cañon: return new Unidad { Vel = 1, Blindaje = 0, PotenciaFuego = 22, Precio = 1100 };
                case EnumEjercito.TorpederoMovil: return new Unidad { Vel = 3, Blindaje = 2, PotenciaFuego = 19, Precio = 1350 };
                case EnumEjercito.transporte: return new Unidad { Vel = 0, Blindaje = 0, PotenciaFuego = 14, Precio = 1100 };
                default: return null;
            }
        }

        internal IUnidad CrearTropas()
        {
            throw new NotImplementedException();
        }
    }
}