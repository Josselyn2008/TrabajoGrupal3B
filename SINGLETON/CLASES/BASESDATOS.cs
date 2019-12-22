using System;
using System.Collections.Generic;
using System.Text;

namespace SINGLETON.CLASES
{
    public class BASESDATOS
    {
        private string datos;

        public BASESDATOS(string datos)
        {
            Datos = datos;
        }

        public string Datos
        {
            get { return datos; }
            set { datos = value; }
        }
     
        public string MOSTRAR()
        {
            return "\n" + Datos ;
        }


    }
}
