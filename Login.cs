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

namespace Proyecto_de_catedra
{
    public partial class Login : Form
    {
        // Cadena de conexi�n a la base de datos
        private string cadenaConexion = "Server=DESKTOP-C340CT0;Database=Contactos;integrated security=True;";
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Capturamos los datos del formulario
            string usuario = txtuser.Text;
            string contrase�a = txtpass.Text;

            // Validamos que los campos no est�n vac�os
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrase�a))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intentamos iniciar sesi�n
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Verificamos si el usuario y la contrase�a coinciden en la base de datos
                    string consultaInicioSesion = "SELECT COUNT(*) FROM Usuarios WHERE usuario = @Usuario AND password = @Password";
                    SqlCommand comandoInicioSesion = new SqlCommand(consultaInicioSesion, conexion);
                    comandoInicioSesion.Parameters.AddWithValue("@Usuario", usuario);
                    comandoInicioSesion.Parameters.AddWithValue("@Password", contrase�a);
                    int cantidadUsuarios = (int)comandoInicioSesion.ExecuteScalar();

                    if (cantidadUsuarios > 0)
                    {
                        // Inicio de sesi�n exitoso
                        MessageBox.Show($"�Bienvenida/o, {usuario}!", "Inicio de sesi�n exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();

                        // Se abre el formulario principal de la aplicaci�n                      
                        this.Hide(); // Ocultar el formulario de inicio de sesi�n
                        Inicio formInicio = new Inicio(this, usuario); // Mostrar el formulario de inicio
                        formInicio.ShowDialog(); // Utiliza Show() si no necesitas bloquear el formulario de inicio de sesi�n

                    }
                    else
                    {
                        // Error de inicio de sesi�n: usuario o contrase�a incorrectos
                        MessageBox.Show("Usuario o contrase�a incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesi�n: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtuser.Clear();
            txtpass.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click_1(object sender, EventArgs e)
        {
            // Aqu� abrimos el formulario de registro
            Registro Registro = new Registro();
            Registro.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Cambiar el car�cter de contrase�a a texto o viceversa
            txtpass.PasswordChar = txtpass.PasswordChar == '\0' ? '*' : '\0';
        }
    }
}
