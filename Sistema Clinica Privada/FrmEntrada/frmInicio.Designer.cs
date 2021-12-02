
namespace FrmEntrada
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconHistorial = new FontAwesome.Sharp.IconButton();
            this.iconListaDeEspera = new FontAwesome.Sharp.IconButton();
            this.iconListaDeMedicos = new FontAwesome.Sharp.IconButton();
            this.iconDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.PictureBox();
            this.barraDeTitulo = new System.Windows.Forms.Panel();
            this.labelInicio = new System.Windows.Forms.Label();
            this.iconhijo = new FontAwesome.Sharp.IconPictureBox();
            this.panelSombraSuperior = new System.Windows.Forms.Panel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            this.barraDeTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconhijo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(78)))), ((int)(((byte)(119)))));
            this.panelMenu.Controls.Add(this.iconHistorial);
            this.panelMenu.Controls.Add(this.iconListaDeEspera);
            this.panelMenu.Controls.Add(this.iconListaDeMedicos);
            this.panelMenu.Controls.Add(this.iconDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 556);
            this.panelMenu.TabIndex = 0;
            // 
            // iconHistorial
            // 
            this.iconHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconHistorial.FlatAppearance.BorderSize = 0;
            this.iconHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(200)))), ((int)(((byte)(147)))));
            this.iconHistorial.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconHistorial.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(146)))));
            this.iconHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHistorial.IconSize = 40;
            this.iconHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconHistorial.Location = new System.Drawing.Point(0, 280);
            this.iconHistorial.Name = "iconHistorial";
            this.iconHistorial.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconHistorial.Size = new System.Drawing.Size(220, 50);
            this.iconHistorial.TabIndex = 6;
            this.iconHistorial.Text = "Historial";
            this.iconHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconHistorial.UseVisualStyleBackColor = true;
            this.iconHistorial.Click += new System.EventHandler(this.iconHistorial_Click);
            // 
            // iconListaDeEspera
            // 
            this.iconListaDeEspera.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconListaDeEspera.FlatAppearance.BorderSize = 0;
            this.iconListaDeEspera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconListaDeEspera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(200)))), ((int)(((byte)(147)))));
            this.iconListaDeEspera.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconListaDeEspera.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(146)))));
            this.iconListaDeEspera.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconListaDeEspera.IconSize = 40;
            this.iconListaDeEspera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconListaDeEspera.Location = new System.Drawing.Point(0, 230);
            this.iconListaDeEspera.Name = "iconListaDeEspera";
            this.iconListaDeEspera.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconListaDeEspera.Size = new System.Drawing.Size(220, 50);
            this.iconListaDeEspera.TabIndex = 5;
            this.iconListaDeEspera.Text = "Lista de Espera";
            this.iconListaDeEspera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconListaDeEspera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconListaDeEspera.UseVisualStyleBackColor = true;
            this.iconListaDeEspera.Click += new System.EventHandler(this.iconListaDeEspera_Click);
            // 
            // iconListaDeMedicos
            // 
            this.iconListaDeMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconListaDeMedicos.FlatAppearance.BorderSize = 0;
            this.iconListaDeMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconListaDeMedicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(200)))), ((int)(((byte)(147)))));
            this.iconListaDeMedicos.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.iconListaDeMedicos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(146)))));
            this.iconListaDeMedicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconListaDeMedicos.IconSize = 40;
            this.iconListaDeMedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconListaDeMedicos.Location = new System.Drawing.Point(0, 180);
            this.iconListaDeMedicos.Name = "iconListaDeMedicos";
            this.iconListaDeMedicos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconListaDeMedicos.Size = new System.Drawing.Size(220, 50);
            this.iconListaDeMedicos.TabIndex = 4;
            this.iconListaDeMedicos.Text = "Lista de Medicos";
            this.iconListaDeMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconListaDeMedicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconListaDeMedicos.UseVisualStyleBackColor = true;
            this.iconListaDeMedicos.Click += new System.EventHandler(this.iconListaDeMedicos_Click);
            // 
            // iconDashboard
            // 
            this.iconDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconDashboard.FlatAppearance.BorderSize = 0;
            this.iconDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(146)))));
            this.iconDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconDashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(146)))));
            this.iconDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDashboard.IconSize = 40;
            this.iconDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDashboard.Location = new System.Drawing.Point(0, 130);
            this.iconDashboard.Name = "iconDashboard";
            this.iconDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconDashboard.Size = new System.Drawing.Size(220, 50);
            this.iconDashboard.TabIndex = 3;
            this.iconDashboard.Text = "Dashboard";
            this.iconDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconDashboard.UseVisualStyleBackColor = true;
            this.iconDashboard.Click += new System.EventHandler(this.iconDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 130);
            this.panelLogo.TabIndex = 0;
            // 
            // btnLogo
            // 
            this.btnLogo.Image = global::Interfaz.Properties.Resources.kisspng_data_analysis_predictive_analytics_business_administrator_5acd70937605e1_5624598715234131394834;
            this.btnLogo.Location = new System.Drawing.Point(0, 0);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(220, 130);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogo.TabIndex = 1;
            this.btnLogo.TabStop = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // barraDeTitulo
            // 
            this.barraDeTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(78)))), ((int)(((byte)(119)))));
            this.barraDeTitulo.Controls.Add(this.labelInicio);
            this.barraDeTitulo.Controls.Add(this.iconhijo);
            this.barraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraDeTitulo.Location = new System.Drawing.Point(220, 0);
            this.barraDeTitulo.Name = "barraDeTitulo";
            this.barraDeTitulo.Size = new System.Drawing.Size(662, 80);
            this.barraDeTitulo.TabIndex = 1;
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(146)))));
            this.labelInicio.Location = new System.Drawing.Point(85, 37);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(41, 19);
            this.labelInicio.TabIndex = 2;
            this.labelInicio.Text = "Inicio";
            this.labelInicio.Click += new System.EventHandler(this.label1_Click);
            // 
            // iconhijo
            // 
            this.iconhijo.BackColor = System.Drawing.Color.Transparent;
            this.iconhijo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(146)))));
            this.iconhijo.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconhijo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(146)))));
            this.iconhijo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconhijo.IconSize = 50;
            this.iconhijo.Location = new System.Drawing.Point(29, 22);
            this.iconhijo.Name = "iconhijo";
            this.iconhijo.Size = new System.Drawing.Size(50, 50);
            this.iconhijo.TabIndex = 2;
            this.iconhijo.TabStop = false;
            this.iconhijo.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // panelSombraSuperior
            // 
            this.panelSombraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(79)))));
            this.panelSombraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSombraSuperior.Location = new System.Drawing.Point(220, 80);
            this.panelSombraSuperior.Name = "panelSombraSuperior";
            this.panelSombraSuperior.Size = new System.Drawing.Size(662, 4);
            this.panelSombraSuperior.TabIndex = 2;
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(78)))), ((int)(((byte)(119)))));
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(220, 84);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(662, 472);
            this.panelDashboard.TabIndex = 5;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 556);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.panelSombraSuperior);
            this.Controls.Add(this.barraDeTitulo);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            this.barraDeTitulo.ResumeLayout(false);
            this.barraDeTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconhijo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconHistorial;
        private FontAwesome.Sharp.IconButton iconListaDeEspera;
        private FontAwesome.Sharp.IconButton iconListaDeMedicos;
        private FontAwesome.Sharp.IconButton iconDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnLogo;
        private System.Windows.Forms.Panel barraDeTitulo;
        private FontAwesome.Sharp.IconPictureBox iconhijo;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.Panel panelSombraSuperior;
        private System.Windows.Forms.Panel panelDashboard;
    }
}

