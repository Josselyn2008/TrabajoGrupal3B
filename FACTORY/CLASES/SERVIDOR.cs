using System;
using System.Collections.Generic;
using System.Text;
using FACTORY.INTERFACES;

namespace FACTORY.CLASES
{
    public class SERVIDOR : IPOSTGRESQL
    {
        public SERVIDOR()
        {

        }
         public string GETBASEDETALLES()
        {
            return " POSTGRES \n Al ejecutarse pueden ser escritos en varios lenguajes " +
                "con la potencia que cada uno de ellos da \n " +
                " desde las operaciones básicas de programación  \n hasta las complejidades " +
                "de la programación orientada a objetos";
        }
    } 
}
