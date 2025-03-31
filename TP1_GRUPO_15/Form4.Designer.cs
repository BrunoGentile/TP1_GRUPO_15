namespace TP1_GRUPO_15
{
    partial class Form4
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
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.gbxEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbSoltero = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.checkedLbOficio = new System.Windows.Forms.CheckedListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lbElementos = new System.Windows.Forms.Label();
            this.gbxSexo.SuspendLayout();
            this.gbxEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbMasculino);
            this.gbxSexo.Controls.Add(this.rbFemenino);
            this.gbxSexo.Location = new System.Drawing.Point(32, 50);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(158, 108);
            this.gbxSexo.TabIndex = 1;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(28, 61);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(28, 37);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 0;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // gbxEstadoCivil
            // 
            this.gbxEstadoCivil.Controls.Add(this.rbSoltero);
            this.gbxEstadoCivil.Controls.Add(this.rbCasado);
            this.gbxEstadoCivil.Location = new System.Drawing.Point(270, 50);
            this.gbxEstadoCivil.Name = "gbxEstadoCivil";
            this.gbxEstadoCivil.Size = new System.Drawing.Size(157, 108);
            this.gbxEstadoCivil.TabIndex = 2;
            this.gbxEstadoCivil.TabStop = false;
            this.gbxEstadoCivil.Text = "Estado Civil";
            // 
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Location = new System.Drawing.Point(29, 61);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(58, 17);
            this.rbSoltero.TabIndex = 1;
            this.rbSoltero.TabStop = true;
            this.rbSoltero.Text = "Soltero";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Location = new System.Drawing.Point(29, 37);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(61, 17);
            this.rbCasado.TabIndex = 0;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // checkedLbOficio
            // 
            this.checkedLbOficio.FormattingEnabled = true;
            this.checkedLbOficio.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.checkedLbOficio.Location = new System.Drawing.Point(147, 183);
            this.checkedLbOficio.Name = "checkedLbOficio";
            this.checkedLbOficio.Size = new System.Drawing.Size(154, 94);
            this.checkedLbOficio.TabIndex = 3;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrar.Location = new System.Drawing.Point(147, 293);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(154, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar lo que se seleccionó";
            this.btnMostrar.UseVisualStyleBackColor = false;
            // 
            // lbElementos
            // 
            this.lbElementos.AutoSize = true;
            this.lbElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbElementos.Location = new System.Drawing.Point(99, 355);
            this.lbElementos.Name = "lbElementos";
            this.lbElementos.Size = new System.Drawing.Size(238, 20);
            this.lbElementos.TabIndex = 5;
            this.lbElementos.Text = "label para mostrar los elementos";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 517);
            this.Controls.Add(this.lbElementos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.checkedLbOficio);
            this.Controls.Add(this.gbxEstadoCivil);
            this.Controls.Add(this.gbxSexo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Ejercicio3";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.gbxEstadoCivil.ResumeLayout(false);
            this.gbxEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.GroupBox gbxEstadoCivil;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbSoltero;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.CheckedListBox checkedLbOficio;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lbElementos;
    }
}