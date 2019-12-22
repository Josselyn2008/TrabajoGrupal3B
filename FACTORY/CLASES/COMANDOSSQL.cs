using System;
using System.Collections.Generic;
using System.Text;
using FACTORY.INTERFACES;

namespace FACTORY.CLASES
{
    public class COMANDOSSQL :  IORACLE
    {
        public COMANDOSSQL()
        {

        }
        public string GETBASEDETALLES()
        {
            return " ORACLE \n Para ejecutar debe introducir el bloque SQL o PL/SQL en el editor de comandos \n " +
                "Se pueden ejecutar comandos tanto de lenguaje de manipulación de bases de datos (DML)\n";
        }
    }
}
