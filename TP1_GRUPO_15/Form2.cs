using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_15
{
    public partial class Formulario2 : Form
    {
        Form1 formulario1;
        public Formulario2(Form1 formulario1)
        {
            InitializeComponent();
            this.formulario1 = formulario1;

            txtNombre.Leave += new EventHandler(txtNombre_Leave);


        }
        //private void ValidarAgregar()
        //{
        //    btnAgregar.Enabled = (txtNombre.BackColor != Color.Red);
        //}


        private bool ValidarAgregar(string TB)
        {
            bool Condicion = true;

            if ( TB.Length == 0 )
            {
                Condicion = false;
                txtNombre.BackColor = Color.DarkRed;
            }
            else
            {
                txtNombre.BackColor = System.Drawing.SystemColors.Window;
            }

                return Condicion;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //btnAgregar.Enabled = false;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            txtNombre.Text = CapitalizarPrimeraLetra(txtNombre.Text);
        }
        private string CapitalizarPrimeraLetra(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return "";

            texto = texto.ToLower(); // Convierte todo a minúsculas
            return char.ToUpper(texto[0]) + texto.Substring(1);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreFormateado = CapitalizarPrimeraLetra(txtNombre.Text.Trim());

            if ( ValidarAgregar( txtNombre.Text.Trim() ) ) {
                lbxIzquierda.Items.Add( txtNombre.Text.Trim() );
            }

            txtNombre.Text = "";


        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNombre.BackColor = System.Drawing.SystemColors.Window;
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            if (lbxIzquierda.Items.Count == 0)
            {
                MessageBox.Show("No se encuentran datos en la lista");
            }
            else
            {
                foreach (string nombre in lbxIzquierda.Items)
                {
                    lbxDerecha.Items.Add(nombre);
                }
                    lbxIzquierda.Items.Clear();
            }
        }
        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            if( lbxIzquierda.Items.Count == 0 )
            {
                MessageBox.Show("No se encuentran datos en la lista");
            }
            else
            {
                List<string> itemsToRemove = new List<string>();

                foreach (string Nombre in lbxIzquierda.SelectedItems)
                {
                    lbxDerecha.Items.Add(Nombre);
                    itemsToRemove.Add(Nombre);
                }

                foreach (string Nombre in itemsToRemove)
                {
                    lbxIzquierda.Items.Remove(Nombre);
                }
            }
        }


        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario1.Show();
        }
    }
}
