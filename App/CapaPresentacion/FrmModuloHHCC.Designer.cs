namespace CapaPresentacion
{
    partial class FrmModuloHHCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModuloHHCC));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHHCCCodigo = new System.Windows.Forms.TextBox();
            this.txtPacienteCodigo = new System.Windows.Forms.TextBox();
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.dgvHHCC = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHHCC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(854, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "MODULO DE GESTION DE HHCC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NUMERO DE HHCC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DNI PACIENTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "FECHA ACTUAL";
            // 
            // txtHHCCCodigo
            // 
            this.txtHHCCCodigo.BackColor = System.Drawing.SystemColors.Info;
            this.txtHHCCCodigo.Location = new System.Drawing.Point(142, 32);
            this.txtHHCCCodigo.Name = "txtHHCCCodigo";
            this.txtHHCCCodigo.Size = new System.Drawing.Size(330, 20);
            this.txtHHCCCodigo.TabIndex = 5;
            // 
            // txtPacienteCodigo
            // 
            this.txtPacienteCodigo.BackColor = System.Drawing.Color.PeachPuff;
            this.txtPacienteCodigo.Location = new System.Drawing.Point(142, 58);
            this.txtPacienteCodigo.Name = "txtPacienteCodigo";
            this.txtPacienteCodigo.Size = new System.Drawing.Size(330, 20);
            this.txtPacienteCodigo.TabIndex = 6;
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.BackColor = System.Drawing.SystemColors.Info;
            this.txtFechaActual.Location = new System.Drawing.Point(142, 84);
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.Size = new System.Drawing.Size(330, 20);
            this.txtFechaActual.TabIndex = 7;
            // 
            // dgvHHCC
            // 
            this.dgvHHCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHHCC.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvHHCC.Location = new System.Drawing.Point(478, 29);
            this.dgvHHCC.Name = "dgvHHCC";
            this.dgvHHCC.Size = new System.Drawing.Size(376, 141);
            this.dgvHHCC.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(362, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 50);
            this.button4.TabIndex = 51;
            this.button4.Text = "BUSCAR";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(246, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 50);
            this.button3.TabIndex = 50;
            this.button3.Text = "ELIMINAR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(130, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 50);
            this.button2.TabIndex = 49;
            this.button2.Text = "MODIFICAR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(14, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 48;
            this.button1.Text = "INSERTAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmModuloHHCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 170);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvHHCC);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.txtPacienteCodigo);
            this.Controls.Add(this.txtHHCCCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmModuloHHCC";
            this.Text = "Modulo Historia Clinica";
            this.Load += new System.EventHandler(this.FrmModuloHHCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHHCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHHCCCodigo;
        private System.Windows.Forms.TextBox txtPacienteCodigo;
        private System.Windows.Forms.TextBox txtFechaActual;
        private System.Windows.Forms.DataGridView dgvHHCC;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}