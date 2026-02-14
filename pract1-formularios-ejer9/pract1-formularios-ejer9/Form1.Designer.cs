namespace pract1_formularios_ejer9
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
            txtValidar = new TextBox();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // txtValidar
            // 
            txtValidar.Location = new Point(34, 38);
            txtValidar.Name = "txtValidar";
            txtValidar.Size = new Size(235, 31);
            txtValidar.TabIndex = 0;
            // 
            // btnValidar
            // 
            btnValidar.BackColor = Color.FromArgb(192, 255, 192);
            btnValidar.Location = new Point(51, 75);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(187, 34);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar el numero";
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Click += btnValidar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 319);
            Controls.Add(btnValidar);
            Controls.Add(txtValidar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValidar;
        private Button btnValidar;
    }
}
