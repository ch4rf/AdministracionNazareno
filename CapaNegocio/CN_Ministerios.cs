using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Ministerios
    {
        private CD_Ministerios objDatos = new CD_Ministerios();

        public DataTable Mostrar()
        {
            return objDatos.MostrarMinisterios();
        }

        public void Insertar(string nombre)
        {
            // Validamos que no nos manden un ministerio en blanco
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception("El nombre del ministerio no puede estar vacío.");
            }

            objDatos.InsertarMinisterio(nombre);
        }

        public void Editar(int id, string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception("El nombre del ministerio no puede estar vacío.");
            }

            objDatos.EditarMinisterio(id, nombre);
        }

        public void Eliminar(int id)
        {
            objDatos.EliminarMinisterio(id);
        }
    }
}
