using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    /// <summary>
    /// Clase para las consultas entre un medico y un paciente
    /// </summary>
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
        
        /// <summary>
        /// Compara si un objeto es igual a una consulta si y solo si tiene el mismo medico y paciente
        /// </summary>
        /// <param name="obj">Objeto a comparar</param>
        /// <returns>booleano de la operacion de comparacion</returns>
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
