namespace Tateti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonContinuar_Click(object sender, EventArgs e)
        {
            if(textoJ1.Text != "" && textoJ2.Text != "")
            {
                this.Hide();
                CuadrillaJuego cj = new CuadrillaJuego();
                cj.ShowDialog();
            }
        }
    }
}