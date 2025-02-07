namespace GestionConsultasMedicas.Views
{
    using System;
    using System.Windows.Forms;
    //seguridad
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            frm_Medico medicoForm = new frm_Medico();
            medicoForm.Show();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            frm_Paciente pacienteForm = new frm_Paciente();
            pacienteForm.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frm_Consulta consultaForm = new frm_Consulta();
            consultaForm.Show();
        }

        private void btn_Salida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}

