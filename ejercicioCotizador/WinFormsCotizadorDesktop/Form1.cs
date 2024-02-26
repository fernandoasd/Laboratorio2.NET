using Billetes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCotizadorDesktop
{
    public partial class Form1 : Form
    {
        int indiceImagen;
        public Form1()
        {
            InitializeComponent();
            indiceImagen = 1;
            btnLockCotizacion.ImageIndex = indiceImagen;
            txtCotizadorEuros.Text = Euro.GetCotizacion().ToString();
            txtCotizadorPesos.Text = Peso.GetCotizacion().ToString();
            txtCotizadorDolares.Text = Dolar.GetCotizacion().ToString();
        }

        private void lblEuro_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtEuro.Text, out double cantidadEuros))
            {
                Euro euros = new Euro(cantidadEuros);
                txtEuroAEuro.Text = euros.ToString();
                txtEuroADolar.Text = ((Dolar)euros).ToString();
                txtEuroAPeso.Text = ((Peso)euros).ToString();
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDolar.Text, out double cantidadDolares))
            {
                Dolar dolares = (Dolar)cantidadDolares;
                txtDolarAEuro.Text = ((Euro)dolares).ToString();
                txtDolarADolar.Text = dolares.ToString();
                txtDolarAPeso.Text = ((Peso)dolares).ToString();
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPeso.Text, out double cantidadPesos))
            {
                Peso pesos = (Peso)cantidadPesos;
                txtPesoAEuro.Text = ((Euro)pesos).ToString();
                txtPesoADolar.Text = ((Dolar)pesos).ToString();
                txtPesoAPeso.Text = pesos.ToString();
            }
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            indiceImagen++;

            if (indiceImagen > 1)
            {
                indiceImagen = 0;
            }

            //switch (indiceImagen)
            //{
            //    case 0:
            //        txtCotizadorEuros.Enabled = false;
            //        txtCotizadorDolares.Enabled = false;
            //        txtCotizadorPesos.Enabled = false;
            //        break;
            //    default:
            //        txtCotizadorEuros.Enabled = true;
            //        txtCotizadorDolares.Enabled = true;
            //        txtCotizadorPesos.Enabled = true;
            //        indiceImagen = 0;
            //        break;

            //}

            if (indiceImagen == 1)
            {
                txtCotizadorEuros.Enabled = true;
                txtCotizadorPesos.Enabled = true;
            }
            else
            {
                txtCotizadorEuros.Enabled = false;
                txtCotizadorPesos.Enabled = false;
            }
            btnLockCotizacion.ImageIndex = indiceImagen;
            txtCotizadorDolares.Text = indiceImagen.ToString();
        }

        private void txtCotizadorEuros_Leave(object sender, EventArgs e)
        {
            txtCotizadorEuros.Text = txtCotizadorEuros.Text.Replace(".", ",");
            if (double.TryParse(txtCotizadorEuros.Text, out double cotizaciónAuro))
            {
                Euro.SetCotizacion(cotizaciónAuro);
                MessageBox.Show(cotizaciónAuro.ToString());
            }
            else
            {
                txtCotizadorEuros.Focus();
            }
        }

        private void txtCotizadorPesos_Leave(object sender, EventArgs e)
        {
            txtCotizadorPesos.Text = txtCotizadorPesos.Text.Replace(".", ",");
            if (double.TryParse(txtCotizadorPesos.Text, out double cotizaciónPeso))
            {
                Euro.SetCotizacion(cotizaciónPeso);
                MessageBox.Show(cotizaciónPeso.ToString());
            }
            else
            {
                txtCotizadorPesos.Focus();
            }
        }
    }
}
