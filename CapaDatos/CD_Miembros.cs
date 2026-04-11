using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Miembros
    {
        // 1. Mostrar todos los miembros (Para la Grilla)
        public DataTable ListarMiembros()
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = CD_Conexiones.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("sp_MostrarMiembros", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los miembros: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return dt;
        }

        // 2. Buscar un solo miembro (Para editar)
        public DataTable BuscarMiembroPorID(int idMiembro)
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = CD_Conexiones.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("sp_BuscarMiembroPorID", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdMiembro", idMiembro);
                conexion.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar los datos del miembro: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return dt;
        }

        // 3. Insertar Miembro
        public void InsertarMiembro(int idFamilia, string rolFamiliar, string dpi, string nombres, string apellidos, int idGenero, DateTime? fechaNacimiento, int idProfesion, string telefono, string correo, DateTime? fechaBautismo, DateTime? fechaRecepcion, int idRecepcion, int idEstado, int idMotivoRetiro, DateTime? fechaRetiro, int idAsentamiento, string calleAvenida, string referenciaCasa)
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = CD_Conexiones.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("sp_InsertarMiembro", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdFamilia", idFamilia == 0 ? (object)DBNull.Value : idFamilia);
                cmd.Parameters.AddWithValue("@RolFamiliar", string.IsNullOrEmpty(rolFamiliar) ? (object)DBNull.Value : rolFamiliar);
                cmd.Parameters.AddWithValue("@DPI", string.IsNullOrEmpty(dpi) ? (object)DBNull.Value : dpi);
                cmd.Parameters.AddWithValue("@Nombres", nombres);
                cmd.Parameters.AddWithValue("@Apellidos", apellidos);
                cmd.Parameters.AddWithValue("@IdGenero", idGenero == 0 ? (object)DBNull.Value : idGenero);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento.HasValue ? (object)fechaNacimiento.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@IdProfesion", idProfesion == 0 ? (object)DBNull.Value : idProfesion);
                cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrEmpty(telefono) ? (object)DBNull.Value : telefono);
                cmd.Parameters.AddWithValue("@Correo", string.IsNullOrEmpty(correo) ? (object)DBNull.Value : correo);
                cmd.Parameters.AddWithValue("@FechaBautismo", fechaBautismo.HasValue ? (object)fechaBautismo.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaRecepcion", fechaRecepcion.HasValue ? (object)fechaRecepcion.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@IdRecepcion", idRecepcion == 0 ? (object)DBNull.Value : idRecepcion);
                cmd.Parameters.AddWithValue("@IdEstado", idEstado == 0 ? (object)DBNull.Value : idEstado);
                cmd.Parameters.AddWithValue("@IdMotivoRetiro", idMotivoRetiro == 0 ? (object)DBNull.Value : idMotivoRetiro);
                cmd.Parameters.AddWithValue("@FechaRetiro", fechaRetiro.HasValue ? (object)fechaRetiro.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@IdAsentamiento", idAsentamiento == 0 ? (object)DBNull.Value : idAsentamiento);
                cmd.Parameters.AddWithValue("@CalleAvenida", string.IsNullOrEmpty(calleAvenida) ? (object)DBNull.Value : calleAvenida);
                cmd.Parameters.AddWithValue("@ReferenciaCasa", string.IsNullOrEmpty(referenciaCasa) ? (object)DBNull.Value : referenciaCasa);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Error al registrar: " + ex.Message); }
            finally { if (conexion.State == ConnectionState.Open) conexion.Close(); }
        }

        // 4. Editar Miembro
        public void EditarMiembro(int idMiembro, int idFamilia, string rolFamiliar, string dpi, string nombres, string apellidos, int idGenero, DateTime? fechaNacimiento, int idProfesion, string telefono, string correo, DateTime? fechaBautismo, DateTime? fechaRecepcion, int idRecepcion, int idEstado, int idMotivoRetiro, DateTime? fechaRetiro, int idAsentamiento, string calleAvenida, string referenciaCasa)
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = CD_Conexiones.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("sp_EditarMiembro", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdMiembro", idMiembro); // El ID es clave aquí
                cmd.Parameters.AddWithValue("@IdFamilia", idFamilia == 0 ? (object)DBNull.Value : idFamilia);
                cmd.Parameters.AddWithValue("@RolFamiliar", string.IsNullOrEmpty(rolFamiliar) ? (object)DBNull.Value : rolFamiliar);
                cmd.Parameters.AddWithValue("@DPI", string.IsNullOrEmpty(dpi) ? (object)DBNull.Value : dpi);
                cmd.Parameters.AddWithValue("@Nombres", nombres);
                cmd.Parameters.AddWithValue("@Apellidos", apellidos);
                cmd.Parameters.AddWithValue("@IdGenero", idGenero == 0 ? (object)DBNull.Value : idGenero);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento.HasValue ? (object)fechaNacimiento.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@IdProfesion", idProfesion == 0 ? (object)DBNull.Value : idProfesion);
                cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrEmpty(telefono) ? (object)DBNull.Value : telefono);
                cmd.Parameters.AddWithValue("@Correo", string.IsNullOrEmpty(correo) ? (object)DBNull.Value : correo);
                cmd.Parameters.AddWithValue("@FechaBautismo", fechaBautismo.HasValue ? (object)fechaBautismo.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaRecepcion", fechaRecepcion.HasValue ? (object)fechaRecepcion.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@IdRecepcion", idRecepcion == 0 ? (object)DBNull.Value : idRecepcion);
                cmd.Parameters.AddWithValue("@IdEstado", idEstado == 0 ? (object)DBNull.Value : idEstado);
                cmd.Parameters.AddWithValue("@IdMotivoRetiro", idMotivoRetiro == 0 ? (object)DBNull.Value : idMotivoRetiro);
                cmd.Parameters.AddWithValue("@FechaRetiro", fechaRetiro.HasValue ? (object)fechaRetiro.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@IdAsentamiento", idAsentamiento == 0 ? (object)DBNull.Value : idAsentamiento);
                cmd.Parameters.AddWithValue("@CalleAvenida", string.IsNullOrEmpty(calleAvenida) ? (object)DBNull.Value : calleAvenida);
                cmd.Parameters.AddWithValue("@ReferenciaCasa", string.IsNullOrEmpty(referenciaCasa) ? (object)DBNull.Value : referenciaCasa);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Error al editar: " + ex.Message); }
            finally { if (conexion.State == ConnectionState.Open) conexion.Close(); }
        }

        // Tus otros métodos (Ministerios)
        public DataTable ListarMinisterios() { /* Tu código original aquí */ return new DataTable(); }
        public DataTable ListarMiembrosPorMinisterio(int id) { /* Tu código original aquí */ return new DataTable(); }
    }
}