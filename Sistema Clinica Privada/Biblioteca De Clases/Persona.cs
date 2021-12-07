using System;

namespace BibliotecaDeClases
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private bool estado;

        public Persona(string nombre, string apellido, bool estado)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Estado = estado;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
