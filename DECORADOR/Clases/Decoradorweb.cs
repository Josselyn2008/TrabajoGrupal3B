using System;
using System.Collections.Generic;
using System.Text;
using TareaN2.Clases;
using TareaN2.Interfaces;

namespace TareaN2.Clases
{
    public abstract class Decoradorweb : IPaginaweb

    {


        protected IPaginaweb paginaweb;

        public Decoradorweb(IPaginaweb paginaweb) { this.paginaweb = paginaweb; }

        public abstract string obtenerDescripcion();

    }
}