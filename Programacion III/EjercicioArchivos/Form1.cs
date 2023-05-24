using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EjercicioArchivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string directorio = folderDialog.SelectedPath;

                    DirectoryInfo infoDirectorio = new DirectoryInfo(directorio);
                    FileInfo[] archivos = infoDirectorio.GetFiles("*", SearchOption.AllDirectories);

                    long tamañoTotal = directorio.Length;

                    foreach (FileInfo archivo in archivos)
                    {
                        long tamañoArchivo = archivo.Length;

                        double porcentajeRelativo = (double)tamañoArchivo / tamañoTotal * 100;

                        string informaciónArchivo = $"-{archivo.Name}\n -Tamaño: {tamañoArchivo} bytes \n-Porcentaje relativo: {porcentajeRelativo}%\n";

                        richTextBox1.AppendText(informaciónArchivo + Environment.NewLine);
                    }
                }
            }
        }
    }
}