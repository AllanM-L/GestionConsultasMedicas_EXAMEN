namespace GestionConsultasMedicas.Views
{
    partial class frm_Medico
    {
        private System.Windows.Forms.Button btnAgregarMedico;
        private System.Windows.Forms.Button btnVerMedicos;
        private System.Windows.Forms.Button btnEliminarMedico;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.TextBox txtEspecialidadMedico;
        private System.Windows.Forms.Label lblIdMedico;
        private System.Windows.Forms.Label lblNombreMedico;
        private System.Windows.Forms.Label lblEspecialidadMedico;

        private void InitializeComponent()
        {
            this.btnAgregarMedico = new System.Windows.Forms.Button();
            this.btnVerMedicos = new System.Windows.Forms.Button();
            this.btnEliminarMedico = new System.Windows.Forms.Button();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.txtEspecialidadMedico = new System.Windows.Forms.TextBox();
            this.lblIdMedico = new System.Windows.Forms.Label();
            this.lblNombreMedico = new System.Windows.Forms.Label();
            this.lblEspecialidadMedico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarMedico
            // 
            this.btnAgregarMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAgregarMedico.Location = new System.Drawing.Point(12, 110);
            this.btnAgregarMedico.Name = "btnAgregarMedico";
            this.btnAgregarMedico.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarMedico.TabIndex = 6;
            this.btnAgregarMedico.Text = "Agregar Médico";
            this.btnAgregarMedico.UseVisualStyleBackColor = false;
            this.btnAgregarMedico.Click += new System.EventHandler(this.btnAgregarMedico_Click);
            // 
            // btnVerMedicos
            // 
            this.btnVerMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnVerMedicos.Location = new System.Drawing.Point(118, 110);
            this.btnVerMedicos.Name = "btnVerMedicos";
            this.btnVerMedicos.Size = new System.Drawing.Size(100, 23);
            this.btnVerMedicos.TabIndex = 7;
            this.btnVerMedicos.Text = "Ver Médicos";
            this.btnVerMedicos.UseVisualStyleBackColor = false;
            this.btnVerMedicos.Click += new System.EventHandler(this.btnVerMedicos_Click);
            // 
            // btnEliminarMedico
            // 
            this.btnEliminarMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarMedico.Location = new System.Drawing.Point(224, 110);
            this.btnEliminarMedico.Name = "btnEliminarMedico";
            this.btnEliminarMedico.Size = new System.Drawing.Size(100, 23);
            this.btnEliminarMedico.TabIndex = 8;
            this.btnEliminarMedico.Text = "Eliminar Médico";
            this.btnEliminarMedico.UseVisualStyleBackColor = false;
            this.btnEliminarMedico.Click += new System.EventHandler(this.btnEliminarMedico_Click);
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvMedicos.Location = new System.Drawing.Point(12, 140);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.Size = new System.Drawing.Size(460, 150);
            this.dgvMedicos.TabIndex = 9;
            this.dgvMedicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicos_CellContentClick);
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.BackColor = System.Drawing.Color.White;
            this.txtIdMedico.Location = new System.Drawing.Point(135, 21);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.Size = new System.Drawing.Size(206, 20);
            this.txtIdMedico.TabIndex = 10;
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.BackColor = System.Drawing.Color.White;
            this.txtNombreMedico.Location = new System.Drawing.Point(135, 47);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.Size = new System.Drawing.Size(206, 20);
            this.txtNombreMedico.TabIndex = 11;
            // 
            // txtEspecialidadMedico
            // 
            this.txtEspecialidadMedico.BackColor = System.Drawing.Color.White;
            this.txtEspecialidadMedico.Location = new System.Drawing.Point(135, 74);
            this.txtEspecialidadMedico.Name = "txtEspecialidadMedico";
            this.txtEspecialidadMedico.Size = new System.Drawing.Size(206, 20);
            this.txtEspecialidadMedico.TabIndex = 12;
            // 
            // lblIdMedico
            // 
            this.lblIdMedico.AutoSize = true;
            this.lblIdMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblIdMedico.Location = new System.Drawing.Point(12, 24);
            this.lblIdMedico.Name = "lblIdMedico";
            this.lblIdMedico.Size = new System.Drawing.Size(54, 13);
            this.lblIdMedico.TabIndex = 13;
            this.lblIdMedico.Text = "Id Médico";
            // 
            // lblNombreMedico
            // 
            this.lblNombreMedico.AutoSize = true;
            this.lblNombreMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblNombreMedico.Location = new System.Drawing.Point(12, 50);
            this.lblNombreMedico.Name = "lblNombreMedico";
            this.lblNombreMedico.Size = new System.Drawing.Size(82, 13);
            this.lblNombreMedico.TabIndex = 14;
            this.lblNombreMedico.Text = "Nombre Médico";
            // 
            // lblEspecialidadMedico
            // 
            this.lblEspecialidadMedico.AutoSize = true;
            this.lblEspecialidadMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblEspecialidadMedico.Location = new System.Drawing.Point(12, 77);
            this.lblEspecialidadMedico.Name = "lblEspecialidadMedico";
            this.lblEspecialidadMedico.Size = new System.Drawing.Size(105, 13);
            this.lblEspecialidadMedico.TabIndex = 15;
            this.lblEspecialidadMedico.Text = "Especialidad Médico";
            // 
            // frm_Medico
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(480, 311);
            this.Controls.Add(this.dgvMedicos);
            this.Controls.Add(this.btnEliminarMedico);
            this.Controls.Add(this.btnVerMedicos);
            this.Controls.Add(this.btnAgregarMedico);
            this.Controls.Add(this.txtEspecialidadMedico);
            this.Controls.Add(this.txtNombreMedico);
            this.Controls.Add(this.txtIdMedico);
            this.Controls.Add(this.lblEspecialidadMedico);
            this.Controls.Add(this.lblNombreMedico);
            this.Controls.Add(this.lblIdMedico);
            this.Name = "frm_Medico";
            this.Text = "Gestión de Médicos";
            this.Load += new System.EventHandler(this.frm_Medico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}




