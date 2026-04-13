using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Familias
    {
        // No creamos "new CD_Conexiones", usamos tu método getInstancia()
        public void InsertarFamilia(string pApe, string sApe, string nomFam, string dir)
        {
            // Usamos 'using' para que la conexión se cierre y se libere sola pase lo que pase
            using (SqlConnection sqlCon = CD_Conexiones.getInstancia().CrearConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = sqlCon;
                    comando.CommandText = "INSERT INTO Familias (primer_apellido, segundo_apellido, nombrefamilia, direccion_principal) VALUES (@pape, @sape, @nom, @dir)";
                    comando.CommandType = CommandType.Text;

                    // Agregamos los parámetros
                    comando.Parameters.AddWithValue("@pape", pApe);
                    comando.Parameters.AddWithValue("@sape", sApe);
                    comando.Parameters.AddWithValue("@nom", nomFam);
                    comando.Parameters.AddWithValue("@dir", dir);

                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la Capa de Datos: " + ex.Message);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
                }
            }
        }
        public DataTable ListarFamilias()
        {
            DataTable tabla = new DataTable();
            // Usamos el método CrearConexion de tu clase CD_Conexiones
            using (SqlConnection sqlCon = CD_Conexiones.getInstancia().CrearConexion())
            {
                try
                {
                    // Puedes usar el procedimiento sp_ListarFamilias que creamos antes
                    SqlCommand comando = new SqlCommand("SELECT idfamilia as ID, nombrefamilia as [Nombre de Familia], direccion_principal as [Dirección] FROM Familias", sqlCon);
                    comando.CommandType = CommandType.Text;
                    sqlCon.Open();
                    SqlDataReader leer = comando.ExecuteReader();
                    tabla.Load(leer);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar familias: " + ex.Message);
                }
            }
            return tabla;
        }
        public void EliminarMiembro(int idMiembro)
        {
            // Usamos la misma estructura que tienes en tus otros métodos
            using (SqlConnection sqlCon = CD_Conexiones.getInstancia().CrearConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = sqlCon;
                    // Aquí pones tu sentencia SQL o el procedimiento almacenado
                    comando.CommandText = "UPDATE MIEMBROS SET ID_Familia = NULL WHERE ID_Miembro = @id";
                    comando.CommandType = CommandType.Text;

                    comando.Parameters.AddWithValue("@id", idMiembro);

                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la Capa de Datos al eliminar: " + ex.Message);
                }
                finally
                {
                    // El 'using' ya cierra la conexión, pero esto es tu estilo de seguridad
                    if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
                }
            }
        }
        public void EditarMiembro(int idMiembro, string nombre, string apellido, string rol, string telefono)
        {
            using (SqlConnection sqlCon = CD_Conexiones.getInstancia().CrearConexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE MIEMBROS SET Nombres = @nom, Apellidos = @ape, Rol_Familiar = @rol, Telefono = @tel WHERE ID_Miembro = @id", sqlCon);
                    cmd.Parameters.AddWithValue("@id", idMiembro);
                    cmd.Parameters.AddWithValue("@nom", nombre);
                    cmd.Parameters.AddWithValue("@ape", apellido);
                    cmd.Parameters.AddWithValue("@rol", rol);
                    cmd.Parameters.AddWithValue("@tel", telefono);
                    

                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { throw new Exception("Error al editar: " + ex.Message); }
            }
        }
        public int ContarMiembros(int idFamilia)
        {
            using (SqlConnection sqlCon = CD_Conexiones.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM MIEMBROS WHERE ID_Familia = @id", sqlCon);
                cmd.Parameters.AddWithValue("@id", idFamilia);
                sqlCon.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Método para eliminar la familia
        public void EliminarFamilia(int idFamilia)
        {
            using (SqlConnection sqlCon = CD_Conexiones.getInstancia().CrearConexion())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Familias WHERE idfamilia = @id", sqlCon);
                cmd.Parameters.AddWithValue("@id", idFamilia);
                sqlCon.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}