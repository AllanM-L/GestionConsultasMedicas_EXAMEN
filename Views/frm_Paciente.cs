namespace GestionConsultasMedicas.Views
{
    using GestionConsultasMedicas.Controllers;
    using GestionConsultasMedicas.Models;
    using System;
    using System.Linq;
    using System.Windows.Forms;
    //seguridad
    public partial class frm_Paciente : Form
    {
        private PacienteController pacienteController = new PacienteController();

        public frm_Paciente()
        {
            InitializeComponent();
            lblIdPaciente.Visible = false;
            txtIdPaciente.Visible = false;
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente nuevoPaciente = new Paciente
                {
                    Nombre = txtNombrePaciente.Text,
                    Edad = Convert.ToInt32(txtEdadPaciente.Text),
                    Telefono = txtTelefonoPaciente.Text 
                };
                pacienteController.AgregarPaciente(nuevoPaciente);
                MessageBox.Show("Paciente agregado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar paciente: " + ex.Message);
            }
        }

        private void btnVerPacientes_Click(object sender, EventArgs e)
        {
            var pacientes = pacienteController.ObtenerPacientes();
            if (pacientes.Count == 0)
            {
                MessageBox.Show("No hay pacientes registrados.");
            }
            else
            {
                dgvPacientes.DataSource = pacientes;
            }
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            //Visibilidad de los controles para el ID del paciente
            lblIdPaciente.Visible = true;
            txtIdPaciente.Visible = true;

            int idPaciente;
            if (int.TryParse(txtIdPaciente.Text, out idPaciente))
            {
                try
                {
                    pacienteController.EliminarPaciente(idPaciente);
                    MessageBox.Show("Paciente eliminado exitosamente.");
                    CargarPacientes(); // Recargar la lista de pacientes
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                
                MessageBox.Show("Por favor ingrese un ID de paciente válido.");
            }
        }

        private void CargarPacientes()
        {
            var pacientes = pacienteController.ObtenerPacientes();
            dgvPacientes.DataSource = pacientes;
        }

        private void frm_Paciente_Load(object sender, EventArgs e)
        {
           
        }
    }
}






