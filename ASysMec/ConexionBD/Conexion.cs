using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ASysMec.ConexionBD
{
    public class Conexion
    {
        public SqlConnection conexion;

        public Conexion()
        {
            
        }

        public void CrearConexion()
        {
            try
            {
                string cadena = "Data Source = -JEFFREY\\SQLEXPRESSJEFRY; Initial Catalog = BD_SysMec; Integrated Security = True";
                conexion = new SqlConnection(cadena);
                conexion.Open();
            }
            catch (Exception) { }
        }

        public SqlConnection getConexion()
        {
            try
            {
                return conexion;
            }
            catch (Exception) { return null; }
        }
    }
}