using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_15
{
    public partial class Form2 : Form
    {
        public Form2(Form1 Form)
        {
            InitializeComponent();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ( ValidarAgregar( txtNombre.Text.Trim() ) ) {
                lbxIzquierda.Items.Add( txtNombre.Text.Trim() );
            }
            
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
                foreach ( string Nombre in lbxIzquierda.SelectedItems)
                {
                    lbxDerecha.Items.Add(Nombre);
                }
            }
        }
    }
}
