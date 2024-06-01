using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_de_catedra
{
    public partial class Configuracion : Form
    {
        private string cadenaConexion = "Server=DESKTOP-C340CT0;Database=Contactos;Integrated Security=True;";

        public Configuracion()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual y muestra el formulario de Inicio
            this.Close();
            Application.OpenForms["Inicio"]?.Show();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT usuario, correo, password FROM Usuarios WHERE id_usuario = @IdUsuario";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@IdUsuario", Sesion.IdUsuario);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtuser.Text = reader["usuario"].ToString();
                        txtcorreo.Text = reader["correo"].ToString();
                        txtpass.Text = reader["password"].ToString();
                    }
                }
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "UPDATE Usuarios SET usuario = @Usuario, correo = @Correo, password = @Password WHERE id_usuario = @IdUsuario";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Usuario", txtuser.Text);
                comando.Parameters.AddWithValue("@Correo", txtcorreo.Text);
                comando.Parameters.AddWithValue("@Password", txtpass.Text);
                comando.Parameters.AddWithValue("@IdUsuario", Sesion.IdUsuario);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            // Código adicional si es necesario
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {
            // Código adicional si es necesario
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            // Código adicional si es necesario
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar tu cuenta? Esta acción no se puede deshacer.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "DELETE FROM Usuarios WHERE id_usuario = @IdUsuario";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@IdUsuario", Sesion.IdUsuario);

                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Cuenta eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Cerrar la aplicación o redirigir al formulario de inicio de sesión
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
