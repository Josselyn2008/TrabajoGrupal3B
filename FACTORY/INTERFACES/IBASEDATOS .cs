using System;
using System.Collections.Generic;
using System.Text;

namespace FACTORY.INTERFACES
{
    public interface IBASEDATOS
    {
        IORACLE GETIORACLE();
        IPOSTGRESQL GETIPOSTGRESQL();
        ISEVERSQL GETISEVERSQL();

    }
}
