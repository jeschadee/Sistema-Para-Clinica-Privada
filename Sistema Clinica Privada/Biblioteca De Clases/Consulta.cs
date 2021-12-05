using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    class Consulta
    {
        private Paciente paciente;
        private Medico medico;
        private string resultado;
        private bool estadoConsulta;

        public Consulta(Paciente paciente, Medico medico)
        {
            this.paciente = paciente;
            this.medico = medico;
            estadoConsulta = true;
        }
    }
}
