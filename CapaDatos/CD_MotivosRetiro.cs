using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace CapaDatos
{
    public class CD_MotivosRetiro
    {
        private string cadenaConexion = "Server=DESKTOP-2H6A21O;Database=BDNazareno;Integrated Security=true;";

        // MOSTRAR
        public DataTable MostrarMotivos()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_MostrarMotivosRetiro", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cargar los motivos de retiro: " + ex.Message);
                }
            }
            return dt;
        }

        // INSERTAR
        public void InsertarMotivo(string descripcion)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_InsertarMotivoRetiro", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar el motivo: " + ex.Message);
                }
            }
        }

        // EDITAR
        public void EditarMotivo(int idMotivo, string descripcion)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_EditarMotivoRetiro", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdMotivo", idMotivo);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el motivo: " + ex.Message);
                }
            }
        }

        // ELIMINAR (Con la protección anti-colapsos)
        public void EliminarMotivo(int idMotivo)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarMotivoRetiro", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdMotivo", idMotivo);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        throw new Exception("¡Alto! No puedes eliminar este motivo porque hay miembros registrados que se retiraron por esta razón.");
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
