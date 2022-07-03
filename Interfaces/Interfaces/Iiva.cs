using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    interface Iiva
    {
        List<IVAmodels> calcularIVA(IDbConnection dbConnection, int id_cliente);
    }
}
