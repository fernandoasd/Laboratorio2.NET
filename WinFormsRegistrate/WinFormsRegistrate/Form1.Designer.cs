namespace WinFormsRegistrate
{
    partial class Form1
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
            lblNombre = new System.Windows.Forms.Label();
            lblDireción = new System.Windows.Forms.Label();
            lblEdad = new System.Windows.Forms.Label();
            txbNombre = new System.Windows.Forms.TextBox();
            txbDireccion = new System.Windows.Forms.TextBox();
            lblPais = new System.Windows.Forms.Label();
            lstbPais = new System.Windows.Forms.ListBox();
            gbDetalleUsuario = new System.Windows.Forms.GroupBox();
            nudEdad = new System.Windows.Forms.NumericUpDown();
            gbGenero = new System.Windows.Forms.GroupBox();
            rbNoBinario = new System.Windows.Forms.RadioButton();
            rbFemenino = new System.Windows.Forms.RadioButton();
            rbMasculino = new System.Windows.Forms.RadioButton();
            gbCursos = new System.Windows.Forms.GroupBox();
            cbJS = new System.Windows.Forms.CheckBox();
            cbCMasMas = new System.Windows.Forms.CheckBox();
            cbC = new System.Windows.Forms.CheckBox();
            btnIngresar = new System.Windows.Forms.Button();
            gbDetalleUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            gbGenero.SuspendLayout();
            gbCursos.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(6, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(52, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblDireción
            // 
            lblDireción.AutoSize = true;
            lblDireción.Location = new System.Drawing.Point(6, 67);
            lblDireción.Name = "lblDireción";
            lblDireción.Size = new System.Drawing.Size(61, 15);
            lblDireción.TabIndex = 2;
            lblDireción.Text = "Direccion";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new System.Drawing.Point(6, 97);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new System.Drawing.Size(35, 15);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad";
            // 
            // txbNombre
            // 
            txbNombre.Location = new System.Drawing.Point(83, 31);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new System.Drawing.Size(100, 21);
            txbNombre.TabIndex = 4;
            // 
            // txbDireccion
            // 
            txbDireccion.Location = new System.Drawing.Point(83, 67);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new System.Drawing.Size(100, 21);
            txbDireccion.TabIndex = 5;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPais.Location = new System.Drawing.Point(37, 167);
            lblPais.Name = "lblPais";
            lblPais.Size = new System.Drawing.Size(36, 17);
            lblPais.TabIndex = 7;
            lblPais.Text = "País";
            lblPais.Click += label1_Click;
            // 
            // lstbPais
            // 
            lstbPais.FormattingEnabled = true;
            lstbPais.ItemHeight = 15;
            lstbPais.Location = new System.Drawing.Point(37, 186);
            lstbPais.Name = "lstbPais";
            lstbPais.Size = new System.Drawing.Size(204, 94);
            lstbPais.TabIndex = 8;
            // 
            // gbDetalleUsuario
            // 
            gbDetalleUsuario.Controls.Add(nudEdad);
            gbDetalleUsuario.Controls.Add(lblNombre);
            gbDetalleUsuario.Controls.Add(lblDireción);
            gbDetalleUsuario.Controls.Add(lblEdad);
            gbDetalleUsuario.Controls.Add(txbNombre);
            gbDetalleUsuario.Controls.Add(txbDireccion);
            gbDetalleUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbDetalleUsuario.Location = new System.Drawing.Point(37, 18);
            gbDetalleUsuario.Name = "gbDetalleUsuario";
            gbDetalleUsuario.Size = new System.Drawing.Size(204, 133);
            gbDetalleUsuario.TabIndex = 9;
            gbDetalleUsuario.TabStop = false;
            gbDetalleUsuario.Text = "Detalle del Usuario";
            // 
            // nudEdad
            // 
            nudEdad.Location = new System.Drawing.Point(83, 97);
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new System.Drawing.Size(100, 21);
            nudEdad.TabIndex = 13;
            // 
            // gbGenero
            // 
            gbGenero.Controls.Add(rbNoBinario);
            gbGenero.Controls.Add(rbFemenino);
            gbGenero.Controls.Add(rbMasculino);
            gbGenero.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbGenero.Location = new System.Drawing.Point(284, 20);
            gbGenero.Name = "gbGenero";
            gbGenero.Size = new System.Drawing.Size(116, 110);
            gbGenero.TabIndex = 10;
            gbGenero.TabStop = false;
            gbGenero.Text = "Género";
            // 
            // rbNoBinario
            // 
            rbNoBinario.AutoSize = true;
            rbNoBinario.Location = new System.Drawing.Point(7, 84);
            rbNoBinario.Name = "rbNoBinario";
            rbNoBinario.Size = new System.Drawing.Size(83, 19);
            rbNoBinario.TabIndex = 15;
            rbNoBinario.TabStop = true;
            rbNoBinario.Text = "No Binario";
            rbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            rbFemenino.AutoSize = true;
            rbFemenino.Location = new System.Drawing.Point(6, 54);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new System.Drawing.Size(80, 19);
            rbFemenino.TabIndex = 14;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "Femenino";
            rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new System.Drawing.Point(7, 22);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new System.Drawing.Size(83, 19);
            rbMasculino.TabIndex = 13;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // gbCursos
            // 
            gbCursos.Controls.Add(cbJS);
            gbCursos.Controls.Add(cbCMasMas);
            gbCursos.Controls.Add(cbC);
            gbCursos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbCursos.Location = new System.Drawing.Point(284, 136);
            gbCursos.Name = "gbCursos";
            gbCursos.Size = new System.Drawing.Size(115, 102);
            gbCursos.TabIndex = 11;
            gbCursos.TabStop = false;
            gbCursos.Text = "Cursos";
            // 
            // cbJS
            // 
            cbJS.AutoSize = true;
            cbJS.Location = new System.Drawing.Point(6, 78);
            cbJS.Name = "cbJS";
            cbJS.Size = new System.Drawing.Size(87, 19);
            cbJS.TabIndex = 14;
            cbJS.Text = "JavaScript";
            cbJS.UseVisualStyleBackColor = true;
            // 
            // cbCMasMas
            // 
            cbCMasMas.AutoSize = true;
            cbCMasMas.Location = new System.Drawing.Point(6, 53);
            cbCMasMas.Name = "cbCMasMas";
            cbCMasMas.Size = new System.Drawing.Size(48, 19);
            cbCMasMas.TabIndex = 14;
            cbCMasMas.Text = "C++";
            cbCMasMas.UseVisualStyleBackColor = true;
            // 
            // cbC
            // 
            cbC.AutoSize = true;
            cbC.Location = new System.Drawing.Point(6, 28);
            cbC.Name = "cbC";
            cbC.Size = new System.Drawing.Size(41, 19);
            cbC.TabIndex = 13;
            cbC.Text = "C#";
            cbC.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnIngresar.Location = new System.Drawing.Point(284, 257);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(116, 23);
            btnIngresar.TabIndex = 12;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(438, 301);
            Controls.Add(btnIngresar);
            Controls.Add(gbCursos);
            Controls.Add(gbGenero);
            Controls.Add(gbDetalleUsuario);
            Controls.Add(lstbPais);
            Controls.Add(lblPais);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += Form1_Load;
            gbDetalleUsuario.ResumeLayout(false);
            gbDetalleUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            gbGenero.ResumeLayout(false);
            gbGenero.PerformLayout();
            gbCursos.ResumeLayout(false);
            gbCursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDetalleUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireción;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ListBox lstbPais;
        private System.Windows.Forms.GroupBox gbDetalleUsuario;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.RadioButton rbNoBinario;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.GroupBox gbCursos;
        private System.Windows.Forms.CheckBox cbJS;
        private System.Windows.Forms.CheckBox cbCMasMas;
        private System.Windows.Forms.CheckBox cbC;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.NumericUpDown nudEdad;
    }
}
