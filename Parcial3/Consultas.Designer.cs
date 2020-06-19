namespace Parcial3
{
    partial class Consultas
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
            this.DgvMuestras = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbSecretaria = new System.Windows.Forms.ComboBox();
            this.BtbConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMuestras)).BeginInit();
            this.SuspendLayout();
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
            this.DgvMuestras.Location = new System.Drawing.Point(40, 197);
            this.DgvMuestras.Name = "DgvMuestras";
            this.DgvMuestras.Size = new System.Drawing.Size(776, 156);
            this.DgvMuestras.TabIndex = 11;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Municipio :";
            // 
            // CmbSecretaria
            // 
            this.CmbSecretaria.FormattingEnabled = true;
            this.CmbSecretaria.Items.AddRange(new object[] {
            "Todos",
            "Valledupar",
            "Robles la Paz",
            "Agustín Codazzi"});
            this.CmbSecretaria.Location = new System.Drawing.Point(136, 54);
            this.CmbSecretaria.Name = "CmbSecretaria";
            this.CmbSecretaria.Size = new System.Drawing.Size(121, 21);
            this.CmbSecretaria.TabIndex = 17;
            // 
            // BtbConsultar
            // 
            this.BtbConsultar.Location = new System.Drawing.Point(281, 43);
            this.BtbConsultar.Name = "BtbConsultar";
            this.BtbConsultar.Size = new System.Drawing.Size(197, 41);
            this.BtbConsultar.TabIndex = 19;
            this.BtbConsultar.Text = "Ver Consultas de Pacientes";
            this.BtbConsultar.UseVisualStyleBackColor = true;
            this.BtbConsultar.Click += new System.EventHandler(this.BtbConsultar_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 502);
            this.Controls.Add(this.BtbConsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbSecretaria);
            this.Controls.Add(this.DgvMuestras);
            this.Name = "Consultas";
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMuestras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMuestras;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSecretaria;
        private System.Windows.Forms.Button BtbConsultar;
    }
}