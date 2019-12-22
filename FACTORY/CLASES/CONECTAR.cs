using System;
using System.Collections.Generic;
using System.Text;
using FACTORY.INTERFACES;

namespace FACTORY.CLASES
{
    public class CONECTAR : IBASEDATOS
    {
        public CONECTAR()
        {
        }

        public IORACLE GETIORACLE()
        {
            return new PUERTO();
        }

        public IPOSTGRESQL GETIPOSTGRESQL()
        {
            return new PSQL();
        }
        public ISEVERSQL GETISEVERSQL()
        {
            return new MOTORDEBASEDEDATOS();
        }

    }
}
