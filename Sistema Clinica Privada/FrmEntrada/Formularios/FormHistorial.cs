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
    public partial class FormHistorial : Form
    {
        private IconButton currentBtn; //Icono actual de la pestaña de navegacion
        private Historial historial;   
        public FormHistorial(IconButton currentBtn, List<Medico> listaMedicos)
        {
            InitializeComponent();
            this.currentBtn = currentBtn;
            historial = new Historial(listaMedicos);
        }

        public Historial Historial { get => historial; set => historial = value; }
        /// <summary>
        /// Desactiva el boton en la pestaña de navegacion
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

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            //Se ordena la lista descendente por numero de pacientes atendidos
            historial.ListaDeHistorial.OrderBy(x => x.PacientesAtendidos);
            dataGridViewHistorial.Rows.Clear();
            //Se actializa la lista
            foreach(Medico medico in Historial.ListaDeHistorial)
            {
                int n = dataGridViewHistorial.Rows.Add();
                dataGridViewHistorial.Rows[n].Cells[0].Value = medico.PacientesAtendidos;
                dataGridViewHistorial.Rows[n].Cells[1].Value = medico.Nombre + " " + medico.Apellido;
            }
            //Se actualizan los textos
            label2.Text = historial.ListaDeHistorial.First().Nombre + " " + historial.ListaDeHistorial.First().Apellido;
            label3.Text = historial.ListaDeHistorial.First().Especialidad;
            label5.Text = historial.ListaDeHistorial.Last().Nombre + " " + historial.ListaDeHistorial.Last().Apellido;
        }
    }
}
