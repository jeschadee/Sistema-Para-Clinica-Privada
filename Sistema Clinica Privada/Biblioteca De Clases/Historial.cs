using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    /// <summary>
    /// Clase que administra los registros historicos
    /// </summary>
    public class Historial
    {
        private List<Medico> listaDeHistorial;

        public Historial(List<Medico> listaMedicosPacientesAtendido)
        {
            listaDeHistorial = new List<Medico>();
            listaDeHistorial = listaMedicosPacientesAtendido.OrderByDescending(x => x.PacientesAtendidos).ToList();
        }

        public List<Medico> ListaDeHistorial { get => listaDeHistorial; set => listaDeHistorial = value; }
    }
}
