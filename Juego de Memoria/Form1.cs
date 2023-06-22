using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Juego_de_Memoria
{
    public partial class Form1 : Form
    {
        private LinkedList<Label> cartasEnJuego;
        private Label[] cartasSeleccionadas;
        private LinkedList<string> palabrasAcertadas;
        private string[] palabras, palabrasCartas;
        private Random random;
        private int movimientos = 10;
        private int clicks = 0, movimientosRestantes = 0;
        public Form1()
        {
            InitializeComponent();
            palabrasCartas = new string[20];
            palabrasAcertadas= new LinkedList<string>();
            cartasSeleccionadas = new Label[2];
            palabras = new string[10];
            cartasEnJuego = new LinkedList<Label>();

            cartasEnJuego.AddLast(carta0);
            cartasEnJuego.AddLast(carta1);
            cartasEnJuego.AddLast(carta2);
            cartasEnJuego.AddLast(carta3);
            cartasEnJuego.AddLast(carta4);
            cartasEnJuego.AddLast(carta5);
            cartasEnJuego.AddLast(carta6);
            cartasEnJuego.AddLast(carta7);
            cartasEnJuego.AddLast(carta8);
            cartasEnJuego.AddLast(carta9);
            cartasEnJuego.AddLast(carta10);
            cartasEnJuego.AddLast(carta11);
            cartasEnJuego.AddLast(carta12);
            cartasEnJuego.AddLast(carta13);
            cartasEnJuego.AddLast(carta14);
            cartasEnJuego.AddLast(carta15);
            cartasEnJuego.AddLast(carta16);
            cartasEnJuego.AddLast(carta17);
            cartasEnJuego.AddLast(carta18);
            cartasEnJuego.AddLast(carta19);

            random = new Random();

            textoApareadas.SelectionAlignment = HorizontalAlignment.Center;

            SetearPalabras();
        }
        private void SetearPalabras()
        {
            string path = @"C:\Alejo\Programacion\C#\ArchivoPalabras.txt";

            FileInfo file= new FileInfo(path);

            FileStream fs = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);

            //using(StreamWriter sw = new StreamWriter(fs))
            //{
            //    foreach (var p in palabras)
            //    {
            //        sw.WriteLine(p); 
            //    }
            //}

            using (StreamReader sr = new StreamReader(fs))
            {
                string input;
                int a = 0;
                while ((input = sr.ReadLine()) != null)
                {
                    palabras[a] = input;
                    a++;
                }
            }

            int numero = random.Next(0, 20);
            LinkedList<int> numerosRepetidos = new LinkedList<int>();

            for (int i = 0; i <= 9; i++)
            {
                while (numerosRepetidos.Any(x => x == numero))
                {
                    numero = random.Next(0, 20);
                }

                numerosRepetidos.AddLast(numero);
                palabrasCartas[numero] = palabras[i];

                while (numerosRepetidos.Any(x => x == numero))
                {
                    numero = random.Next(0, 20);
                }

                numerosRepetidos.AddLast(numero);
                palabrasCartas[numero] = palabras[i];
            }

        }

        private void ComprobarCartas(Label carta, int n)
        {
            clicks++;
            cartasSeleccionadas[(clicks - 1)] = carta;
            if(movimientos > 0)
            {
                if( cartasEnJuego.Count(x => x.BackColor == Color.White) < 2)
                {
                    carta.BackColor = Color.White;
                    carta.Text = palabrasCartas[n];
                }

                if (clicks == 2 && cartasSeleccionadas[0].Text == cartasSeleccionadas[1].Text ) 
                {
                    palabrasAcertadas.AddLast(carta.Text);
                    textoApareadas.Text += carta.Text.ToString() + "\n";
                    cartasEnJuego.Remove(cartasSeleccionadas[0]);
                    cartasEnJuego.Remove(cartasSeleccionadas[1]);
                    cartasSeleccionadas = new Label[2];
                    labelMovimientos.Text = $"Movimientos: {movimientos}";
                    movimientos--;
                    timerMirarPiezas.Start();
                }
                if (clicks == 2)
                {
                    clicks = 0;
                    timerMirarPiezas.Start();
                }

            }
        }

        private void timerMirarPiezas_Tick(object sender, EventArgs e)
        {
            foreach (var carta in cartasEnJuego)
            {
                carta.BackColor = Color.Sienna;
                carta.Text = "";
            }
            timerMirarPiezas.Stop();
        }

        private void carta0_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta0, 0);
        }

        private void carta1_Click(object sender, EventArgs e)
        {

            ComprobarCartas(carta1, 1);
        }

        private void carta2_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta2, 2);

        }

        private void carta3_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta3, 3);
        }

        private void carta4_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta4, 4);

        }

        private void carta5_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta5, 5);
            
        }

        private void carta6_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta6, 6);
            
        }

        private void carta7_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta7, 7);
            
        }

        private void carta8_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta8, 8);
            
        }

        private void carta9_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta9, 9);
            
        }

        private void carta10_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta10, 10);
            
        }

        private void carta11_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta11, 11);
            
        }

        private void carta12_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta12, 12);
            
        }

        private void carta13_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta13, 13);
            
        }

        private void carta14_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta14, 14);
            
        }

        private void carta15_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta15, 15);
            
        }

        private void carta16_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta16, 16);
            
        }

        private void carta17_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta17, 17);
            
        }

        private void carta18_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta18, 18);
            
        }

        private void carta19_Click(object sender, EventArgs e)
        {
            ComprobarCartas(carta19, 19);
            
        }
    }
}