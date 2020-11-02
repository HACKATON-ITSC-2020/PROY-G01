using Entities;
using System;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataTitular : DataAccess
    {        
        public int SaveTitular(Titular _titular)
        {
            int resultado = -1;

            string query = @"insert into Titular (Apellido,
                                                  Nombre,
                                                  CUIL,
                                                  DNI,
                                                  Contacto,
                                                  ContactoAlternativo,
                                                  Correo,
                                                  Adicional,
                                                  Clave,
                                                  Estado)

                                          values (@Apellido,
                                                  @Nombre,
                                                  @CUIL,
                                                  @DNI,
                                                  @Contacto,
                                                  @ContactoAlternativo,
                                                  @Correo,
                                                  @Adicional,
                                                  @Clave,
                                                  @Estado)"
            ;

            SqlParameter apellido = new SqlParameter("@Apellido", _titular.Apellido);
            SqlParameter nombre = new SqlParameter("@Nombre", _titular.Nombre);
            SqlParameter cUIL = new SqlParameter("@CUIL", _titular.CUIL);
            SqlParameter dNI = new SqlParameter("@DNI", _titular.DNI);
            SqlParameter contacto = new SqlParameter("@Contacto", _titular.Contacto);
            SqlParameter contactoAlternativo = new SqlParameter("@ContactoAlternativo", _titular.ContactoAlternativo);
            SqlParameter correo = new SqlParameter("@Correo", _titular.Correo);
            SqlParameter adicional = new SqlParameter("@Adicional", _titular.Adicional);
            SqlParameter clave = new SqlParameter("@Clave", _titular.Clave);
            SqlParameter estado = new SqlParameter("@Estado", _titular.Estado);

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add(apellido);
            cmd.Parameters.Add(nombre);
            cmd.Parameters.Add(cUIL);
            cmd.Parameters.Add(dNI);
            cmd.Parameters.Add(contacto);
            cmd.Parameters.Add(contactoAlternativo);
            cmd.Parameters.Add(correo);
            cmd.Parameters.Add(adicional);
            cmd.Parameters.Add(clave);
            cmd.Parameters.Add(estado);

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

        public Titular ConsultarTitular(string correo, string clave)
        {
            Titular _titular = new Titular();
            string query = @"select Correo, Clave from Titular where Correo = '" + correo + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                Abrirconexion();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    _titular.Correo = reader["Correo"].ToString();
                    _titular.Clave = reader["Clave"].ToString();
                }
                else
                {
                    _titular.Correo = "No";
                    _titular.Clave = "No";
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
            return _titular;
        }

        public DataSet ListadoTitularesPendientes()
        {
            string query = @"select Id, CUIL, Apellido, Nombre from Titular where Estado = 'P'
                           Order by Id, CUIL, Apellido, Nombre";

            SqlCommand cmd = new SqlCommand(query, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al traer titulares", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

        public int RestablecerClave(Titular _titular)
        {
            int resultado = -1;

            string query = @"Update Titular Set Clave = @Clave
                            where Correo = @Correo"
            ;

            SqlParameter clave = new SqlParameter("@Clave", _titular.Clave);
            SqlParameter correo = new SqlParameter("@Correo", _titular.Correo);

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add(clave);
            cmd.Parameters.Add(correo);

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

        public Titular ConsultarTitularPendiente(Titular _titular)
        {
            string query = @"select * from Titular where Id = '"+_titular.Id+"'";

            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                Abrirconexion();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    _titular.Id = int.Parse(reader["Id"].ToString());
                    _titular.Apellido = reader["Apellido"].ToString();
                    _titular.Nombre = reader["Nombre"].ToString();
                    _titular.CUIL = reader["CUIL"].ToString();
                    _titular.DNI = reader["DNI"].ToString();
                    _titular.Contacto = reader["Contacto"].ToString();
                    _titular.ContactoAlternativo = reader["ContactoAlternativo"].ToString();
                    _titular.Correo = reader["Correo"].ToString();
                    _titular.Clave = reader["Clave"].ToString();
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
            return _titular;
        }

        public Titular BuscarCoincidencias(int PosibleTitularId, Titular _titular)
        {
            string query = "select count(Id) as Idcounter from Titular where Id = '" + PosibleTitularId + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                Abrirconexion();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    _titular.Id = int.Parse(reader["IdCounter"].ToString());
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

            return _titular;
        }
    }
}