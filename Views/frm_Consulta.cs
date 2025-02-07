namespace GestionConsultasMedicas.Views
{
    using GestionConsultasMedicas.Controllers;
    using GestionConsultasMedicas.Models;
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class frm_Consulta : Form
    {
        private ConsultaController consultaController = new ConsultaController();

        public frm_Consulta()
        {
            InitializeComponent();
            lblIdConsulta.Visible = false;
            txtIdConsulta.Visible = false;
        }

        private void frm_Consulta_Load(object sender, EventArgs e)
        {
            CargarConsultas();
        }

        private void CargarConsultas()
        {
            var consultas = consultaController.ObtenerConsultas();
            if (consultas.Count == 0)
            {
                MessageBox.Show("No hay consultas registradas.");
            }
            else
            {
                dgvConsultas.DataSource = consultas;

                // Ocultar las columnas no deseadas
                dgvConsultas.Columns["IdPaciente"].Visible = false;
                dgvConsultas.Columns["IdMedico"].Visible = false;
                dgvConsultas.Columns["FechaConsulta"].Visible = false;
            }
        }

        private void btnAgregarConsulta_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtDiagnostico.Text))
            {
                MessageBox.Show("Por favor ingrese todos los campos.");
                return;
            }

            Consulta nuevaConsulta = new Consulta
            {
                ID_Paciente = Convert.ToInt32(txtIdPaciente.Text),
                ID_Medico = Convert.ToInt32(txtIdMedico.Text),
                Fecha = dtpFechaConsulta.Value,
                Diagnostico = txtDiagnostico.Text
            };

            consultaController.AgregarConsulta(nuevaConsulta);
            MessageBox.Show("Consulta agregada exitosamente.");
            CargarConsultas();
        }

        private void btnEliminarConsulta_Click(object sender, EventArgs e)
        {
            // Asegurarnos de que haya una fila seleccionada en el DataGridView
            if (dgvConsultas.SelectedRows.Count > 0)
            {
                // Obtener el ID de la consulta seleccionada
                int idConsulta = Convert.ToInt32(dgvConsultas.SelectedRows[0].Cells["ID"].Value);

                // Confirmación antes de eliminar
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta consulta?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        consultaController.EliminarConsulta(idConsulta);
                        MessageBox.Show($"Consulta con ID {idConsulta} eliminada exitosamente.");
                        CargarConsultas(); // Recargar la lista de consultas
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar consulta: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una consulta para eliminar.");
            }
        }

        private void dgvConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIdConsulta.Text = dgvConsultas.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtIdPaciente.Text = dgvConsultas.Rows[e.RowIndex].Cells["ID_Paciente"].Value.ToString();
                txtIdMedico.Text = dgvConsultas.Rows[e.RowIndex].Cells["ID_Medico"].Value.ToString();
                dtpFechaConsulta.Value = Convert.ToDateTime(dgvConsultas.Rows[e.RowIndex].Cells["Fecha"].Value);
                txtDiagnostico.Text = dgvConsultas.Rows[e.RowIndex].Cells["Diagnostico"].Value.ToString();
            }
        }
    }
}











