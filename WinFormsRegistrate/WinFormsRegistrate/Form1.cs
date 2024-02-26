using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRegistrate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDetalleUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstbPais.Items.Add("Argentina");
            lstbPais.Items.Add("Chile");
            lstbPais.Items.Add("Uruguay");
            lstbPais.SelectedIndex = 0;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            StringBuilder mensajeError = new StringBuilder("Se deben completar los siguiente/s campo/s:\n");
            bool banderaError = false;
            bool banderaErrorGenero = true;
            string generoSeleccionado = "";
            string cursos = "";
            String[] arrayCursos = new string[0];


            foreach (Control item in gbDetalleUsuario.Controls)
            {
                if (item is TextBox && string.IsNullOrWhiteSpace(item.Text))
                {
                    mensajeError.AppendLine(item.Name);
                    banderaError = true;
                } 
            }

            foreach (Control item in gbCursos.Controls)
            {
                if (((CheckBox)item).Checked)
                {
                    Array.Resize<string>(ref arrayCursos, arrayCursos.Length + 1);
                    arrayCursos[arrayCursos.Length - 1] = item.Text;
                }
            }

            foreach (Control item in gbGenero.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    banderaErrorGenero = false;
                    generoSeleccionado = ((RadioButton)item).Text;
                }
            }

            if (banderaErrorGenero)
            {
                mensajeError.AppendLine("Género");
            }

            if (banderaError || banderaErrorGenero)
            {
                MessageBox.Show(mensajeError.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Ingresante ingresanteNuevo = new Ingresante(arrayCursos, txbDireccion.Text, (int)nudEdad.Value, generoSeleccionado, txbNombre.Text, lstbPais.SelectedItem.ToString());

                MessageBox.Show(ingresanteNuevo.Mostrar(), "Datos de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }





        }
    }
}
