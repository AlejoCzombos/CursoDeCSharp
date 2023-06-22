using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tateti
{

    public enum Turnos{
        Jugador1, Jugador2
    }

    public partial class CuadrillaJuego : Form
    {
        private Label[] casillas;
        private Turnos turnoActual = Turnos.Jugador1;
        public string Jugador1Text, jugador2Text;
        private int segundosTranscurridos = 0;
        public CuadrillaJuego()
        {
            InitializeComponent();
            Jugador1Text = "X";
            jugador2Text= "O";
        }

        private void casilla0_Click(object sender, EventArgs e)
        {
            ControlarJugada(casilla0);
        }

        private void casilla1_Click(object sender, EventArgs e)
        {
            ControlarJugada(casilla1);
        }

        private void casilla2_Click(object sender, EventArgs e)
        {
            ControlarJugada(casilla2);
        }

        private void casilla3_Click(object sender, EventArgs e)
        {
            ControlarJugada(casilla3);
        }

        private void casilla4_Click(object sender, EventArgs e)
        {
            ControlarJugada(casilla4);
        }

        private void casilla5_Click(object sender, EventArgs e)
        {
            ControlarJugada(casilla5);
        }

        private void casilla6_Click(object sender, EventArgs e)
        {
            ControlarJugada(casilla6);
        }

        private void casilla7_Click(object sender, EventArgs e)
        {
            ControlarJugada(casilla7);
        }

        private void casilla8_Click(object sender, EventArgs e)
        {
            ControlarJugada(casilla8);
        }

        private void Cerrar(object sender, EventArgs e)
        {
            Program.form1.Show();
        }

        private void TickTiempo(object sender, EventArgs e)
        {
            segundosTranscurridos++;
            labelTiempo.Text = segundosTranscurridos.ToString();
        }

        private void ControlarJugada(Label casillero)
        {
            if (casillero.Text == "")
            {
                casillero.Text = turnoActual == Turnos.Jugador1 ? Jugador1Text : jugador2Text;

                turnoActual = turnoActual == Turnos.Jugador1 ? Turnos.Jugador2 : Turnos.Jugador1;

                if (casilla0.Text == "X" && casilla1.Text == "X" && casilla2.Text == "X" ||
                    casilla3.Text == "X" && casilla4.Text == "X" && casilla5.Text == "X" ||
                    casilla6.Text == "X" && casilla7.Text == "X" && casilla8.Text == "X" ||
                    casilla0.Text == "X" && casilla4.Text == "X" && casilla8.Text == "X" ||
                    casilla2.Text == "X" && casilla4.Text == "X" && casilla6.Text == "X" ||
                    casilla0.Text == "X" && casilla3.Text == "X" && casilla6.Text == "X" ||
                    casilla1.Text == "X" && casilla4.Text == "X" && casilla7.Text == "X" ||
                    casilla2.Text == "X" && casilla5.Text == "X" && casilla8.Text == "X" )
                {
                    MessageBox.Show("gano el jugador X");
                }
                if (casilla0.Text == "O" && casilla1.Text == "O" && casilla2.Text == "O" ||
                    casilla3.Text == "O" && casilla4.Text == "O" && casilla5.Text == "O" ||
                    casilla6.Text == "O" && casilla7.Text == "O" && casilla8.Text == "O" ||
                    casilla0.Text == "O" && casilla4.Text == "O" && casilla8.Text == "O" ||
                    casilla2.Text == "O" && casilla4.Text == "O" && casilla6.Text == "O" ||
                    casilla0.Text == "O" && casilla3.Text == "O" && casilla6.Text == "O" ||
                    casilla1.Text == "O" && casilla4.Text == "O" && casilla7.Text == "O" ||
                    casilla2.Text == "O" && casilla5.Text == "O" && casilla8.Text == "O")
                {
                    MessageBox.Show("gano el jugador O");
                }
            }
        }
    }
}
