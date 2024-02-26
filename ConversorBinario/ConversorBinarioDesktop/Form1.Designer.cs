namespace ConversorBinarioDesktop
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
            txtResultadoDec = new System.Windows.Forms.TextBox();
            lblBinToDec = new System.Windows.Forms.Label();
            lblDecToBin = new System.Windows.Forms.Label();
            btnBinToDec = new System.Windows.Forms.Button();
            btnDecToBin = new System.Windows.Forms.Button();
            txtResultadoBin = new System.Windows.Forms.TextBox();
            txtBinario = new System.Windows.Forms.TextBox();
            txtDecimal = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // txtResultadoDec
            // 
            txtResultadoDec.Location = new System.Drawing.Point(373, 30);
            txtResultadoDec.Name = "txtResultadoDec";
            txtResultadoDec.Size = new System.Drawing.Size(100, 23);
            txtResultadoDec.TabIndex = 4;
            // 
            // lblBinToDec
            // 
            lblBinToDec.AutoSize = true;
            lblBinToDec.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblBinToDec.Location = new System.Drawing.Point(35, 36);
            lblBinToDec.Name = "lblBinToDec";
            lblBinToDec.Size = new System.Drawing.Size(123, 17);
            lblBinToDec.TabIndex = 0;
            lblBinToDec.Text = "Binario a Decimal";
            // 
            // lblDecToBin
            // 
            lblDecToBin.AutoSize = true;
            lblDecToBin.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDecToBin.Location = new System.Drawing.Point(35, 72);
            lblDecToBin.Name = "lblDecToBin";
            lblDecToBin.Size = new System.Drawing.Size(123, 17);
            lblDecToBin.TabIndex = 1;
            lblDecToBin.Text = "Decimal a Binario";
            // 
            // btnBinToDec
            // 
            btnBinToDec.Location = new System.Drawing.Point(282, 32);
            btnBinToDec.Name = "btnBinToDec";
            btnBinToDec.Size = new System.Drawing.Size(75, 23);
            btnBinToDec.TabIndex = 2;
            btnBinToDec.Text = "->";
            btnBinToDec.UseVisualStyleBackColor = true;
            btnBinToDec.Click += btnBinToDec_Click;
            // 
            // btnDecToBin
            // 
            btnDecToBin.Location = new System.Drawing.Point(282, 66);
            btnDecToBin.Name = "btnDecToBin";
            btnDecToBin.Size = new System.Drawing.Size(75, 23);
            btnDecToBin.TabIndex = 3;
            btnDecToBin.Text = "->";
            btnDecToBin.UseVisualStyleBackColor = true;
            btnDecToBin.Click += btnDecToBin_Click;
            // 
            // txtResultadoBin
            // 
            txtResultadoBin.Location = new System.Drawing.Point(373, 67);
            txtResultadoBin.Name = "txtResultadoBin";
            txtResultadoBin.Size = new System.Drawing.Size(100, 23);
            txtResultadoBin.TabIndex = 5;
            // 
            // txtBinario
            // 
            txtBinario.Location = new System.Drawing.Point(165, 32);
            txtBinario.Name = "txtBinario";
            txtBinario.Size = new System.Drawing.Size(100, 23);
            txtBinario.TabIndex = 6;
            txtBinario.TextChanged += txtBinario_TextChanged;
            // 
            // txtDecimal
            // 
            txtDecimal.Location = new System.Drawing.Point(165, 66);
            txtDecimal.Name = "txtDecimal";
            txtDecimal.Size = new System.Drawing.Size(100, 23);
            txtDecimal.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(511, 118);
            Controls.Add(txtDecimal);
            Controls.Add(txtBinario);
            Controls.Add(txtResultadoBin);
            Controls.Add(txtResultadoDec);
            Controls.Add(btnDecToBin);
            Controls.Add(btnBinToDec);
            Controls.Add(lblDecToBin);
            Controls.Add(lblBinToDec);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Conversor Numérico";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBinToDec;
        private System.Windows.Forms.Label lblDecToBin;
        private System.Windows.Forms.Button btnBinToDec;
        private System.Windows.Forms.Button btnDecToBin;
        private System.Windows.Forms.TextBox txtResultadoDec;
        private System.Windows.Forms.TextBox txtResultadoBin;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.TextBox txtDecimal;
    }
}
