using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    interface Icliente
    {
        Clientemodels GetCliente();
        List<Clientemodels> GetClientes(System.Data.IDbConnection dbConnection);
        List<Clientemodels> GetClienteayFirstLetter(char FirstLetter);
        void SetCategoria(Clientemodels cliente);
        void DeleteCategoria(int id);
        List<Clientemodels> EditCliente(System.Data.IDbConnection dbConnection, int id_Cliente);
    }
}
