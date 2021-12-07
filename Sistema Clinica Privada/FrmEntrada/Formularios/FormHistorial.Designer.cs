
namespace FrmEntrada
{
    partial class FormHistorial
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posicion,
            this.Medicos});
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(426, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Roboto", 18.32727F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.labelTitulo.Location = new System.Drawing.Point(247, 29);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(119, 34);
            this.labelTitulo.TabIndex = 13;
            this.labelTitulo.Text = "Historial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.74545F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(492, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Medico 1º";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // Posicion
            // 
            this.Posicion.HeaderText = "Num Pacientes";
            this.Posicion.MinimumWidth = 6;
            this.Posicion.Name = "Posicion";
            this.Posicion.Width = 130;
            // 
            // Medicos
            // 
            this.Medicos.HeaderText = "Medicos";
            this.Medicos.MinimumWidth = 6;
            this.Medicos.Name = "Medicos";
            this.Medicos.Width = 250;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 13.74545F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.label4.Location = new System.Drawing.Point(492, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Medico 1º";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 13.74545F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.label6.Location = new System.Drawing.Point(492, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Medico 1º";
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(640, 428);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormHistorial";
            this.Text = "FormHistorialcs";
            this.Load += new System.EventHandler(this.FormHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicos;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}