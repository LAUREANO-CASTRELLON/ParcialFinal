namespace Parcial3
{
    partial class GuardarEnBaseDeDatos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnConsultarArchivo = new System.Windows.Forms.Button();
            this.DgvMuestras = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.BtnConsultasPacientes = new System.Windows.Forms.Button();
            this.CmbSecretaria = new System.Windows.Forms.ComboBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMuestras)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConsultarArchivo
            // 
            this.BtnConsultarArchivo.Location = new System.Drawing.Point(34, 7);
            this.BtnConsultarArchivo.Name = "BtnConsultarArchivo";
            this.BtnConsultarArchivo.Size = new System.Drawing.Size(197, 39);
            this.BtnConsultarArchivo.TabIndex = 11;
            this.BtnConsultarArchivo.Text = "Consultar Archivo Muestra";
            this.BtnConsultarArchivo.UseVisualStyleBackColor = true;
            this.BtnConsultarArchivo.Click += new System.EventHandler(this.BtnConsultarArchivo_Click_1);
            // 
            // DgvMuestras
            // 
            this.DgvMuestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMuestras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Cedula,
            this.Nombre,
            this.Edad,
            this.Sexo,
            this.Fecha,
            this.Resultado});
            this.DgvMuestras.Location = new System.Drawing.Point(34, 61);
            this.DgvMuestras.Name = "DgvMuestras";
            this.DgvMuestras.Size = new System.Drawing.Size(787, 156);
            this.DgvMuestras.TabIndex = 10;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Resultado
            // 
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.Name = "Resultado";
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(336, 316);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(87, 76);
            this.BtnCargar.TabIndex = 9;
            this.BtnCargar.Text = "Cargar a base de datos ";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // BtnConsultasPacientes
            // 
            this.BtnConsultasPacientes.Location = new System.Drawing.Point(694, 444);
            this.BtnConsultasPacientes.Name = "BtnConsultasPacientes";
            this.BtnConsultasPacientes.Size = new System.Drawing.Size(197, 39);
            this.BtnConsultasPacientes.TabIndex = 12;
            this.BtnConsultasPacientes.Text = "Ver Consultas de Pacientes";
            this.BtnConsultasPacientes.UseVisualStyleBackColor = true;
            this.BtnConsultasPacientes.Click += new System.EventHandler(this.BtnConsultasPacientes_Click);
            // 
            // CmbSecretaria
            // 
            this.CmbSecretaria.FormattingEnabled = true;
            this.CmbSecretaria.Items.AddRange(new object[] {
            "Valledupar",
            "Robles la Paz",
            "Agustín Codazzi"});
            this.CmbSecretaria.Location = new System.Drawing.Point(110, 347);
            this.CmbSecretaria.Name = "CmbSecretaria";
            this.CmbSecretaria.Size = new System.Drawing.Size(121, 21);
            this.CmbSecretaria.TabIndex = 13;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(110, 374);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(200, 20);
            this.DtpFecha.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-8, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 34);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Municipio :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha :";
            // 
            // GuardarEnBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.CmbSecretaria);
            this.Controls.Add(this.BtnConsultasPacientes);
            this.Controls.Add(this.BtnConsultarArchivo);
            this.Controls.Add(this.DgvMuestras);
            this.Controls.Add(this.BtnCargar);
            this.Name = "GuardarEnBaseDeDatos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMuestras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConsultarArchivo;
        private System.Windows.Forms.DataGridView DgvMuestras;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Button BtnConsultasPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private System.Windows.Forms.ComboBox CmbSecretaria;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

