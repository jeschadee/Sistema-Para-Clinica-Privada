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

namespace FrmEntrada
{
    public partial class ListaDeMedicos : Form
    {        
        private Clinica clinica;
        private ErrorProvider erp = new ErrorProvider();
        private IconButton currentBtn;
        public ListaDeMedicos(IconButton iconButton)
        {
            InitializeComponent();
            clinica = new Clinica();
            this.currentBtn = iconButton;
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

        private void ListaDeMedicos_Load(object sender, EventArgs e)
        {
            clinica.CrearMedico("Jesus", "Colmenares", "Cirujano Plastico");
            clinica.CrearMedico("Sebastian", "Castellanos", "Psiquiatra");
            clinica.CrearMedico("Mia", "Kalifa", "Internista");

            foreach (Medico medico in clinica.listaDeMedico)
            {
                int n = dataGridViewMedicos.Rows.Add();
                dataGridViewMedicos.Rows[n].Cells[0].Value = medico.Nombre;
                dataGridViewMedicos.Rows[n].Cells[1].Value = medico.Apellido;
                dataGridViewMedicos.Rows[n].Cells[2].Value = medico.Especialidad;
                dataGridViewMedicos.Rows[n].Cells[3].Value = medico.Estado;
            }

        }

        private void BotonInsertar_Click(object sender, EventArgs e)
        {
            if(ValidarMedico())
            {
                //Agregamos informacion
                clinica.CrearMedico(textBoxNombre.Text, textBoxApellido.Text, textBoxEspecialidad.Text);
                //Refrescamos el datagridview
                dataGridViewMedicos.Rows.Clear();
                dataGridViewMedicos.Refresh();
                //Volvemos a imprimir la lista con los datos actualizados
                foreach(Medico medico in clinica.listaDeMedico)
                {
                    int n = dataGridViewMedicos.Rows.Add();
                    dataGridViewMedicos.Rows[n].Cells[0].Value = medico.Nombre;
                    dataGridViewMedicos.Rows[n].Cells[1].Value = medico.Apellido;
                    dataGridViewMedicos.Rows[n].Cells[2].Value = medico.Especialidad;
                    dataGridViewMedicos.Rows[n].Cells[3].Value = medico.Estado;
                }
                //Dejamos en blanco las casillas de texto
                textBoxNombre.Text = "";
                textBoxApellido.Text = "";
                textBoxEspecialidad.Text = "";
            }
        }
        private bool ValidarMedico()
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

        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            BotonDesactivado();
        }
    }
}
