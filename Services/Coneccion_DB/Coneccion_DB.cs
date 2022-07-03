using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Coneccion_DB
{
    public class Coneccion_DB
    {
        private readonly SqlConnection conn = new SqlConnection();
        public SqlConnection GetConnection()
        {
            try
            {
                conn.ConnectionString = @"Server=localhost;Initial Catalog=ProyectoPrograX;Trusted_Connection=true";
                conn.Open();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                conn.Close();
            }
            return conn;
        }
    }
}
