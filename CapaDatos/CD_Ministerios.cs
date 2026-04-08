using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Ministerios
    {
        private string cadenaConexion = "Server=DESKTOP-2H6A21O;Database=BDNazareno;Integrated Security=true;";

        public DataTable MostrarMinisterios()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_MostrarCatalogosMinisterios", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cargar los ministerios: " + ex.Message);
                }
            }
            return dt;
        }

        public void InsertarMinisterio(string nombre)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
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
            }
        }

        public void EditarMinisterio(int idMinisterio, string nombre)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
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
            }
        }

        public void EliminarMinisterio(int idMinisterio)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
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
            }
        }
    }
}
