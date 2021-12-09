using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    /// <summary>
    /// Clase de profesionales que prestan servicios
    /// </summary>
    public class Medico : Persona
    {
        private string especialidad;        
        private int pacientesAtendidos; //Numero de pacientes atendidos.
        /// <summary>
        /// Lista de espera personal del medico
        /// </summary>
        private List<Paciente> listaDeEsperaDelMedico; //Lista de espera personal del medico
        public Medico(string nombre, string apellido) : base(nombre, apellido, false)
        {
            especialidad = "";
        }
        public Medico(string nombre, string apellido, bool estado, string especialidad) : base(nombre, apellido, estado)
        {
            this.especialidad = especialidad;
            PacientesAtendidos = 0;
            ListaDeEsperaDelMedico = new List<Paciente>();
        }
        /// <summary>
        /// Metodo polimorfico sobreescrito de la clase heredada Persona
        /// </summary>
        public override void Chismear()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metodo sobreescrito de la clase virtual base
        /// </summary>
        /// <returns>Forma de informarse</returns>
        public override string Informarse()
        {
            return base.Informarse() + " Libro de Anatomia";
        }
        /// <summary>
        /// Se suma 1 a los pacientes atendidos
        /// </summary>
        public void AgregarCantidadDePacientesAtendidos()
        {
            PacientesAtendidos++;
        }

        public string Especialidad { get => especialidad;}
        public List<Paciente> ListaDeEsperaDelMedico { get => listaDeEsperaDelMedico; set => listaDeEsperaDelMedico = value; }
        public int PacientesAtendidos { get => pacientesAtendidos; set => pacientesAtendidos = value; }

        /// <summary>
        /// Un medico es igual si tiene el mismo nombre y apellido
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return this.Nombre == ((Medico)obj).Nombre && this.Apellido == ((Medico)obj).Apellido;
        }
        public override int GetHashCode()
        {
            return Apellido.GetHashCode();
        }
        public static explicit operator Medico(Paciente p)
        {
            Medico medico = new Medico(p.Nombre, p.Apellido);
            return medico;
        }
    }
}
