using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataTipoMovimiento : DataAccess
    {
        public DataTable TraerTipoMovimiento()
        {
            string query = "Select Descripcion from TipoMovimiento";

            SqlCommand cmd = new SqlCommand(query, conexion);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return dt;
        }
    }
}