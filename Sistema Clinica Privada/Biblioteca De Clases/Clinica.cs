using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public enum especialidad
    {
        Internista,
        Cardiologo,
        Radiologo,
        Neumonologo,
        Urologo
    }
    public enum obraSocial
    {
        NoTiene,
        CoberturaBasica,
        CoberturaCompleta
    }
    public class Clinica
    {
        public List<Paciente> listaDeEspera;
        public List<Medico> listaDeMedico;

        public Clinica()
        {
            listaDeEspera = new List<Paciente>();
            listaDeMedico = new List<Medico>();
        }
        public void CrearMedico(string nombre, string apellido, string especialidad)
        {
            try
            {
                Medico medico = new Medico(nombre, apellido, false, especialidad);
                AgregarMedico(listaDeMedico, medico);
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void AgregarMedico(List<Medico> listaMedico, Medico medico)
        {
            if (listaMedico.Contains(medico))
            {
                throw new MiExepcion("El nombre y apellido ingresado ya lo contiene un medico registrado");
            }
            else
            {
                listaDeMedico.Add(medico);
            }
        }

        public void CrearPaciente(string nombre, string apellido, int edad, long dni, string obraSocial)
        {
            try
            {
                Paciente paciente = new Paciente(nombre, apellido, false, edad, dni, obraSocial);
                AgregarPaciente(listaDeEspera, paciente);
            }
            catch(Exception)
            {
                throw ;
            }
        }
        public void AgregarPaciente(List<Paciente> listaPaciente, Paciente paciente)
        {
            if(listaPaciente.Contains(paciente))
            {
                throw new MiExepcion("El dni ingresado ya lo contiene un paciente registrado"); 
            }
            else
            {
                listaDeEspera.Add(paciente);
            }
        }

        


    }    
}
