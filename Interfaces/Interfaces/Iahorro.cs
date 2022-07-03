using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    public interface Iahorro
    {
        List<Ahorromodels> calcularIVA(IDbConnection dbConnection, int id_cliente);

    }
}
