namespace pract1_formularios_ejer2
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
            button1 = new Button();
            lblTextoCambio = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Location = new Point(32, 39);
            button1.Name = "button1";
            button1.Size = new Size(300, 71);
            button1.TabIndex = 0;
            button1.Text = "Cambiar texto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblTextoCambio
            // 
            lblTextoCambio.AutoSize = true;
            lblTextoCambio.BackColor = Color.FromArgb(255, 128, 255);
            lblTextoCambio.Location = new Point(153, 122);
            lblTextoCambio.Name = "lblTextoCambio";
            lblTextoCambio.Size = new Size(37, 25);
            lblTextoCambio.TabIndex = 1;
            lblTextoCambio.Text = "Ver";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTextoCambio);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblTextoCambio;
    }
}
