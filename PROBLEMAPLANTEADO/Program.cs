using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Punto4.Clases;
//using Punto4.Interfaces;

namespace Punto4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Zapatos zapatos = new Zapatos();
            Zapatos_coleccion extension = new Zapatos_coleccion(zapatos);
            Zapato_personalizado diseño = new Zapato_personalizado(extension);
            Console.WriteLine("El zapato tiene lo siguiente:\n");
            Console.WriteLine(diseño.descripcion());

            //****
            Zapatos_correr correr1 = new Zapatos_correr("Nike revolution 4");
            Zapatos_correr correr2 = new Zapatos_correr("Nike Zoom Strike");
            Zapatos_correr correr3 = new Zapatos_correr("Adidas Adizero 4\n");

            Singleton.Instancia.Correr = new List<Zapatos_correr>();
            Singleton.Instancia.Correr.Add(correr1);
            Singleton.Instancia.Correr.Add(correr2);
            Singleton.Instancia.Correr.Add(correr3);

            //********
            Zapatos_baloncesto baloncesto1 = new Zapatos_baloncesto("Jordan 1 low");
            Zapatos_baloncesto baloncesto2 = new Zapatos_baloncesto("Jordan retro 8");
            Zapatos_baloncesto baloncesto3 = new Zapatos_baloncesto("Under Armour Curry\n");

            Singleton.Instancia.Baloncesto = new List<Zapatos_baloncesto>();
            Singleton.Instancia.Baloncesto.Add(baloncesto1);
            Singleton.Instancia.Baloncesto.Add(baloncesto2);
            Singleton.Instancia.Baloncesto.Add(baloncesto3);
            //***

            Zapatosfutbol futbol1 = new Zapatosfutbol("Adidas Goletto");
            Zapatosfutbol futbol2 = new Zapatosfutbol("Adidas Performance");
            Zapatosfutbol futbol3 = new Zapatosfutbol("Nike Nemeziz\n");

            Singleton.Instancia.Futbol = new List<Zapatosfutbol>();
            Singleton.Instancia.Futbol.Add(futbol1);
            Singleton.Instancia.Futbol.Add(futbol2);
            Singleton.Instancia.Futbol.Add(futbol3);

            Console.WriteLine("           **TIENDA**");
            Console.WriteLine("       Zapatos en inventario:");

            Console.WriteLine("\nZapatos de correr: ");
            foreach (Zapatos_correr item in Singleton.Instancia.Correr)
            {

                Console.WriteLine(item.Mostrar());
            }

            Console.WriteLine("\nZapatos de baloncesto: ");
            foreach (Zapatos_baloncesto item1 in Singleton.Instancia.Baloncesto)
            {
                Console.WriteLine(item1.Mostrar());
            }

            Console.WriteLine("\nZapatos de futbol: ");
            foreach (Zapatosfutbol item2 in Singleton.Instancia.Futbol)
            {
                Console.WriteLine(item2.Mostrar());
            }
            Console.ReadKey();

        }





        
    }
}
