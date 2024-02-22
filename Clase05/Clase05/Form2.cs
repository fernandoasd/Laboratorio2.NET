using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase05
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Crear formulario?", "Nuevo formulario", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {
                Form2 frm = new Form2();
                frm.Show();
            }
        }
    }
}
