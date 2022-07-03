using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class IVAcontrollers : Controller
    {
        private readonly Iiva _service;
        private readonly IDbConnection _dbConnection;

        [HttpPost("Calcular IVA")]
        public List<IVAmodels> PostIva(int id_cliente)
        {
            return _service.calcularIVA(_dbConnection, id_cliente);
        }
    }
}
