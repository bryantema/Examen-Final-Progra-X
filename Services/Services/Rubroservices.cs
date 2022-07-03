using Interfaces.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.Services
{
    class Rubroservices : Irubro
    {
        public void DeleteCategoria(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rubromodels> EditRubro(IDbConnection dbConnection, int id_Rubro)
        {
            throw new NotImplementedException();
        }

        public Rubromodels GetRubro()
        {
            throw new NotImplementedException();
        }

        public List<Rubromodels> GetRubroayFirstLetter(char FirstLetter)
        {
            throw new NotImplementedException();
        }

        public List<Rubromodels> GetRubros(IDbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public void SetCategoria(Rubromodels rubro)
        {
            throw new NotImplementedException();
        }
    }
}
