using Modelos;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        List<Perro> listado;
        public Form1()
        {
            InitializeComponent();
        }

        public void RecargarGrid()
        {
            listado = NPerro.GetAllPerros();
            nPerroBindingSource.DataSource = listado;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Agregar formuagregar=new Agregar();
            formuagregar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            listado=NPerro.GetAllPerros();
            nPerroBindingSource.DataSource = listado;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var seleccionado = (Perro)nPerroBindingSource.Current;
            NPerro.DeletePerro(seleccionado.id);
            listado = NPerro.GetAllPerros();
            nPerroBindingSource.DataSource = listado;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var seleccionado = (Perro)nPerroBindingSource.Current;
            Actualizar form = new Actualizar(seleccionado.id);
            form.Show();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            listado = NPerro.GetAllPerros();
            nPerroBindingSource.DataSource = listado;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listado = NPerro.GetAllPerros();
            nPerroBindingSource.DataSource = listado;

        }
    }
}