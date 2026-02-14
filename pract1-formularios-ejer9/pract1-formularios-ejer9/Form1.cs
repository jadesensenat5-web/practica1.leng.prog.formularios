namespace pract1_formularios_ejer9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            double resultado;
            if (double.TryParse(txtValidar.Text, out resultado))
                MessageBox.Show("¡Correcto! El número es: " + resultado);
            else
                MessageBox.Show("Error: Lo que escribiste no es un número válido.");
            txtValidar.Clear();
            txtValidar.Focus();

        }
    }
}
