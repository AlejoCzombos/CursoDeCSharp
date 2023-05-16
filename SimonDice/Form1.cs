namespace SimonDice
{
    public partial class Form1 : Form
    {
        List<int> secuencia = new List<int>();
        int contador = 0, contadorActual = 0;
        int ticks = 0;
        bool iluminado = false, mostrandoSecuencia = false;

        public Form1()
        {
            InitializeComponent();
            mostrandoSecuencia = true;
            AgregarAlaSecuencia();
        }

        private void OnClickRojo(object sender, EventArgs e)
        {
            ComprobarSecuenciaJugador(1);
        }

        private void OnClickVerde(object sender, EventArgs e)
        {
            ComprobarSecuenciaJugador(2);
        }

        private void OnClickAmarillo(object sender, EventArgs e)
        {
            ComprobarSecuenciaJugador(3);
        }

        private void OnClickAzul(object sender, EventArgs e)
        {
            ComprobarSecuenciaJugador(4);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks < 5)
            {
                return;
            }

            if (mostrandoSecuencia)
            {
                MostrarSecuencia();
            }

            ticks = 0;
        }

        private void MostrarSecuencia()
        {
           IluminarBoton(secuencia[contadorActual]);
            if (!iluminado)
            {
                if (contadorActual < contador)
                {
                    contadorActual++;
                }

                if (contadorActual == contador)
                {
                    mostrandoSecuencia = false;
                    contadorActual = 0;
                }
            }
        }

        

        private void AgregarAlaSecuencia()
        {
            Random rd= new Random();
            secuencia.Add(rd.Next(1,5));
            contador = (int)secuencia.LongCount();
        }

        private void ComprobarSecuenciaJugador(int indiceColor)
        {
            if (!mostrandoSecuencia && secuencia[contadorActual] == indiceColor)
            {
                contadorActual++;
                if(contadorActual == contador)
                {
                    AgregarAlaSecuencia();
                    mostrandoSecuencia = true;
                    contadorActual = 0;
                    label1.Text = "Ganaste la primera ronda";
                }
            }
        }

        private void IluminarBoton(int boton)
        {
            switch (boton)
            {
                case 1://Rojo
                    Rojo.BackColor = !iluminado ? Color.White : Color.Red;
                    break;
                case 2://Verde
                    Verde.BackColor = !iluminado ? Color.White : Color.Green;
                    break;
                case 3://Amarillo
                    Amarillo.BackColor = !iluminado ? Color.White : Color.Yellow;
                    break;
                case 4://Azul
                    Azul.BackColor = !iluminado ? Color.White : Color.Blue;
                    break;
                default:
                    break;
            }
            iluminado = !iluminado;
        }

        private void OnDownClickVerde(object sender, MouseEventArgs e)
        {
            Verde.BackColor = ControlPaint.Light(Color.Green);
        }

        private void OnUpClickVerde(object sender, MouseEventArgs e)
        {
            Verde.BackColor = Color.Green;
        }

        private void OnDownClickAzul(object sender, MouseEventArgs e)
        {

        }

        private void OnUpClickAzul(object sender, MouseEventArgs e)
        {

        }

        private void OnDownClickAmarillo(object sender, MouseEventArgs e)
        {

        }

        private void OnUpClickAmarillo(object sender, MouseEventArgs e)
        {

        }

        //Eventos de Click botones
        private void OnDownClickRojo(object sender, MouseEventArgs e)
        {
            Rojo.BackColor = ControlPaint.Light(Color.FromArgb(255,200,0,0));
        }

        private void OnUpClickRojo(object sender, MouseEventArgs e)
        {
            Rojo.BackColor = Color.FromArgb(255, 200, 0, 0);
        }

    }
}