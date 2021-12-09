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
    /// <summary>
    /// Form que visualiza la lista de medicos
    /// </summary>
    public partial class ListaDeMedicos : Form
    {        
        private Clinica clinica;
        private ErrorProvider erp = new ErrorProvider(); //icono que muestra errores
        private IconButton currentBtn; //boton actual seleccionado de la pestaña de navegacion
        public Clinica Clinica { get => clinica; set => clinica = value; }

        public ListaDeMedicos(IconButton iconButton, List<Medico> listaDeMedicos)
        {
            InitializeComponent();
            clinica = new Clinica();
            this.currentBtn = iconButton;
            clinica.ListaDeMedico = listaDeMedicos;
        }
        /// <summary>
        /// Desactiva el boton seleccionado en la pestaña de navegacion
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
        /// <summary>
        /// Deja en blanco los textBox y actualiza el datagridviewMedicos
        /// </summary>
        public void LimpiarCeldas()
        {
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxEspecialidad.Text = "";
            dataGridViewMedicos.Rows.Clear();
            dataGridViewMedicos.Refresh();
            //Volvemos a imprimir la lista con los datos actualizados
            foreach (Medico medico in clinica.ListaDeMedico)
            {
                int n = dataGridViewMedicos.Rows.Add();
                dataGridViewMedicos.Rows[n].Cells[0].Value = medico.Nombre;
                dataGridViewMedicos.Rows[n].Cells[1].Value = medico.Apellido;
                dataGridViewMedicos.Rows[n].Cells[2].Value = medico.Especialidad;
                if (medico.Estado == true) //si el medico tiene el estado true, que imprima si, sino imprima no
                {
                    dataGridViewMedicos.Rows[n].Cells[3].Value = "Si";
                }
                else
                {
                    dataGridViewMedicos.Rows[n].Cells[3].Value = "No";
                }
            }

        }

        private void ListaDeMedicos_Load(object sender, EventArgs e)
        {
           
            LimpiarCeldas();
        }
        //Al cliquear sobre insertar, agrega un medico
        private void BotonInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (ValidarMedico())
                {   //Agregamos informacion
                    clinica.CrearMedico(textBoxNombre.Text, textBoxApellido.Text, textBoxEspecialidad.Text);                                    
                    //Dejamos en blanco las casillas de texto
                    LimpiarCeldas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Valida si son correcto los datos ingresados en los textBox
        /// </summary>
        /// <returns></returns>
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
        //Al cliquear sobre el boton consulta esconde el form y muestra el inicio donde se pueden hacer consultas
        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            BotonDesactivado();
        }
        //al cliquear en el boton eliminar, eliminamos al medico seleccionado
        private void BotonEliminar_Click(object sender, EventArgs e) //Elimina un medico al hacer click
        {
            if (dataGridViewMedicos.CurrentCell.Value != null) //si hay una celda seleccionada
            {
                int posicion;
                Medico medicoActual = null;
                posicion = dataGridViewMedicos.CurrentCell.RowIndex;
                foreach (Medico medico in clinica.ListaDeMedico)
                {
                    if (dataGridViewMedicos.Rows[posicion].Cells[0].Value.ToString() == medico.Nombre)
                    {
                        if (dataGridViewMedicos.Rows[posicion].Cells[1].Value.ToString() == medico.Apellido)
                        {
                            medicoActual = medico; //Si coincide el nombre del medico y el apellido, entonces ese es el medico
                        }
                    }
                }
                clinica.ListaDeMedico.Remove(medicoActual); //eliminamos el medico seleccionado
                LimpiarCeldas();
            }
        }
    }
}
