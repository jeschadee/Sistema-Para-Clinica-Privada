using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Consulta
    {
        private Paciente paciente;
        private Medico medico;
        private string resultado;

        public Consulta(Medico medico, Paciente paciente)
        {
            this.Paciente = paciente;
            this.Medico = medico;
        }

        public Paciente Paciente { get => paciente; set => paciente = value; }
        public Medico Medico { get => medico; set => medico = value; }
        public string Resultado { get => resultado; set => resultado = value; }

        public override bool Equals(object obj)
        {
            return obj is Consulta consulta &&
                   EqualityComparer<Paciente>.Default.Equals(Paciente, consulta.Paciente) &&
                   EqualityComparer<Medico>.Default.Equals(Medico, consulta.Medico);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Paciente, Medico);
        }
    }
}
