using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_Actividades
    {
        CD_Actividades objDatos = new CD_Actividades();

        public DataTable MostrarTiposActividad() => objDatos.MostrarTiposActividad();
        public DataTable MostrarLugares() => objDatos.MostrarLugaresIglesia();
        public DataTable MostrarMinisterios() => objDatos.MostrarMinisterios();
        public DataTable MostrarMiembros() => objDatos.MostrarMiembros();

        public DataTable BuscarActividades(string buscar, int? idTipo, int? idMinisterio,
            int? idLugar, int? idAnfitrion,
            DateTime fechaDesde, DateTime fechaHasta,
            TimeSpan horaInicio, TimeSpan horaFin)
            => objDatos.BuscarActividades(buscar, idTipo, idMinisterio, idLugar,
                idAnfitrion, fechaDesde, fechaHasta, horaInicio, horaFin);

        public void InsertarActividad(int idMinisterio, int idTipo, DateTime fecha,
            TimeSpan horaInicio, TimeSpan horaFin, int idLugar, int? idAnfitrion)
            => objDatos.InsertarActividad(idMinisterio, idTipo, fecha,
                horaInicio, horaFin, idLugar, idAnfitrion);

        public void EditarActividad(int idActividad, int idMinisterio, int idTipo,
            DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin,
            int idLugar, int? idAnfitrion)
            => objDatos.EditarActividad(idActividad, idMinisterio, idTipo,
                fecha, horaInicio, horaFin, idLugar, idAnfitrion);

        public void EliminarActividad(int idActividad)
            => objDatos.EliminarActividad(idActividad);
    }
}
