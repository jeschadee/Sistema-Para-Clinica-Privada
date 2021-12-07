using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Clinica
    {
        private List<Paciente> listaDeEspera;        
        private List<Medico> listaDeMedico;
        private List<Consulta> listaDeConsultas;
        private Historial historial;

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

        public void CrearPaciente(string nombre, string apellido, int edad, long dni, string obraSocial)
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
