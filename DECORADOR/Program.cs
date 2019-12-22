using System;
using TareaN2.Clases;
using TareaN2.Interfaces;

namespace TareaN2
{
    class Program
    {
        static void Main(string[] args)
        {
            PaginaWeb PaginaPersonalizada = new PaginaWeb();
            Chat Comunicacion = new Chat(PaginaPersonalizada);
            Pagoenlinea transferencias = new Pagoenlinea(Comunicacion);
            Login Cargando = new Login(transferencias);
            Múltiplesidiomas Lenguas = new Múltiplesidiomas(transferencias);

            Console.WriteLine("La pagina tiene las siguientes funcionalidades:\n");

            Console.WriteLine(Lenguas.obtenerDescripcion());

            Console.ReadKey();

        }
    }
}