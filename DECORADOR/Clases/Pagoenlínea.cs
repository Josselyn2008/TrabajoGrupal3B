using System;
using System.Collections.Generic;
using System.Text;
using TareaN2.Interfaces;

namespace TareaN2.Clases
{
    public class Pagoenlinea : Decoradorweb

    {
        public Pagoenlinea(IPaginaweb paginaweb) : base(paginaweb)
        {
        }

        public override string obtenerDescripcion()
        {
            return this.paginaweb.obtenerDescripcion() + "- Pago en linea\n";
        }


    }
}