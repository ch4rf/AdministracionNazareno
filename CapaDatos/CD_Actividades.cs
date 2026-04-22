using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Actividades
    {
        private SqlConnection CrearConexion()
        {
            return CD_Conexiones.getInstancia().CrearConexion();
        }

        public DataTable MostrarTiposActividad()
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_MostrarTiposActividad", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable MostrarLugaresIglesia()
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_MostrarLugaresIglesia", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable MostrarMinisterios()
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_MostrarMinisterios", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable MostrarMiembros()
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_MostrarMiembros", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable MostrarTiposDuracion()
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_MostrarTiposDuracion", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //BUSCAR
        public DataTable BuscarActividades(string buscar, int? idTipo, int? idMinisterio,
            int? idLugar, int? idAnfitrion,
            DateTime fechaDesde, DateTime fechaHasta,
            TimeSpan? horaInicio, TimeSpan? horaFin)
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_BuscarActividades", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Buscar",
                    string.IsNullOrWhiteSpace(buscar) ? (object)DBNull.Value : buscar.Trim());
                cmd.Parameters.AddWithValue("@IdTipo",
                    idTipo.HasValue ? (object)idTipo.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@IdMinisterio",
                    idMinisterio.HasValue ? (object)idMinisterio.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@IdLugar",
                    idLugar.HasValue ? (object)idLugar.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@IdAnfitrion",
                    idAnfitrion.HasValue ? (object)idAnfitrion.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde.Date);
                cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta.Date);
                cmd.Parameters.AddWithValue("@HoraInicio",
                    horaInicio.HasValue ? (object)horaInicio.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@HoraFin",
                    horaFin.HasValue ? (object)horaFin.Value : DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //INSERTAR
        public void InsertarActividad(int idMinisterio, int idTipo,
            DateTime fecha, int? idTipoDuracion,
            TimeSpan? horaInicio, TimeSpan? horaFin,
            int idLugar, int? idAnfitrion)
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_InsertarActividad", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdMinisterio", idMinisterio);
                cmd.Parameters.AddWithValue("@IdTipo", idTipo);
                cmd.Parameters.AddWithValue("@Fecha", fecha.Date);
                cmd.Parameters.AddWithValue("@IdTipoDuracion",
                    idTipoDuracion.HasValue ? (object)idTipoDuracion.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@HoraInicio",
                    horaInicio.HasValue ? (object)horaInicio.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@HoraFin",
                    horaFin.HasValue ? (object)horaFin.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@IdLugar", idLugar);
                cmd.Parameters.AddWithValue("@IdAnfitrion",
                    idAnfitrion.HasValue ? (object)idAnfitrion.Value : DBNull.Value);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //EDITAR
        public void EditarActividad(int idActividad, int idMinisterio, int idTipo,
            DateTime fecha, int? idTipoDuracion,
            TimeSpan? horaInicio, TimeSpan? horaFin,
            int idLugar, int? idAnfitrion)
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_EditarActividad", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdActividad", idActividad);
                cmd.Parameters.AddWithValue("@IdMinisterio", idMinisterio);
                cmd.Parameters.AddWithValue("@IdTipo", idTipo);
                cmd.Parameters.AddWithValue("@Fecha", fecha.Date);
                cmd.Parameters.AddWithValue("@IdTipoDuracion",
                    idTipoDuracion.HasValue ? (object)idTipoDuracion.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@HoraInicio",
                    horaInicio.HasValue ? (object)horaInicio.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@HoraFin",
                    horaFin.HasValue ? (object)horaFin.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@IdLugar", idLugar);
                cmd.Parameters.AddWithValue("@IdAnfitrion",
                    idAnfitrion.HasValue ? (object)idAnfitrion.Value : DBNull.Value);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //ELIMINAR
        public void EliminarActividad(int idActividad)
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_EliminarActividad", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdActividad", idActividad);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //crud catalogos
        public DataTable MostrarCatalogoTiposActividad()
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_MostrarCatalogoTiposActividad", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void InsertarTipoActividad(string descripcion)
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_InsertarTipoActividad", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarTipoActividad(int idTipo, string descripcion)
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_EditarTipoActividad", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipo", idTipo);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarTipoActividad(int idTipo)
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_EliminarTipoActividad", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipo", idTipo);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //crud catalogos lugares

        public DataTable MostrarCatalogoLugares()
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_MostrarCatalogoLugares", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void InsertarLugar(string nombre)
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_InsertarLugar", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarLugar(int idLugar, string nombre)
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_EditarLugar", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdLugar", idLugar);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarLugar(int idLugar)
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_EliminarLugar", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdLugar", idLugar);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //tipos duracion
        public void InsertarTipoDuracion(string descripcion, bool requiereHora)
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_InsertarTipoDuracion", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@RequiereHora", requiereHora);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarTipoDuracion(int id, string descripcion, bool requiereHora)
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_EditarTipoDuracion", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoDuracion", id);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@RequiereHora", requiereHora);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarTipoDuracion(int id)
        {
            using (SqlConnection cn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_EliminarTipoDuracion", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoDuracion", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
