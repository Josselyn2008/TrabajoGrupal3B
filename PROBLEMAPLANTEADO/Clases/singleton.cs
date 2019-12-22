using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4.Clases
{
    public sealed class Singleton
    {
        private static Singleton instancia = null;

        public Singleton()
        {

        }

        public static Singleton Instancia
        {
            get
            {
                if (instancia == null)
                {
                    Console.WriteLine("Instancia");
                    instancia = new Singleton();
                }

                return instancia;
            }

        }

        private List<Zapatos_correr> correr;  //

        public List<Zapatos_correr> Correr
        {
            get { return correr; }
            set { correr = value; }

        }

        private List<Zapatos_baloncesto> baloncesto;

        public List<Zapatos_baloncesto> Baloncesto
        {
            get { return baloncesto; }
            set { baloncesto = value; }

        }
        private List<Zapatosfutbol> futbol;

        public List<Zapatosfutbol> Futbol
        {
            get { return futbol; }
            set { futbol = value; }

        }

    }
}
