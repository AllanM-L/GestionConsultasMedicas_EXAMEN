namespace GestionConsultasMedicas.Views
{
    using GestionConsultasMedicas.Controllers;
    using GestionConsultasMedicas.Models;
    using System;
    using System.Linq;
    using System.Windows.Forms;
    //seguridad
    public partial class frm_Medico : Form
    {
        private MedicoController medicoController = new MedicoController();

        public frm_Medico()
        {
            InitializeComponent();
            lblIdMedico.Visible = false;
            txtIdMedico.Visible = false;
        }

        private void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombreMedico.Text) || string.IsNullOrWhiteSpace(txtEspecialidadMedico.Text))
            {
                MessageBox.Show("Todos los campos deben ser completados.");
                return;
            }

            Medicos nuevoMedico = new Medicos
            {
                Nombre = txtNombreMedico.Text,
                Especialidad = txtEspecialidadMedico.Text
            };

            medicoController.AgregarMedico(nuevoMedico);
            MessageBox.Show("Médico agregado exitosamente");

        }


        private void btnVerMedicos_Click(object sender, EventArgs e)
        {
            var medicos = medicoController.ObtenerMedicos();
            if (medicos.Count == 0)
            {
                MessageBox.Show("No hay médicos registrados.");
            }
            else
            {
                dgvMedicos.DataSource = medicos;
            }
            CargarMedicos();
        }


        private void btnEliminarMedico_Click(object sender, EventArgs e)
        {
            //Visibilidad de los controles para el ID del médico
            lblIdMedico.Visible = true;
            txtIdMedico.Visible = true;

            int idMedico;
            if (int.TryParse(txtIdMedico.Text, out idMedico))
            {
                try
                {
                    medicoController.EliminarMedico(idMedico);
                    MessageBox.Show("Médico eliminado exitosamente.");
                    CargarMedicos(); // Recargar la lista de médicos
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                // Si la conversión falla, mostramos un mensaje de error
                MessageBox.Show("Por favor ingrese un ID de médico válido.");
            }
        }


        private void CargarMedicos()
        {
            var medicos = medicoController.ObtenerMedicos();
            dgvMedicos.DataSource = medicos;
        }


        private void frm_Medico_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}




