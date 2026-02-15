namespace pract1_formularios_ejer16
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "9";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            primero = double.Parse(txtPantalla.Text);
            operacion = "+";
            txtPantalla.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            primero = double.Parse(txtPantalla.Text);
            operacion = "-";
            txtPantalla.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            primero = double.Parse(txtPantalla.Text);
            operacion = "*";
            txtPantalla.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            primero = double.Parse(txtPantalla.Text);
            operacion = "/";
            txtPantalla.Clear();
        }

        private void btnParentesisCierra_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += ")";
        }

        private void btnParentesisAbre_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "(";
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtPantalla.Text);
            valor = valor / 100;
            txtPantalla.Text = valor.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtPantalla.Text.Contains("."))
                txtPantalla.Text += ".";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtPantalla.Text);

            if (operacion == "+") txtPantalla.Text = (primero + segundo).ToString();
            if (operacion == "-") txtPantalla.Text = (primero - segundo).ToString();
            if (operacion == "*") txtPantalla.Text = (primero * segundo).ToString();
            if (operacion == "/") txtPantalla.Text = (segundo != 0) ? (primero / segundo).ToString() : "Error";
        }
    }
}
