using System;
using FACTORY.CLASES;
using FACTORY.INTERFACES;

namespace FACTORY
{
    class Program
    {
        static void Main(string[] args)
        {
            IBASEDATOS conectarbasedatos = new CONECTAR();
            PAGINASWEB conectarpaginas = new PAGINASWEB(conectarbasedatos);

            Console.WriteLine("*********  CONECTAR PAGINAS WEB **********");
            Console.WriteLine(conectarpaginas.GETIORACLEBASEDETALLES());
            Console.WriteLine(conectarpaginas.GETISEVERSQLBASEDETALLES());
            Console.WriteLine(conectarpaginas.GETPOSTGRESQLBASEDETALLES());

            IBASEDATOS ejecutarbasedatos = new CONECTAR();
            PAGINASWEB ejecutarpaginas = new PAGINASWEB(ejecutarbasedatos);

            Console.WriteLine("*********  EJECUTAR PAGINAS WEB **********");
            Console.WriteLine(ejecutarpaginas.GETIORACLEBASEDETALLES());
            Console.WriteLine(ejecutarpaginas.GETISEVERSQLBASEDETALLES());
            Console.WriteLine(ejecutarpaginas.GETPOSTGRESQLBASEDETALLES());

            Console.ReadLine();

        }
    }
           
}
