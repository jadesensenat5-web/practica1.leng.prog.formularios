namespace pract1_formularios_ejer10
{
    partial class from1
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
            btnMensaje = new Button();
            SuspendLayout();
            // 
            // btnMensaje
            // 
            btnMensaje.BackColor = Color.Thistle;
            btnMensaje.FlatStyle = FlatStyle.Popup;
            btnMensaje.Font = new Font("Tw Cen MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMensaje.Location = new Point(122, 102);
            btnMensaje.Name = "btnMensaje";
            btnMensaje.Size = new Size(252, 46);
            btnMensaje.TabIndex = 0;
            btnMensaje.Text = "Ver datos";
            btnMensaje.UseVisualStyleBackColor = false;
            btnMensaje.Click += btnMensaje_Click;
            // 
            // from1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(516, 278);
            Controls.Add(btnMensaje);
            Name = "from1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMensaje;
    }
}
