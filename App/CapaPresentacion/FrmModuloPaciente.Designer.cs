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
            this.dB_ClinicaDataSetGenero = new CapaPresentacion.DB_ClinicaDataSetGenero();
            this.cbxEECC = new System.Windows.Forms.ComboBox();
            this.eECCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_ClinicaDataSetEECC = new CapaPresentacion.DB_ClinicaDataSetEECC();
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
            this.eECCTableAdapter = new CapaPresentacion.DB_ClinicaDataSetEECCTableAdapters.EECCTableAdapter();
            this.generoTableAdapter = new CapaPresentacion.DB_ClinicaDataSetGeneroTableAdapters.GeneroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ClinicaDataSetGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eECCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ClinicaDataSetEECC)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(354, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 50);
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
            this.button3.Location = new System.Drawing.Point(238, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 50);
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
            this.button2.Location = new System.Drawing.Point(122, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 50);
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
            this.button1.Location = new System.Drawing.Point(6, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
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
            this.dgvPaciente.Location = new System.Drawing.Point(470, 34);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.Size = new System.Drawing.Size(384, 281);
            this.dgvPaciente.TabIndex = 39;
            // 
            // cbxGenero
            // 
            this.cbxGenero.BackColor = System.Drawing.SystemColors.Info;
            this.cbxGenero.DataSource = this.generoBindingSource;
            this.cbxGenero.DisplayMember = "GeneroDescripcion";
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(134, 225);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(330, 21);
            this.cbxGenero.TabIndex = 38;
            this.cbxGenero.ValueMember = "GeneroCCodigo";
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.dB_ClinicaDataSetGenero;
            // 
            // dB_ClinicaDataSetGenero
            // 
            this.dB_ClinicaDataSetGenero.DataSetName = "DB_ClinicaDataSetGenero";
            this.dB_ClinicaDataSetGenero.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxEECC
            // 
            this.cbxEECC.BackColor = System.Drawing.SystemColors.Info;
            this.cbxEECC.DataSource = this.eECCBindingSource;
            this.cbxEECC.DisplayMember = "EECCDescripcion";
            this.cbxEECC.FormattingEnabled = true;
            this.cbxEECC.Location = new System.Drawing.Point(135, 198);
            this.cbxEECC.Name = "cbxEECC";
            this.cbxEECC.Size = new System.Drawing.Size(330, 21);
            this.cbxEECC.TabIndex = 37;
            this.cbxEECC.ValueMember = "EECCCodigo";
            // 
            // eECCBindingSource
            // 
            this.eECCBindingSource.DataMember = "EECC";
            this.eECCBindingSource.DataSource = this.dB_ClinicaDataSetEECC;
            // 
            // dB_ClinicaDataSetEECC
            // 
            this.dB_ClinicaDataSetEECC.DataSetName = "DB_ClinicaDataSetEECC";
            this.dB_ClinicaDataSetEECC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtFechaNacimientoPaciente
            // 
            this.txtFechaNacimientoPaciente.BackColor = System.Drawing.SystemColors.Info;
            this.txtFechaNacimientoPaciente.Location = new System.Drawing.Point(135, 172);
            this.txtFechaNacimientoPaciente.Name = "txtFechaNacimientoPaciente";
            this.txtFechaNacimientoPaciente.Size = new System.Drawing.Size(330, 20);
            this.txtFechaNacimientoPaciente.TabIndex = 36;
            // 
            // txtTelefonoPaciente
            // 
            this.txtTelefonoPaciente.BackColor = System.Drawing.SystemColors.Info;
            this.txtTelefonoPaciente.Location = new System.Drawing.Point(135, 146);
            this.txtTelefonoPaciente.Name = "txtTelefonoPaciente";
            this.txtTelefonoPaciente.Size = new System.Drawing.Size(330, 20);
            this.txtTelefonoPaciente.TabIndex = 35;
            // 
            // txtDireccionPaciente
            // 
            this.txtDireccionPaciente.BackColor = System.Drawing.SystemColors.Info;
            this.txtDireccionPaciente.Location = new System.Drawing.Point(135, 120);
            this.txtDireccionPaciente.Name = "txtDireccionPaciente";
            this.txtDireccionPaciente.Size = new System.Drawing.Size(330, 20);
            this.txtDireccionPaciente.TabIndex = 34;
            // 
            // txtApellidoPaciente
            // 
            this.txtApellidoPaciente.BackColor = System.Drawing.SystemColors.Info;
            this.txtApellidoPaciente.Location = new System.Drawing.Point(135, 94);
            this.txtApellidoPaciente.Name = "txtApellidoPaciente";
            this.txtApellidoPaciente.Size = new System.Drawing.Size(330, 20);
            this.txtApellidoPaciente.TabIndex = 33;
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombrePaciente.Location = new System.Drawing.Point(135, 68);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(330, 20);
            this.txtNombrePaciente.TabIndex = 32;
            // 
            // txtCodigoPaciente
            // 
            this.txtCodigoPaciente.BackColor = System.Drawing.SystemColors.Info;
            this.txtCodigoPaciente.Location = new System.Drawing.Point(135, 42);
            this.txtCodigoPaciente.Name = "txtCodigoPaciente";
            this.txtCodigoPaciente.Size = new System.Drawing.Size(330, 20);
            this.txtCodigoPaciente.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "GENERO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "EECC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "FECHA NACIMIENTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "TELEFONO PACIENTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "DIRECCION PACIENTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "APELLIDO PACIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "NOMBRE PACIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "CODIGO PACIENTE";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(854, 34);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 315);
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
            this.Name = "FrmModuloPaciente";
            this.Text = "Modulo Administracion de Pacientes";
            this.Load += new System.EventHandler(this.FrmModuloPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ClinicaDataSetGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eECCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ClinicaDataSetEECC)).EndInit();
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
        private DB_ClinicaDataSetEECC dB_ClinicaDataSetEECC;
        private System.Windows.Forms.BindingSource eECCBindingSource;
        private DB_ClinicaDataSetEECCTableAdapters.EECCTableAdapter eECCTableAdapter;
        private DB_ClinicaDataSetGenero dB_ClinicaDataSetGenero;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private DB_ClinicaDataSetGeneroTableAdapters.GeneroTableAdapter generoTableAdapter;
    }
}