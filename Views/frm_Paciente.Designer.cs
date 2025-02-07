namespace GestionConsultasMedicas.Views
{
    partial class frm_Paciente
    {
        private System.Windows.Forms.Button btnAgregarPaciente;
        private System.Windows.Forms.Button btnVerPacientes;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.TextBox txtEdadPaciente;
        private System.Windows.Forms.TextBox txtTelefonoPaciente; // Agregar el TextBox para teléfono
        private System.Windows.Forms.Label lblIdPaciente;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblEdadPaciente;
        private System.Windows.Forms.Label lblTelefonoPaciente; // Agregar el Label para teléfono

        private void InitializeComponent()
        {
            this.btnAgregarPaciente = new System.Windows.Forms.Button();
            this.btnVerPacientes = new System.Windows.Forms.Button();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.txtEdadPaciente = new System.Windows.Forms.TextBox();
            this.txtTelefonoPaciente = new System.Windows.Forms.TextBox();
            this.lblIdPaciente = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblEdadPaciente = new System.Windows.Forms.Label();
            this.lblTelefonoPaciente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarPaciente
            // 
            this.btnAgregarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAgregarPaciente.Location = new System.Drawing.Point(12, 135);
            this.btnAgregarPaciente.Name = "btnAgregarPaciente";
            this.btnAgregarPaciente.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarPaciente.TabIndex = 6;
            this.btnAgregarPaciente.Text = "Agregar Paciente";
            this.btnAgregarPaciente.UseVisualStyleBackColor = false;
            this.btnAgregarPaciente.Click += new System.EventHandler(this.btnAgregarPaciente_Click);
            // 
            // btnVerPacientes
            // 
            this.btnVerPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnVerPacientes.Location = new System.Drawing.Point(118, 135);
            this.btnVerPacientes.Name = "btnVerPacientes";
            this.btnVerPacientes.Size = new System.Drawing.Size(100, 23);
            this.btnVerPacientes.TabIndex = 7;
            this.btnVerPacientes.Text = "Ver Pacientes";
            this.btnVerPacientes.UseVisualStyleBackColor = false;
            this.btnVerPacientes.Click += new System.EventHandler(this.btnVerPacientes_Click);
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarPaciente.Location = new System.Drawing.Point(224, 135);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(100, 23);
            this.btnEliminarPaciente.TabIndex = 8;
            this.btnEliminarPaciente.Text = "Eliminar Paciente";
            this.btnEliminarPaciente.UseVisualStyleBackColor = false;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(12, 175);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(460, 150);
            this.dgvPacientes.TabIndex = 9;
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(118, 21);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(241, 20);
            this.txtIdPaciente.TabIndex = 10;
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(118, 47);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(241, 20);
            this.txtNombrePaciente.TabIndex = 11;
            // 
            // txtEdadPaciente
            // 
            this.txtEdadPaciente.Location = new System.Drawing.Point(118, 73);
            this.txtEdadPaciente.Name = "txtEdadPaciente";
            this.txtEdadPaciente.Size = new System.Drawing.Size(241, 20);
            this.txtEdadPaciente.TabIndex = 12;
            // 
            // txtTelefonoPaciente
            // 
            this.txtTelefonoPaciente.Location = new System.Drawing.Point(118, 99);
            this.txtTelefonoPaciente.Name = "txtTelefonoPaciente";
            this.txtTelefonoPaciente.Size = new System.Drawing.Size(241, 20);
            this.txtTelefonoPaciente.TabIndex = 13;
            // 
            // lblIdPaciente
            // 
            this.lblIdPaciente.AutoSize = true;
            this.lblIdPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblIdPaciente.Location = new System.Drawing.Point(12, 24);
            this.lblIdPaciente.Name = "lblIdPaciente";
            this.lblIdPaciente.Size = new System.Drawing.Size(61, 13);
            this.lblIdPaciente.TabIndex = 14;
            this.lblIdPaciente.Text = "Id Paciente";
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblNombrePaciente.Location = new System.Drawing.Point(12, 50);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(89, 13);
            this.lblNombrePaciente.TabIndex = 15;
            this.lblNombrePaciente.Text = "Nombre Paciente";
            // 
            // lblEdadPaciente
            // 
            this.lblEdadPaciente.AutoSize = true;
            this.lblEdadPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblEdadPaciente.Location = new System.Drawing.Point(12, 76);
            this.lblEdadPaciente.Name = "lblEdadPaciente";
            this.lblEdadPaciente.Size = new System.Drawing.Size(77, 13);
            this.lblEdadPaciente.TabIndex = 16;
            this.lblEdadPaciente.Text = "Edad Paciente";
            // 
            // lblTelefonoPaciente
            // 
            this.lblTelefonoPaciente.AutoSize = true;
            this.lblTelefonoPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblTelefonoPaciente.Location = new System.Drawing.Point(12, 102);
            this.lblTelefonoPaciente.Name = "lblTelefonoPaciente";
            this.lblTelefonoPaciente.Size = new System.Drawing.Size(94, 13);
            this.lblTelefonoPaciente.TabIndex = 17;
            this.lblTelefonoPaciente.Text = "Teléfono Paciente";
            // 
            // frm_Paciente
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(489, 337);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.btnEliminarPaciente);
            this.Controls.Add(this.btnVerPacientes);
            this.Controls.Add(this.btnAgregarPaciente);
            this.Controls.Add(this.txtTelefonoPaciente);
            this.Controls.Add(this.txtEdadPaciente);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.lblTelefonoPaciente);
            this.Controls.Add(this.lblEdadPaciente);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.lblIdPaciente);
            this.Name = "frm_Paciente";
            this.Text = "Gestión de Pacientes";
            this.Load += new System.EventHandler(this.frm_Paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}




