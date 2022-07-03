using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class ISRcontroller : Controller
    {
        private readonly Iisr _service;
        private readonly IDbConnection _dbConnection;

        [HttpPost("Calcular ISR")]
        public List<ISRmodels> PostIsr(int id_cliente)
        {
            return _service.calcularISR(_dbConnection, id_cliente);
        }
    }
}
