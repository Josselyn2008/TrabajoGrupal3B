using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4.Clases
{
    public class Zapatos_coleccion : Decorador_zapatos
    {
        public Zapatos_coleccion(Izapato zapatos) : base(zapatos)
        {
        }

        public override string descripcion()
        {
            return this.zapatosx.descripcion() + "*Zapato de coleccion\n";
        }
    }
}
