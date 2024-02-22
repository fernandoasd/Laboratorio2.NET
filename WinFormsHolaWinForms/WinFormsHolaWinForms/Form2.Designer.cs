namespace WinFormsHolaWinForms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSaludo = new System.Windows.Forms.Label();
            lblSoy = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSaludo.Location = new System.Drawing.Point(39, 57);
            lblSaludo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new System.Drawing.Size(222, 22);
            lblSaludo.TabIndex = 0;
            lblSaludo.Text = "¡Hola, Windows Forms!";
            lblSaludo.Click += lblSaludo_Click;
            // 
            // lblSoy
            // 
            lblSoy.AutoSize = true;
            lblSoy.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSoy.Location = new System.Drawing.Point(39, 122);
            lblSoy.Name = "lblSoy";
            lblSoy.Size = new System.Drawing.Size(46, 22);
            lblSoy.TabIndex = 1;
            lblSoy.Text = "Soy";
            lblSoy.Click += label2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(827, 302);
            Controls.Add(lblSoy);
            Controls.Add(lblSaludo);
            Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Saludo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblSoy;
    }
}