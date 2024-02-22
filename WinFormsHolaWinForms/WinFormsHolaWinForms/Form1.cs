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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbxMateriaFavorita.Items.Add("Prograación |");
            cbxMateriaFavorita.Items.Add("Prograación ||");
            cbxMateriaFavorita.Items.Add("Matematica");
            cbxMateriaFavorita.Items.Add("Ingles |");
            cbxMateriaFavorita.Items.Add("Laboratorio ||");
            cbxMateriaFavorita.Items.Add("Laboratorio |");
            cbxMateriaFavorita.Items.Add("Estadistica");
            cbxMateriaFavorita.SelectedIndex = 1;

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string mensajeError = "Se deben completar los siguiente/s campo/s:";
            bool banderaError = false;

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item.Name == "txtNombre" && String.IsNullOrWhiteSpace(txtNombre.Text))
                    {
                        mensajeError += $"\nNombre";
                        banderaError = true;
                    }

                    if (item.Name == "txtApellido" && String.IsNullOrWhiteSpace(txtApellido.Text))
                    {
                        mensajeError += $"\nApellido";
                        banderaError = true;
                    }
                }
            }

            //if (String.IsNullOrWhiteSpace(txtNombre.Text))
            //{
            //    mensajeError += $"\nNombre";
            //    banderaError = true;
            //}

            //if (String.IsNullOrWhiteSpace(txtApellido.Text))
            //{
            //    mensajeError += $"\nApellido";
            //    banderaError = true;
            //}

            if (!banderaError)
            {
                Form2 winFormSaludo = new Form2(txtNombre.Text, txtApellido.Text, cbxMateriaFavorita.Text);

                winFormSaludo.Show();
            }
            else
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

