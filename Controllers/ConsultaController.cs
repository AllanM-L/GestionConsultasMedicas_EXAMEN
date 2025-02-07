using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GestionConsultasMedicas.Models;

namespace GestionConsultasMedicas.Controllers
{
    public class ConsultaController
    {
        private string connectionString = "Server=DESKTOP-6IIB0IE\\SQLEXPRESS;Database=GestionConsultasMedicas;Integrated Security=True;";

        // Obtener las consultas de la base de datos
        public List<Consulta> ObtenerConsultas()
        {
            List<Consulta> consultas = new List<Consulta>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Consultas";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        consultas.Add(new Consulta
                        {
                            ID = reader.GetInt32(0),
                            ID_Paciente = reader.GetInt32(1),
                            ID_Medico = reader.GetInt32(2),
                            Fecha = reader.GetDateTime(3),
                            Diagnostico = reader.GetString(4)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las consultas: " + ex.Message);
            }
            return consultas;
        }

        // Agregar una nueva consulta a la base de datos
        public void AgregarConsulta(Consulta consulta)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Consultas (ID_Paciente, ID_Medico, Fecha, Diagnostico) VALUES (@ID_Paciente, @ID_Medico, @Fecha, @Diagnostico)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_Paciente", consulta.ID_Paciente);
                    command.Parameters.AddWithValue("@ID_Medico", consulta.ID_Medico);
                    command.Parameters.AddWithValue("@Fecha", consulta.Fecha);
                    command.Parameters.AddWithValue("@Diagnostico", consulta.Diagnostico);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar consulta: " + ex.Message);
            }
        }

        // Eliminar una consulta de la base de datos
        public void EliminarConsulta(int idConsulta)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Consultas WHERE ID = @ID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", idConsulta);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar consulta: " + ex.Message);
            }
        }
    }
}



