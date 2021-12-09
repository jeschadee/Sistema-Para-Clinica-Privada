using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public enum ObraSocial
    {
        NoTiene = 0,
        CoberturaBasica = 1, 
        CoberturaCompleta = 2
    };
    /// <summary>
    /// Persona que solicita servicios a la clinica
    /// </summary>
    public class Paciente : Persona
    {
        private long dni;
        private int edad;
        private ObraSocial obraSocial;        
        public Paciente(string nombre, string apellido, bool estado, int edad, long dni, ObraSocial obraSocial) : base(nombre, apellido, estado)
        {
            ObraSocial = obraSocial;
            Edad = edad;
            Dni = dni;
        }
        /// <summary>
        /// Metodo polimorfico sobreescrito de la clase heredada Persona
        /// </summary>
        public override void Chismear()
        {
            //solo para mostrar, aunque medico y paciente no tienen metodos
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metodo sobreescrito de la clase virtual base
        /// </summary>
        /// <returns>Forma de informarse</returns>
        public override string Informarse()
        {
            return base.Informarse() + " Revista";
        }

        public long Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }
        public ObraSocial ObraSocial { get => obraSocial; set => obraSocial = value; }

        /// <summary>
        /// Una persona es igual a otra si solo si tienen el mismo dni
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
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
