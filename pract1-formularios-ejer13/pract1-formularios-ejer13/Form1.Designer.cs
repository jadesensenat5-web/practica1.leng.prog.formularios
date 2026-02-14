namespace pract1_formularios_ejer13
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            btnIniciar = new Button();
            btnDetener = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.ActiveCaption;
            progressBar1.Location = new Point(121, 53);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(162, 44);
            progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(192, 255, 192);
            btnIniciar.Location = new Point(141, 103);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(112, 34);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.BackColor = Color.FromArgb(255, 128, 128);
            btnDetener.Location = new Point(141, 143);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(112, 34);
            btnDetener.TabIndex = 2;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = false;
            btnDetener.Click += btnDetener_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 238);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Button btnIniciar;
        private Button btnDetener;
    }
}
