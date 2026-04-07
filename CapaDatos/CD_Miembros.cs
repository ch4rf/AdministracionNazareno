using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Miembros
    {
        
        private string cadenaConexion = "Server=DESKTOP-2H6A21O;Database=IglesiaBD;Integrated Security=true;";

        // metodo para mostrar los miembros
        public DataTable ListarMiembros()
        {
            // Creamos la tabla en memoria donde se guardarán los resultados de SQL
            DataTable dt = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_MostrarMiembros", conexion);
                    // Le decimos explícitamente que es un Procedimiento Almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

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
            }

            return dt; // Retornamos la tabla llena de datos
        }

        // metodo para mostrar los ministerios
        public DataTable ListarMinisterios()
        {
            // Creamos la tabla en memoria donde se guardarán los resultados de SQL
            DataTable dt = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_MostrarMinisterios", conexion);
                    // Le decimos explícitamente que es un Procedimiento Almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

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
            }

            return dt; // Retornamos la tabla llena de datos
        }
    }
}