using CapaDatos;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        // --- Metodos nuevos adami de aqui para abajo
        public DataTable BuscarMiembrosSinFamilia(string ape1, string ape2, string nombre)
        {
            // Si el buscador está vacío, podemos retornar una tabla vacía o todos los huérfanos
            return objDatos.BuscarMiembrosHuerfanos(ape1, ape2, nombre);
        }

        public void VincularMiembroAFamilia(int idMiembro, int idFamilia)
        {
            // Aquí podrías validar que los IDs sean mayores a 0
            if (idMiembro > 0 && idFamilia > 0)
            {
                objDatos.AsignarFamilia(idMiembro, idFamilia);
            }
            else
            {
                throw new Exception("IDs no válidos para la asignación.");
            }
        }
        public DataTable FiltrarMiembrosPorFamilia(int idFam)
        {
            // Ahora objDatos sí encontrará el método ListarMiembrosPorFamilia
            return objDatos.ListarMiembrosPorFamilia(idFam);
        }
    }
}