namespace GestionConsultasMedicas.Views
{
    partial class frm_Principal
    {
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnConsulta;

        private void InitializeComponent()
        {
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Salida = new System.Windows.Forms.Button();
            this.pnl_menu.SuspendLayout();
            this.pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMedico
            // 
            this.btnMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(199)))));
            this.btnMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedico.ForeColor = System.Drawing.Color.White;
            this.btnMedico.Location = new System.Drawing.Point(12, 202);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(121, 66);
            this.btnMedico.TabIndex = 0;
            this.btnMedico.Text = "Médico";
            this.btnMedico.UseVisualStyleBackColor = false;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(199)))));
            this.btnPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.Color.White;
            this.btnPaciente.Location = new System.Drawing.Point(12, 109);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(121, 66);
            this.btnPaciente.TabIndex = 1;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.UseVisualStyleBackColor = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(199)))));
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(12, 295);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(121, 66);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnl_menu.Controls.Add(this.btn_Salida);
            this.pnl_menu.Controls.Add(this.btnMedico);
            this.pnl_menu.Controls.Add(this.btnConsulta);
            this.pnl_menu.Controls.Add(this.btnPaciente);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(152, 569);
            this.pnl_menu.TabIndex = 3;
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(223)))));
            this.pnl_Titulo.Controls.Add(this.label1);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(152, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(502, 89);
            this.pnl_Titulo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultas Médicas";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GestionConsultasMedicas.Properties.Resources.servicio_de_orientacion_medica_telefonica;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(152, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 480);
            this.panel1.TabIndex = 5;
            // 
            // btn_Salida
            // 
            this.btn_Salida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(199)))));
            this.btn_Salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salida.ForeColor = System.Drawing.Color.White;
            this.btn_Salida.Location = new System.Drawing.Point(12, 405);
            this.btn_Salida.Name = "btn_Salida";
            this.btn_Salida.Size = new System.Drawing.Size(121, 66);
            this.btn_Salida.TabIndex = 3;
            this.btn_Salida.Text = "Salir";
            this.btn_Salida.UseVisualStyleBackColor = false;
            this.btn_Salida.Click += new System.EventHandler(this.btn_Salida_Click);
            // 
            // frm_Principal
            // 
            this.ClientSize = new System.Drawing.Size(654, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Titulo);
            this.Controls.Add(this.pnl_menu);
            this.Name = "frm_Principal";
            this.Text = "Gestión Consultas Médicas";
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.pnl_menu.ResumeLayout(false);
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Salida;
    }
}
