namespace WinFormsHolaWinForms
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
            cbxMateriaFavorita = new System.Windows.Forms.ComboBox();
            txtNombre = new System.Windows.Forms.TextBox();
            txtApellido = new System.Windows.Forms.TextBox();
            lblNombre = new System.Windows.Forms.Label();
            lblApellido = new System.Windows.Forms.Label();
            btnSaludar = new System.Windows.Forms.Button();
            lblMateriaFavorita = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // cbxMateriaFavorita
            // 
            cbxMateriaFavorita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxMateriaFavorita.FormattingEnabled = true;
            cbxMateriaFavorita.Location = new System.Drawing.Point(31, 104);
            cbxMateriaFavorita.Name = "cbxMateriaFavorita";
            cbxMateriaFavorita.Size = new System.Drawing.Size(252, 23);
            cbxMateriaFavorita.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(31, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(111, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(172, 49);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(111, 23);
            txtApellido.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNombre.Location = new System.Drawing.Point(31, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(53, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            lblNombre.Click += lblNombre_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblApellido.Location = new System.Drawing.Point(172, 31);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(52, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            lblApellido.Click += lblApellido_Click;
            // 
            // btnSaludar
            // 
            btnSaludar.Location = new System.Drawing.Point(208, 147);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new System.Drawing.Size(75, 23);
            btnSaludar.TabIndex = 4;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // lblMateriaFavorita
            // 
            lblMateriaFavorita.AutoSize = true;
            lblMateriaFavorita.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMateriaFavorita.Location = new System.Drawing.Point(31, 86);
            lblMateriaFavorita.Name = "lblMateriaFavorita";
            lblMateriaFavorita.Size = new System.Drawing.Size(97, 15);
            lblMateriaFavorita.TabIndex = 6;
            lblMateriaFavorita.Text = "Materia favorita";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(308, 189);
            Controls.Add(lblMateriaFavorita);
            Controls.Add(cbxMateriaFavorita);
            Controls.Add(btnSaludar);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "¡Hola, Windows Forms!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.ComboBox cbxMateriaFavorita;
        private System.Windows.Forms.Label lblMateriaFavorita;
    }
}
