using System;
using System.Collections.Generic;
using System.Text;
using FACTORY.INTERFACES;

namespace FACTORY.CLASES
{
    public class PSQL :IPOSTGRESQL
    {
        public PSQL()
        {
        }

        public string GETBASEDETALLES()
        {
            return "POSGRESQL \n Al conectar realiza \n Transacciones eventuales consistentes \n Y tendra un mayor rendimiento \n";
        }
    }
}
