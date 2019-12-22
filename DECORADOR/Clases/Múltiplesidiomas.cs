using System;
using System.Collections.Generic;
using System.Text;
using TareaN2.Interfaces;

namespace TareaN2.Clases
{
    public class Múltiplesidiomas : Decoradorweb

    {
        public Múltiplesidiomas(IPaginaweb paginaweb) : base(paginaweb)
        {
        }

        public override string obtenerDescripcion()
        {
            return this.paginaweb.obtenerDescripcion() + "********Tipos de Idiomas********\n- " +
            "Español\n- Ingles\n- italiano\n- Frances\n- portugues\n";
        }

    }
}