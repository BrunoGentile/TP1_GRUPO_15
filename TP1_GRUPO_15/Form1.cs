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
    public partial class Form1: Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formulario2 Ejercicio1 = new Formulario2(this);
            Ejercicio1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formulario3 Ejercicio2 = new Formulario3(this); 
            Ejercicio2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Ejercicio3 = new Form4(this);
            Ejercicio3.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
