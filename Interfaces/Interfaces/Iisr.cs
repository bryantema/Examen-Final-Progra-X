using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    interface Iisr
    {
        List<ISRmodels> calcularIVA(IDbConnection dbConnection, int id_cliente);

    }
}
