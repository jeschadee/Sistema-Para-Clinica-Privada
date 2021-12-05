using System;

namespace BibliotecaDeClases
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private bool estado;

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido;}
        public bool Estado { get => estado;}

        public Persona(string nombre, string apellido, bool estado)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.estado = estado;
        }
    }
}
