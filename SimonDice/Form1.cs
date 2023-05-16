namespace SimonDice
{
    public partial class Form1 : Form
    {
        List<int> secuencia = new List<int>();
        int contador = 0, contadorActual = 0;
        int ticks = 0;
        bool iluminado = false, mostrandoSecuencia = false, cambiarColorFondo = false;

        public Form1()
        {
            InitializeComponent();
            mostrandoSecuencia = true;
            AgregarAlaSecuencia();
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

            if (cambiarColorFondo)
            {
                this.BackColor = !iluminado ? ControlPaint.Light(Color.FromArgb(100, 200, 50, 50)) : Color.White;
                iluminado = !iluminado;
                if (!iluminado)
                {
                    mostrandoSecuencia = true;
                    cambiarColorFondo = false;
                }
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

        private void AgregarAlaSecuencia()//Agrega un elemento a la secuencia con un random y actualiza la variable contador
        {
            Random rd = new Random();
            secuencia.Add(rd.Next(1, 5));
            contador = (int)secuencia.LongCount();
        }
        private void BorrarSecuencia()
        {
            secuencia.Clear();
        }

        private void ComprobarSecuenciaJugador(int indiceColor)
        {
            if (!mostrandoSecuencia && secuencia[contadorActual] == indiceColor)
            {
                contadorActual++;
                if (contadorActual == contador) //Gano una ronda y se agrega un elemento a la secuencia
                {
                    AgregarAlaSecuencia();
                    mostrandoSecuencia = true;
                    contadorActual = 0;
                    label1.Text = $"Puntaje: {contador - 1}";
                }
            }
            else //Perdió, se borra la secuencia y se agrega el primer elemento a la secuencia
            {
                BorrarSecuencia();
                AgregarAlaSecuencia();
                contadorActual = 0;
                label1.Text = "Puntaje: 0";
                cambiarColorFondo = true;
            }
        }

        private void IluminarBoton(int boton)
        {
            switch (boton)//Se ilumina si la variable booleana iluminacion es falsa
            {
                case 1://Rojo
                    Rojo.BackColor = !iluminado ? ControlPaint.Light(Color.FromArgb(255, 200, 0, 0)) : Color.FromArgb(255, 200, 0, 0);
                    break;
                case 2://Verde
                    Verde.BackColor = !iluminado ? ControlPaint.Light(Color.Green) : Color.Green;
                    break;
                case 3://Amarillo
                    Amarillo.BackColor = !iluminado ? ControlPaint.Light(Color.FromArgb(255, 192, 192, 0)) : Color.FromArgb(255, 192, 192, 0);
                    break;
                case 4://Azul
                    Azul.BackColor = !iluminado ? ControlPaint.Light(Color.FromArgb(255, 0, 0, 192)) : Color.FromArgb(255, 0, 0, 192);
                    break;
                default:
                    break;
            }
            iluminado = !iluminado;
        }

        //Eventos de Click de botones para comprobar la secuencia
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

        //Eventos de Click botones para simular iluminacion

        private void OnDownClickVerde(object sender, MouseEventArgs e)
        {
            if (!mostrandoSecuencia) Verde.BackColor = ControlPaint.Light(Color.Green);
        }

        private void OnUpClickVerde(object sender, MouseEventArgs e)
        {
            Verde.BackColor = Color.Green;
        }

        private void OnDownClickAzul(object sender, MouseEventArgs e)
        {
            if (!mostrandoSecuencia) Azul.BackColor = ControlPaint.Light(Color.FromArgb(255, 0, 0, 192));
        }

        private void OnUpClickAzul(object sender, MouseEventArgs e)
        {
            Azul.BackColor = Color.FromArgb(255, 0, 0, 192);
        }

        private void OnDownClickAmarillo(object sender, MouseEventArgs e)
        {
            if (!mostrandoSecuencia) Amarillo.BackColor = ControlPaint.Light(Color.FromArgb(255, 192, 192, 0));
        }

        private void OnUpClickAmarillo(object sender, MouseEventArgs e)
        {
            Amarillo.BackColor = Color.FromArgb(255, 192, 192, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OnDownClickRojo(object sender, MouseEventArgs e)
        {
            if (!mostrandoSecuencia) Rojo.BackColor = ControlPaint.Light(Color.FromArgb(255, 200, 0, 0));
        }

        private void OnUpClickRojo(object sender, MouseEventArgs e)
        {
            Rojo.BackColor = Color.FromArgb(255, 200, 0, 0);
        }

    }
}