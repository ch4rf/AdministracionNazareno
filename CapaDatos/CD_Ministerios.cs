using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Ministerios
    {
        

        public DataTable MostrarMinisterios()
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection();

            //Primero debemos conectarnos al método getInstancia para activar el string de conexión
            
            try
            {
                conexion = CD_Conexiones.getInstancia().CrearConexion(); //Conectamos a getInstancia para activar el string de conexión
                SqlCommand cmd = new SqlCommand("sp_MostrarCatalogosMinisterios", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
                {
                    throw new Exception("Error al cargar los ministerios: " + ex.Message);
                }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
       
            }
            
            
        }

        public void InsertarMinisterio(string nombre)
        {
            SqlConnection conexion = new SqlConnection();

                try
                {
                    conexion = CD_Conexiones.getInstancia().CrearConexion();
                    SqlCommand cmd = new SqlCommand("sp_InsertarMinisterio", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar el ministerio: " + ex.Message);
                }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();

            }

        }

        public void EditarMinisterio(int idMinisterio, string nombre)
        {
            SqlConnection conexion = new SqlConnection();
            try
                {
                    conexion = CD_Conexiones.getInstancia().CrearConexion();
                    SqlCommand cmd = new SqlCommand("sp_EditarMinisterio", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdMinisterio", idMinisterio);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el ministerio: " + ex.Message);
                }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();

            }

        }

        public void EliminarMinisterio(int idMinisterio)
        {
            SqlConnection conexion = new SqlConnection();
            try
                {
                    conexion = CD_Conexiones.getInstancia().CrearConexion();
                    SqlCommand cmd = new SqlCommand("sp_EliminarMinisterio", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdMinisterio", idMinisterio);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            catch (SqlException ex)
                {
                    // Protección anti-colapsos: Error 547
                    if (ex.Number == 547)
                    {
                        throw new Exception("No puedes eliminar este ministerio porque ya hay miembros que tienen historial de servicio en él.");
                    }
                    else
                    {
                        throw new Exception("Error de base de datos: " + ex.Message);
                    }
                }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();

            }

        }
    }
}
