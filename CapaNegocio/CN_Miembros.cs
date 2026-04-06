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

        public DataTable MostrarMiembros()
        {
            // Aquí Saúl podría agregar reglas de negocio si fuera necesario, 
            // pero para una simple lectura, solo retorna el método de tu capa.
            return objDatos.Mostrar();
        }
    }
}
