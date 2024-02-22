namespace Clase05
{
    partial class Form01
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            lstPersonas = new System.Windows.Forms.ListBox();
            textName = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnShow = new System.Windows.Forms.Button();
            nudEdad = new System.Windows.Forms.NumericUpDown();
            checkBox1 = new System.Windows.Forms.CheckBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            checkBox3 = new System.Windows.Forms.CheckBox();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton3 = new System.Windows.Forms.RadioButton();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            grb1 = new System.Windows.Forms.GroupBox();
            listBox1 = new System.Windows.Forms.ListBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            grb1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Form01";
            label1.Click += label1_Click;
            // 
            // lstPersonas
            // 
            lstPersonas.FormattingEnabled = true;
            lstPersonas.ItemHeight = 15;
            lstPersonas.Location = new System.Drawing.Point(12, 27);
            lstPersonas.Name = "lstPersonas";
            lstPersonas.Size = new System.Drawing.Size(120, 154);
            lstPersonas.TabIndex = 1;
            lstPersonas.SelectedIndexChanged += lstNames_SelectedIndexChanged;
            // 
            // textName
            // 
            textName.Location = new System.Drawing.Point(138, 45);
            textName.Name = "textName";
            textName.Size = new System.Drawing.Size(100, 23);
            textName.TabIndex = 2;
            textName.TextChanged += txtName_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(138, 158);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(100, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            btnAdd.MouseClick += btnAdd_MouseClick;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(257, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Agrandar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(138, 214);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Form2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(12, 214);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Form1";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(138, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(138, 80);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 15);
            label3.TabIndex = 8;
            label3.Text = "Edad";
            label3.Click += label3_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new System.Drawing.Point(258, 158);
            btnShow.Name = "btnShow";
            btnShow.Size = new System.Drawing.Size(75, 23);
            btnShow.TabIndex = 10;
            btnShow.Text = "Mostrar";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += button4_Click;
            // 
            // nudEdad
            // 
            nudEdad.Location = new System.Drawing.Point(138, 98);
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new System.Drawing.Size(51, 23);
            nudEdad.TabIndex = 11;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(6, 40);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(83, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(541, 52);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(83, 19);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new System.Drawing.Point(541, 79);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(83, 19);
            checkBox3.TabIndex = 14;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(100, 37);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(94, 19);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(406, 55);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(94, 19);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new System.Drawing.Point(406, 80);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(94, 19);
            radioButton3.TabIndex = 17;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 21);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(212, 15);
            label4.TabIndex = 18;
            label4.Text = "Indeterminado / checked para agregar.";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(541, 27);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(85, 15);
            label5.TabIndex = 19;
            label5.Text = "Indeterminado";
            // 
            // grb1
            // 
            grb1.Controls.Add(label4);
            grb1.Controls.Add(checkBox1);
            grb1.Controls.Add(radioButton1);
            grb1.Location = new System.Drawing.Point(406, 121);
            grb1.Name = "grb1";
            grb1.Size = new System.Drawing.Size(218, 100);
            grb1.TabIndex = 20;
            grb1.TabStop = false;
            grb1.Text = "Grupo 1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(683, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(347, 94);
            listBox1.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(683, 154);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(217, 23);
            comboBox1.TabIndex = 22;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form01
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1054, 266);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(grb1);
            Controls.Add(label5);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(nudEdad);
            Controls.Add(btnShow);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Controls.Add(textName);
            Controls.Add(lstPersonas);
            Controls.Add(label1);
            Name = "Form01";
            Text = "Form01";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            grb1.ResumeLayout(false);
            grb1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPersonas;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
