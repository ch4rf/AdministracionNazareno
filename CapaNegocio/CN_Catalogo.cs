using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaNegocio
{
    public class CN_Catalogo
    {
        private CD_Miembros objDatos = new CD_Miembros();

        // metodos para los catalogos
        public DataTable Mostrar()
        {
            return objDatos.ListarProfesiones();
        }

        public void Insertar(string descripcion)
        {
            objDatos.InsertarProfesion(descripcion);
        }

        public void Editar(int id, string descripcion)
        {
            objDatos.EditarProfesion(id, descripcion);
        }

        public void Eliminar(int id)
        {
            objDatos.EliminarProfesion(id);
        }
    }
}
