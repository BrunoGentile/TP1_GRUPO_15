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
    public partial class Form3 : Form
    {
        public Form3(Form1 Form)
        {
            InitializeComponent();
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
    }
}
