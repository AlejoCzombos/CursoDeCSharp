using Microsoft.Data.SqlClient;

namespace EjercicioBasesDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (SqlConnection cn = new SqlConnection())
            {

                cn.ConnectionString = GetConnectionString();
                cn.Open();

                string sqlQuery = "SELECT * FROM Cliente";
                SqlCommand command = new SqlCommand(sqlQuery, cn);
                using (SqlDataReader myDataReader = command.ExecuteReader())
                {
                    while (myDataReader.Read())
                    {
                        String nombre = myDataReader["nombre"].ToString() + " " + myDataReader["apellido"].ToString();
                        richTextBox1.AppendText(nombre + "\n");
                    }
                }

            }
        }

        private string GetConnectionString()
        {
            string path = @"C:\Alejo\Programacion\C#\CursoDeCSharp\Programacion III\EjercicioBasesDeDatos\Database1.mdf";
            return @$"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = {path}; Integrated Security = True";
        }

    }
}