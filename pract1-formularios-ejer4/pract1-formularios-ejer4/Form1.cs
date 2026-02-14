namespace pract1_formularios_ejer4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox2.Text);
            double num2 = Convert.ToDouble(textBox3.Text);
            double resultado = num1 + num2;

            label1.Text = "La suma es: " + resultado.ToString();
        }
    }
}
