using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionEjercito
{
    public interface IEjercito
    {
        public double DameCM();

        public void Add(IUnidad tropa);
        public int ElementoTotal();
    }
}