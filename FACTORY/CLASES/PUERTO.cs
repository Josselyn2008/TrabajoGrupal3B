using System;
using System.Collections.Generic;
using System.Text;
using FACTORY.INTERFACES;

namespace FACTORY.CLASES
{
   public class PUERTO : IORACLE
    {
        public PUERTO()
        {
        }
        public string GETBASEDETALLES()
        {
            return "ORACLE \n Conectada al puerto \n Alta disponibilidad \n Reduccion de los costos \n ";
        }

    }
}
