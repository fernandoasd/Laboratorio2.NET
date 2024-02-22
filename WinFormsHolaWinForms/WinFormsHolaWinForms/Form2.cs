using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHolaWinForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string nombre, string apellido, string materiaFavorita)
        {
            InitializeComponent();
            lblSoy.Text = $"Soy {nombre} {apellido} y mi materia favorita es {materiaFavorita}.";
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblSaludo_Click(object sender, EventArgs e)
        {

        }
    }
}
