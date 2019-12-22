using System;
using System.Collections.Generic;
using System.Text;
using FACTORY.INTERFACES;

namespace FACTORY.CLASES
{
    public class PAGINASWEB
    {
        public PAGINASWEB()
        {

        }
        IORACLE Ioracle;
        ISEVERSQL Iseversql;
        IPOSTGRESQL Ipostgresql;
        public PAGINASWEB(IBASEDATOS factory) {
            Ioracle =  factory.GETIORACLE();
            Iseversql = factory.GETISEVERSQL();
            Ipostgresql = factory.GETIPOSTGRESQL();
                }
        public string GETIORACLEBASEDETALLES()
        {
            return Ioracle.GETBASEDETALLES();
        }
        public string GETISEVERSQLBASEDETALLES()
        {
            return Iseversql.GETBASEDETALLES();
        }
        public string GETPOSTGRESQLBASEDETALLES()
        {
            return Ipostgresql.GETBASEDETALLES();
        }
       
    }
}
