using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Miembros
    {
        // ¡Actualizado apuntando a tu nueva base de datos BD_IGLESIA!
        private string cadenaConexion = @"Server=(localdb)\MSSQLLocalDB;Database=BD_IGLESIA;Integrated Security=true;";

        public DataTable Mostrar()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    // La consulta que trae los datos bonitos (con los nombres en vez de los números de ID)
                    string query = @"
                        SELECT 
                            M.ID_Miembro,
                            M.Nombres,
                            M.Apellidos,
                            G.Descripcion AS Genero,
                            M.Fecha_Nacimiento,
                            P.Descripcion AS Profesion,
                            E.Descripcion AS Estado_Actual
                        FROM MIEMBROS M
                        INNER JOIN Cat_Genero G ON M.ID_Genero = G.ID_Genero
                        INNER JOIN Cat_Estado_Miembro E ON M.ID_Estado = E.ID_Estado
                        LEFT JOIN Cat_Profesiones P ON M.ID_Profesion = P.ID_Profesion;";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cargar los miembros desde la BD: " + ex.Message);
                }
            }

            return dt;
        }
    }
}