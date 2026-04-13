using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Profesiones
    {



        // METODO PARA MOTRARAR PROFESIONES
        public DataTable ListarProfesiones()
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = CD_Conexiones.getInstancia().CrearConexion(); //Conectamos a getInstancia para activar el string de conexión
                SqlCommand cmd = new SqlCommand("sp_MostrarProfesiones", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt); // Esto abre y cierra la conexión automáticamente
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar la lista de profesiones: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();

            }
            return dt;
        }

        // METODO PARA INSERTAR PROFESIONES
        public void InsertarProfesion(string descripcion)
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = CD_Conexiones.getInstancia().CrearConexion(); //Conectamos a getInstancia para activar el string de conexión
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
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();

            }
        }

        // MÉTODO PARA EDITAR
        public void EditarProfesion(int idProfesion, string descripcion)
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = CD_Conexiones.getInstancia().CrearConexion(); //Conectamos a getInstancia para activar 
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
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();

            }
        }

        // MÉTODO PARA ELIMINAR - CON PROTECCIÓN

        public void EliminarProfesion(int idProfesion)
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = CD_Conexiones.getInstancia().CrearConexion(); //Conectamos a getInstancia para activar 
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
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();

            }

        }
    }
}

