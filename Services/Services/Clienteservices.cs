using Interfaces.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.Services
{
    public class Clienteservices : Icliente
    {
        public void DeleteCategoria(int id)
        {
            throw new NotImplementedException();
        }

        public List<Clientemodels> EditCliente(IDbConnection dbConnection, int id_Cliente)
        {
            throw new NotImplementedException();
        }

        public Clientemodels GetCliente()
        {
            throw new NotImplementedException();
        }

        public List<Clientemodels> GetClienteayFirstLetter(char FirstLetter)
        {
            throw new NotImplementedException();
        }

        public List<Clientemodels> GetClientes(IDbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public void SetCategoria(Clientemodels cliente)
        {
            throw new NotImplementedException();
        }
    }
}
