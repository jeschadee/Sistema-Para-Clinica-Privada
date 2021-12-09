using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    /// <summary>
    /// Clase que controla todo el sistema, contiene metodos funcionales para controlar las entidades
    /// </summary>
    public class Clinica
    {
        /// <summary>
        /// Lista de Pacientes
        /// </summary>
        private List<Paciente> listaDeEspera;  
        /// <summary>
        /// Lista de Medicos
        /// </summary>
        private List<Medico> listaDeMedico;
        /// <summary>
        /// Lista de Consultas Activas
        /// </summary>
        private List<Consulta> listaDeConsultas;
        /// <summary>
        /// Objeto que almacena datos historicos
        /// </summary>
        private Historial historial;
        /// <summary>
        /// Lista De Pacientes
        /// </summary>
        public List<Paciente> ListaDeEspera { get => listaDeEspera; set => listaDeEspera = value; }
        public List<Medico> ListaDeMedico { get => listaDeMedico; set => listaDeMedico = value; }
        public List<Consulta> ListaDeConsultas { get => listaDeConsultas; set => listaDeConsultas = value; }
        public Historial Historial { get => historial; set => historial = value; }

        public Clinica()
        {
            ListaDeEspera = new List<Paciente>();
            ListaDeMedico = new List<Medico>();
            listaDeConsultas = new List<Consulta>();
            Historial = new Historial(ListaDeMedico);
        }
        /// <summary>
        /// Crea un Medico y lo agrega a la lista de medicos
        /// </summary>
        /// <param name="nombre">nombre del medico</param>
        /// <param name="apellido">apellido del medico</param>
        /// <param name="especialidad">especialidad del medico</param>
        public void CrearMedico(string nombre, string apellido, string especialidad)
        {
            try
            {
                Medico medico = new(nombre, apellido, false, especialidad);
                AgregarMedico(medico);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Crea una consulta, si el medico ya tiene una consulta, agrega al paciente a su lista de espera
        /// </summary>
        /// <param name="medico">Medico de la consulta</param>
        /// <param name="paciente">Paciente de la consulta</param>
        public void CrearConsulta(Medico medico, Paciente paciente)
        {
            try
            {
                if(medico.Estado == true)
                {
                    medico.ListaDeEsperaDelMedico.Add(paciente);
                }
                else
                {
                    Consulta consulta = new(medico, paciente);
                    AgregarConsulta(consulta);
                    medico.Estado = true;
                    paciente.Estado = true;
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Crea un paciente y lo agrega a la lista de espera
        /// </summary>
        /// <param name="nombre">nombre del paciente</param>
        /// <param name="apellido">apellido del paciente</param>
        /// <param name="edad">edad del paciente</param>
        /// <param name="dni">dni del paciente</param>
        /// <param name="obraSocial">obra social del paciente</param>
        public void CrearPaciente(string nombre, string apellido, int edad, long dni, ObraSocial obraSocial)
        {
            try
            {
                Paciente paciente = new(nombre, apellido, false, edad, dni, obraSocial);
                AgregarPaciente(paciente);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Agrega una consulta a la lista de consultas
        /// </summary>
        /// <param name="consulta">Consulta para agregar</param>
        public void AgregarConsulta(Consulta consulta)
        {
            if(ListaDeConsultas.Contains(consulta))
            {
                throw new MiExepcion("Esta consulta ya esta activa");
            }
            else
            {
                ListaDeConsultas.Add(consulta);
            }
        }
        /// <summary>
        /// Agrega un medico a la lista de medicos
        /// </summary>
        /// <param name="medico">Medico por agregar</param>
        public void AgregarMedico(Medico medico)
        {
            if (ListaDeMedico.Contains(medico))
            {
                throw new MiExepcion("El nombre y apellido ingresado ya lo contiene un medico registrado");
            }
            else
            {
                ListaDeMedico.Add(medico);
            }
        }
        /// <summary>
        /// Agrega un paciente a la lista de espera
        /// </summary>
        /// <param name="paciente">Paciente para agregar</param>
        public void AgregarPaciente(Paciente paciente)
        {
            if (listaDeEspera.Contains(paciente))
            {
                throw new MiExepcion("El dni ingresado ya lo contiene un paciente registrado");
            }
            else
            {
                ListaDeEspera.Add(paciente);
            }
        }

    }
}
