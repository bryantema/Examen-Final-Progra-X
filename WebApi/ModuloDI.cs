using Autofac;
using Interfaces.Interfaces;
using Microsoft.Data.SqlClient;
using Services.Services;
using System.Data;

namespace WebApi
{
    public class ModuloDI : Autofac.Module
    {
        string connectionString = @"Server=.;Initial Catalog=Examen_final;Trusted_Connection=true;TrustServerCertificate=True";


        protected override void Load(ContainerBuilder builder)
        {
            SqlConnection conn;
            #region Ahorros
            builder.RegisterType<Ahorrosservices>().As<Iahorro>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Clientes
            builder.RegisterType<Clientesservices>().As<Iclientes>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region ISR
            builder.RegisterType<ISRservices>().As<Iisr>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region IVA
            builder.RegisterType<IVAservices>().As<Iiva>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Transacciones
            builder.RegisterType<Transaccionesservices>().As<Itransacciones>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
        }
    }
}
