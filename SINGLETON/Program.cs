using System;
using SINGLETON.CLASES;
using System.Collections.Generic;
using System.Text;

namespace SINGLETON.CLASES
{
    class Program
    {
        static void Main(string[] args)
        {
            BASESDATOS DATO1 = new BASESDATOS("SQL SERVER");
            BASESDATOS DATO2 = new BASESDATOS("ORACLE");
            BASESDATOS DATO3 = new BASESDATOS("POST SQL");
            SINGLETON.Instancia.Basedatos = new List<BASESDATOS>();

            SINGLETON.Instancia.Basedatos.Add(DATO1);
            SINGLETON.Instancia.Basedatos.Add(DATO2);
            SINGLETON.Instancia.Basedatos.Add(DATO3);
            foreach (BASESDATOS item in SINGLETON.Instancia.Basedatos)
            {
                Console.WriteLine(item.MOSTRAR());
            }

            Console.ReadLine();
        }
    }
}
