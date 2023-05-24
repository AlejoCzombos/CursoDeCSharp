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

namespace Typing_Fast
{
    public partial class Form1 : Form
    {
        String frase;
        int errores;
        int aciertos;
        int tiempo = 0;
        int indiceActual;
        SQLiteConnection conexion;
        public Form1()
        {
            InitializeComponent();
            ConeccionDB();
            CargarPalabra();
            textBoxInput.Focus();
            timer1.Interval = 10;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo++;
            labelTiempo.Text = $"{tiempo / 100} {tiempo}";
        }
        private void inputCheck(object sender, KeyPressEventArgs e)
        {
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
            string stringConexion = "Data Source=C:/Alejo/Programacion/C#/Palabras.db;";
            conexion = new SQLiteConnection(stringConexion);
            conexion.Open();
        }

        private void inputCheck(object sender, EventArgs e)
        {
            string textoEscrito = textBoxInput.Text;

            if (frase.Equals(textoEscrito)) CargarPalabra();
        }
    }
}
