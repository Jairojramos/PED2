using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_catedra
{
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual (Agregar) y muestra el formulario de Inicio
            this.Close();
            // Muestra el formulario de Inicio si ya está creado
            Application.OpenForms["Inicio"]?.Show();
        }
    }
}
