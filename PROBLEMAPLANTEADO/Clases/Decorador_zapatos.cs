using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4.Clases
{
    public abstract class Decorador_zapatos : Izapato
    {
        protected Izapato zapatosx;

        public Decorador_zapatos(Izapato zapato) 
        
        { this.zapatosx = zapato; }

        public abstract string descripcion();
    }
}
