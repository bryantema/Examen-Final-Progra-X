using Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.Services
{
    class ISRservices
    {
        public List<ISRmodels> calcularISR(IDbConnection dbConnection, int id_cliente)
        {
            var cliente = dbConnection.Query<ClienteImpuesto>("SELECT * FROM [V_IMPUESTO_CLIENTE] WHERE id_cliente = " + id_cliente);
            double ISR;

            foreach (var item in cliente)
            {
                var salario = item.Salario;

                if (salario <= 30000.00)
                {
                    ISR = salario * 0.05;
                }
                else
                {
                    ISR = salario * 0.07;
                }

                dbConnection.Query<ISRmodels>("INSERT INTO tabla_impuesto (idIsr, idClientes, Totalisr,) VALUES ("
                                                    + item.id_cliente + "," + item.id_rubro + "," + "'ISR'" + "," + "'Calculo de ISR'" + "," + ISR + ")");
            }

            return (List<ISRmodels>)dbConnection.Query<ISRmodels>("SELECT * FROM  tabla_impuesto WHERE id_cliente = " + id_cliente);
        }

    }
}
