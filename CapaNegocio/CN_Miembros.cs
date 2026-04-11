using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaNegocio
{
    public class CN_Miembros
    {
        private CD_Miembros objDatos = new CD_Miembros();

        public DataTable MostrarMiembros() { return objDatos.ListarMiembros(); }
        public DataTable MostrarMinisterios() { return objDatos.ListarMinisterios(); }
        public DataTable MostrarMiembrosPorMinisterio(int id) { return objDatos.ListarMiembrosPorMinisterio(id); }

        // --- NUEVOS MÉTODOS ---
        public DataTable BuscarMiembroPorID(int idMiembro)
        {
            return objDatos.BuscarMiembroPorID(idMiembro);
        }

        public void InsertarMiembro(int idFamilia, string rolFamiliar, string dpi, string nombres, string apellidos, int idGenero, DateTime? fechaNacimiento, int idProfesion, string telefono, string correo, DateTime? fechaBautismo, DateTime? fechaRecepcion, int idRecepcion, int idEstado, int idMotivoRetiro, DateTime? fechaRetiro, int idAsentamiento, string calleAvenida, string referenciaCasa)
        {
            objDatos.InsertarMiembro(idFamilia, rolFamiliar, dpi, nombres, apellidos, idGenero, fechaNacimiento, idProfesion, telefono, correo, fechaBautismo, fechaRecepcion, idRecepcion, idEstado, idMotivoRetiro, fechaRetiro, idAsentamiento, calleAvenida, referenciaCasa);
        }

        public void EditarMiembro(int idMiembro, int idFamilia, string rolFamiliar, string dpi, string nombres, string apellidos, int idGenero, DateTime? fechaNacimiento, int idProfesion, string telefono, string correo, DateTime? fechaBautismo, DateTime? fechaRecepcion, int idRecepcion, int idEstado, int idMotivoRetiro, DateTime? fechaRetiro, int idAsentamiento, string calleAvenida, string referenciaCasa)
        {
            objDatos.EditarMiembro(idMiembro, idFamilia, rolFamiliar, dpi, nombres, apellidos, idGenero, fechaNacimiento, idProfesion, telefono, correo, fechaBautismo, fechaRecepcion, idRecepcion, idEstado, idMotivoRetiro, fechaRetiro, idAsentamiento, calleAvenida, referenciaCasa);
        }
    }
}