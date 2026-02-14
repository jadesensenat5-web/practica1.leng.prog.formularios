namespace pract1_formularios_ejer12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius = Convert.ToDouble(txtCelsius.Text);
            double fahrenheit = (celsius * 1.8) + 32;
            lblResultadoF.Text = fahrenheit.ToString() + " °F";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
