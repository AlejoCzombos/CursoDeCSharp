using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace Typing_Fast
{
    public partial class Form1 : Form
    {
        String frase;
        int errores;
        int aciertos = 0;
        int tiempo = 0;
        int indiceActual;
        SQLiteConnection conexion;
        private Stopwatch stopwatch;
        public Form1()
        {
            InitializeComponent();
            ConeccionDB();
            CargarPalabra();
            textBoxInput.Focus();
            timer1.Interval = 10;
            timer1.Enabled = true;
            stopwatch = new Stopwatch();
            stopwatch.Start();
            textBoxInput.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempoTranscurrido = stopwatch.Elapsed;
            string tiempoFormateado;
            if(tiempoTranscurrido.Minutes > 0)
            {
                tiempoFormateado = $"{tiempoTranscurrido.Minutes} : {tiempoTranscurrido.Seconds}.{tiempoTranscurrido.Milliseconds.ToString("000")}";
            }
            else
            {
                tiempoFormateado = $"{tiempoTranscurrido.Seconds}.{tiempoTranscurrido.Milliseconds.ToString("000")}";
            }

            labelTiempo.Text = tiempoFormateado;
        }
        private void inputCheck(object sender, KeyPressEventArgs e)
        {
            if (indiceActual < 0) indiceActual = 0;

            if (e.KeyChar == (char)Keys.Back)
            {
                indiceActual--;
                return;
            }

            bool esCorrecto = (indiceActual >= 0 && indiceActual < frase.Length && e.KeyChar == frase[indiceActual]);

            textBoxInput.SelectionStart = indiceActual;
            textBoxInput.SelectionLength = 1;
            textBoxInput.SelectionColor = esCorrecto ? Color.Green : Color.Red;

            indiceActual++;
        }
        private void CargarPalabra()
        {
            string consulta = "SELECT Palabra FROM Palabras ORDER BY random() LIMIT 1";
            SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
            SQLiteDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                string palabra = lector.GetString(0);
                frase = palabra;
            }
            labelFrase.Text = frase;
            labelFrase.ForeColor = Color.Black;
            textBoxInput.Clear();
            indiceActual = 0;
        }
        private void ConeccionDB()
        {
            string nombreBaseDatos = "Palabras.db";
            string rutaBaseDatos = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), nombreBaseDatos);
            string connectionString = $"Data Source={rutaBaseDatos};Version=3;";
            conexion = new SQLiteConnection(connectionString);
            conexion.Open();
        }

        private void inputCheck(object sender, EventArgs e)
        {
            string textoEscrito = textBoxInput.Text;

            if (frase.Equals(textoEscrito))
            {
                aciertos++;
                labelAciertos.Text = aciertos.ToString();
                CargarPalabra();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
