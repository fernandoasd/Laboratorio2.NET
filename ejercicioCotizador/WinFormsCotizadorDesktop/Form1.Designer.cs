namespace WinFormsCotizadorDesktop
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imglFotos = new System.Windows.Forms.ImageList(components);
            lblCotizacion = new System.Windows.Forms.Label();
            lblEuroA = new System.Windows.Forms.Label();
            lblDolarA = new System.Windows.Forms.Label();
            lblPesoA = new System.Windows.Forms.Label();
            btnConvertEuro = new System.Windows.Forms.Button();
            btnConvertDolar = new System.Windows.Forms.Button();
            btnConvertPeso = new System.Windows.Forms.Button();
            lblEuro = new System.Windows.Forms.Label();
            lblDolar = new System.Windows.Forms.Label();
            lblPeso = new System.Windows.Forms.Label();
            txtEuro = new System.Windows.Forms.TextBox();
            txtDolar = new System.Windows.Forms.TextBox();
            txtPeso = new System.Windows.Forms.TextBox();
            txtEuroAEuro = new System.Windows.Forms.TextBox();
            txtDolarAEuro = new System.Windows.Forms.TextBox();
            txtPesoAEuro = new System.Windows.Forms.TextBox();
            txtEuroADolar = new System.Windows.Forms.TextBox();
            txtDolarADolar = new System.Windows.Forms.TextBox();
            txtPesoADolar = new System.Windows.Forms.TextBox();
            txtEuroAPeso = new System.Windows.Forms.TextBox();
            txtDolarAPeso = new System.Windows.Forms.TextBox();
            txtPesoAPeso = new System.Windows.Forms.TextBox();
            txtCotizadorEuros = new System.Windows.Forms.TextBox();
            txtCotizadorDolares = new System.Windows.Forms.TextBox();
            txtCotizadorPesos = new System.Windows.Forms.TextBox();
            btnLockCotizacion = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // imglFotos
            // 
            imglFotos.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imglFotos.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imglFotos.ImageStream");
            imglFotos.TransparentColor = System.Drawing.Color.White;
            imglFotos.Images.SetKeyName(0, "candado_cerrado.png");
            imglFotos.Images.SetKeyName(1, "candado_abierto.png");
            // 
            // lblCotizacion
            // 
            lblCotizacion.AutoSize = true;
            lblCotizacion.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCotizacion.Location = new System.Drawing.Point(42, 14);
            lblCotizacion.Name = "lblCotizacion";
            lblCotizacion.Size = new System.Drawing.Size(77, 17);
            lblCotizacion.TabIndex = 0;
            lblCotizacion.Text = "Cotización";
            // 
            // lblEuroA
            // 
            lblEuroA.AutoSize = true;
            lblEuroA.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblEuroA.Location = new System.Drawing.Point(12, 67);
            lblEuroA.Name = "lblEuroA";
            lblEuroA.Size = new System.Drawing.Size(38, 17);
            lblEuroA.TabIndex = 1;
            lblEuroA.Text = "Euro";
            // 
            // lblDolarA
            // 
            lblDolarA.AutoSize = true;
            lblDolarA.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDolarA.Location = new System.Drawing.Point(12, 103);
            lblDolarA.Name = "lblDolarA";
            lblDolarA.Size = new System.Drawing.Size(42, 17);
            lblDolarA.TabIndex = 2;
            lblDolarA.Text = "Dólar";
            // 
            // lblPesoA
            // 
            lblPesoA.AutoSize = true;
            lblPesoA.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPesoA.Location = new System.Drawing.Point(14, 132);
            lblPesoA.Name = "lblPesoA";
            lblPesoA.Size = new System.Drawing.Size(40, 17);
            lblPesoA.TabIndex = 3;
            lblPesoA.Text = "Peso";
            // 
            // btnConvertEuro
            // 
            btnConvertEuro.Location = new System.Drawing.Point(166, 61);
            btnConvertEuro.Name = "btnConvertEuro";
            btnConvertEuro.Size = new System.Drawing.Size(75, 23);
            btnConvertEuro.TabIndex = 4;
            btnConvertEuro.Text = "->";
            btnConvertEuro.UseVisualStyleBackColor = true;
            btnConvertEuro.Click += btnConvertEuro_Click;
            // 
            // btnConvertDolar
            // 
            btnConvertDolar.Location = new System.Drawing.Point(166, 97);
            btnConvertDolar.Name = "btnConvertDolar";
            btnConvertDolar.Size = new System.Drawing.Size(75, 23);
            btnConvertDolar.TabIndex = 5;
            btnConvertDolar.Text = "->";
            btnConvertDolar.UseVisualStyleBackColor = true;
            btnConvertDolar.Click += btnConvertDolar_Click;
            // 
            // btnConvertPeso
            // 
            btnConvertPeso.Location = new System.Drawing.Point(166, 132);
            btnConvertPeso.Name = "btnConvertPeso";
            btnConvertPeso.Size = new System.Drawing.Size(75, 23);
            btnConvertPeso.TabIndex = 6;
            btnConvertPeso.Text = "->";
            btnConvertPeso.UseVisualStyleBackColor = true;
            btnConvertPeso.Click += btnConvertPeso_Click;
            // 
            // lblEuro
            // 
            lblEuro.AutoSize = true;
            lblEuro.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblEuro.Location = new System.Drawing.Point(285, 41);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new System.Drawing.Size(38, 17);
            lblEuro.TabIndex = 7;
            lblEuro.Text = "Euro";
            lblEuro.Click += lblEuro_Click;
            // 
            // lblDolar
            // 
            lblDolar.AutoSize = true;
            lblDolar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDolar.Location = new System.Drawing.Point(386, 41);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new System.Drawing.Size(42, 17);
            lblDolar.TabIndex = 8;
            lblDolar.Text = "Dólar";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPeso.Location = new System.Drawing.Point(511, 41);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new System.Drawing.Size(40, 17);
            lblPeso.TabIndex = 9;
            lblPeso.Text = "Peso";
            // 
            // txtEuro
            // 
            txtEuro.Location = new System.Drawing.Point(60, 61);
            txtEuro.Name = "txtEuro";
            txtEuro.Size = new System.Drawing.Size(100, 23);
            txtEuro.TabIndex = 10;
            // 
            // txtDolar
            // 
            txtDolar.Location = new System.Drawing.Point(60, 97);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new System.Drawing.Size(100, 23);
            txtDolar.TabIndex = 11;
            // 
            // txtPeso
            // 
            txtPeso.Location = new System.Drawing.Point(60, 132);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new System.Drawing.Size(100, 23);
            txtPeso.TabIndex = 12;
            // 
            // txtEuroAEuro
            // 
            txtEuroAEuro.Enabled = false;
            txtEuroAEuro.Location = new System.Drawing.Point(257, 61);
            txtEuroAEuro.Name = "txtEuroAEuro";
            txtEuroAEuro.Size = new System.Drawing.Size(100, 23);
            txtEuroAEuro.TabIndex = 13;
            // 
            // txtDolarAEuro
            // 
            txtDolarAEuro.Enabled = false;
            txtDolarAEuro.Location = new System.Drawing.Point(256, 98);
            txtDolarAEuro.Name = "txtDolarAEuro";
            txtDolarAEuro.Size = new System.Drawing.Size(100, 23);
            txtDolarAEuro.TabIndex = 14;
            // 
            // txtPesoAEuro
            // 
            txtPesoAEuro.Enabled = false;
            txtPesoAEuro.Location = new System.Drawing.Point(256, 133);
            txtPesoAEuro.Name = "txtPesoAEuro";
            txtPesoAEuro.Size = new System.Drawing.Size(100, 23);
            txtPesoAEuro.TabIndex = 15;
            // 
            // txtEuroADolar
            // 
            txtEuroADolar.Enabled = false;
            txtEuroADolar.Location = new System.Drawing.Point(362, 61);
            txtEuroADolar.Name = "txtEuroADolar";
            txtEuroADolar.Size = new System.Drawing.Size(100, 23);
            txtEuroADolar.TabIndex = 16;
            // 
            // txtDolarADolar
            // 
            txtDolarADolar.Enabled = false;
            txtDolarADolar.Location = new System.Drawing.Point(362, 98);
            txtDolarADolar.Name = "txtDolarADolar";
            txtDolarADolar.Size = new System.Drawing.Size(100, 23);
            txtDolarADolar.TabIndex = 17;
            // 
            // txtPesoADolar
            // 
            txtPesoADolar.Enabled = false;
            txtPesoADolar.Location = new System.Drawing.Point(362, 133);
            txtPesoADolar.Name = "txtPesoADolar";
            txtPesoADolar.Size = new System.Drawing.Size(100, 23);
            txtPesoADolar.TabIndex = 18;
            // 
            // txtEuroAPeso
            // 
            txtEuroAPeso.Enabled = false;
            txtEuroAPeso.Location = new System.Drawing.Point(468, 62);
            txtEuroAPeso.Name = "txtEuroAPeso";
            txtEuroAPeso.Size = new System.Drawing.Size(100, 23);
            txtEuroAPeso.TabIndex = 19;
            // 
            // txtDolarAPeso
            // 
            txtDolarAPeso.Enabled = false;
            txtDolarAPeso.Location = new System.Drawing.Point(468, 98);
            txtDolarAPeso.Name = "txtDolarAPeso";
            txtDolarAPeso.Size = new System.Drawing.Size(100, 23);
            txtDolarAPeso.TabIndex = 20;
            // 
            // txtPesoAPeso
            // 
            txtPesoAPeso.Enabled = false;
            txtPesoAPeso.Location = new System.Drawing.Point(468, 133);
            txtPesoAPeso.Name = "txtPesoAPeso";
            txtPesoAPeso.Size = new System.Drawing.Size(100, 23);
            txtPesoAPeso.TabIndex = 21;
            // 
            // txtCotizadorEuros
            // 
            txtCotizadorEuros.Location = new System.Drawing.Point(256, 12);
            txtCotizadorEuros.Name = "txtCotizadorEuros";
            txtCotizadorEuros.Size = new System.Drawing.Size(100, 23);
            txtCotizadorEuros.TabIndex = 22;
            txtCotizadorEuros.Leave += txtCotizadorEuros_Leave;
            // 
            // txtCotizadorDolares
            // 
            txtCotizadorDolares.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            txtCotizadorDolares.Enabled = false;
            txtCotizadorDolares.Location = new System.Drawing.Point(362, 12);
            txtCotizadorDolares.Name = "txtCotizadorDolares";
            txtCotizadorDolares.Size = new System.Drawing.Size(100, 23);
            txtCotizadorDolares.TabIndex = 23;
            txtCotizadorDolares.Text = "1";
            // 
            // txtCotizadorPesos
            // 
            txtCotizadorPesos.Location = new System.Drawing.Point(468, 12);
            txtCotizadorPesos.Name = "txtCotizadorPesos";
            txtCotizadorPesos.Size = new System.Drawing.Size(100, 23);
            txtCotizadorPesos.TabIndex = 24;
            txtCotizadorPesos.Leave += txtCotizadorPesos_Leave;
            // 
            // btnLockCotizacion
            // 
            btnLockCotizacion.ImageIndex = 1;
            btnLockCotizacion.ImageList = imglFotos;
            btnLockCotizacion.Location = new System.Drawing.Point(155, 12);
            btnLockCotizacion.Name = "btnLockCotizacion";
            btnLockCotizacion.Size = new System.Drawing.Size(68, 40);
            btnLockCotizacion.TabIndex = 25;
            btnLockCotizacion.UseVisualStyleBackColor = true;
            btnLockCotizacion.Click += btnLockCotizacion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(612, 187);
            Controls.Add(btnLockCotizacion);
            Controls.Add(txtCotizadorPesos);
            Controls.Add(txtCotizadorDolares);
            Controls.Add(txtCotizadorEuros);
            Controls.Add(txtPesoAPeso);
            Controls.Add(txtDolarAPeso);
            Controls.Add(txtEuroAPeso);
            Controls.Add(txtPesoADolar);
            Controls.Add(txtDolarADolar);
            Controls.Add(txtEuroADolar);
            Controls.Add(txtPesoAEuro);
            Controls.Add(txtDolarAEuro);
            Controls.Add(txtEuroAEuro);
            Controls.Add(txtPeso);
            Controls.Add(txtDolar);
            Controls.Add(txtEuro);
            Controls.Add(lblPeso);
            Controls.Add(lblDolar);
            Controls.Add(lblEuro);
            Controls.Add(btnConvertPeso);
            Controls.Add(btnConvertDolar);
            Controls.Add(btnConvertEuro);
            Controls.Add(lblPesoA);
            Controls.Add(lblDolarA);
            Controls.Add(lblEuroA);
            Controls.Add(lblCotizacion);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Conversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ImageList imglFotos;
        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.Label lblEuroA;
        private System.Windows.Forms.Label lblDolarA;
        private System.Windows.Forms.Label lblPesoA;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertPeso;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtPesoAEuro;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtPesoADolar;
        private System.Windows.Forms.TextBox txtEuroAPeso;
        private System.Windows.Forms.TextBox txtDolarAPeso;
        private System.Windows.Forms.TextBox txtPesoAPeso;
        private System.Windows.Forms.TextBox txtCotizadorEuros;
        private System.Windows.Forms.TextBox txtCotizadorDolares;
        private System.Windows.Forms.TextBox txtCotizadorPesos;
        private System.Windows.Forms.Button btnLockCotizacion;
    }
}
