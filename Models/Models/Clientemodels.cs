using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    public class Clientemodels
    {
        public int idClientes { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int celular { get; set; }
        public string pais { get; set; }
        public string ciudad { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public string entidad { get; set; }
        public double salario { get; set; }
        public int idrubro { get; set; }
        public double cantidaddonacion { get; set; }
    }
}
