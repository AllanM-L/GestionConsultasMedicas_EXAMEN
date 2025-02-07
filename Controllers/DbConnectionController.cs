namespace GestionConsultasMedicas.Controllers
{
    using System;
    using System.Data.SqlClient;

    public class DbConnectionController
    {
        private readonly string connectionString = "Server=DESKTOP-6IIB0IE\\SQLEXPRESS;Database=GestionConsultasMedicas;Trusted_Connection=True;";

        public SqlConnection GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al conectar a la base de datos: " + ex.Message);
            }

        }

    }

}




