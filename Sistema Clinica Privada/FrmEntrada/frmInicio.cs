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

namespace FrmEntrada
{
    public partial class frmInicio : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form formActual;
        public frmInicio()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        private void BotonActivado(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                BotonDesactivado();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(30, 96, 145);
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
                currentBtn.BackColor = Color.FromArgb(24, 78, 119);
                currentBtn.ForeColor = Color.FromArgb(217, 237, 146);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(217, 237, 146);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconDashboard_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, Color.FromArgb(217, 237, 146));
        }

        private void iconListaDeMedicos_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, Color.FromArgb(217, 237, 146));
        }

        private void iconListaDeEspera_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, Color.FromArgb(217, 237, 146));
        }

        private void iconHistorial_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, Color.FromArgb(217, 237, 146));
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            BotonDesactivado();
            leftBorderBtn.Visible = false;
            iconhijo.IconChar = IconChar.Home;
            iconhijo.IconColor = Color.FromArgb(217, 237, 146);
        }
        private void AbrirIconoHijo(Form formHijo)
        {
            if(formActual != null)
            {
                formActual.Close(); 
                formActual = formHijo;
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                formHijo.Dock = DockStyle.Fill;
            }
        }


        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
