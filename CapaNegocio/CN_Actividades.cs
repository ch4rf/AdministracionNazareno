using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaNegocio
{
    public class CN_Actividades
    {
        CD_Actividades objDatos = new CD_Actividades();

        public DataTable MostrarTiposActividad() => objDatos.MostrarTiposActividad();
        public DataTable MostrarLugares() => objDatos.MostrarLugaresIglesia();
        public DataTable MostrarMinisterios() => objDatos.MostrarMinisterios();
        public DataTable MostrarMiembros() => objDatos.MostrarMiembros();
        public DataTable MostrarTiposDuracion() => objDatos.MostrarTiposDuracion();

        public DataTable BuscarActividades(string buscar, int? idTipo, int? idMinisterio,
            int? idLugar, int? idAnfitrion,
            DateTime fechaDesde, DateTime fechaHasta,
            TimeSpan? horaInicio, TimeSpan? horaFin)
            => objDatos.BuscarActividades(buscar, idTipo, idMinisterio, idLugar,
                idAnfitrion, fechaDesde, fechaHasta, horaInicio, horaFin);

        public void InsertarActividad(int idMinisterio, int idTipo,
            DateTime fecha, int? idTipoDuracion,
            TimeSpan? horaInicio, TimeSpan? horaFin,
            int idLugar, int? idAnfitrion)
            => objDatos.InsertarActividad(idMinisterio, idTipo,
                fecha, idTipoDuracion, horaInicio, horaFin, idLugar, idAnfitrion);

        public void EditarActividad(int idActividad, int idMinisterio, int idTipo,
            DateTime fecha, int? idTipoDuracion,
            TimeSpan? horaInicio, TimeSpan? horaFin,
            int idLugar, int? idAnfitrion)
            => objDatos.EditarActividad(idActividad, idMinisterio, idTipo,
                fecha, idTipoDuracion, horaInicio, horaFin, idLugar, idAnfitrion);

        public void EliminarActividad(int idActividad)
            => objDatos.EliminarActividad(idActividad);

        // ================================================================
        // CRUD CATÁLOGOS — Lugares
        // ================================================================
        public DataTable MostrarCatalogoLugares() => objDatos.MostrarCatalogoLugares();
        public void InsertarLugar(string nombre) => objDatos.InsertarLugar(nombre);
        public void EditarLugar(int id, string nombre) => objDatos.EditarLugar(id, nombre);
        public void EliminarLugar(int id) => objDatos.EliminarLugar(id);

        // ================================================================
        // CRUD CATÁLOGOS — Tipos de Actividad
        // ================================================================
        public DataTable MostrarCatalogoTiposActividad() => objDatos.MostrarCatalogoTiposActividad();
        public void InsertarTipoActividad(string descripcion) => objDatos.InsertarTipoActividad(descripcion);
        public void EditarTipoActividad(int id, string desc) => objDatos.EditarTipoActividad(id, desc);
        public void EliminarTipoActividad(int id) => objDatos.EliminarTipoActividad(id);

        // ================================================================
        // CRUD CATÁLOGOS — Tipos de Duración
        // ================================================================
        public void InsertarTipoDuracion(string descripcion, bool requiereHora)
            => objDatos.InsertarTipoDuracion(descripcion, requiereHora);

        public void EditarTipoDuracion(int id, string descripcion, bool requiereHora)
            => objDatos.EditarTipoDuracion(id, descripcion, requiereHora);

        public void EliminarTipoDuracion(int id)
            => objDatos.EliminarTipoDuracion(id);
    }

}
