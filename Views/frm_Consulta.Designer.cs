namespace GestionConsultasMedicas.Views
{
    partial class frm_Consulta
    {
        /// <summary>
        /// Variable del diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se están utilizando.
        /// </summary>
        /// <param name="disposing">True si los recursos administrados deben ser eliminados; de lo contrario, False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el diseñador de Windows Forms

        /// <summary>
        /// Método necesario para el diseñador.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.btnAgregarConsulta = new System.Windows.Forms.Button();
            this.btnEliminarConsulta = new System.Windows.Forms.Button();
            this.txtIdConsulta = new System.Windows.Forms.TextBox();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.dtpFechaConsulta = new System.Windows.Forms.DateTimePicker();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.lblIdConsulta = new System.Windows.Forms.Label();
            this.lblIdPaciente = new System.Windows.Forms.Label();
            this.lblIdMedico = new System.Windows.Forms.Label();
            this.lblFechaConsulta = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.Size = new System.Drawing.Size(760, 150);
            this.dgvConsultas.TabIndex = 0;
            this.dgvConsultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultas_CellContentClick);
            // 
            // btnAgregarConsulta
            // 
            this.btnAgregarConsulta.Location = new System.Drawing.Point(40, 316);
            this.btnAgregarConsulta.Name = "btnAgregarConsulta";
            this.btnAgregarConsulta.Size = new System.Drawing.Size(171, 54);
            this.btnAgregarConsulta.TabIndex = 1;
            this.btnAgregarConsulta.Text = "Agregar Consulta";
            this.btnAgregarConsulta.UseVisualStyleBackColor = true;
            this.btnAgregarConsulta.Click += new System.EventHandler(this.btnAgregarConsulta_Click);
            // 
            // btnEliminarConsulta
            // 
            this.btnEliminarConsulta.Location = new System.Drawing.Point(270, 316);
            this.btnEliminarConsulta.Name = "btnEliminarConsulta";
            this.btnEliminarConsulta.Size = new System.Drawing.Size(171, 54);
            this.btnEliminarConsulta.TabIndex = 2;
            this.btnEliminarConsulta.Text = "Eliminar Consulta";
            this.btnEliminarConsulta.UseVisualStyleBackColor = true;
            this.btnEliminarConsulta.Click += new System.EventHandler(this.btnEliminarConsulta_Click);
            // 
            // txtIdConsulta
            // 
            this.txtIdConsulta.Location = new System.Drawing.Point(112, 184);
            this.txtIdConsulta.Name = "txtIdConsulta";
            this.txtIdConsulta.Size = new System.Drawing.Size(261, 20);
            this.txtIdConsulta.TabIndex = 3;
            this.txtIdConsulta.Visible = false;
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(112, 210);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(261, 20);
            this.txtIdPaciente.TabIndex = 4;
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Location = new System.Drawing.Point(112, 248);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.Size = new System.Drawing.Size(261, 20);
            this.txtIdMedico.TabIndex = 5;
            // 
            // dtpFechaConsulta
            // 
            this.dtpFechaConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaConsulta.Location = new System.Drawing.Point(507, 187);
            this.dtpFechaConsulta.Name = "dtpFechaConsulta";
            this.dtpFechaConsulta.Size = new System.Drawing.Size(191, 20);
            this.dtpFechaConsulta.TabIndex = 6;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(417, 244);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(294, 20);
            this.txtDiagnostico.TabIndex = 7;
            // 
            // lblIdConsulta
            // 
            this.lblIdConsulta.AutoSize = true;
            this.lblIdConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblIdConsulta.Location = new System.Drawing.Point(37, 187);
            this.lblIdConsulta.Name = "lblIdConsulta";
            this.lblIdConsulta.Size = new System.Drawing.Size(68, 13);
            this.lblIdConsulta.TabIndex = 8;
            this.lblIdConsulta.Text = "ID Consulta: ";
            this.lblIdConsulta.Visible = false;
            // 
            // lblIdPaciente
            // 
            this.lblIdPaciente.AutoSize = true;
            this.lblIdPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblIdPaciente.Location = new System.Drawing.Point(37, 213);
            this.lblIdPaciente.Name = "lblIdPaciente";
            this.lblIdPaciente.Size = new System.Drawing.Size(69, 13);
            this.lblIdPaciente.TabIndex = 9;
            this.lblIdPaciente.Text = "ID Paciente: ";
            // 
            // lblIdMedico
            // 
            this.lblIdMedico.AutoSize = true;
            this.lblIdMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblIdMedico.Location = new System.Drawing.Point(37, 251);
            this.lblIdMedico.Name = "lblIdMedico";
            this.lblIdMedico.Size = new System.Drawing.Size(62, 13);
            this.lblIdMedico.TabIndex = 10;
            this.lblIdMedico.Text = "ID Médico: ";
            // 
            // lblFechaConsulta
            // 
            this.lblFechaConsulta.AutoSize = true;
            this.lblFechaConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblFechaConsulta.Location = new System.Drawing.Point(414, 187);
            this.lblFechaConsulta.Name = "lblFechaConsulta";
            this.lblFechaConsulta.Size = new System.Drawing.Size(87, 13);
            this.lblFechaConsulta.TabIndex = 11;
            this.lblFechaConsulta.Text = "Fecha Consulta: ";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblDiagnostico.Location = new System.Drawing.Point(414, 217);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(69, 13);
            this.lblDiagnostico.TabIndex = 12;
            this.lblDiagnostico.Text = "Diagnóstico: ";
            // 
            // frm_Consulta
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(780, 407);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.lblFechaConsulta);
            this.Controls.Add(this.lblIdMedico);
            this.Controls.Add(this.lblIdPaciente);
            this.Controls.Add(this.lblIdConsulta);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.dtpFechaConsulta);
            this.Controls.Add(this.txtIdMedico);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.txtIdConsulta);
            this.Controls.Add(this.btnEliminarConsulta);
            this.Controls.Add(this.btnAgregarConsulta);
            this.Controls.Add(this.dgvConsultas);
            this.Name = "frm_Consulta";
            this.Text = "Gestión de Consultas Médicas";
            this.Load += new System.EventHandler(this.frm_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Button btnAgregarConsulta;
        private System.Windows.Forms.Button btnEliminarConsulta;
        private System.Windows.Forms.TextBox txtIdConsulta;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.DateTimePicker dtpFechaConsulta;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label lblIdConsulta;
        private System.Windows.Forms.Label lblIdPaciente;
        private System.Windows.Forms.Label lblIdMedico;
        private System.Windows.Forms.Label lblFechaConsulta;
        private System.Windows.Forms.Label lblDiagnostico;
    }
}








