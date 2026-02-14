namespace pract1_formularios_ejer8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int conteo = 0;
        private void btnContador_Click(object sender, EventArgs e)
        {
            conteo = conteo + 1;
            lblConteo.Text = "Clics: " + conteo.ToString();
        }
    }
}
