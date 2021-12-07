using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Paciente : Persona
    {
        private long dni;
        private int edad;
        private string obraSocial;        
        public Paciente(string nombre, string apellido, bool estado, int edad, long dni, string obraSocial) : base(nombre, apellido, estado)
        {
            ObraSocial = obraSocial;
            Edad = edad;
            Dni = dni;
        }

        public long Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }
        public string ObraSocial { get => obraSocial; set => obraSocial = value; }

        public override bool Equals(object obj)
        {
            return this.Dni == ((Paciente)obj).Dni;
        }
        public override int GetHashCode()
        {
            return Dni.GetHashCode();
        }
    }
}
