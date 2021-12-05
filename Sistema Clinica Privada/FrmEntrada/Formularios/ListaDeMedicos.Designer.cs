
namespace FrmEntrada
{
    partial class ListaDeMedicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEdad = new System.Windows.Forms.Label();
            this.textBoxEspecialidad = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.dataGridViewMedicos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BotonConsulta = new FontAwesome.Sharp.IconButton();
            this.BotonEliminar = new FontAwesome.Sharp.IconButton();
            this.BotonInsertar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelEdad);
            this.panel1.Controls.Add(this.textBoxEspecialidad);
            this.panel1.Controls.Add(this.labelApellido);
            this.panel1.Controls.Add(this.textBoxApellido);
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 63);
            this.panel1.TabIndex = 9;
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.labelEdad.Location = new System.Drawing.Point(278, 12);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(82, 19);
            this.labelEdad.TabIndex = 19;
            this.labelEdad.Text = "Especialidad";
            // 
            // textBoxEspecialidad
            // 
            this.textBoxEspecialidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.textBoxEspecialidad.Location = new System.Drawing.Point(278, 34);
            this.textBoxEspecialidad.Name = "textBoxEspecialidad";
            this.textBoxEspecialidad.Size = new System.Drawing.Size(133, 26);
            this.textBoxEspecialidad.TabIndex = 18;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.labelApellido.Location = new System.Drawing.Point(141, 12);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(58, 19);
            this.labelApellido.TabIndex = 17;
            this.labelApellido.Text = "Apellido";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.textBoxApellido.Location = new System.Drawing.Point(141, 34);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(115, 26);
            this.textBoxApellido.TabIndex = 16;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.labelNombre.Location = new System.Drawing.Point(3, 12);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(59, 19);
            this.labelNombre.TabIndex = 15;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.textBoxNombre.Location = new System.Drawing.Point(3, 34);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(115, 26);
            this.textBoxNombre.TabIndex = 14;
            // 
            // dataGridViewMedicos
            // 
            this.dataGridViewMedicos.AllowUserToAddRows = false;
            this.dataGridViewMedicos.AllowUserToDeleteRows = false;
            this.dataGridViewMedicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.dataGridViewMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Especialidad,
            this.Estado});
            this.dataGridViewMedicos.Location = new System.Drawing.Point(0, 192);
            this.dataGridViewMedicos.Name = "dataGridViewMedicos";
            this.dataGridViewMedicos.ReadOnly = true;
            this.dataGridViewMedicos.RowHeadersWidth = 47;
            this.dataGridViewMedicos.RowTemplate.Height = 28;
            this.dataGridViewMedicos.Size = new System.Drawing.Size(640, 236);
            this.dataGridViewMedicos.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 145;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 145;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.MinimumWidth = 6;
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Width = 145;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Atendiendo";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 145;
            // 
            // BotonConsulta
            // 
            this.BotonConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.BotonConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonConsulta.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BotonConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.BotonConsulta.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.BotonConsulta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.BotonConsulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BotonConsulta.IconSize = 40;
            this.BotonConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonConsulta.Location = new System.Drawing.Point(0, 82);
            this.BotonConsulta.Name = "BotonConsulta";
            this.BotonConsulta.Size = new System.Drawing.Size(640, 41);
            this.BotonConsulta.TabIndex = 7;
            this.BotonConsulta.Text = "Programar consulta";
            this.BotonConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonConsulta.UseVisualStyleBackColor = false;
            this.BotonConsulta.Click += new System.EventHandler(this.BotonConsulta_Click);
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.BotonEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonEliminar.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BotonEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.BotonEliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.BotonEliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.BotonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BotonEliminar.IconSize = 40;
            this.BotonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonEliminar.Location = new System.Drawing.Point(0, 41);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(640, 41);
            this.BotonEliminar.TabIndex = 6;
            this.BotonEliminar.Text = "Eliminar Medico";
            this.BotonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonEliminar.UseVisualStyleBackColor = false;
            // 
            // BotonInsertar
            // 
            this.BotonInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.BotonInsertar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonInsertar.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BotonInsertar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.BotonInsertar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BotonInsertar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.BotonInsertar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BotonInsertar.IconSize = 40;
            this.BotonInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonInsertar.Location = new System.Drawing.Point(0, 0);
            this.BotonInsertar.Name = "BotonInsertar";
            this.BotonInsertar.Size = new System.Drawing.Size(640, 41);
            this.BotonInsertar.TabIndex = 5;
            this.BotonInsertar.Text = "Insertar Medico";
            this.BotonInsertar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonInsertar.UseVisualStyleBackColor = false;
            this.BotonInsertar.Click += new System.EventHandler(this.BotonInsertar_Click);
            // 
            // ListaDeMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(640, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewMedicos);
            this.Controls.Add(this.BotonConsulta);
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.BotonInsertar);
            this.Name = "ListaDeMedicos";
            this.Text = "ListaDeMedicos";
            this.Load += new System.EventHandler(this.ListaDeMedicos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.DataGridView dataGridViewMedicos;
        private FontAwesome.Sharp.IconButton BotonConsulta;
        private FontAwesome.Sharp.IconButton BotonEliminar;
        private FontAwesome.Sharp.IconButton BotonInsertar;
        private System.Windows.Forms.TextBox textBoxEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}