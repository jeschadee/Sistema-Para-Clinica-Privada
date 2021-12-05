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
    public partial class FormListaDeEspera : Form
    {
        //Declaracion de entidades
        private Clinica clinica;
        private ErrorProvider erp = new ErrorProvider();
        int edad;
        long dni;
        private IconButton currentBtn;
        public FormListaDeEspera(IconButton currentBtn)
        {
            InitializeComponent();
            clinica = new Clinica();
            this.currentBtn = currentBtn;
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
        private void BotonInsertar_Click(object sender, EventArgs e)
        {
            //Validamos que los datos sean correctos
            if(ValidarPaciente())
            {
                //Agregamos Informacion                
                clinica.CrearPaciente(textBoxNombre.Text,textBoxApellido.Text,edad,dni,comboBoxOS.Text);
                dataGridViewPacientes.Rows.Clear();
                dataGridViewPacientes.Refresh();
                foreach (Paciente paciente in clinica.listaDeEspera)
                {
                    int n = dataGridViewPacientes.Rows.Add();
                    dataGridViewPacientes.Rows[n].Cells[0].Value = paciente.Nombre;
                    dataGridViewPacientes.Rows[n].Cells[1].Value = paciente.Apellido;
                    dataGridViewPacientes.Rows[n].Cells[2].Value = paciente.Edad;
                    dataGridViewPacientes.Rows[n].Cells[3].Value = paciente.Dni;
                    dataGridViewPacientes.Rows[n].Cells[4].Value = paciente.ObraSocial;
                }
                //Dejamos en blanco las casillas de texto
                LimpiarCeldas();
            }
        }
        public void LimpiarCeldas()
        {
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxEdad.Text = "";
            textBoxEdad.Text = "";
            textBoxDNI.Text = "";
            comboBoxOS.Text = "";
        }
        private bool ValidarPaciente()
        {            
            if(!string.IsNullOrEmpty(textBoxNombre.Text))
            {
                if(!string.IsNullOrEmpty(textBoxApellido.Text))
                {
                    if((int.TryParse(textBoxEdad.Text, out edad) || !(textBoxEdad.Text == ""))&& edad>0 && edad <=130)
                    {
                        if((long.TryParse(textBoxDNI.Text, out dni) || !(textBoxDNI.Text == ""))&& dni>0)
                        {
                            if(!string.IsNullOrEmpty(comboBoxOS.Text))
                            {
                                erp.SetError(comboBoxOS, "");
                                erp.SetError(textBoxDNI, "");
                                erp.SetError(textBoxEdad, "");
                                erp.SetError(textBoxApellido, "");
                                erp.SetError(textBoxNombre, "");
                                return true;
                            }
                            else
                            {
                                erp.SetError(comboBoxOS, "Ingrese una Obra Social");
                                return false;
                            }
                        }
                        else
                        {
                            erp.SetError(textBoxDNI, "Ingrese un dni valido");
                            return false;
                        }
                    }
                    else
                    {
                        erp.SetError(textBoxEdad, "Ingrese una edad valida");
                        return false;
                    }
                }
                else
                {
                    erp.SetError(textBoxApellido, "Ingrese un apellido");
                    return false;
                }
            }
            else
            {
                erp.SetError(textBoxNombre, "Ingrese un nombre");
                return false;
            }
        }

        private void FormListaDeEspera_Load(object sender, EventArgs e)
        {
            clinica.CrearPaciente("Dayana", "Mendoza", 35, 42557785, "Cobertura Completa");
            clinica.CrearPaciente("Wiliam", "Smith", 50, 50759635, "No Tiene");

            foreach (Paciente paciente in clinica.listaDeEspera)
            {
                int n = dataGridViewPacientes.Rows.Add();
                dataGridViewPacientes.Rows[n].Cells[0].Value = paciente.Nombre;
                dataGridViewPacientes.Rows[n].Cells[1].Value = paciente.Apellido;
                dataGridViewPacientes.Rows[n].Cells[2].Value = paciente.Edad;
                dataGridViewPacientes.Rows[n].Cells[3].Value = paciente.Dni;
                dataGridViewPacientes.Rows[n].Cells[4].Value = paciente.ObraSocial;
            }
            //Dejamos en blanco las casillas de texto
            LimpiarCeldas();
        }

        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            BotonDesactivado();
        }
    }
}
