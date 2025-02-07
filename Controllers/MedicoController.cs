namespace GestionConsultasMedicas.Controllers
{
    using GestionConsultasMedicas.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    //Se coloca por mayor seguridad
    public class MedicoController
    {
        private DbConnectionController dbConnectionController;

        public MedicoController()
        {
            dbConnectionController = new DbConnectionController();
        }

        // Método para agregar un médico a la base de datos
        public void AgregarMedico(Medicos medico)
        {
            try
            {
                using (SqlConnection connection = dbConnectionController.GetConnection())
                {
                    // Cambiar el nombre de la tabla de 'Medico' a 'Medicos'
                    string query = "INSERT INTO Medicos (Nombre, Especialidad) VALUES (@Nombre, @Especialidad)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Nombre", medico.Nombre);
                    cmd.Parameters.AddWithValue("@Especialidad", medico.Especialidad);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
            }
        }



        // Método para obtener todos los médicos de la base de datos
        public List<Medicos> ObtenerMedicos()
        {
            List<Medicos> medicos = new List<Medicos>();

            try
            {
                using (SqlConnection connection = dbConnectionController.GetConnection())
                {
                    string query = "SELECT * FROM Medicos";  // Cambié 'Medico' por 'Medicos'
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Medicos medico = new Medicos
                        {
                            ID = (int)reader["ID"],
                            Nombre = reader["Nombre"].ToString(),
                            Especialidad = reader["Especialidad"].ToString()
                        };

                        medicos.Add(medico);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al obtener los médicos: " + ex.Message);
            }

            return medicos;
        }

        // Método para Eliminar Médico
        public void EliminarMedico(int idMedico)
        {
            using (SqlConnection connection = dbConnectionController.GetConnection())
            {
                string query = "DELETE FROM Medicos WHERE ID = @ID";  
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", idMedico);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    throw new Exception("Médico no encontrado o ya ha sido eliminado.");
                }
            }
        }


    }
}


