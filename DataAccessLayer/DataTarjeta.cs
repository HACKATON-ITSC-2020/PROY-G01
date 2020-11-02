using Entities;
using System;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace DataAccessLayer
{
    public class DataTarjeta : DataAccess
    {

        public int GenerarTarjeta(string Tipotarjeta, Tarjeta tarjeta)
        {
            int resultado = -1;
            string query = string.Empty;

            SqlCommand cmd;

            if (Tipotarjeta == "Debito")
            {
                query = @"insert into Tarjeta (NroTarjeta, clave, TitularId, TipoTarjeta)
                                         values  (@NroTarjeta, @clave, @TitularId, @TipoTarjeta)"
                ;

                SqlParameter nroTarjeta = new SqlParameter("@NroTarjeta", tarjeta.NroTarjeta);
                SqlParameter clave = new SqlParameter("@clave", tarjeta.clave);
                SqlParameter titularId = new SqlParameter("@TitularId", tarjeta.TitularId);
                SqlParameter tipoTarjeta = new SqlParameter("@TipoTarjeta", tarjeta.TipoTarjeta);

                cmd = new SqlCommand(query, conexion);

                cmd.Parameters.Add(nroTarjeta);
                cmd.Parameters.Add(clave);
                cmd.Parameters.Add(titularId);
                cmd.Parameters.Add(tipoTarjeta);

            }
            else
            {
                query = @"insert into Tarjeta (NroTarjeta, clave, TitularId, TipoTarjeta, LimiteCompra, MaxCuotas, InteresMensual)
                                         values  (@NroTarjeta, @clave, @TitularId, @TipoTarjeta, @LimiteCompra, @MaxCuotas, @InteresMensual)"
                ;

                SqlParameter nroTarjeta = new SqlParameter("@NroTarjeta", tarjeta.NroTarjeta);
                SqlParameter clave = new SqlParameter("@clave", tarjeta.clave);
                SqlParameter titularId = new SqlParameter("@TitularId", tarjeta.TitularId);
                SqlParameter tipoTarjeta = new SqlParameter("@TipoTarjeta", tarjeta.TipoTarjeta);
                SqlParameter limiteCompra = new SqlParameter("@LimiteCompra", tarjeta.LimiteCompra);
                SqlParameter maxCuotas = new SqlParameter("@MaxCuotas", tarjeta.MaxCuotas);
                SqlParameter interesMensual = new SqlParameter("@InteresMensual", tarjeta.InteresMensual);

                cmd = new SqlCommand(query, conexion);

                cmd.Parameters.Add(nroTarjeta);
                cmd.Parameters.Add(clave);
                cmd.Parameters.Add(titularId);
                cmd.Parameters.Add(tipoTarjeta);
                cmd.Parameters.Add(limiteCompra);
                cmd.Parameters.Add(maxCuotas);
                cmd.Parameters.Add(interesMensual);
            }

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
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

            return resultado;
        }

    }
}
