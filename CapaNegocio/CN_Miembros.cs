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

        // metodo para mostrar los miembros
        public DataTable MostrarMiembros()
        {
            return objDatos.ListarMiembros();
        }

        // metodo para mostrar los ministerios
        public DataTable MostrarMinisterios()
        {
            return objDatos.ListarMinisterios();
        }

        // metodo para mostrar los miembros por ministerio
        public DataTable MostrarMiembrosPorMinisterio(int idMinisterio)
        {
            return objDatos.ListarMiembrosPorMinisterio(idMinisterio);
        }
    }
}
