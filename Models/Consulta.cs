namespace GestionConsultasMedicas.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Consulta
    {
        public int ID { get; set; }
        public int ID_Paciente { get; set; }
        public int ID_Medico { get; set; }
        public DateTime Fecha { get; set; }
        public string Diagnostico { get; set; }
        public int IdPaciente { get; internal set; }
        public int IdMedico { get; internal set; }
        public DateTime FechaConsulta { get; internal set; }
    }
}

