namespace pract1_formularios_ejer15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscador = new OpenFileDialog();
            if (buscador.ShowDialog() == DialogResult.OK)
                txtEditor.Text = System.IO.File.ReadAllText(buscador.FileName);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardador = new SaveFileDialog();
            if (guardador.ShowDialog() == DialogResult.OK)
                System.IO.File.WriteAllText(guardador.FileName, txtEditor.Text);
            MessageBox.Show("¡Guardado correctamente!");
        }
    }
}
