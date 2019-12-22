using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4.Clases
{
    public class Zapato_personalizado : Decorador_zapatos
    {
        public Zapato_personalizado(Izapato zapatos) : base(zapatos)
        {
        }

        public override string descripcion()
        {
            return this.zapatosx.descripcion() + "*Zapato personalizado\n";
        }
    }
}
