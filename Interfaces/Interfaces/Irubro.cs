using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    public interface Irubro
    {
        Rubromodels GetRubro();
        List<Rubromodels> GetRubros(System.Data.IDbConnection dbConnection);
        List<Rubromodels> GetRubroayFirstLetter(char FirstLetter);
        void SetCategoria(Rubromodels rubro);
        void DeleteCategoria(int id);
        List<Rubromodels> EditRubro(System.Data.IDbConnection dbConnection, int id_Rubro);
    }
}
