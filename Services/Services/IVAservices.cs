using Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.Services
{
    class IVAservices
    {
        public List<IVAmodels> calcularIVA(IDbConnection dbConnection, int id_cliente)
        {
            var cliente = dbConnection.Query<ClienteImpuesto>("SELECT * FROM [VW_IMPUESTO_CLIENTE] WHERE id_cliente = " + id_cliente);
            double IVA;

            foreach (var item in cliente)
            {
                var salario = item.Salario;

                IVA = salario * 0.12;

                dbConnection.Query<IVAmodels>("INSERT INTO tabla_impuesto(idIva, idClientes,Totaliva,) VALUES ("
                                                    + item.id_cliente + "," + item.id_rubro + "," + "'IVA'" + "," + "'Calculo de IVA'" + "," + IVA + ")");
            }

            return (List<IVAmodels>)dbConnection.Query<IVAmodels>("SELECT * FROM  tabla_impuesto WHERE id_cliente = " + id_cliente);
        }
    }
}
