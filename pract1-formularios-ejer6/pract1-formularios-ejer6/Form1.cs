namespace pract1_formularios_ejer6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string colorSeleccionado = cmbColores.SelectedItem.ToString();

            if (colorSeleccionado == "Rojo")
            {
                this.BackColor = Color.Red;
            }
            else if (colorSeleccionado == "Verde")
            {
                this.BackColor = Color.Green;
            }
            else if (colorSeleccionado == "Azul")
            {
                this.BackColor = Color.Blue;
            }
        }
    }
}
