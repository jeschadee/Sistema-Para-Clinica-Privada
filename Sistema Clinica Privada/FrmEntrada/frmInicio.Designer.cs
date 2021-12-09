
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconListaDeEsperaMedicos = new FontAwesome.Sharp.IconButton();
            this.iconHistorial = new FontAwesome.Sharp.IconButton();
            this.iconListaDeMedicos = new FontAwesome.Sharp.IconButton();
            this.iconListaDeEspera = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.PictureBox();
            this.barraDeTitulo = new System.Windows.Forms.Panel();
            this.labelInicio = new System.Windows.Forms.Label();
            this.iconhijo = new FontAwesome.Sharp.IconPictureBox();
            this.panelSombraSuperior = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelEscritorio = new System.Windows.Forms.Panel();
            this.checkBoxMedicosEnConsulta = new System.Windows.Forms.CheckBox();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.comboBoxMedico = new System.Windows.Forms.ComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButtonFinalizar = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewConsultas = new System.Windows.Forms.DataGridView();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.Fecha = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            this.barraDeTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconhijo)).BeginInit();
            this.PanelEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.panelMenu.Controls.Add(this.iconListaDeEsperaMedicos);
            this.panelMenu.Controls.Add(this.iconHistorial);
            this.panelMenu.Controls.Add(this.iconListaDeMedicos);
            this.panelMenu.Controls.Add(this.iconListaDeEspera);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 556);
            this.panelMenu.TabIndex = 0;
            // 
            // iconListaDeEsperaMedicos
            // 
            this.iconListaDeEsperaMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.iconListaDeEsperaMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconListaDeEsperaMedicos.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconListaDeEsperaMedicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.iconListaDeEsperaMedicos.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.iconListaDeEsperaMedicos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.iconListaDeEsperaMedicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconListaDeEsperaMedicos.IconSize = 40;
            this.iconListaDeEsperaMedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconListaDeEsperaMedicos.Location = new System.Drawing.Point(27, 479);
            this.iconListaDeEsperaMedicos.Name = "iconListaDeEsperaMedicos";
            this.iconListaDeEsperaMedicos.Size = new System.Drawing.Size(164, 65);
            this.iconListaDeEsperaMedicos.TabIndex = 17;
            this.iconListaDeEsperaMedicos.Text = "Lista De Espera de Medicos";
            this.iconListaDeEsperaMedicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconListaDeEsperaMedicos.UseVisualStyleBackColor = false;
            this.iconListaDeEsperaMedicos.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconHistorial
            // 
            this.iconHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconHistorial.FlatAppearance.BorderSize = 0;
            this.iconHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconHistorial.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.iconHistorial.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconHistorial.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.iconHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHistorial.IconSize = 40;
            this.iconHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconHistorial.Location = new System.Drawing.Point(0, 230);
            this.iconHistorial.Name = "iconHistorial";
            this.iconHistorial.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconHistorial.Size = new System.Drawing.Size(220, 50);
            this.iconHistorial.TabIndex = 7;
            this.iconHistorial.Text = "Historial";
            this.iconHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconHistorial.UseVisualStyleBackColor = true;
            this.iconHistorial.Click += new System.EventHandler(this.iconHistorial_Click_1);
            // 
            // iconListaDeMedicos
            // 
            this.iconListaDeMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconListaDeMedicos.FlatAppearance.BorderSize = 0;
            this.iconListaDeMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconListaDeMedicos.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconListaDeMedicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.iconListaDeMedicos.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.iconListaDeMedicos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.iconListaDeMedicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconListaDeMedicos.IconSize = 40;
            this.iconListaDeMedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconListaDeMedicos.Location = new System.Drawing.Point(0, 180);
            this.iconListaDeMedicos.Name = "iconListaDeMedicos";
            this.iconListaDeMedicos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconListaDeMedicos.Size = new System.Drawing.Size(220, 50);
            this.iconListaDeMedicos.TabIndex = 5;
            this.iconListaDeMedicos.Text = "Lista de Medicos";
            this.iconListaDeMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconListaDeMedicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconListaDeMedicos.UseVisualStyleBackColor = true;
            this.iconListaDeMedicos.Click += new System.EventHandler(this.iconListaDeMedicos_Click);
            // 
            // iconListaDeEspera
            // 
            this.iconListaDeEspera.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconListaDeEspera.FlatAppearance.BorderSize = 0;
            this.iconListaDeEspera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconListaDeEspera.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconListaDeEspera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.iconListaDeEspera.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconListaDeEspera.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.iconListaDeEspera.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconListaDeEspera.IconSize = 40;
            this.iconListaDeEspera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconListaDeEspera.Location = new System.Drawing.Point(0, 130);
            this.iconListaDeEspera.Name = "iconListaDeEspera";
            this.iconListaDeEspera.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconListaDeEspera.Size = new System.Drawing.Size(220, 50);
            this.iconListaDeEspera.TabIndex = 3;
            this.iconListaDeEspera.Text = "Lista de Espera";
            this.iconListaDeEspera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconListaDeEspera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconListaDeEspera.UseVisualStyleBackColor = true;
            this.iconListaDeEspera.Click += new System.EventHandler(this.iconListaDeEspera_Click);
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
            this.btnLogo.Image = global::Interfaz.Properties.Resources.kisspng_medicine_staff_of_hermes_symbol_clip_art_hermes_5ac75ec52c3953_2370121915230153651812;
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
            this.barraDeTitulo.BackColor = System.Drawing.Color.White;
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
            this.labelInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInicio.AutoSize = true;
            this.labelInicio.Font = new System.Drawing.Font("Segoe UI", 20.29091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(115)))));
            this.labelInicio.Location = new System.Drawing.Point(266, 22);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(97, 45);
            this.labelInicio.TabIndex = 2;
            this.labelInicio.Text = "Inicio";
            // 
            // iconhijo
            // 
            this.iconhijo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconhijo.BackColor = System.Drawing.Color.Transparent;
            this.iconhijo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(115)))));
            this.iconhijo.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconhijo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(115)))));
            this.iconhijo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconhijo.IconSize = 50;
            this.iconhijo.Location = new System.Drawing.Point(210, 24);
            this.iconhijo.Name = "iconhijo";
            this.iconhijo.Size = new System.Drawing.Size(50, 50);
            this.iconhijo.TabIndex = 2;
            this.iconhijo.TabStop = false;
            // 
            // panelSombraSuperior
            // 
            this.panelSombraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(233)))), ((int)(((byte)(247)))));
            this.panelSombraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSombraSuperior.Location = new System.Drawing.Point(220, 80);
            this.panelSombraSuperior.Name = "panelSombraSuperior";
            this.panelSombraSuperior.Size = new System.Drawing.Size(662, 4);
            this.panelSombraSuperior.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(233)))), ((int)(((byte)(247)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(220, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 472);
            this.panel2.TabIndex = 3;
            // 
            // PanelEscritorio
            // 
            this.PanelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.PanelEscritorio.Controls.Add(this.checkBoxMedicosEnConsulta);
            this.PanelEscritorio.Controls.Add(this.comboBoxPaciente);
            this.PanelEscritorio.Controls.Add(this.comboBoxMedico);
            this.PanelEscritorio.Controls.Add(this.iconButton1);
            this.PanelEscritorio.Controls.Add(this.iconButtonFinalizar);
            this.PanelEscritorio.Controls.Add(this.iconPictureBox2);
            this.PanelEscritorio.Controls.Add(this.label2);
            this.PanelEscritorio.Controls.Add(this.label1);
            this.PanelEscritorio.Controls.Add(this.dataGridViewConsultas);
            this.PanelEscritorio.Controls.Add(this.labelFecha);
            this.PanelEscritorio.Controls.Add(this.labelHora);
            this.PanelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEscritorio.Location = new System.Drawing.Point(224, 84);
            this.PanelEscritorio.Name = "PanelEscritorio";
            this.PanelEscritorio.Size = new System.Drawing.Size(658, 472);
            this.PanelEscritorio.TabIndex = 4;
            // 
            // checkBoxMedicosEnConsulta
            // 
            this.checkBoxMedicosEnConsulta.AutoSize = true;
            this.checkBoxMedicosEnConsulta.Location = new System.Drawing.Point(73, 400);
            this.checkBoxMedicosEnConsulta.Name = "checkBoxMedicosEnConsulta";
            this.checkBoxMedicosEnConsulta.Size = new System.Drawing.Size(207, 23);
            this.checkBoxMedicosEnConsulta.TabIndex = 5;
            this.checkBoxMedicosEnConsulta.Text = "Habilitar medicos en consulta";
            this.checkBoxMedicosEnConsulta.UseVisualStyleBackColor = true;
            this.checkBoxMedicosEnConsulta.CheckedChanged += new System.EventHandler(this.checkBoxMedicosEnConsulta_CheckedChanged);
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point(364, 370);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(254, 27);
            this.comboBoxPaciente.TabIndex = 16;
            // 
            // comboBoxMedico
            // 
            this.comboBoxMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMedico.FormattingEnabled = true;
            this.comboBoxMedico.Location = new System.Drawing.Point(71, 370);
            this.comboBoxMedico.Name = "comboBoxMedico";
            this.comboBoxMedico.Size = new System.Drawing.Size(244, 27);
            this.comboBoxMedico.TabIndex = 8;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(71, 429);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(141, 40);
            this.iconButton1.TabIndex = 15;
            this.iconButton1.Text = "Apuntar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButtonFinalizar
            // 
            this.iconButtonFinalizar.FlatAppearance.BorderSize = 0;
            this.iconButtonFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonFinalizar.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButtonFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.iconButtonFinalizar.IconChar = FontAwesome.Sharp.IconChar.CalendarTimes;
            this.iconButtonFinalizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.iconButtonFinalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonFinalizar.IconSize = 40;
            this.iconButtonFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonFinalizar.Location = new System.Drawing.Point(364, 429);
            this.iconButtonFinalizar.Name = "iconButtonFinalizar";
            this.iconButtonFinalizar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonFinalizar.Size = new System.Drawing.Size(151, 40);
            this.iconButtonFinalizar.TabIndex = 14;
            this.iconButtonFinalizar.Text = "Finalizar";
            this.iconButtonFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonFinalizar.UseVisualStyleBackColor = true;
            this.iconButtonFinalizar.Click += new System.EventHandler(this.iconButtonFinalizar_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Ambulance;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 113;
            this.iconPictureBox2.Location = new System.Drawing.Point(6, 16);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(113, 115);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox2.TabIndex = 11;
            this.iconPictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 18.32727F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(206, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Consultas Activas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 28.14545F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(125, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 52);
            this.label1.TabIndex = 10;
            this.label1.Text = "¡Bienvenidos!";
            // 
            // dataGridViewConsultas
            // 
            this.dataGridViewConsultas.AllowUserToAddRows = false;
            this.dataGridViewConsultas.AllowUserToDeleteRows = false;
            this.dataGridViewConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medico,
            this.Doctor});
            this.dataGridViewConsultas.Location = new System.Drawing.Point(30, 158);
            this.dataGridViewConsultas.Name = "dataGridViewConsultas";
            this.dataGridViewConsultas.ReadOnly = true;
            this.dataGridViewConsultas.RowHeadersWidth = 47;
            this.dataGridViewConsultas.RowTemplate.Height = 28;
            this.dataGridViewConsultas.Size = new System.Drawing.Size(604, 210);
            this.dataGridViewConsultas.TabIndex = 13;
            this.dataGridViewConsultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsultas_CellContentClick);
            // 
            // Medico
            // 
            this.Medico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Medico.HeaderText = "Medico";
            this.Medico.MinimumWidth = 6;
            this.Medico.Name = "Medico";
            this.Medico.ReadOnly = true;
            // 
            // Doctor
            // 
            this.Doctor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Doctor.HeaderText = "Paciente";
            this.Doctor.MinimumWidth = 6;
            this.Doctor.Name = "Doctor";
            this.Doctor.ReadOnly = true;
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Segoe UI", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(115)))));
            this.labelFecha.Location = new System.Drawing.Point(550, 438);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(68, 30);
            this.labelFecha.TabIndex = 8;
            this.labelFecha.Text = "label1";
            // 
            // labelHora
            // 
            this.labelHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Segoe UI", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(115)))));
            this.labelHora.Location = new System.Drawing.Point(550, 409);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(68, 30);
            this.labelHora.TabIndex = 8;
            this.labelHora.Text = "label1";
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // Fecha
            // 
            this.Fecha.Enabled = true;
            this.Fecha.Tick += new System.EventHandler(this.Fecha_Tick);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 556);
            this.Controls.Add(this.PanelEscritorio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSombraSuperior);
            this.Controls.Add(this.barraDeTitulo);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Clinica";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            this.barraDeTitulo.ResumeLayout(false);
            this.barraDeTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconhijo)).EndInit();
            this.PanelEscritorio.ResumeLayout(false);
            this.PanelEscritorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconListaDeMedicos;
        private FontAwesome.Sharp.IconButton iconListaDeEspera;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnLogo;
        private System.Windows.Forms.Panel barraDeTitulo;
        private FontAwesome.Sharp.IconPictureBox iconhijo;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.Panel panelSombraSuperior;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelEscritorio;
        private FontAwesome.Sharp.IconButton iconHistorial;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Timer Fecha;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewConsultas;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButtonFinalizar;
        private System.Windows.Forms.ComboBox comboBoxPaciente;
        private System.Windows.Forms.ComboBox comboBoxMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private FontAwesome.Sharp.IconButton iconListaDeEsperaMedicos;
        private System.Windows.Forms.CheckBox checkBoxMedicosEnConsulta;
    }
}

