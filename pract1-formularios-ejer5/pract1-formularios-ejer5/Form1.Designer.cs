namespace pract1_formularios_ejer5
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(12, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 40);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "A";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(12, 67);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(57, 40);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "B";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(12, 123);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(58, 40);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "C";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 255);
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(44, 169);
            button1.Name = "button1";
            button1.Size = new Size(145, 42);
            button1.TabIndex = 3;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 243);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button1;
        private Label label1;
    }
}
