using System;
using System.Collections.Generic;
using System.Text;
using TareaN2.Interfaces;

namespace TareaN2.Clases
{
    public class Login : Decoradorweb

    {
        public Login(IPaginaweb paginaweb) : base(paginaweb)
        {
        }

        public override string obtenerDescripcion()
        {
            return this.paginaweb.obtenerDescripcion() + "- Login\n";
        }


    }
}
