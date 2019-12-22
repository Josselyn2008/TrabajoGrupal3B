using System;
using System.Collections.Generic;
using System.Text;
using FACTORY.INTERFACES;

namespace FACTORY.CLASES
{
    public class EJECUTAR : IBASEDATOS
    {
        public EJECUTAR()
        {

        }
        public IORACLE GETIORACLE()
        {
            return new COMANDOSSQL();
        }

        public IPOSTGRESQL GETIPOSTGRESQL()
        {
            return new SERVIDOR();
        }

        public ISEVERSQL GETISEVERSQL()
        {
            return new TRANSACTSQL();
        }
    }
}
