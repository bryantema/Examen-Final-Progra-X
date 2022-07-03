using Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Interfaces.Interfaces
{
    public interface Itransacciones
    {
        List<Clientemodels> GetClientes(IDbConnection dbConnection);
        List<Clientemodels> GetClienteImpuesto(IDbConnection dbConnection, Clientemodels clienteImpuesto);
    }
}
