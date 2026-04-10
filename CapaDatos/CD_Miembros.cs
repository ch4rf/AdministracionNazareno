using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Miembros
    {

        
        
        // metodo para mostrar los miembros
        public DataTable ListarMiembros()
        {
            // Creamos la tabla en memoria donde se guardarán los resultados de SQL
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection();

            try
                {
                    conexion = CD_Conexiones.getInstancia().CrearConexion();
                    SqlCommand cmd = new SqlCommand("sp_MostrarMiembros", conexion);
                    // Le decimos explícitamente que es un Procedimiento Almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    // El DataAdapter es el puente entre SQL y nuestro DataTable en C#
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    // Llena el DataTable (Abre y cierra la conexión por detrás)
                    da.Fill(dt);
            }
            catch (Exception ex)
                {
                    // Si algo falla (ej. servidor apagado), mandamos el error hacia arriba
                    throw new Exception("Error al cargar los miembros desde la BD: " + ex.Message);
                }
            finally
                 {
                    if (conexion.State == ConnectionState.Open) conexion.Close();

                }


            return dt; // Retornamos la tabla llena de datos
        }

        // metodo para mostrar los ministerios
        public DataTable ListarMinisterios()
        {
            // Creamos la tabla en memoria donde se guardarán los resultados de SQL
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection();

            try
                {
                    conexion = CD_Conexiones.getInstancia().CrearConexion();
                    SqlCommand cmd = new SqlCommand("sp_MostrarMinisterios", conexion);
                    // Le decimos explícitamente que es un Procedimiento Almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    // El DataAdapter es el puente entre SQL y nuestro DataTable en C#
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    
                    // Llena el DataTable (Abre y cierra la conexión por detrás)
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    // Si algo falla (ej. servidor apagado), mandamos el error hacia arriba
                    throw new Exception("Error al cargar los miembros desde la BD: " + ex.Message);
                }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();

            }


            return dt; // Retornamos la tabla llena de datos
        }

        // miembros por ministerio
        public DataTable ListarMiembrosPorMinisterio(int idMinisterio)
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection();

            try
                {
                    conexion = CD_Conexiones.getInstancia().CrearConexion();
                    SqlCommand cmd = new SqlCommand("sp_MostrarMiembrosPorMinisterio", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Aquí le pasamos el parámetro que SQL está esperando
                    cmd.Parameters.AddWithValue("@IdMinisterio", idMinisterio);
                    conexion.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al filtrar miembros del ministerio: " + ex.Message);
                }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();

            }


            return dt;
        }
    }
}