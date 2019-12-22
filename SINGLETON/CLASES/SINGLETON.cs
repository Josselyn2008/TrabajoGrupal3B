using System;
using System.Collections.Generic;
using System.Text;

namespace SINGLETON.CLASES
{
    public sealed class SINGLETON
    {
      
        private static SINGLETON instancia = null;
        public SINGLETON()
        {
        }
        public static SINGLETON Instancia
        {
            get
            {
                if (instancia == null)
                {
                    Console.WriteLine("Se instancia");
                    instancia = new SINGLETON();
                }

                return instancia;
            }
        }
        private List<BASESDATOS> basedatos;
        public List<BASESDATOS> Basedatos
        {
            get { return basedatos; }
            set { basedatos = value; }
        }

    }
}
