namespace pract1_formularios_ejer15
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
            txtEditor = new TextBox();
            btnAbrir = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtEditor
            // 
            txtEditor.BackColor = Color.FromArgb(255, 192, 255);
            txtEditor.Location = new Point(57, 63);
            txtEditor.Multiline = true;
            txtEditor.Name = "txtEditor";
            txtEditor.Size = new Size(444, 288);
            txtEditor.TabIndex = 0;
            // 
            // btnAbrir
            // 
            btnAbrir.BackColor = SystemColors.ActiveCaption;
            btnAbrir.Location = new Point(396, 254);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(93, 34);
            btnAbrir.TabIndex = 1;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = false;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 255);
            btnGuardar.Location = new Point(396, 294);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 32);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(btnAbrir);
            Controls.Add(txtEditor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEditor;
        private Button btnAbrir;
        private Button btnGuardar;
    }
}
