namespace GestionConsultasMedicas.Controllers
{
    using GestionConsultasMedicas.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    public class PacienteController
    {
        private DbConnectionController dbConnectionController;

        public PacienteController()
        {
            dbConnectionController = new DbConnectionController();
        }

        // Método para agregar un paciente a la base de datos
        public void AgregarPaciente(Paciente paciente)
        {
            using (SqlConnection connection = dbConnectionController.GetConnection())
            {
                
                string query = "INSERT INTO Pacientes (Nombre, Edad, Telefono) VALUES (@Nombre, @Edad, @Telefono)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                cmd.Parameters.AddWithValue("@Edad", paciente.Edad);
                cmd.Parameters.AddWithValue("@Telefono", paciente.Telefono);

                cmd.ExecuteNonQuery();
            }
        }

        // Método para obtener todos los pacientes de la base de datos
        public List<Paciente> ObtenerPacientes()
        {
            List<Paciente> pacientes = new List<Paciente>();

            using (SqlConnection connection = dbConnectionController.GetConnection())
            {
                
                string query = "SELECT * FROM Pacientes";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Paciente paciente = new Paciente
                    {
                        ID = (int)reader["ID"],
                        Nombre = reader["Nombre"].ToString(),
                        Edad = (int)reader["Edad"],
                        Telefono = reader["Telefono"].ToString()
                    };

                    pacientes.Add(paciente);
                }
            }

            return pacientes;
        }

        // Método para eliminar un paciente de la base de datos
        public void EliminarPaciente(int idPaciente)
        {
            using (SqlConnection connection = dbConnectionController.GetConnection())
            {
                
                string query = "DELETE FROM Pacientes WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", idPaciente);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    throw new Exception("Paciente no encontrado o ya ha sido eliminado.");
                }
            }
        }
    }
}


