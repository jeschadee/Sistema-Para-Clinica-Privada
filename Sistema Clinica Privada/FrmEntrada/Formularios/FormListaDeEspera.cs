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
using System.Text.RegularExpressions;
namespace FrmEntrada
{
    public partial class FormListaDeEspera : Form
    {
        //Declaracion de entidades
        private Clinica clinica;
        private ErrorProvider erp = new ErrorProvider(); //Funciona para mostrar errores
        int edad; //variable que almacena valor del textboxEdad
        long dni; //variable que almacena valor del textBoxDni
        private IconButton currentBtn; //boton actual de la pestaña de navegacion

        public Clinica Clinica { get => clinica; }

        public FormListaDeEspera(IconButton currentBtn, List<Paciente> listaPaciente)
        {
            InitializeComponent();
            clinica = new Clinica();
            this.currentBtn = currentBtn;
            clinica.ListaDeEspera = listaPaciente;
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
        //Inserta un paciente en la lista de espera al dar click sobre insertar
        private void BotonInsertar_Click(object sender, EventArgs e)
        {
            //Validamos que los datos sean correctos
            if(ValidarPaciente())
            {
                try
                {
                    //Agregamos Informacion                
                    clinica.CrearPaciente(textBoxNombre.Text, textBoxApellido.Text, edad, dni, (ObraSocial)comboBoxOS.SelectedIndex);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //Dejamos en blanco las casillas de texto
                LimpiarCeldas();
            }
        }
        /// <summary>
        /// Deja en blanco los textbox y actualiza el datagridviewPacientes
        /// </summary>
        public void LimpiarCeldas()
        {
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxEdad.Text = "";
            textBoxEdad.Text = "";
            textBoxDNI.Text = "";
            comboBoxOS.Text = "";

            dataGridViewPacientes.Rows.Clear();
            dataGridViewPacientes.Refresh();
            foreach (Paciente paciente in clinica.ListaDeEspera)
            {
                int n = dataGridViewPacientes.Rows.Add();
                dataGridViewPacientes.Rows[n].Cells[0].Value = paciente.Nombre;
                dataGridViewPacientes.Rows[n].Cells[1].Value = paciente.Apellido;
                dataGridViewPacientes.Rows[n].Cells[2].Value = paciente.Edad;
                dataGridViewPacientes.Rows[n].Cells[3].Value = paciente.Dni;
                dataGridViewPacientes.Rows[n].Cells[4].Value = paciente.ObraSocial;
            }
        }
        /// <summary>
        /// Comprueba si los valores ingresados en los textBox fueron correctos para agregar una persona
        /// </summary>
        /// <returns>Retorna true si los valores son correctos</returns>
        private bool ValidarPaciente()
        {
            Regex valor = new Regex(@"^[a-zA-Z]+$");
            if (!string.IsNullOrEmpty(textBoxNombre.Text) && valor.IsMatch(textBoxNombre.Text)) 
            {
                if(!string.IsNullOrEmpty(textBoxApellido.Text)&& valor.IsMatch(textBoxApellido.Text))
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
            //Dejamos en blanco las casillas de texto
            LimpiarCeldas();
        }
        //Al dar click sobre consulta, oculta el fomr y muestra el inicio donde se pueden hacer las consultas
        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            BotonDesactivado();
        }
        //al clickear en eliminar, se elimina el paciente seleccionado
        private void BotonEliminar_Click(object sender, EventArgs e)
        {            
            if(dataGridViewPacientes.CurrentCell.Value != null)//si hay una casilla seleccionada se procede a borrar
            {
                int posicion;
                Paciente pacienteActual = null;
                posicion = dataGridViewPacientes.CurrentCell.RowIndex;//posicion de la casilla seleccionada
                foreach (Paciente paciente in clinica.ListaDeEspera) //se recorre la lista
                {
                    if (dataGridViewPacientes.Rows[posicion].Cells[0].Value.ToString() == paciente.Nombre)
                    {
                        if (dataGridViewPacientes.Rows[posicion].Cells[1].Value.ToString() == paciente.Apellido)
                        {
                            pacienteActual = paciente;
                        }
                    }
                }
                clinica.ListaDeEspera.Remove(pacienteActual); //se elimina el paciente seleccionado
                LimpiarCeldas();
            }

        }
    }
}
