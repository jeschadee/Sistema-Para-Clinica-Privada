﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using BibliotecaDeClases;
namespace FrmEntrada
{
    public partial class frmInicio : Form
    {
        //Propiedades para los botones
        private IconButton currentBtn; //Icono actual del boton
        private Panel leftBorderBtn; //Borde del boton en la pestaña de navegacion que dara la ilusion de esta seleccionado
        //Creamos los formularios y el objeto clinica que lo controla todo
        private Clinica clinica;
        private FormHistorial formHistorial;
        private FormListaDeEspera formListaDeEspera;
        private ListaDeMedicos formListaDeMedicos;
        //Creamos una clase random y un entero que almacenara la semilla del sistema para dar resultados aleatorios
        private Random random;
        private int semillaDelSistema;

        public frmInicio()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
            //Creamos los Forms y les pasamos su respectivo boton currentBtn y la lista
            clinica = new Clinica();
            semillaDelSistema = Environment.TickCount;
            random = new Random(semillaDelSistema);
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {            
            //Inicializamos Medicos
            clinica.CrearMedico("Jesus", "Colmenares", "Programador");
            clinica.CrearMedico("Sebastian", "Rodriguez", "Psiquiatra");
            clinica.CrearMedico("Sara", "Montero", "Internista");
            //Pacientes
            clinica.CrearPaciente("Paciente1", "Mendoza1", 35, 42555, ObraSocial.CoberturaBasica);
            clinica.CrearPaciente("Paciente2", "Smith2", 51, 50635, ObraSocial.CoberturaCompleta);
            clinica.CrearPaciente("Paciente3", "Mendoza3", 36, 557785, ObraSocial.NoTiene);
            clinica.CrearPaciente("Paciente4", "Smith4", 52, 507535, ObraSocial.CoberturaCompleta);
            clinica.CrearPaciente("Paciente5", "Mendoza5", 37, 42585, ObraSocial.CoberturaBasica);
            clinica.CrearPaciente("Paciente6", "Smith6", 53, 5759635, ObraSocial.CoberturaBasica);
            clinica.CrearPaciente("Paciente7", "Mendoza7", 38, 4255785, ObraSocial.CoberturaCompleta);
            clinica.CrearPaciente("Paciente8", "Smith8", 54, 5075963, ObraSocial.NoTiene);
            InicializarComboBox();
            //Actualizamos listas de los forms
            ActualizarForms();
        }
        /// <summary>
        /// Da la ilusion de que el boton seleccionado en la pestaña de navegacion se activa, se agrega un panel y se mueve el icono
        /// </summary>
        /// <param name="senderBtn">Boton clickeado</param>
        /// <param name="color">Color que modificara las letras del boton</param>
        private void BotonActivado(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                BotonDesactivado();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(219, 233, 247);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icono en el centro del form
                iconhijo.IconChar = currentBtn.IconChar;
                iconhijo.IconColor = color;

            }
        }
        /// <summary>
        /// Inicializa nuevos forms con las listas actualizadas
        /// </summary>
        private void ActualizarForms()
        {
            formHistorial = new FormHistorial(currentBtn, clinica.ListaDeMedico);
            formListaDeEspera = new FormListaDeEspera(currentBtn, clinica.ListaDeEspera);
            formListaDeMedicos = new ListaDeMedicos(currentBtn, clinica.ListaDeMedico);            
            
        }
        /// <summary>
        /// Da la ilusion de que el boton se desactiva en la pestaña de navegacion, funciona con el metodo BotonActivado()
        /// </summary>
        private void BotonDesactivado()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(240, 246, 251);
                currentBtn.ForeColor = Color.FromArgb(70, 71, 115);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(70, 71, 115);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        //click en el logo, reinicia y va al inicio
        private void btnLogo_Click(object sender, EventArgs e)
        {
            Reset();
            clinica.ListaDeEspera = formListaDeEspera.Clinica.ListaDeEspera;
            clinica.ListaDeMedico = formListaDeMedicos.Clinica.ListaDeMedico;
            //Refrescamos el datagridview
            ActualizarData();
        }
        /// <summary>
        /// Vuelve a la pagina de inicio y esconde los forms secundarios, cambia el icono central al predeterminado
        /// </summary>
        private void Reset()
        {
            formListaDeEspera.Hide();
            formListaDeMedicos.Hide();
            formHistorial.Hide();
            BotonDesactivado();
            leftBorderBtn.Visible = false;
            iconhijo.IconChar = IconChar.Home;
            iconhijo.IconColor = Color.FromArgb(70, 71, 115);
            labelInicio.Text = "Inicio";
        }
        /// <summary>
        /// Deja en blanco los comboBox y actualiza sus Items
        /// </summary>
        private void InicializarComboBox()
        {
            comboBoxMedico.Items.Clear();
            comboBoxPaciente.Items.Clear();
            comboBoxMedico.Text = "";
            comboBoxPaciente.Text = "";
            foreach(Medico medico in clinica.ListaDeMedico)
            {
                if(checkBoxMedicosEnConsulta.Checked==true)
                {
                    comboBoxMedico.Items.Add(medico.Nombre + " " + medico.Apellido);
                }
                else
                {
                    if (medico.Estado == false)
                    {
                        comboBoxMedico.Items.Add(medico.Nombre + " " + medico.Apellido);
                    }                    
                }
            }
            if(clinica.ListaDeEspera != null && clinica.ListaDeEspera.Any())
            {
                comboBoxPaciente.Items.Add(clinica.ListaDeEspera.First().Nombre + " " + clinica.ListaDeEspera.First().Apellido);
            }
            foreach(Medico medico1 in clinica.ListaDeMedico)
            {
                comboBoxMedico.Items.Add(medico1.Especialidad);
            }
        }
        //Fecha
        private void horaFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToShortTimeString();
        }
        //Hora
        private void Fecha_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToShortDateString();
        }
        //Abre el form listaDeMedicos
        private void iconListaDeMedicos_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, Color.FromArgb(70, 71, 115));
            formHistorial.Hide();
            formListaDeEspera.Hide();
            formListaDeMedicos.TopLevel = false;
            formListaDeMedicos.FormBorderStyle = FormBorderStyle.None;
            formListaDeMedicos.Dock = DockStyle.Fill;
            PanelEscritorio.Controls.Add(formListaDeMedicos);
            PanelEscritorio.Tag = formListaDeMedicos;
            formListaDeMedicos.Show();
            formListaDeMedicos.BringToFront();
            labelInicio.Text = formListaDeMedicos.Text;
        }
        //Abre el form Historial
        private void iconHistorial_Click_1(object sender, EventArgs e)
        {
            BotonActivado(sender, Color.FromArgb(70, 71, 115));
            formListaDeEspera.Hide();
            formListaDeMedicos.Hide();
            formHistorial.TopLevel = false;
            formHistorial.FormBorderStyle = FormBorderStyle.None;
            formHistorial.Dock = DockStyle.Fill;
            PanelEscritorio.Controls.Add(formHistorial);
            PanelEscritorio.Tag = formHistorial;
            formHistorial.Show();
            formHistorial.BringToFront();
            labelInicio.Text = formHistorial.Text;
        }
        //abre el form listaDeEspera
        private void iconListaDeEspera_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, Color.FromArgb(70, 71, 115));            
            formHistorial.Hide();
            formListaDeMedicos.Hide(); 
            formListaDeEspera.TopLevel = false;
            formListaDeEspera.FormBorderStyle = FormBorderStyle.None;
            formListaDeEspera.Dock = DockStyle.Fill;
            PanelEscritorio.Controls.Add(formListaDeEspera);
            PanelEscritorio.Tag = formListaDeEspera;
            formListaDeEspera.Show();
            formListaDeEspera.BringToFront();
            labelInicio.Text = formListaDeEspera.Text;
        }
        //Click sobre crear consulta, verifica los datos en los comboBoxMedico y comboBoxPaciente
        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxMedico.SelectedItem != null && comboBoxPaciente.SelectedItem != null)
                {
                    string[] nombre;
                    nombre = comboBoxMedico.SelectedItem.ToString().Split(" ");
                    foreach(Medico medico in clinica.ListaDeMedico)
                    {
                        if (medico.Nombre == nombre[0])
                        {
                            clinica.CrearConsulta(clinica.ListaDeMedico.FirstOrDefault(x => x.Nombre == nombre[0]), clinica.ListaDeEspera.FirstOrDefault());
                        }
                        else if (medico.Especialidad == comboBoxMedico.Text)
                        {
                            clinica.CrearConsulta(clinica.ListaDeMedico.FirstOrDefault(x => x.Especialidad == comboBoxMedico.Text), clinica.ListaDeEspera.FirstOrDefault());
                        }
                    }
                     
                     clinica.ListaDeEspera.RemoveAt(0);
                     //Agregarmos informacion al datagridview
                     ActualizarData();
                }
                else
                {
                     MessageBox.Show("Seleccione una casilla");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Actualiza la informacion del datagridviewConsultas, InicializaComboBox y ActualizaForms
        /// </summary>
        private void ActualizarData()
        {
            dataGridViewConsultas.Rows.Clear();
            dataGridViewConsultas.Refresh();
            foreach (Consulta consulta in clinica.ListaDeConsultas)
            {
                int n = dataGridViewConsultas.Rows.Add();
                dataGridViewConsultas.Rows[n].Cells[0].Value = consulta.Medico.Nombre + " " + consulta.Medico.Apellido;
                dataGridViewConsultas.Rows[n].Cells[1].Value = consulta.Paciente.Nombre + " " + consulta.Paciente.Apellido;                
            }
            InicializarComboBox();
            ActualizarForms();
            dataGridViewConsultas.CurrentCell = null;
        }
        //Click en finalizar, finaliza la consulta seleccionada
        private void iconButtonFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewConsultas.CurrentCell != null)
                {
                    Consulta consultaActual = null;
                    int posicion;
                    Paciente pacienteListaDeEsperaMedico;
                    posicion = dataGridViewConsultas.CurrentCell.RowIndex;
                    
                        foreach (Consulta consulta in clinica.ListaDeConsultas)
                        {
                            if ((consulta.Medico.Nombre + " " + consulta.Medico.Apellido) == dataGridViewConsultas.Rows[posicion].Cells[0].Value.ToString())
                            {
                                if ((consulta.Paciente.Nombre + " " + consulta.Paciente.Apellido) == dataGridViewConsultas.Rows[posicion].Cells[1].Value.ToString())
                                {
                                    consultaActual = consulta;
                                }
                            }
                        }
                        clinica.ListaDeConsultas.Remove(consultaActual);
                        if (consultaActual.Medico.ListaDeEsperaDelMedico.Any())
                        {
                            pacienteListaDeEsperaMedico = consultaActual.Medico.ListaDeEsperaDelMedico.First();
                            consultaActual.Medico.ListaDeEsperaDelMedico.Remove(pacienteListaDeEsperaMedico);
                            consultaActual.Medico.Estado = false;
                            clinica.CrearConsulta(consultaActual.Medico, pacienteListaDeEsperaMedico);
                            consultaActual.Medico.AgregarCantidadDePacientesAtendidos();
                        }
                        else
                        {
                            consultaActual.Medico.AgregarCantidadDePacientesAtendidos();
                            consultaActual.Medico.Estado = false;
                        }
                        //Agregarmos informacion al datagridview
                        ActualizarData();
                    //Imprimimos un resultado aleatorio
                        switch (random.Next(0, 6))
                        {
                            case 0:
                                MessageBox.Show("Estamos mal, hay que hacerse más estudios", "Resultado de: " + consultaActual.Paciente.Nombre + ".", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            case 1:
                                MessageBox.Show("Necesita internarse unos días", "Resultado de:" + consultaActual.Paciente.Nombre + ".", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            case 2:
                                MessageBox.Show("Tiene COVID", "Urgente!!! Aislar Paciente: " + consultaActual.Paciente.Nombre + ".", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case 3:
                                MessageBox.Show("Se encuentra en perfecto estado", "Resultado de:" + consultaActual.Paciente.Nombre + ".");
                                break;
                            case 4:
                                MessageBox.Show("Recetar pastillas", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                break;
                            case 5:
                                MessageBox.Show("Tomar nuevamente turno con otro profesional", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                  
                }
                else
                {
                    MessageBox.Show("Seleccione una consulta a eliminar");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No existe ninguna consulta para eliminar");
            }
        }
        //Click sobre lista de espera de medicos en consulta actual
        private void iconButton2_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder("");
            
            foreach (Medico medico in clinica.ListaDeMedico)
            {
                foreach (Paciente paciente in medico.ListaDeEsperaDelMedico)
                {
                    stringBuilder.Append("Medico:" + medico.Nombre + " " + medico.Apellido + "      \t" + "Paciente:" + paciente.Nombre + " " + paciente.Apellido + "\n");                    
                }
            }
            if (stringBuilder.ToString().Equals(""))
            {
                stringBuilder.Append("No hay pacientes en espera de los medicos en consulta.");
            }
            MessageBox.Show(stringBuilder.ToString());
        }
        //Implementa la funcionalidad de eliminar con un click
        private void dataGridViewConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult respuesta;
            Consulta consulta = null;
            //hacemos un cuadro de verificacion para proceder a eliminar
            respuesta = MessageBox.Show("¿Desea eliminar la consulta seleccionada?","Eliminar Consulta", MessageBoxButtons.YesNoCancel);
            if (respuesta==DialogResult.Yes)
            {
                Paciente pacienteListaDeEsperaMedico;
                string nombre;
                string nombre2;
                string[] nombreMedico;
                string[] nombrePaciente;
                nombre = dataGridViewConsultas.Rows[e.RowIndex].Cells[0].Value.ToString();
                nombreMedico = nombre.Split(" ");
                nombre2 = dataGridViewConsultas.Rows[e.RowIndex].Cells[1].Value.ToString();
                nombrePaciente = nombre2.Split(" "); 
                foreach (Consulta consulta1 in clinica.ListaDeConsultas)
                {
                    if (consulta1.Medico.Nombre == nombreMedico[0] && consulta1.Medico.Apellido == nombreMedico[1]);
                    {
                        if (consulta1.Paciente.Nombre == nombrePaciente[0] && consulta1.Paciente.Apellido == nombrePaciente[1]);
                        {
                            consulta = consulta1;
                        }
                    }
                }
                clinica.ListaDeConsultas.Remove(consulta);
                //chequeamos que el medico que esta saliendo de consulta no tenga ningun paciente en espera, sino, lo agregamos
                if (consulta.Medico.ListaDeEsperaDelMedico.Any())
                {
                    pacienteListaDeEsperaMedico = consulta.Medico.ListaDeEsperaDelMedico.First();
                    consulta.Medico.ListaDeEsperaDelMedico.Remove(pacienteListaDeEsperaMedico);
                    consulta.Medico.Estado = false;
                    consulta.Medico.AgregarCantidadDePacientesAtendidos();
                    clinica.CrearConsulta(consulta.Medico, pacienteListaDeEsperaMedico);
                }
                else
                {
                    consulta.Medico.Estado = false;
                    consulta.Medico.AgregarCantidadDePacientesAtendidos();//Le sumamos un paciente atendido
                }
                //Agregarmos informacion al datagridview
                ActualizarData();
                switch (random.Next(0, 6))
                {
                    case 0:
                        MessageBox.Show("Estamos mal, hay que hacerse más estudios", "Resultado de: " + consulta.Paciente.Nombre + ".", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 1:
                        MessageBox.Show("Necesita internarse unos días", "Resultado de:" + consulta.Paciente.Nombre + ".", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 2:
                        MessageBox.Show("Tiene COVID", "Urgente!!! Aislar Paciente: " + consulta.Paciente.Nombre + ".", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 3:
                        MessageBox.Show("Se encuentra en perfecto estado", "Resultado de:" + consulta.Paciente.Nombre + ".");
                        break;
                    case 4:
                        MessageBox.Show("Recetar pastillas", "Resultado de:" + consulta.Paciente.Nombre + ".", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        break;
                    case 5:
                        MessageBox.Show("Tomar nuevamente turno con otro profesional", "Resultado de:" + consulta.Paciente.Nombre + ".", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            else
            {
                ActualizarData();
            }
        }
        //si activamos o desactivamos el checkBox que se actualizen los comboBox y las tablas
        private void checkBoxMedicosEnConsulta_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarData();
        }
    }
}
