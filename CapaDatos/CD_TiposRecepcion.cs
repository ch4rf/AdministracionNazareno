using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_TiposRecepcion
    {

        public DataTable MostrarTiposRecepcion()
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = CD_Conexiones.getInstancia().CrearConexion(); //Conectamos a getInstancia para activar el string de conexión
                SqlCommand cmd = new SqlCommand("sp_MostrarTiposRecepcion", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los tipos de recepción: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();

            }

            return dt;
        }

        public void InsertarTipoRecepcion(string descripcion)
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = CD_Conexiones.getInstancia().CrearConexion(); //Conectamos a getInstancia para activar el string de conexión
                SqlCommand cmd = new SqlCommand("sp_InsertarTipoRecepcion", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el tipo de recepción: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();

            }

        }

        public void EditarTipoRecepcion(int idRecepcion, string descripcion)
        {
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion = CD_Conexiones.getInstancia().CrearConexion(); //Conectamos a getInstancia para activar el string de conexión
                SqlCommand cmd = new SqlCommand("sp_EditarTipoRecepcion", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdRecepcion", idRecepcion);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el tipo de recepción: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();

            }

        }

        public void EliminarTipoRecepcion(int idRecepcion)
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = CD_Conexiones.getInstancia().CrearConexion(); //Conectamos a getInstancia para activar el string de conexión
                SqlCommand cmd = new SqlCommand("sp_EliminarTipoRecepcion", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdRecepcion", idRecepcion);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                // Protección anti-colapsos
                if (ex.Number == 547)
                {
                    throw new Exception("No puedes eliminar este tipo de recepción porque hay miembros en la base de datos que ingresaron bajo esta modalidad.");
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

