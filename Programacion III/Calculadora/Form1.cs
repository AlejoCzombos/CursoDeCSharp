using System.Data;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        List<string> listaOperadores = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AgregarDigito(string digito)
        {
            if(textBox.Text == "0")
            {
                textBox.Text = "";
            }
            listaOperadores.Add(digito);
            textBox.Text = textBox.Text + digito;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void boton1_Click(object sender, EventArgs e)
        {
            AgregarDigito("1");
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            AgregarDigito("2");
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            AgregarDigito("0");
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            AgregarDigito("3");
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            AgregarDigito("4");
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            AgregarDigito("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AgregarDigito("6");
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            AgregarDigito("7");
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            AgregarDigito("8");
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            AgregarDigito("9");
        }

        private void botonMas_Click(object sender, EventArgs e)
        {
            AgregarDigito("+");
        }

        private void botonMenos_Click(object sender, EventArgs e)
        {
            AgregarDigito("-");
        }

        private void botonMultiplicacion_Click(object sender, EventArgs e)
        {
            AgregarDigito("*");
        }

        private void botonDivision_Click(object sender, EventArgs e)
        {
            AgregarDigito("/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AgregarDigito("%");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }

        private void botonBorrarTodo_Click(object sender, EventArgs e)
        {
            listaOperadores.Clear();
            textBox.Text = "0";
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            string expresionCompleta = string.Join("", listaOperadores);

            DataTable dt = new DataTable();
            var resultado = dt.Compute(expresionCompleta, "");

            textBox.Text = resultado.ToString();

            listaOperadores.Clear();
            listaOperadores.Add(resultado.ToString());
        }
    }
}