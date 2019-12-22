using System;
using System.Collections.Generic;
using System.Text;
using TareaN2.Interfaces;
using TareaN2.Clases;

namespace TareaN2.Clases
{
    public class Chat : Decoradorweb

    {
        public Chat(IPaginaweb paginaweb) : base(paginaweb)
        {
        }

        public override string obtenerDescripcion()
        {
            return this.paginaweb.obtenerDescripcion() + "- Chat\n";
        }


    }
}
