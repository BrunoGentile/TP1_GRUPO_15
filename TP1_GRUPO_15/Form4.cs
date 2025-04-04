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
    public partial class Form4 : Form
    {
        Form1 form1;
        public Form4(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

        }

        /// Funciones

        private string VerificarGenero()
        {
            string Genero;

            if ( rbFemenino.Checked)
            {
                Genero = "Femenino";
            }
            else
            {
                Genero = "Masculino";
            }

                return Genero;
        }

        private bool ValidarSeleccionOficio()
        {
            return checkedLbOficio.CheckedItems.Count > 0;
        }

        /// Eventos

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccionOficio() == false)
            {
                MessageBox.Show("Debe seleccionar al menos un oficio.");
                return;
            }

            string Genero = VerificarGenero();
            string EstadoCivil = (string)(rbCasado.Checked ? "Casado" : "Soltero");

            List<string> seleccionados = new List<string>();

            foreach (var item in checkedLbOficio.CheckedItems)
            {
                seleccionados.Add("- " + item.ToString());
            }

            string mensaje = "Usted seleccionó los siguientes elementos:\r\n";
            mensaje += "Sexo: " + Genero +"\r\n";
            mensaje += "Estado Civil: " + EstadoCivil + "\r\n";
            mensaje += "Oficio: " + "\r\n";
            mensaje += string.Join("\r\n", seleccionados);

            lbElementos.Text = mensaje;

        }

        private void rbCasado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbElementos_Click(object sender, EventArgs e)
        {
            {
            }

        }
    }
}
