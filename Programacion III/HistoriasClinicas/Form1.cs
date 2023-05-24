namespace HistoriasClinicas
{
    public partial class Form1 : Form
    {

        List<Paciente> listaPacientes = new List<Paciente>();  
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        public void refrescar()
        {
            dataGridView1.DataSource = null;
            BindingSource db = new BindingSource();
            db.DataSource = listaPacientes;
            dataGridView1.DataSource = db;
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            CrearPaciente crearPaciente= new CrearPaciente();
            crearPaciente.ShowDialog();

            if(crearPaciente.DialogResult == DialogResult.OK)
            {
                listaPacientes.Add(crearPaciente.paciente);
                refrescar();
            }
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            CrearPaciente crearPaciente = new CrearPaciente();

            if(dataGridView1.SelectedRows.Count > 0)//Si esta seleccionada por lo menos una fila
            {
                crearPaciente.paciente = GetPaciente();
                Paciente oldPaciente = GetPaciente();
                crearPaciente.CargarDatos();
                crearPaciente.ShowDialog();

                if(crearPaciente.DialogResult == DialogResult.OK)
                {
                    listaPacientes.Remove(oldPaciente);
                    listaPacientes.Add(crearPaciente.paciente);
                    refrescar();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }

        }

        public Paciente GetPaciente()
        {
            string nombre = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string apellido = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string telefono = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Paciente oldPaciente = listaPacientes.FirstOrDefault(p => p.Nombre == nombre && p.Apellido == apellido && p.Telefono == telefono);
            return oldPaciente;
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)//Si esta seleccionada por lo menos una fila
            {
                Paciente paciente = GetPaciente();
                listaPacientes.Remove(paciente);
                refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}