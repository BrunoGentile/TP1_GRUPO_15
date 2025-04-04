using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_15
{
    public partial class Formulario3 : Form
    {
        Form1 formulario1;
        
        public Formulario3(Form1 formulario1)
        {
            InitializeComponent();
            this.formulario1 = formulario1;
        }
        
        Form1 form1;
        public void Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private bool CompararNombres(string nombre, string apellido)
        {
            string nombreApellido = nombre +" "+ apellido;
            
            foreach (string personas in listBox1.Items)
            {

                if(nombreApellido.ToLower() == personas.ToLower())
                {
                    
                    MessageBox.Show("el nombre ya se encuentra en la lista, ingrese uno distinto");
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text.Trim();
            string apellido = textBox2.Text.Trim();
           
            if (NombresEnBlanco(nombre, apellido) == false) 
            {
                if(!CompararNombres(nombre, apellido))
                {
                listBox1.Items.Add(nombre + " " + apellido);
                }

            }
            else
            {
                textBox1.BackColor = Color.DarkRed;
                textBox2.BackColor = Color.DarkRed;
                MessageBox.Show("Debe completar todos los campos");
            }

            textBox1.Clear();
            textBox2.Clear();

            listBox1.Sorted = true;
        }
        private bool NombresEnBlanco(string nombre, string apellido)
                {
                    if (nombre.Length == 0 || apellido.Length == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
  
        private void button2_Click(object sender, EventArgs e)
        {
            List<object> itemsToRemove = new List<object>();

            foreach (var item in listBox1.SelectedItems)
            {
                itemsToRemove.Add(item);
            }

            foreach (var item in itemsToRemove)
            {
                listBox1.Items.Remove(item);
            }

            //for( int i = listBox1.Items.Count - 1; i > 0; i--)
            //{
            //    if( listBox1.GetSelected(i) )
            //    {
            //        listBox1.Items.Remove( listBox1.Items[i] );
            //    }
            //}
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario1.Show();
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            textBox1.BackColor = System.Drawing.SystemColors.Window;
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            textBox2.BackColor = System.Drawing.SystemColors.Window;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
