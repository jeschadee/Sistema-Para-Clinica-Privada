using System;

namespace BibliotecaDeClases
{
    /// <summary>
    /// Clase Padre que define a las personas
    /// </summary>
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        /// <summary>
        /// Representa en booleano si esta actualmente en una consulta
        /// </summary>
        private bool estado;

        public Persona(string nombre, string apellido, bool estado)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Estado = estado;
        }

        public abstract void Chismear();//Metodo abstracto
        public virtual string Informarse()//Metodo virtual
        {
            return "Tomando informacion de ";
        }


        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        /// <summary>
        /// Representa en booleano si esta actualmente en una consulta
        /// </summary>
        public bool Estado { get => estado; set => estado = value; }
    }
}
