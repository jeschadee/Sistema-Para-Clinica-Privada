using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Historial
    {
        private List<Medico> listaDeHistorial;
        private string medicoConMasPacientes;
        private string medicoConMenosPacientes;
        private string especialidadConMasConsultas;

        public Historial(List<Medico> listaMedicosPacientesAtendido)
        {
            listaDeHistorial = new List<Medico>();
            listaDeHistorial = listaMedicosPacientesAtendido.OrderByDescending(x => x.PacientesAtendidos).ToList();
        }

        public List<Medico> ListaDeHistorial { get => listaDeHistorial; set => listaDeHistorial = value; }
    }
}
