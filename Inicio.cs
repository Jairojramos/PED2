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
    
    public partial class Inicio : Form
    {
        private Login login; // Referencia al formulario de inicio de sesión
        private string nombreUsuario; // Variable para almacenar el nombre de usuario

        public Inicio(Login login, string nombreUsuario)
        {
            InitializeComponent();
            this.login = login; // Asignar el formulario de inicio de sesión
            this.nombreUsuario = nombreUsuario; // Guardar el nombre de usuario
            MostrarSaludo(); // Mostrar el saludo al usuario
            CambiarImagenSegunHora(); // Cambiar la imagen según la hora del día
        }

        public Inicio()
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cierra la sesión actual y muestra el formulario de inicio de sesión
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Cierra el formulario actual y muestra el formulario de inicio de sesión
                this.Close(); // Cierra el formulario actual
                login.Show(); // Muestra el formulario de inicio de sesión
            }
        }
        private void MostrarSaludo()
        {
            string saludo = ObtenerSaludo();
            lblsaludo.Text = $"{saludo}, {nombreUsuario}"; // Mostrar el saludo con el nombre del usuario
        }
        private string ObtenerSaludo()
        {
            string saludo = "Buenas";

            // Determinar si es mañana, tarde o noche
            int hora = DateTime.Now.Hour;
            if (hora >= 6 && hora < 12)
                saludo += " días";
            else if (hora >= 12 && hora < 19)
                saludo += " tardes";
            else
                saludo += " noches";

            return saludo;
        }

        private void CambiarImagenSegunHora()
        {
            int hora = DateTime.Now.Hour;

            // Cambiar la imagen del PictureBox según la hora del día
            if (hora >= 6 && hora < 12)
                pictureBox1.Image = Properties.Resources.dia; // Imagen para la mañana
            else if (hora >= 12 && hora < 18)
                pictureBox1.Image = Properties.Resources.tarde; // Imagen para la tarde
            else
                pictureBox1.Image = Properties.Resources.noche; // Imagen para la noche
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener el nombre de usuario desde el formulario de inicio de sesión
            string nombreUsuario = login.NombreUsuario;

            // Crear una instancia del formulario "Agregar" y pasar el nombre de usuario al constructor
            Agregar formulario = new Agregar(nombreUsuario);

            // Mostrar el formulario como una ventana modal
            formulario.ShowDialog();
        }
    }
}