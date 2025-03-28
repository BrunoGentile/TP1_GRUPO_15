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
    public partial class Form2 : Form
    {
        public Form2(Form1 Form)
        {
            InitializeComponent();
        }
        private void ValidarAgregar()
        {
            btnAgregar.Enabled = (txtNombre.BackColor != Color.Red);
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
          
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
                tb.BackColor = Color.Red;
            else
                tb.BackColor = System.Drawing.SystemColors.Window;
            ValidarAgregar();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
        }
    }
}
