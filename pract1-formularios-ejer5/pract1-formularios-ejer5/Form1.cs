namespace pract1_formularios_ejer5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) label1.Text = "Seleccionaste: " + radioButton1.Text;
            else if (radioButton2.Checked) label1.Text = "Seleccionaste: " + radioButton2.Text;
            else if (radioButton3.Checked) label1.Text = "Seleccionaste: " + radioButton3.Text;
        }
    }
}
