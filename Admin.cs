using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_de_catedra
{
    public partial class Admin : Form
    {
        // Cadena de conexión a la base de datos
        private string cadenaConexion = "Server=DESKTOP-C340CT0;Database=Contactos;Integrated Security=True;";
        private int idUsuarioSeleccionado;

        public Admin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cierra la sesión actual y muestra el formulario de inicio de sesión
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Cierra el formulario actual y muestra el formulario de inicio de sesión
                this.Close(); // Cierra el formulario actual
                Login loginForm = new Login();
                loginForm.Show();
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgv.Rows[e.RowIndex];
                idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["id_usuario"].Value);
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        // Método para cargar todos los usuarios en el DataGridView
        private void CargarUsuarios()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                // Consulta para obtener todos los usuarios
                string consulta = "SELECT id_usuario, usuario, correo, fecha_registro, tipo_usuario FROM Usuarios";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable tablaUsuarios = new DataTable();
                adaptador.Fill(tablaUsuarios);

                // Asigna la tabla de usuarios al DataGridView
                dgv.DataSource = tablaUsuarios;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                    {
                        try
                        {
                            conexion.Open();
                            string consulta = "DELETE FROM Usuarios WHERE id_usuario = @IdUsuario";
                            SqlCommand comando = new SqlCommand(consulta, conexion);
                            comando.Parameters.AddWithValue("@IdUsuario", idUsuarioSeleccionado);
                            comando.ExecuteNonQuery();

                            MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarUsuarios();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al eliminar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
