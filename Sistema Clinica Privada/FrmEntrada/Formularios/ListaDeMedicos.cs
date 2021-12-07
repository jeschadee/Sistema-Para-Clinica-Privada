using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;
using FontAwesome.Sharp;
using System.Text.RegularExpressions;
namespace FrmEntrada
{
    public partial class ListaDeMedicos : Form
    {        
        private Clinica clinica;
        private ErrorProvider erp = new ErrorProvider();
        private IconButton currentBtn;

        public Clinica Clinica { get => clinica; set => clinica = value; }

        public ListaDeMedicos(IconButton iconButton, List<Medico> listaDeMedicos)
        {
            InitializeComponent();
            clinica = new Clinica();
            this.currentBtn = iconButton;
            clinica.ListaDeMedico = listaDeMedicos;
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
        public void LimpiarCeldas()
        {
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxEspecialidad.Text = "";
        }

        private void ListaDeMedicos_Load(object sender, EventArgs e)
        {
            foreach (Medico medico in clinica.ListaDeMedico)
            {
                int n = dataGridViewMedicos.Rows.Add();
                dataGridViewMedicos.Rows[n].Cells[0].Value = medico.Nombre;
                dataGridViewMedicos.Rows[n].Cells[1].Value = medico.Apellido;
                dataGridViewMedicos.Rows[n].Cells[2].Value = medico.Especialidad;
                if(medico.Estado == true)
                {
                    dataGridViewMedicos.Rows[n].Cells[3].Value = "Si";
                }
                else
                {
                    dataGridViewMedicos.Rows[n].Cells[3].Value = "No";
                }
            }
            LimpiarCeldas();
        }

        private void BotonInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (ValidarMedico())
                {   //Agregamos informacion
                    clinica.CrearMedico(textBoxNombre.Text, textBoxApellido.Text, textBoxEspecialidad.Text);
                    //Refrescamos el datagridview
                    dataGridViewMedicos.Rows.Clear();
                    dataGridViewMedicos.Refresh();
                    //Volvemos a imprimir la lista con los datos actualizados
                    foreach (Medico medico in clinica.ListaDeMedico)
                    {
                        int n = dataGridViewMedicos.Rows.Add();
                        dataGridViewMedicos.Rows[n].Cells[0].Value = medico.Nombre;
                        dataGridViewMedicos.Rows[n].Cells[1].Value = medico.Apellido;
                        dataGridViewMedicos.Rows[n].Cells[2].Value = medico.Especialidad;
                        dataGridViewMedicos.Rows[n].Cells[3].Value = medico.Estado;
                    }
                    //Dejamos en blanco las casillas de texto
                    LimpiarCeldas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool ValidarMedico()
        {
            Regex valor = new Regex(@"^[a-zA-Z]+$");
            if(valor.IsMatch(textBoxApellido.Text))
            {
                if(valor.IsMatch(textBoxNombre.Text))
                {
                    if (!string.IsNullOrEmpty(textBoxNombre.Text))
                    {
                        if (!string.IsNullOrEmpty(textBoxApellido.Text))
                        {
                            if (!string.IsNullOrEmpty(textBoxEspecialidad.Text))
                            {
                                erp.SetError(textBoxEspecialidad, "");
                                erp.SetError(textBoxApellido, "");
                                erp.SetError(textBoxNombre, "");
                                return true;
                            }
                            else
                            {
                                erp.SetError(textBoxEspecialidad, "Ingrese una edad valida");
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
                else
                {
                    erp.SetError(textBoxNombre, "Ingrese letras");
                    return false;
                }
            }
            else
            {
                erp.SetError(textBoxApellido, "Ingrese letras");
                return false;
            }
        }

        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            BotonDesactivado();
        }
    }
}
