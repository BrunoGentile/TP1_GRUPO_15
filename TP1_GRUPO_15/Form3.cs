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
        Form1 form1;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text.Trim();
            string apellido = textBox2.Text.Trim();

            listBox1.Items.Add(nombre + " " + apellido);
            textBox1.Clear();
            textBox2.Clear();
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
            form1.Show();
        }
    }
}
