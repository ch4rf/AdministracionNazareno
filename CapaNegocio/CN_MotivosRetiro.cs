using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace CapaNegocio
{
    public class CN_MotivosRetiro
    {
        private CD_MotivosRetiro objDatos = new CD_MotivosRetiro();

        public DataTable Mostrar()
        {
            return objDatos.MostrarMotivos();
        }

        public void Insertar(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                throw new Exception("La descripción del motivo de retiro no puede estar vacía.");
            }

            objDatos.InsertarMotivo(descripcion);
        }

        public void Editar(int id, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                throw new Exception("La descripción del motivo de retiro no puede estar vacía.");
            }

            objDatos.EditarMotivo(id, descripcion);
        }

        public void Eliminar(int id)
        {
            objDatos.EliminarMotivo(id);
        }
    }
}
