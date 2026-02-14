namespace pract1_formularios_ejer8
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
            btnContador = new Button();
            lblConteo = new Label();
            SuspendLayout();
            // 
            // btnContador
            // 
            btnContador.BackColor = Color.FromArgb(255, 128, 255);
            btnContador.Location = new Point(22, 24);
            btnContador.Name = "btnContador";
            btnContador.Size = new Size(183, 50);
            btnContador.TabIndex = 0;
            btnContador.Text = "Contar Clic";
            btnContador.UseVisualStyleBackColor = false;
            btnContador.Click += btnContador_Click;
            // 
            // lblConteo
            // 
            lblConteo.AutoSize = true;
            lblConteo.BackColor = Color.FromArgb(255, 192, 192);
            lblConteo.Location = new Point(92, 89);
            lblConteo.Name = "lblConteo";
            lblConteo.Size = new Size(58, 25);
            lblConteo.TabIndex = 1;
            lblConteo.Text = "Clic: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 450);
            Controls.Add(lblConteo);
            Controls.Add(btnContador);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnContador;
        private Label lblConteo;
    }
}
