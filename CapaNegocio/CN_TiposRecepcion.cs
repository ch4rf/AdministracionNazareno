using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_TiposRecepcion
    {
        private CD_TiposRecepcion objDatos = new CD_TiposRecepcion();

        public DataTable Mostrar()
        {
            return objDatos.MostrarTiposRecepcion();
        }

        public void Insertar(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                throw new Exception("La descripción no puede estar vacía.");
            }

            objDatos.InsertarTipoRecepcion(descripcion);
        }

        public void Editar(int id, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                throw new Exception("La descripción no puede estar vacía.");
            }

            objDatos.EditarTipoRecepcion(id, descripcion);
        }

        public void Eliminar(int id)
        {
            objDatos.EliminarTipoRecepcion(id);
        }
    }
}
