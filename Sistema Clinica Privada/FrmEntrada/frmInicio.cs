using System;
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
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        //Inicializamos los formularios y el objeto clinica que lo controla todo
        private Clinica clinica;
        private FormHistorial formHistorial;
        private FormListaDeEspera formListaDeEspera;
        private ListaDeMedicos formListaDeMedicos;
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
            clinica.ListaDeConsultas = new List<Consulta>();
            semillaDelSistema = Environment.TickCount;
            random = new Random(semillaDelSistema);
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {            
            //Inicializamos Medicos y Pacientes
            clinica.CrearMedico("Jesus", "Colmenares", "Programador");
            clinica.CrearMedico("Sebastian", "Rodriguez", "Psiquiatra");
            clinica.CrearMedico("Sara", "Montero", "Internista");
            //Pacientes
            clinica.CrearPaciente("Paciente1", "Mendoza1", 35, 42555, "Cobertura Completa");
            clinica.CrearPaciente("Paciente2", "Smith2", 51, 50635, "No Tiene");
            clinica.CrearPaciente("Paciente3", "Mendoza3", 36, 557785, "Cobertura Completa");
            clinica.CrearPaciente("Paciente4", "Smith4", 52, 507535, "No Tiene");
            clinica.CrearPaciente("Paciente5", "Mendoza5", 37, 42585, "Cobertura Completa");
            clinica.CrearPaciente("Paciente6", "Smith6", 53, 5759635, "No Tiene");
            clinica.CrearPaciente("Paciente7", "Mendoza7", 38, 4255785, "Cobertura Completa");
            clinica.CrearPaciente("Paciente8", "Smith8", 54, 5075963, "No Tiene");
            InicializarComboBox();
            //Actualizamos listas de los forms
            ActualizarForms();
        }
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

                iconhijo.IconChar = currentBtn.IconChar;
                iconhijo.IconColor = color;

            }
        }
        private void ActualizarForms()
        {
            formHistorial = new FormHistorial(currentBtn, clinica.Historial.ListaMedicosPacientesAtendidos);
            formListaDeEspera = new FormListaDeEspera(currentBtn, clinica.ListaDeEspera);
            formListaDeMedicos = new ListaDeMedicos(currentBtn, clinica.ListaDeMedico);
        }
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
        private void btnLogo_Click(object sender, EventArgs e)
        {
            Reset();
            clinica.ListaDeEspera = formListaDeEspera.Clinica.ListaDeEspera;
            clinica.ListaDeMedico = formListaDeMedicos.Clinica.ListaDeMedico;
            //Refrescamos el datagridview
            ActualizarData();
        }
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
        private void horaFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void Fecha_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToShortDateString();
        }

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
        private void iconButtonFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewConsultas.CurrentCell.Value != null)
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
            }
            catch(Exception)
            {
                MessageBox.Show("No existe ninguna consulta para eliminar");
            }
        }

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
                stringBuilder.Append("Los medicos no tienen pacientes en espera.");
            }
            MessageBox.Show(stringBuilder.ToString());
        }

        private void dataGridViewConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult respuesta;
            Consulta consulta = null;
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
                    consulta.Medico.AgregarCantidadDePacientesAtendidos();
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

        private void checkBoxMedicosEnConsulta_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarData();
        }
    }
}
