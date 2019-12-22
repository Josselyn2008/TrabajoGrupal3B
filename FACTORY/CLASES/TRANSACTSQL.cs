using System;
using System.Collections.Generic;
using System.Text;
using FACTORY.INTERFACES;

namespace FACTORY.CLASES
{
    public class TRANSACTSQL : ISEVERSQL
    {
        public TRANSACTSQL()
        {

        }

        public string GETBASEDETALLES()
        {
            return " SERVER SQL \n Ejecutado para manipular y recuperar datos \n Incluye " +
                "interfaces de acceso \n para varias plataformas de desarrollo \n ";
        }
    }
}
