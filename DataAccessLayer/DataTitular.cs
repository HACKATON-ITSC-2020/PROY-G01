using Entities;
using System;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataTitular : DataAccess
    {
        public int SavePosibleTitular(Titular _titular)
        {
            int resultado = -1;

            string query = @"insert into PosibleTitular (Apellido,
                                                  Nombre,
                                                  CUIL,
                                                  DNI,
                                                  Contacto,
                                                  ContactoAlternativo,
                                                  Correo,
                                                  Adicional) values (@Apellido,
                                                  @Nombre,
                                                  @CUIL,
                                                  @DNI,
                                                  @Contacto,
                                                  @ContactoAlternativo,
                                                  @Correo,
                                                  @Adicional)"
            ;

            SqlParameter apellido = new SqlParameter("@Apellido", _titular.Apellido);
            SqlParameter nombre = new SqlParameter("@Nombre", _titular.Nombre);
            SqlParameter cUIL = new SqlParameter("@CUIL", _titular.CUIL);
            SqlParameter dNI = new SqlParameter("@DNI", _titular.DNI);
            SqlParameter contacto = new SqlParameter("@Contacto", _titular.Contacto);
            SqlParameter contactoAlternativo = new SqlParameter("@ContactoAlternativo", _titular.ContactoAlternativo);
            SqlParameter correo = new SqlParameter("@Correo", _titular.Correo);
            SqlParameter adicional = new SqlParameter("@Adicional", _titular.Adicional);

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add(apellido);
            cmd.Parameters.Add(nombre);
            cmd.Parameters.Add(cUIL);
            cmd.Parameters.Add(dNI);
            cmd.Parameters.Add(contacto);
            cmd.Parameters.Add(contactoAlternativo);
            cmd.Parameters.Add(correo);
            cmd.Parameters.Add(adicional);

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
                                                  Adicional) values (@Apellido,
                                                  @Nombre,
                                                  @CUIL,
                                                  @DNI,
                                                  @Contacto,
                                                  @ContactoAlternativo,
                                                  @Correo,
                                                  @Adicional)"
            ;

            SqlParameter apellido = new SqlParameter("@Apellido", _titular.Apellido);
            SqlParameter nombre = new SqlParameter("@Nombre", _titular.Nombre);
            SqlParameter cUIL = new SqlParameter("@CUIL", _titular.CUIL);
            SqlParameter dNI = new SqlParameter("@DNI", _titular.DNI);
            SqlParameter contacto = new SqlParameter("@Contacto", _titular.Contacto);
            SqlParameter contactoAlternativo = new SqlParameter("@ContactoAlternativo", _titular.ContactoAlternativo);
            SqlParameter correo = new SqlParameter("@Correo", _titular.Correo);
            SqlParameter adicional = new SqlParameter("@Adicional", _titular.Adicional);

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add(apellido);
            cmd.Parameters.Add(nombre);
            cmd.Parameters.Add(cUIL);
            cmd.Parameters.Add(dNI);
            cmd.Parameters.Add(contacto);
            cmd.Parameters.Add(contactoAlternativo);
            cmd.Parameters.Add(correo);
            cmd.Parameters.Add(adicional);

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

        public bool ConsultarTitular(Titular _titular)
        {
            string query = @""
                            
            ;

            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                Abrirconexion();                               
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Cerrarconexion();
            }

            return false;
        }

        public DataSet listadoPosiblesTitulares(string cual)
        {
            string orden = string.Empty;
            orden = "select * from PosibleTitular";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception)
            {
                throw new Exception("Error al mostrar posibles titulares");
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

    }
}