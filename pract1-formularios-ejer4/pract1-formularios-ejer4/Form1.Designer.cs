namespace pract1_formularios_ejer4
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(107, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveCaption;
            textBox3.Location = new Point(107, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(125, 157);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Sumar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Location = new Point(155, 213);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label1;
    }
}
