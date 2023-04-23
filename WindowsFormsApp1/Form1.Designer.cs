namespace WindowsFormsApp1
{
    partial class Inicio
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.rbtOtro = new System.Windows.Forms.RadioButton();
            this.rbtNoResp = new System.Windows.Forms.RadioButton();
            this.lblCompleteOtro = new System.Windows.Forms.Label();
            this.txtOtro = new System.Windows.Forms.TextBox();
            this.btnEdad = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.rbtResumen = new System.Windows.Forms.RichTextBox();
            this.btnClases = new System.Windows.Forms.Button();
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(264, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(42, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre y Apellido";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(140, 73);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 2;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(26, 73);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(140, 106);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cboEstadoCivil.TabIndex = 4;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(72, 109);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(62, 13);
            this.lblEstadoCivil.TabIndex = 5;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(102, 261);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "Edad";
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbtNoResp);
            this.gbSexo.Controls.Add(this.rbtOtro);
            this.gbSexo.Controls.Add(this.rbtFemenino);
            this.gbSexo.Controls.Add(this.rbtMasculino);
            this.gbSexo.Location = new System.Drawing.Point(140, 133);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(490, 51);
            this.gbSexo.TabIndex = 7;
            this.gbSexo.TabStop = false;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(6, 20);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 0;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            this.rbtMasculino.CheckedChanged += new System.EventHandler(this.rbtMasculino_CheckedChanged);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(103, 157);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 8;
            this.lblSexo.Text = "Sexo";
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(85, 20);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtFemenino.TabIndex = 1;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            this.rbtFemenino.CheckedChanged += new System.EventHandler(this.rbtFemenino_CheckedChanged);
            // 
            // rbtOtro
            // 
            this.rbtOtro.AutoSize = true;
            this.rbtOtro.Location = new System.Drawing.Point(162, 20);
            this.rbtOtro.Name = "rbtOtro";
            this.rbtOtro.Size = new System.Drawing.Size(45, 17);
            this.rbtOtro.TabIndex = 2;
            this.rbtOtro.TabStop = true;
            this.rbtOtro.Text = "Otro";
            this.rbtOtro.UseVisualStyleBackColor = true;
            this.rbtOtro.CheckedChanged += new System.EventHandler(this.rbtOtro_CheckedChanged);
            // 
            // rbtNoResp
            // 
            this.rbtNoResp.AutoSize = true;
            this.rbtNoResp.Location = new System.Drawing.Point(213, 20);
            this.rbtNoResp.Name = "rbtNoResp";
            this.rbtNoResp.Size = new System.Drawing.Size(126, 17);
            this.rbtNoResp.TabIndex = 3;
            this.rbtNoResp.TabStop = true;
            this.rbtNoResp.Text = "Prefiero no responder";
            this.rbtNoResp.UseVisualStyleBackColor = true;
            this.rbtNoResp.CheckedChanged += new System.EventHandler(this.rbtNoResp_CheckedChanged);
            // 
            // lblCompleteOtro
            // 
            this.lblCompleteOtro.AutoSize = true;
            this.lblCompleteOtro.Location = new System.Drawing.Point(60, 197);
            this.lblCompleteOtro.Name = "lblCompleteOtro";
            this.lblCompleteOtro.Size = new System.Drawing.Size(74, 13);
            this.lblCompleteOtro.TabIndex = 9;
            this.lblCompleteOtro.Text = "Complete Otro";
            this.lblCompleteOtro.Visible = false;
            // 
            // txtOtro
            // 
            this.txtOtro.Location = new System.Drawing.Point(140, 194);
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.Size = new System.Drawing.Size(267, 20);
            this.txtOtro.TabIndex = 10;
            this.txtOtro.Visible = false;
            // 
            // btnEdad
            // 
            this.btnEdad.Location = new System.Drawing.Point(140, 229);
            this.btnEdad.Name = "btnEdad";
            this.btnEdad.Size = new System.Drawing.Size(118, 23);
            this.btnEdad.TabIndex = 11;
            this.btnEdad.Text = "Calcular Edad";
            this.btnEdad.UseVisualStyleBackColor = true;
            this.btnEdad.Click += new System.EventHandler(this.btnEdad_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(140, 258);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(27, 20);
            this.txtEdad.TabIndex = 12;
            this.txtEdad.Visible = false;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(144, 301);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(114, 23);
            this.btnCargar.TabIndex = 14;
            this.btnCargar.Text = "Emitir Resumen";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // rbtResumen
            // 
            this.rbtResumen.EnableAutoDragDrop = true;
            this.rbtResumen.Location = new System.Drawing.Point(147, 342);
            this.rbtResumen.Name = "rbtResumen";
            this.rbtResumen.Size = new System.Drawing.Size(485, 91);
            this.rbtResumen.TabIndex = 15;
            this.rbtResumen.Text = "";
            // 
            // btnClases
            // 
            this.btnClases.Location = new System.Drawing.Point(302, 301);
            this.btnClases.Name = "btnClases";
            this.btnClases.Size = new System.Drawing.Size(177, 23);
            this.btnClases.TabIndex = 16;
            this.btnClases.Text = "Emitir Resumen con clase";
            this.btnClases.UseVisualStyleBackColor = true;
            this.btnClases.Click += new System.EventHandler(this.btnClases_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(827, 463);
            this.Controls.Add(this.btnClases);
            this.Controls.Add(this.rbtResumen);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.btnEdad);
            this.Controls.Add(this.txtOtro);
            this.Controls.Add(this.lblCompleteOtro);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.cboEstadoCivil);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Name = "Inicio";
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtNoResp;
        private System.Windows.Forms.RadioButton rbtOtro;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.Label lblCompleteOtro;
        private System.Windows.Forms.TextBox txtOtro;
        private System.Windows.Forms.Button btnEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.RichTextBox rbtResumen;
        private System.Windows.Forms.Button btnClases;
    }
}

