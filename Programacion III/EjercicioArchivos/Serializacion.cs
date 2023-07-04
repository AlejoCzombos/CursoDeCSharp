using HistoriasClinicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioArchivos
{
    public partial class Serializacion : Form
    {
        private string Path = "C:\\Alejo\\Programacion\\C#\\Serializacion.json";
        private Paciente[] pacientes = {
            new Paciente("Alejo", "Czombos", "32432422"),
            new Paciente("Matias", "Barboza", "23432432"),
            new Paciente("Agustin", "Campanella", "735754334"),
            new Paciente("Jose", "Alegre", "434364367")
        };
        public Serializacion()
        {
            InitializeComponent();
        }

        private void botonSerializar_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(Path);
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);

            var options = new JsonSerializerOptions { WriteIndented = true };
            string textoSerializado = JsonSerializer.Serialize(pacientes, options);

            using(StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(textoSerializado);
            }

            fs.Close();
        }

        private void boronDeserializacion_Click(object sender, EventArgs e)
        {
            string textoSerializado = File.ReadAllText(Path);
            var deserializado = JsonSerializer.Deserialize<List<Paciente>>(textoSerializado);

            foreach (var pac in deserializado)
            {
                texto.Text += $"Paciente:\t{pac.Nombre}\t {pac.Apellido}\t {pac.Telefono}\n";
            }

        }
    }
}
