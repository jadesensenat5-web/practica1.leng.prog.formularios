namespace pract1_formularios_ejer7
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
            txtElemento = new TextBox();
            button1 = new Button();
            lstElementos = new ListBox();
            SuspendLayout();
            // 
            // txtElemento
            // 
            txtElemento.BackColor = SystemColors.ScrollBar;
            txtElemento.Location = new Point(30, 23);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(210, 31);
            txtElemento.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(30, 75);
            button1.Name = "button1";
            button1.Size = new Size(170, 34);
            button1.TabIndex = 1;
            button1.Text = "Agregar a la lista";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lstElementos
            // 
            lstElementos.BackColor = Color.FromArgb(255, 224, 192);
            lstElementos.BorderStyle = BorderStyle.None;
            lstElementos.FormattingEnabled = true;
            lstElementos.ItemHeight = 25;
            lstElementos.Location = new Point(30, 136);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(199, 150);
            lstElementos.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstElementos);
            Controls.Add(button1);
            Controls.Add(txtElemento);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtElemento;
        private Button button1;
        private ListBox lstElementos;
    }
}
