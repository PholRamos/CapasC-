﻿namespace CapaPresentacion
{
    partial class FrmModuloEspecialista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModuloEspecialista));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCMPEspecialista = new System.Windows.Forms.TextBox();
            this.txtEspecialistaNombre = new System.Windows.Forms.TextBox();
            this.txtEspecialistaApellido = new System.Windows.Forms.TextBox();
            this.cbxEspecialidad = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvEspecialista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(854, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODULO DE ADMINISTRACION DE ESPECIALISTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CMP ESPECIALISTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRE ESPECIALISTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "APELLIDO ESPECIALISTA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ESPECIALIDAD";
            // 
            // txtCMPEspecialista
            // 
            this.txtCMPEspecialista.BackColor = System.Drawing.SystemColors.Info;
            this.txtCMPEspecialista.Location = new System.Drawing.Point(157, 38);
            this.txtCMPEspecialista.Name = "txtCMPEspecialista";
            this.txtCMPEspecialista.Size = new System.Drawing.Size(330, 20);
            this.txtCMPEspecialista.TabIndex = 5;
            // 
            // txtEspecialistaNombre
            // 
            this.txtEspecialistaNombre.BackColor = System.Drawing.SystemColors.Info;
            this.txtEspecialistaNombre.Location = new System.Drawing.Point(157, 63);
            this.txtEspecialistaNombre.Name = "txtEspecialistaNombre";
            this.txtEspecialistaNombre.Size = new System.Drawing.Size(330, 20);
            this.txtEspecialistaNombre.TabIndex = 6;
            // 
            // txtEspecialistaApellido
            // 
            this.txtEspecialistaApellido.BackColor = System.Drawing.SystemColors.Info;
            this.txtEspecialistaApellido.Location = new System.Drawing.Point(157, 88);
            this.txtEspecialistaApellido.Name = "txtEspecialistaApellido";
            this.txtEspecialistaApellido.Size = new System.Drawing.Size(330, 20);
            this.txtEspecialistaApellido.TabIndex = 7;
            // 
            // cbxEspecialidad
            // 
            this.cbxEspecialidad.BackColor = System.Drawing.SystemColors.Info;
            this.cbxEspecialidad.DisplayMember = "EspecialidadCodigo";
            this.cbxEspecialidad.FormattingEnabled = true;
            this.cbxEspecialidad.Location = new System.Drawing.Point(157, 113);
            this.cbxEspecialidad.Name = "cbxEspecialidad";
            this.cbxEspecialidad.Size = new System.Drawing.Size(330, 21);
            this.cbxEspecialidad.TabIndex = 8;
            this.cbxEspecialidad.ValueMember = "EspecialidadCodigo";
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(377, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 50);
            this.button4.TabIndex = 47;
            this.button4.Text = "BUSCAR";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(261, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 50);
            this.button3.TabIndex = 46;
            this.button3.Text = "ELIMINAR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(145, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 50);
            this.button2.TabIndex = 45;
            this.button2.Text = "MODIFICAR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(29, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 44;
            this.button1.Text = "INSERTAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvEspecialista
            // 
            this.dgvEspecialista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialista.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvEspecialista.Location = new System.Drawing.Point(492, 29);
            this.dgvEspecialista.Name = "dgvEspecialista";
            this.dgvEspecialista.Size = new System.Drawing.Size(362, 171);
            this.dgvEspecialista.TabIndex = 48;
            this.dgvEspecialista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEspecialista_CellContentClick);
            // 
            // FrmModuloEspecialista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 200);
            this.ControlBox = false;
            this.Controls.Add(this.dgvEspecialista);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxEspecialidad);
            this.Controls.Add(this.txtEspecialistaApellido);
            this.Controls.Add(this.txtEspecialistaNombre);
            this.Controls.Add(this.txtCMPEspecialista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmModuloEspecialista";
            this.Text = "Modulo Especialista";
            this.Load += new System.EventHandler(this.FrmModuloEspecialista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCMPEspecialista;
        private System.Windows.Forms.TextBox txtEspecialistaNombre;
        private System.Windows.Forms.TextBox txtEspecialistaApellido;
        private System.Windows.Forms.ComboBox cbxEspecialidad;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvEspecialista;
    }
}