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
using static System.Windows.Forms.DataFormats;

namespace Clase05
{
    public partial class Form01 : Form 
    {
        public Form01()
        {
            InitializeComponent();
        }

        // Agrego un nuevo control por código - textBox edad.
        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox2.ThreeState = true;
            checkBox1.ThreeState = true;

            comboBox1.Items.Add("Item 1");
            comboBox1.Items.Add("Item 2");


            //TextBox textEdad = new TextBox();
            //textEdad.Location = new System.Drawing.Point(138, 110);
            //textEdad.Name = "textEdad";
            //this.Controls.Add(textEdad);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.Text == "Agrandar")
            {
                Size = new Size(350, 300);
                button1.Text = "Achicar";
            }
            else
            {
                Size = new Size(268, 180);
                button1.Text = "Agrandar";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Size = new Size(500, 200);
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(200, 300);
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Crear formulario?", "Nuevo formulario", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {
                Form01 frm = new Form01();
                frm.ShowDialog();
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textName.Text) && !lstPersonas.Items.Contains(textName.Text))
            {
                foreach (Control item in grb1.Controls)
                {
                    if (item is CheckBox && ((CheckBox)item).CheckState == CheckState.Indeterminate)
                    {
                        if (radioButton1.Checked)
                        {
                            Persona persona = new Persona(textName.Text, (int)nudEdad.Value);
                            MessageBox.Show(persona.Mostrar());
                            lstPersonas.Items.Add(textName.Text);

                            string[] nombresPersonas = new string[0];
                            Array.Resize<string>(ref nombresPersonas, nombresPersonas.Length + 1);
                            nombresPersonas[nombresPersonas.Length - 1] = textName.Text;
                            MessageBox.Show($"Personas: {nombresPersonas.Length}, Ultima P: {nombresPersonas[nombresPersonas.Length - 1]}");
                            listBox1.Items.Add(nombresPersonas[nombresPersonas.Length - 1]);
                        }
                    }
                }
            }





        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string listBoxItem = (string)listBox1.SelectedItem;
                MessageBox.Show(listBoxItem);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
