namespace pract1_formularios_ejer14
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(28, 46);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(629, 283);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(255, 192, 255);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(621, 245);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pestaña A";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(192, 192, 255);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(621, 245);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pestaña B";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 0;
            label1.Text = "Informacion 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 27);
            label2.Name = "label2";
            label2.Size = new Size(213, 25);
            label2.TabIndex = 0;
            label2.Text = "Bienvenido a la pestaña 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TabPage tabPage2;
        private Label label2;
    }
}
