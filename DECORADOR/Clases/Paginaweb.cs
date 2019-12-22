using System;
using System.Collections.Generic;
using System.Text;
using TareaN2.Interfaces;

namespace TareaN2.Clases
{
    public class PaginaWeb : IPaginaweb
    {
        public PaginaWeb()
        {
        }

        public string obtenerDescripcion()
        {
            return "- Color de fondo blaco\n- Link\n- Publicidad\n" +
              "- Tipo de Letra normal\n- Tamaño de letras 8\n";
        }

        internal static bool obtenerDescripción()
        {
            throw new NotImplementedException();
        }
    }
}
