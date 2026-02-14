namespace pract1_formularios_ejer11
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
            dateTimePicker1 = new DateTimePicker();
            btnFecha = new Button();
            lblResultadoFecha = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = SystemColors.ControlDarkDark;
            dateTimePicker1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(56, 36);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(196, 45);
            dateTimePicker1.TabIndex = 0;
            // 
            // btnFecha
            // 
            btnFecha.BackColor = Color.White;
            btnFecha.Location = new Point(87, 87);
            btnFecha.Name = "btnFecha";
            btnFecha.Size = new Size(112, 42);
            btnFecha.TabIndex = 1;
            btnFecha.Text = "Fecha";
            btnFecha.UseVisualStyleBackColor = false;
            btnFecha.Click += button1_Click;
            // 
            // lblResultadoFecha
            // 
            lblResultadoFecha.AutoSize = true;
            lblResultadoFecha.BackColor = Color.FromArgb(192, 192, 255);
            lblResultadoFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultadoFecha.Location = new Point(86, 150);
            lblResultadoFecha.Name = "lblResultadoFecha";
            lblResultadoFecha.Size = new Size(113, 32);
            lblResultadoFecha.TabIndex = 2;
            lblResultadoFecha.Text = "Ver fecha";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(424, 293);
            Controls.Add(lblResultadoFecha);
            Controls.Add(btnFecha);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button btnFecha;
        private Label lblResultadoFecha;
    }
}
