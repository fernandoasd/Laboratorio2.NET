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

namespace ConversorBinarioDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtResultadoBin.Enabled = false;
            txtResultadoDec.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBinario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBinario.Text) && int.TryParse(txtBinario.Text, out int binarioParseado))
            {
                txtResultadoDec.Text = Conversor.ConvertirBinarioADecimal(binarioParseado);
            }
            else
            {
                MessageBox.Show("Número binario no valido. Por favor solo ingrese ceros y unos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDecimal.Text) && int.TryParse(txtDecimal.Text, out int decimalparseado))
            {
                txtResultadoBin.Text = Conversor.ConvertirDecimalABinario(decimalparseado);
            }
            else
            {
                MessageBox.Show("Número decimal no valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
