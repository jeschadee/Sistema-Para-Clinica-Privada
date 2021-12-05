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

        private Form formActual;
        private Clinica clinica;
        private Form formHistorial;
        private Form formListaDeEspera;
        public frmInicio()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
            clinica = new Clinica();
            formHistorial = new FormHistorial(currentBtn);
            formListaDeEspera = new FormListaDeEspera(currentBtn);
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
        private void iconHistorial_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, Color.FromArgb(70, 71, 115));
            AbrirFormularioHijo(formListaDeEspera);
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            if(formActual != null)
            {
                formActual.Hide();
                Reset();
            }
        }
        private void Reset()
        {
            BotonDesactivado();
            leftBorderBtn.Visible = false;
            iconhijo.IconChar = IconChar.Home;
            iconhijo.IconColor = Color.FromArgb(70, 71, 115);
            labelInicio.Text = "Home";
        }
        //Metodo para formularios normales
        private void AbrirFormularioHijo(Form formHijo)
        {
            if (formActual != null)
            {
                formActual.Hide();
            }
            formActual = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            PanelEscritorio.Controls.Add(formHijo);
            PanelEscritorio.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
            labelInicio.Text = formHijo.Text;
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            Clinica clinica = new Clinica();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, Color.FromArgb(70, 71, 115));
            AbrirFormularioHijo(new FormHistorial(currentBtn));
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
            AbrirFormularioHijo(new ListaDeMedicos(currentBtn));
        }

        private void iconDashboard_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, Color.FromArgb(70, 71, 115));
            AbrirFormularioHijo(new FormListaDeEspera(currentBtn));
        }
    }
}
