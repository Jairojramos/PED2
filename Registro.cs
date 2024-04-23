using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Proyecto_de_catedra
{
    public partial class Registro : Form
    {
        // Cadena de conexión a la base de datos
        private string cadenaConexion = "Server=DESKTOP-C340CT0;Database=Contactos;integrated security=True;";
        public Registro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Capturamos los datos del formulario
            string usuario = txtuser.Text;
            string contraseña = txtpass.Text;
            string correo = txtcorreo.Text;

            // Validamos que los campos no estén vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(correo))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validamos el formato del correo electrónico
            if (!FormatoCorreo(correo))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validamos la contraseña
            if (!ContrasenaSegura(contraseña))
            {
                MessageBox.Show("La contraseña no cumple con los requisitos mínimos de seguridad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Debe tener al menos 6 caracteres, contener al menos una letra mayúscula, una letra minúscula, un número y un carácter especial.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intentamos registrar al usuario
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Insertamos los datos del nuevo usuario en la tabla Usuarios
                    string consultaInsertar = "INSERT INTO Usuarios (usuario, password, correo, fecha_registro, ultima_sesion, estado, tipo_usuario) VALUES (@Usuario, @Password, @Correo, @FechaRegistro, @UltimaSesion, @Estado, @TipoUsuario)";
                    SqlCommand comandoInsertar = new SqlCommand(consultaInsertar, conexion);
                    comandoInsertar.Parameters.AddWithValue("@Usuario", usuario);
                    comandoInsertar.Parameters.AddWithValue("@Password", contraseña);
                    comandoInsertar.Parameters.AddWithValue("@Correo", correo);
                    comandoInsertar.Parameters.AddWithValue("@FechaRegistro", DateTime.Now);
                    comandoInsertar.Parameters.AddWithValue("@UltimaSesion", DBNull.Value); // Podría ser null
                    comandoInsertar.Parameters.AddWithValue("@Estado", DBNull.Value); // Podría ser null
                    comandoInsertar.Parameters.AddWithValue("@TipoUsuario", "normal");
                    comandoInsertar.ExecuteNonQuery();

                    MessageBox.Show("Usuario registrado correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Método para validar el formato del correo electrónico
        private bool FormatoCorreo(string correo)
        {
            // Expresión regular para validar el formato de correo electrónico
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Se verifica si el correo coincide con el patrón de expresión regular
            return Regex.IsMatch(correo, patronCorreo);
        }
        // Método para la seguridad de la contraseña
        private bool ContrasenaSegura(string contraseña)
        {
            // Verifica que la contraseña tenga al menos 6 caracteres
            if (contraseña.Length < 6)
                return false;

            // Verifica que la contraseña contenga al menos una letra mayúscula
            if (!contraseña.Any(char.IsUpper))
                return false;

            // Verifica que la contraseña contenga al menos una letra minúscula
            if (!contraseña.Any(char.IsLower))
                return false;

            // Verifica que la contraseña contenga al menos un número
            if (!contraseña.Any(char.IsDigit))
                return false;

            // Verifica que la contraseña contenga al menos un carácter especial
            if (!contraseña.Any(c => !char.IsLetterOrDigit(c)))
                return false;

            return true;
        }
        private void LimpiarCampos()
        {
            txtuser.Text = "";
            txtcorreo.Text = "";
            txtpass.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Cambiar el carácter de contraseña a texto o viceversa
            txtpass.PasswordChar = txtpass.PasswordChar == '\0' ? '*' : '\0';
        }
    }
}
