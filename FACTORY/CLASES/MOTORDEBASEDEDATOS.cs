using System;
using System.Collections.Generic;
using System.Text;
using FACTORY.INTERFACES;
namespace FACTORY.CLASES
{
    public class MOTORDEBASEDEDATOS : ISEVERSQL
    {
        public MOTORDEBASEDEDATOS()
        {
        }
        public string GETBASEDETALLES()
        {
            return " SERVER SQL \n Conectada permite habilitar protocolos de servidor \n Configura opciones de protocolo" +
                " \n Por ejemplo los puertos TCP  \n";
        }
    }
}
