using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_de_catedra
{
    public partial class Lista : Form
    {
        // Cadena de conexión a la base de datos
        private string cadenaConexion = "Server=DESKTOP-C340CT0;Database=Contactos;Integrated Security=True;";

        public Lista()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta al cargar el formulario
        private void Lista_Load(object sender, EventArgs e)
        {
            CargarContactos();
        }

        // Método para cargar los contactos registrados por el usuario actual
        private void CargarContactos()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                int idUsuario = ObtenerIdUsuarioActual();

                // Consulta para obtener los contactos registrados por el usuario actual
                string consulta = "SELECT nombre, apellido, correo, telefono, direccion, ciudad, pais, fecha_nacimiento, id_grupo, id_organizacion FROM Contactos WHERE id_usuario = @IdUsuario";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                adaptador.SelectCommand.Parameters.AddWithValue("@IdUsuario", idUsuario);
                DataTable tablaContactos = new DataTable();
                adaptador.Fill(tablaContactos);

                // Asigna la tabla de contactos al DataGridView
                dgvcontactos.DataSource = tablaContactos;
            }
        }

        // Método para obtener el ID del usuario actual desde la sesión
        private int ObtenerIdUsuarioActual()
        {
            return Sesion.IdUsuario;
        }

        // Evento que se ejecuta al hacer clic en el botón para regresar al formulario de inicio
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Inicio"]?.Show();
        }

        // Evento que se ejecuta al hacer clic en el botón para editar un contacto
        private void btneditar_Click(object sender, EventArgs e)
        {
            Editar Editar = new Editar();
            Editar.ShowDialog();
        }

        private void dgvcontactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
