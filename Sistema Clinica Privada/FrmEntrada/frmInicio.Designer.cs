
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
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
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
            this.iconHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(146)))));
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
            // 
            // iconListaDeEspera
            // 
            this.iconListaDeEspera.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconListaDeEspera.FlatAppearance.BorderSize = 0;
            this.iconListaDeEspera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconListaDeEspera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(146)))));
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
            // 
            // iconListaDeMedicos
            // 
            this.iconListaDeMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconListaDeMedicos.FlatAppearance.BorderSize = 0;
            this.iconListaDeMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconListaDeMedicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(146)))));
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
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 130);
            this.panelLogo.TabIndex = 0;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 556);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmInicio";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconHistorial;
        private FontAwesome.Sharp.IconButton iconListaDeEspera;
        private FontAwesome.Sharp.IconButton iconListaDeMedicos;
        private FontAwesome.Sharp.IconButton iconDashboard;
        private System.Windows.Forms.Panel panelLogo;
    }
}

