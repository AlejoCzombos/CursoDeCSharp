using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
/*
Dado un directorio ingresado por el usuario. (Vea los Dialogs)
Obtenga una lista de todos los archivos en esa carpeta, incluyendo el tamaño de 
cada archivo, el tamaño total y el tamaño relativo %.
- Vuelque la salida en un TextBox
- Si encuentra una subcarpeta, márquela en amarillo y omita los tamaños.
 */
namespace EjercicioArchivos
{
    public partial class Form1 : Form
    {

        string textoAMostrar = "";
        DialogResult resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creo y muestro un Dialog para que el usuario seleccione un directorio
            FolderBrowserDialog ventanaDirectorio = new FolderBrowserDialog();

            resultado = ventanaDirectorio.ShowDialog();

            //Compruebo que se selecciono un directorio
            if (resultado != DialogResult.OK)
            {
                return;
            }

            //Creo un DirectoryInfo a partir de el path que selecciono el usuario
            DirectoryInfo informacionDirectorio = new DirectoryInfo(ventanaDirectorio.SelectedPath);

            //Agrego todos los archivos del directorio seleccionado en una lista de FileInfo
            FileInfo[] listaArchivos = informacionDirectorio.GetFiles();

            //Sumo los tamaños de cada archivo para obtener el tamaño total
            long tamanioDirectorio = informacionDirectorio.GetFiles().Sum(x => x.Length);

            //Itero y agrego al string a mostrar la informacion pertinente
            foreach(var archivo in listaArchivos)
            {
                textoAMostrar += $"{archivo.Name} {archivo.Length} {(archivo.Length * 100) / tamanioDirectorio}%\n";
            }

            //Imprimo en el richTextBox el texto
            richTextBox1.Text = textoAMostrar;
        }

        private void buttonAgregarArchivo_Click(object sender, EventArgs e)
        {
            if(resultado != DialogResult.OK)
            {
                return;
            }

            //Obtengo la ruta relativa de la solucion con el nombre del archivo
            string nombreArchivo = "InformacionDirectorio.txt";
            string rutaArchivo = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), nombreArchivo);

            //Creo el FileInfo con la ruta anterior
            FileInfo f = new FileInfo(rutaArchivo);

            //Creo el FileStram con la funcion de crear o sobreescribir
            FileStream fs = f.Create();

            //Creo un StreamWriter y escribo el texto resultante del directorio seleccionado por el usuario en el archivo
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(textoAMostrar);
            }

            //Muestro al usuario un mensaje
            MessageBox.Show("Archivo guardado con exito");

            // cierro el FileStream
            fs.Close();
        }

        private void buttonCargarArchivo_Click(object sender, EventArgs e)
        {
            //Obtengo la ruta relativa de la solucion con el nombre del archivo
            string nombreArchivo = "InformacionDirectorio.txt";
            string rutaArchivo = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), nombreArchivo);

            //Creo el FileInfo con la ruta anterior
            FileInfo f = new FileInfo(rutaArchivo);

            //Creo el FileStram con la funcion de abrir y leer
            FileStream fs = f.OpenRead();

            //Creo el StreamReader
            StreamReader sr = new StreamReader(fs);

            //Creo un string y le asigno todo el texto del archivo
            string text = sr.ReadToEnd();

            //Muestro por pantalla el texto del archivo
            richTextBox1.Text = textoAMostrar;

            //Cierro el StreamReader
            sr.Close();
        }
    }
}