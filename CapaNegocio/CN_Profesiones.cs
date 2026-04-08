using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaNegocio
{
    public class CN_Profesiones
    {
        private CD_Profesiones objDatos = new CD_Profesiones();

        // metodos para los catalogos
        public DataTable Mostrar()
        {
            return objDatos.ListarProfesiones();
        }

        public void Insertar(string descripcion)
        {
            // Regla de negocio básica: Que no intenten guardar un texto en blanco
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                throw new Exception("La descripción de la profesión no puede estar vacía.");
            }

            objDatos.InsertarProfesion(descripcion);
        }

        public void Editar(int id, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                throw new Exception("La descripción de la profesión no puede estar vacía.");
            }

            objDatos.EditarProfesion(id, descripcion);
        }

        public void Eliminar(int id)
        {
            objDatos.EliminarProfesion(id);
        }
    }
}
