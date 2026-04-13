using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_Conexiones
    {

        //Declaramos nuestras variables privadas
        private string Base, servidor, usuario, clave;
        private bool seguridad;

        //declaramos objetos estáticos de tipo conexión, nos genera una instancia al objeto conexión
        private static CD_Conexiones con = null;

        private CD_Conexiones()
        {
            //Inicializamos nuestras variables privadas
            this.Base = "BDNazareno";
            this.servidor = "DESKTOP-2H6A21O";
            this.seguridad = true;
        }

        //definimos el tipo de método que utilizaremos para la conexion a la base de datos
        public SqlConnection CrearConexion()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = this.servidor;
            builder.InitialCatalog = this.Base;
            builder.IntegratedSecurity = this.seguridad;

            // Esto evita errores de timeout y fuerza el protocolo TCP/IP si es necesario
            builder.ConnectTimeout = 15;
            builder.TrustServerCertificate = true; // Muy importante en versiones nuevas de .NET

            return new SqlConnection(builder.ConnectionString);
        }

        //metodo para generar una instancia al constructor

        public static CD_Conexiones getInstancia()
        {
            if (con == null)
            {
                con = new CD_Conexiones();
            }
            return con;

        }
    }
}
