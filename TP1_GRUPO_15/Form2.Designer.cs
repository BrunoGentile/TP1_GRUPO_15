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
            this.SuspendLayout();
            // 
            // lbxIzquierda
            // 
            this.lbxIzquierda.FormattingEnabled = true;
            this.lbxIzquierda.Location = new System.Drawing.Point(75, 123);
            this.lbxIzquierda.Name = "lbxIzquierda";
            this.lbxIzquierda.Size = new System.Drawing.Size(197, 238);
            this.lbxIzquierda.TabIndex = 0;
            // 
            // lbxDerecha
            // 
            this.lbxDerecha.FormattingEnabled = true;
            this.lbxDerecha.Location = new System.Drawing.Point(491, 123);
            this.lbxDerecha.Name = "lbxDerecha";
            this.lbxDerecha.Size = new System.Drawing.Size(197, 238);
            this.lbxDerecha.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(264, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(227, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbxDerecha);
            this.Controls.Add(this.lbxIzquierda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxIzquierda;
        private System.Windows.Forms.ListBox lbxDerecha;
        private System.Windows.Forms.TextBox txtNombre;
    }
}