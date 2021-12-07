using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Medico : Persona
    {
        private string especialidad;
        private int pacientesAtendidos;
        private List<Paciente> listaDeEsperaDelMedico;
        public Medico(string nombre, string apellido, bool estado, string especialidad) : base(nombre, apellido, estado)
        {
            this.especialidad = especialidad;
            pacientesAtendidos = 0;
            ListaDeEsperaDelMedico = new List<Paciente>();
        }
        public void AgregarCantidadDePacientesAtendidos()
        {
            pacientesAtendidos++;
        }

        public string Especialidad { get => especialidad;}
        public List<Paciente> ListaDeEsperaDelMedico { get => listaDeEsperaDelMedico; set => listaDeEsperaDelMedico = value; }

        public override bool Equals(object obj)
        {
            return this.Nombre == ((Medico)obj).Nombre && this.Apellido == ((Medico)obj).Apellido;
        }
        public override int GetHashCode()
        {
            return Apellido.GetHashCode();
        }
    }
}
