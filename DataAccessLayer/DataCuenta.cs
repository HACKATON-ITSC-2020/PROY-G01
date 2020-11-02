using Entities;
using System;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataCuenta : DataAccess
    {

        public Cuenta TraerSaldos(Cuenta cuenta)
        {
            string query = @"select SaldoCC, SaldoCH from Cuenta";
            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                Abrirconexion();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cuenta.SaldoCC = int.Parse(reader["SaldoCC"].ToString());
                    cuenta.SaldoCH = int.Parse(reader["SaldoCH"].ToString());
                }
                else
                {
                    cuenta.SaldoCC = 0;
                    cuenta.SaldoCH = 0;
                }
                reader.Close();
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
            return cuenta;
        }

        public int GenerarCuenta(Cuenta cuenta)
        {
            int resultado = -1;

            string query = @"insert into Cuenta (NroCuenta, CVU, Alias, TitularId, LimiteDescubierto)
                                         values (@NroCuenta, @CVU, @Alias, @TitularId, @LimiteDescubierto);
                            Update Titular set Estado = 'A' where Id = '" + cuenta.TitularId + "'";
            ;

            SqlParameter nroCuenta = new SqlParameter("@NroCuenta", cuenta.NroCuenta);
            SqlParameter cVU = new SqlParameter("@CVU", cuenta.CVU);
            SqlParameter alias = new SqlParameter("@Alias", cuenta.Alias);
            SqlParameter titularId = new SqlParameter("@TitularId", cuenta.TitularId);
            SqlParameter limiteDescubierto = new SqlParameter("@LimiteDescubierto", cuenta.LimiteDescubierto);

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add(nroCuenta);
            cmd.Parameters.Add(cVU);
            cmd.Parameters.Add(alias);
            cmd.Parameters.Add(titularId);
            cmd.Parameters.Add(limiteDescubierto);

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