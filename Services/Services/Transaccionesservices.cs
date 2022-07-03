using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.Services
{
    public class Transaccionesservices : Itransacciones
    {
        private readonly IDbConnection _dbConnection;
        public Transaccionesservices(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
    }
}
