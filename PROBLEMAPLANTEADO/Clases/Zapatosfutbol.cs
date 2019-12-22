using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4.Clases
{
    public class Zapatosfutbol
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Zapatosfutbol(string nombre)
        {
            Nombre = nombre;
        }

        public string Mostrar()
        {
            return "-" + Nombre;
        }
    }
}
