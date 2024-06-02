using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_de_catedra
{
    public partial class Recuperar : Form
    {
        // Cadena de conexión a la base de datos
        private string cadenaConexion = "Server=DESKTOP-C340CT0;Database=Contactos;Integrated Security=True;";

        public Recuperar()
        {
            InitializeComponent();
            txtcontra.Enabled = false; // Deshabilitar el campo de contraseña inicialmente
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual (Agregar) y muestra el formulario de Login
            this.Close();
            Application.OpenForms["Login"]?.Show();
        }

        private void Recuperar_Load(object sender, EventArgs e)
        {

        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcorreo.Text))
            {
                MessageBox.Show("Ingrese el correo electrónico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtcontra.Text))
            {
                MessageBox.Show("Ingrese la nueva contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    string consulta = "UPDATE Usuarios SET password = @Password WHERE correo = @Correo";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@Password", txtcontra.Text);
                    comando.Parameters.AddWithValue("@Correo", txtcorreo.Text);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Contraseña actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la contraseña. Verifique el correo electrónico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la contraseña: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcorreo.Text))
            {
                txtcontra.Enabled = false;
                return;
            }

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    string consulta = "SELECT COUNT(*) FROM Usuarios WHERE correo = @Correo";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@Correo", txtcorreo.Text);
                    int count = (int)comando.ExecuteScalar();

                    if (count > 0)
                    {
                        txtcontra.Enabled = true; // Habilitar el campo de contraseña si el correo existe
                    }
                    else
                    {
                        txtcontra.Enabled = false; // Deshabilitar el campo de contraseña si el correo no existe
                    }

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar el correo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
