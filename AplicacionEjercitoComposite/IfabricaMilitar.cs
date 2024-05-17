using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionEjercito
{
    public interface IfabricaMilitar
    {
        public IUnidad CrearTropas(EnumEjercito Pepino);
    }
}