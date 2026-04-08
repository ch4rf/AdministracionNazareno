using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_TiposRecepcion
    {
        private string cadenaConexion = "Server=DESKTOP-2H6A21O;Database=BDNazareno;Integrated Security=true;";

        public DataTable MostrarTiposRecepcion()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_MostrarTiposRecepcion", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cargar los tipos de recepción: " + ex.Message);
                }
            }
            return dt;
        }

        public void InsertarTipoRecepcion(string descripcion)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
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
            }
        }

        public void EditarTipoRecepcion(int idRecepcion, string descripcion)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
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
            }
        }

        public void EliminarTipoRecepcion(int idRecepcion)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
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
            }
        }
    }
}
