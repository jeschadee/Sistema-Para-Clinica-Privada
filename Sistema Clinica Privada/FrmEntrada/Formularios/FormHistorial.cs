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
    public partial class FormHistorial : Form
    {
        private IconButton currentBtn;
        private List<Medico> historial;
        public FormHistorial(IconButton currentBtn, List<Medico> listaDeMedicosHistorial)
        {
            InitializeComponent();
            this.currentBtn = currentBtn;
        }

        public List<Medico> Historial { get => historial; set => historial = value; }

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
            foreach(Medico medico in Historial)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = medico.PacientesAtendidos;
                dataGridView1.Rows[n].Cells[1].Value = medico.Nombre + " " + medico.Apellido;
            }
        }
    }
}
