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
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual (Agregar) y muestra el formulario de Inicio
            this.Close();
            // Muestra el formulario de Inicio si ya está creado
            Application.OpenForms["Inicio"]?.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
