using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Miembros
    {
        
        private string cadenaConexion = "Server=DESKTOP-2H6A21O;Database=BDNazareno;Integrated Security=true;";

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

        // miembros por ministerio
        public DataTable ListarMiembrosPorMinisterio(int idMinisterio)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_MostrarMiembrosPorMinisterio", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Aquí le pasamos el parámetro que SQL está esperando
                    cmd.Parameters.AddWithValue("@IdMinisterio", idMinisterio);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al filtrar miembros del ministerio: " + ex.Message);
                }
            }

            return dt;
        }

        // METODO PARA MOTRARAR PROFESIONES
        public DataTable ListarProfesiones()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_MostrarProfesiones", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt); // Esto abre y cierra la conexión automáticamente
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cargar la lista de profesiones: " + ex.Message);
                }
            }
            return dt;
        }

        // METODO PARA INSERTAR PROFESIONES
        public void InsertarProfesion(string descripcion)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_InsertarProfesion", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Solo enviamos la descripción, SQL pone el ID automáticamente
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                    conexion.Open();
                    cmd.ExecuteNonQuery(); // Dispara la instrucción
                    // No necesitas poner conexion.Close() porque el bloque 'using' lo hace solo
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar la profesión: " + ex.Message);
                }
            }
        }

        // ==========================================
        // MÉTODO PARA EDITAR (U)
        // ==========================================
        public void EditarProfesion(int idProfesion, string descripcion)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_EditarProfesion", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Aquí sí necesitamos enviar ambos datos
                    cmd.Parameters.AddWithValue("@IdProfesion", idProfesion);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar la profesión: " + ex.Message);
                }
            }
        }

        // ==========================================
        // MÉTODO PARA ELIMINAR (D) - CON PROTECCIÓN
        // ==========================================
        public void EliminarProfesion(int idProfesion)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarProfesion", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdProfesion", idProfesion);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    // Atrapamos específicamente el error de conflicto de Llave Foránea
                    if (ex.Number == 547)
                    {
                        throw new Exception("¡Alto! No puedes eliminar esta profesión porque ya está siendo utilizada por un miembro de la iglesia.");
                    }
                    else
                    {
                        // Si es cualquier otro error de SQL (ej. servidor caído)
                        throw new Exception("Error de base de datos: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    // Errores generales de C#
                    throw new Exception("Ocurrió un error inesperado: " + ex.Message);
                }
            }
        }
    }
}