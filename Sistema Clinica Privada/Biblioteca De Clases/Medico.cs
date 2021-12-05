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
        public Medico(string nombre, string apellido, bool estado, string especialidad) : base(nombre, apellido, estado)
        {
            this.especialidad = especialidad;
            pacientesAtendidos = 0;
        }

        public string Especialidad { get => especialidad;}
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
