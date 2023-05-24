using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoriasClinicas
{
    public partial class CrearPaciente : Form
    {
        public Paciente paciente { get; set; }

        public CrearPaciente()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            CampoNombre.Text = paciente.Nombre;
            campoApellido.Text = paciente.Apellido;
            campoTelefono.Text = paciente.Telefono;
            campoDireccion.Text = paciente.Direccion;
            campoCorreoElect.Text = paciente.CorreoElectronico;
        }

        private void botonContinuar_Click(object sender, EventArgs e)
        {
            this.paciente = new Paciente(
                CampoNombre.Text,
                campoApellido.Text,
                campoTelefono.Text,
                campoDireccion.Text,
                campoCorreoElect.Text
                );
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
