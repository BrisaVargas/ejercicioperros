using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Actualizar : Form
    {
        int id;
        public Actualizar(int id)
        {
            InitializeComponent();
            this.id = id;
            label6.Text = id.ToString();        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string nom = textBox1.Text;
            string ape = textBox2.Text;
            string raza = textBox3.Text;
            int peso = int.Parse(textBox4.Text);
            try
            {
                NPerro.UpdatePerro(this.id,nom, ape, raza, peso);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            Form1 f = new Form1();
            f.RecargarGrid();
            Close();
        }
    }
}
