namespace TP1_GRUPO_15
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbxIzquierda = new System.Windows.Forms.ListBox();
            this.lbxDerecha = new System.Windows.Forms.ListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxIzquierda
            // 
            this.lbxIzquierda.FormattingEnabled = true;
            this.lbxIzquierda.ItemHeight = 20;
            this.lbxIzquierda.Location = new System.Drawing.Point(112, 189);
            this.lbxIzquierda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxIzquierda.Name = "lbxIzquierda";
            this.lbxIzquierda.Size = new System.Drawing.Size(294, 364);
            this.lbxIzquierda.TabIndex = 0;
            // 
            // lbxDerecha
            // 
            this.lbxDerecha.FormattingEnabled = true;
            this.lbxDerecha.ItemHeight = 20;
            this.lbxDerecha.Location = new System.Drawing.Point(736, 189);
            this.lbxDerecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxDerecha.Name = "lbxDerecha";
            this.lbxDerecha.Size = new System.Drawing.Size(294, 364);
            this.lbxDerecha.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(407, 113);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(338, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(170, 113);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(218, 26);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Ingrese un nombre:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(818, 100);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 48);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeleccion.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccion.Location = new System.Drawing.Point(525, 286);
            this.btnSeleccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(86, 46);
            this.btnSeleccion.TabIndex = 5;
            this.btnSeleccion.Text = ">";
            this.btnSeleccion.UseVisualStyleBackColor = false;
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTodos.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.Location = new System.Drawing.Point(525, 372);
            this.btnTodos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(86, 46);
            this.btnTodos.TabIndex = 6;
            this.btnTodos.Text = ">>";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnSeleccion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbxDerecha);
            this.Controls.Add(this.lbxIzquierda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombres";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxIzquierda;
        private System.Windows.Forms.ListBox lbxDerecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.Button btnTodos;
    }
}