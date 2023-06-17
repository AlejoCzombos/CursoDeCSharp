using DataSetsYDataTables;
using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        //Defino el dataSet y los DataTables y los agrego al DataSet
        DataSet dataSetBiblioteca = new DataSet();
        DataTable dtLibro = new DataTable("Libro");
        DataTable dtEditorial = new DataTable("Editorial");

        dataSetBiblioteca.Tables.Add(dtLibro);
        dataSetBiblioteca.Tables.Add(dtEditorial);

        //Defino los Data Columns, defino caracteristicas de los ID y los agregos a sus respectivos DataTables
        DataColumn codEdLibro = new DataColumn("codEdFK", typeof(long));
        DataColumn idLibro = new DataColumn("id", typeof(long));
        DataColumn isbnLibro = new DataColumn("ISBM", typeof(long));
        DataColumn tituloLibro = new DataColumn("titulo", typeof(string));
        DataColumn autorLibro = new DataColumn("autor", typeof(string));

        idLibro.AutoIncrement = true;
        idLibro.ReadOnly = true;
        idLibro.AllowDBNull = false;

        dtLibro.Columns.Add(idLibro);
        dtLibro.Columns.Add(codEdLibro);
        dtLibro.Columns.Add(isbnLibro);
        dtLibro.Columns.Add(tituloLibro);
        dtLibro.Columns.Add(autorLibro);

        DataColumn codEdEditorial = new DataColumn("codEdID", typeof(long));
        DataColumn nombreEditorial = new DataColumn("nombre", typeof(string));
        DataColumn direccionEditorial = new DataColumn("direccion", typeof(string));
        DataColumn telefonoEditorial = new DataColumn("telefono", typeof(string));

        codEdEditorial.AutoIncrement = false;
        codEdEditorial.ReadOnly = true;
        codEdEditorial.AllowDBNull = false;

        dtEditorial.Columns.Add(codEdEditorial);
        dtEditorial.Columns.Add(nombreEditorial);
        dtEditorial.Columns.Add(direccionEditorial);
        dtEditorial.Columns.Add(telefonoEditorial);

        //Creo los multiples objetos libro y editorial y creo los distintos dataRows para rellenar las tablas
        Libro[] libros =
        {
        new Libro(1234567812, 4267, "Brandon Sanderson", "El Camino de los Reyes"),
        new Libro(6453241123, 4267, "Brandon Sanderson", "Palabras Radiantes"),
        new Libro(5413256325, 4267, "Brandon Sanderson", "Juramentada"),
        new Libro(4371829033, 1256, "JK Rowling", "Harry Potter y el Prisionero de Azcaban"),
        new Libro(7849310277, 1256, "JK Rowling", "Harry Potter y la Camara Secreta"),
        new Libro(7843219078, 7438, "Suzanne Collins", "Los Juegos del Hambre")
        };

        Editorial[] editoriales =
        {
            new Editorial("Nova", "Madrid 1764", "76453324", 4267),
            new Editorial("Molino", "Av. San Juan 6712", "43782978", 7438),
            new Editorial("Salamandra", "San Lorenzo", "43217890", 1256)
        };

        foreach (Libro libro in libros)
        {
            DataRow filaLibro = dtLibro.NewRow();
            filaLibro["codEdFK"] = libro.CodigoEditorial;
            filaLibro["ISBM"] = libro.ISBN1;
            filaLibro["titulo"] = libro.Titulo;
            filaLibro["autor"] = libro.Autor;
            dtLibro.Rows.Add(filaLibro);
        }
        foreach (Editorial editorial in editoriales)
        {
            DataRow filaEditorial = dtEditorial.NewRow();
            filaEditorial["codEdID"] = editorial.CodigoEditorial;
            filaEditorial["nombre"] = editorial.Nombre;
            filaEditorial["direccion"] = editorial.Direccion;
            filaEditorial["telefono"] = editorial.Numero;
            dtEditorial.Rows.Add(filaEditorial);
        }

        //Defino las relaciones entre las tablas y las agrego al DataSet
        DataRelation rel = new DataRelation("Tiene", dtEditorial.Columns["codEdID"], dtLibro.Columns["codEdFK"]);
        dataSetBiblioteca.Relations.Add(rel);

        foreach (DataRow dr in dtEditorial.Rows)
        {
            Console.WriteLine($"Nombre: " + dr["nombre"] + ", direccion: " + dr["direccion"] + ", codigo editorial: " + dr["codEdID"]);

            foreach (DataRow relDt in dr.GetChildRows(rel))
            {
                Console.WriteLine("\t Titulo: " + relDt["titulo"] + ", autor: " + relDt["autor"] + ", codigo Editorial" + relDt["codEdFK"]);
            }
            Console.WriteLine("");
        }

    }
}