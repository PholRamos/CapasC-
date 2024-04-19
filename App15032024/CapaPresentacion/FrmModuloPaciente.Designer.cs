namespace CapaPresentacion
{
    partial class FrmModuloPaciente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModuloPaciente));
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_ClinicaDataSet7 = new CapaPresentacion.DB_ClinicaDataSet7();
            this.cbxEECC = new System.Windows.Forms.ComboBox();
            this.eECCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_ClinicaDataSet6 = new CapaPresentacion.DB_ClinicaDataSet6();
            this.txtFechaNacimientoPaciente = new System.Windows.Forms.TextBox();
            this.txtTelefonoPaciente = new System.Windows.Forms.TextBox();
            this.txtDireccionPaciente = new System.Windows.Forms.TextBox();
            this.txtApellidoPaciente = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.txtCodigoPaciente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eECCTableAdapter = new CapaPresentacion.DB_ClinicaDataSet6TableAdapters.EECCTableAdapter();
            this.generoTableAdapter = new CapaPresentacion.DB_ClinicaDataSet7TableAdapters.GeneroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ClinicaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eECCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ClinicaDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(477, 343);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 62);
            this.button4.TabIndex = 43;
            this.button4.Text = "BUSCAR";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(323, 343);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 62);
            this.button3.TabIndex = 42;
            this.button3.Text = "ELIMINAR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(168, 343);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 62);
            this.button2.TabIndex = 41;
            this.button2.Text = "MODIFICAR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 343);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 62);
            this.button1.TabIndex = 40;
            this.button1.Text = "INSERTAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPaciente
            // 
            this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaciente.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvPaciente.Location = new System.Drawing.Point(724, 42);
            this.dgvPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.RowHeadersWidth = 51;
            this.dgvPaciente.Size = new System.Drawing.Size(891, 466);
            this.dgvPaciente.TabIndex = 39;
            // 
            // cbxGenero
            // 
            this.cbxGenero.BackColor = System.Drawing.SystemColors.Info;
            this.cbxGenero.DataSource = this.generoBindingSource;
            this.cbxGenero.DisplayMember = "GeneroDescripcion";
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(179, 277);
            this.cbxGenero.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(439, 24);
            this.cbxGenero.TabIndex = 38;
            this.cbxGenero.ValueMember = "GeneroCCodigo";
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.dB_ClinicaDataSet7;
            // 
            // dB_ClinicaDataSet7
            // 
            this.dB_ClinicaDataSet7.DataSetName = "DB_ClinicaDataSet7";
            this.dB_ClinicaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxEECC
            // 
            this.cbxEECC.BackColor = System.Drawing.SystemColors.Info;
            this.cbxEECC.DataSource = this.eECCBindingSource;
            this.cbxEECC.DisplayMember = "EECCDescripcion";
            this.cbxEECC.FormattingEnabled = true;
            this.cbxEECC.Location = new System.Drawing.Point(180, 244);
            this.cbxEECC.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEECC.Name = "cbxEECC";
            this.cbxEECC.Size = new System.Drawing.Size(439, 24);
            this.cbxEECC.TabIndex = 37;
            this.cbxEECC.ValueMember = "EECCCodigo";
            // 
            // eECCBindingSource
            // 
            this.eECCBindingSource.DataMember = "EECC";
            this.eECCBindingSource.DataSource = this.dB_ClinicaDataSet6;
            // 
            // dB_ClinicaDataSet6
            // 
            this.dB_ClinicaDataSet6.DataSetName = "DB_ClinicaDataSet6";
            this.dB_ClinicaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtFechaNacimientoPaciente
            // 
            this.txtFechaNacimientoPaciente.BackColor = System.Drawing.SystemColors.Info;
            this.txtFechaNacimientoPaciente.Location = new System.Drawing.Point(180, 212);
            this.txtFechaNacimientoPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaNacimientoPaciente.Name = "txtFechaNacimientoPaciente";
            this.txtFechaNacimientoPaciente.Size = new System.Drawing.Size(439, 22);
            this.txtFechaNacimientoPaciente.TabIndex = 36;
            // 
            // txtTelefonoPaciente
            // 
            this.txtTelefonoPaciente.BackColor = System.Drawing.SystemColors.Info;
            this.txtTelefonoPaciente.Location = new System.Drawing.Point(180, 180);
            this.txtTelefonoPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoPaciente.Name = "txtTelefonoPaciente";
            this.txtTelefonoPaciente.Size = new System.Drawing.Size(439, 22);
            this.txtTelefonoPaciente.TabIndex = 35;
            // 
            // txtDireccionPaciente
            // 
            this.txtDireccionPaciente.BackColor = System.Drawing.SystemColors.Info;
            this.txtDireccionPaciente.Location = new System.Drawing.Point(180, 148);
            this.txtDireccionPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionPaciente.Name = "txtDireccionPaciente";
            this.txtDireccionPaciente.Size = new System.Drawing.Size(439, 22);
            this.txtDireccionPaciente.TabIndex = 34;
            // 
            // txtApellidoPaciente
            // 
            this.txtApellidoPaciente.BackColor = System.Drawing.SystemColors.Info;
            this.txtApellidoPaciente.Location = new System.Drawing.Point(180, 116);
            this.txtApellidoPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoPaciente.Name = "txtApellidoPaciente";
            this.txtApellidoPaciente.Size = new System.Drawing.Size(439, 22);
            this.txtApellidoPaciente.TabIndex = 33;
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombrePaciente.Location = new System.Drawing.Point(180, 84);
            this.txtNombrePaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(439, 22);
            this.txtNombrePaciente.TabIndex = 32;
            // 
            // txtCodigoPaciente
            // 
            this.txtCodigoPaciente.BackColor = System.Drawing.SystemColors.Info;
            this.txtCodigoPaciente.Location = new System.Drawing.Point(180, 52);
            this.txtCodigoPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPaciente.Name = "txtCodigoPaciente";
            this.txtCodigoPaciente.Size = new System.Drawing.Size(439, 22);
            this.txtCodigoPaciente.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 281);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "GENERO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 247);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "EECC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 215);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "FECHA NACIMIENTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "TELEFONO PACIENTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "DIRECCION PACIENTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "APELLIDO PACIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "NOMBRE PACIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "CODIGO PACIENTE";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1615, 42);
            this.label1.TabIndex = 22;
            this.label1.Text = "MODULO DE ADMINISTRACION DE PACIENTES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eECCTableAdapter
            // 
            this.eECCTableAdapter.ClearBeforeFill = true;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmModuloPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 508);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPaciente);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.cbxEECC);
            this.Controls.Add(this.txtFechaNacimientoPaciente);
            this.Controls.Add(this.txtTelefonoPaciente);
            this.Controls.Add(this.txtDireccionPaciente);
            this.Controls.Add(this.txtApellidoPaciente);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.txtCodigoPaciente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmModuloPaciente";
            this.Text = "Modulo Administracion de Pacientes";
            this.Load += new System.EventHandler(this.FrmModuloPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ClinicaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eECCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ClinicaDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.ComboBox cbxEECC;
        private System.Windows.Forms.TextBox txtFechaNacimientoPaciente;
        private System.Windows.Forms.TextBox txtTelefonoPaciente;
        private System.Windows.Forms.TextBox txtDireccionPaciente;
        private System.Windows.Forms.TextBox txtApellidoPaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.TextBox txtCodigoPaciente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DB_ClinicaDataSet6 dB_ClinicaDataSet6;
        private System.Windows.Forms.BindingSource eECCBindingSource;
        private DB_ClinicaDataSet6TableAdapters.EECCTableAdapter eECCTableAdapter;
        private DB_ClinicaDataSet7 dB_ClinicaDataSet7;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private DB_ClinicaDataSet7TableAdapters.GeneroTableAdapter generoTableAdapter;
    }
}