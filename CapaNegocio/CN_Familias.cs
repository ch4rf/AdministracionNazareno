using System;
using System.Data;
using CapaDatos; // Importante para reconocer a CD_Familias

namespace CapaNegocio
{
    public class CN_Familias
    {
        // Instanciamos la clase de Datos para poder usar sus métodos
        private CD_Familias objetoCD = new CD_Familias();

        public void GuardarNuevaFamilia(string pApe, string sApe, string nomFam, string dir)
        {
            // --- VALIDACIONES DE NEGOCIO ---
            // Aquí evitamos que entren datos vacíos a la BD

            if (string.IsNullOrWhiteSpace(pApe))
            {
                throw new Exception("El primer apellido es obligatorio para crear la familia.");
            }

            if (string.IsNullOrWhiteSpace(nomFam) || nomFam == "Esperando apellidos...")
            {
                throw new Exception("El nombre de la familia no se ha generado correctamente.");
            }

            // Si todo está bien, mandamos a llamar a la Capa de Datos
            try
            {
                objetoCD.InsertarFamilia(pApe, sApe, nomFam, dir);
            }
            catch (Exception ex)
            {
                // Re-lanzamos el error para que la Capa de Presentación lo muestre
                throw new Exception("Error en la Capa de Negocio: " + ex.Message);
            }
        }
        public DataTable MostrarFamilias()
        {
            return objetoCD.ListarFamilias();
        }

        public void QuitarMiembro(int idMiembro)
        {
            objetoCD.EliminarMiembro(idMiembro);
        }

        public string BorrarFamilia(int idFamilia)
        {
            // Verificamos si tiene miembros
            if (objetoCD.ContarMiembros(idFamilia) > 0)
            {
                return "No se puede eliminar la familia porque tiene miembros asociados.";
            }

            // Si no tiene miembros, procedemos
            objetoCD.EliminarFamilia(idFamilia);
            return "OK";
        }
       
    }
}