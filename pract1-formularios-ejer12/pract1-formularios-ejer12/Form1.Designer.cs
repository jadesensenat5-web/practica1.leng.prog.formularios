namespace pract1_formularios_ejer12
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
            txtCelsius = new TextBox();
            btnConvertir = new Button();
            lblResultadoF = new Label();
            SuspendLayout();
            // 
            // txtCelsius
            // 
            txtCelsius.BackColor = SystemColors.ControlLightLight;
            txtCelsius.Location = new Point(12, 41);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(262, 31);
            txtCelsius.TabIndex = 0;
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = SystemColors.ActiveCaption;
            btnConvertir.Location = new Point(30, 78);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(217, 34);
            btnConvertir.TabIndex = 1;
            btnConvertir.Text = "Convertir a Fahrenheit";
            btnConvertir.UseVisualStyleBackColor = false;
            btnConvertir.Click += button1_Click;
            // 
            // lblResultadoF
            // 
            lblResultadoF.AutoSize = true;
            lblResultadoF.BackColor = Color.FromArgb(255, 255, 192);
            lblResultadoF.Location = new Point(86, 124);
            lblResultadoF.Name = "lblResultadoF";
            lblResultadoF.Size = new Size(92, 25);
            lblResultadoF.TabIndex = 2;
            lblResultadoF.Text = "Respuesta";
            lblResultadoF.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(538, 297);
            Controls.Add(lblResultadoF);
            Controls.Add(btnConvertir);
            Controls.Add(txtCelsius);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCelsius;
        private Button btnConvertir;
        private Label lblResultadoF;
    }
}
