using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Historial
    {
        private List<Medico> listaMedicosPacientesAtendidos;
        private string medicoConMasPacientes;
        private string medicoConMenosPacientes;
        private string especialidadConMasConsultas;

        public Historial(List<Medico> listaMedicosPacientesAtendidos)
        {
            // this.listaMedicosPacientesAtendidos = listaMedicosPacientesAtendidos;
        }

        public List<Medico> ListaMedicosPacientesAtendidos { get => listaMedicosPacientesAtendidos; set => listaMedicosPacientesAtendidos = value; }
    }
}
