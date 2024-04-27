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
        // Cadena de conexión a la base de datos
        private string cadenaConexion = "Server=DESKTOP-C340CT0;Database=Contactos;integrated security=True;";

        // Propiedad pública para el nombre de usuario
        public string NombreUsuario { get; private set; }
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Capturamos los datos del formulario
            string usuario = txtuser.Text;
            string contraseña = txtpass.Text;

            // Validamos que los campos no estén vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intentamos iniciar sesión
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Verificamos si el usuario y la contraseña coinciden en la base de datos
                    string consultaInicioSesion = "SELECT COUNT(*) FROM Usuarios WHERE usuario = @Usuario AND password = @Password";
                    SqlCommand comandoInicioSesion = new SqlCommand(consultaInicioSesion, conexion);
                    comandoInicioSesion.Parameters.AddWithValue("@Usuario", usuario);
                    comandoInicioSesion.Parameters.AddWithValue("@Password", contraseña);
                    int cantidadUsuarios = (int)comandoInicioSesion.ExecuteScalar();

                    if (cantidadUsuarios > 0)
                    {
                        // Si el inicio de sesión es exitoso, establece el nombre de usuario
                        NombreUsuario = usuario;

                        // Inicio de sesión exitoso
                        MessageBox.Show($"¡Bienvenida/o, {usuario}!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();

                        // Se abre el formulario principal de la aplicación                      
                        this.Hide(); // Ocultar el formulario de inicio de sesión
                        Inicio formInicio = new Inicio(this, usuario); // Mostrar el formulario de inicio
                        formInicio.ShowDialog(); // Utiliza Show() si no necesitas bloquear el formulario de inicio de sesión

                    }
                    else
                    {
                        // Error de inicio de sesión: usuario o contraseña incorrectos
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Desactivar el formulario principal para dar un efecto de desenfoque
            this.Enabled = false;

            // Aquí abrimos el formulario de registro
            Registro Registro = new Registro();
            Registro.ShowDialog();

            // Una vez que se cierre el formulario, desbloquear el formulario principal
            this.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Cambiar el carácter de contraseña a texto o viceversa
            txtpass.PasswordChar = txtpass.PasswordChar == '\0' ? '*' : '\0';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Desactivar el formulario principal para dar un efecto de desenfoque
            this.Enabled = false;

            // Crear una instancia del formulario Recuperar
            Recuperar formularioRecuperar = new Recuperar();

            // Mostrar el formulario Recuperar como una ventana modal
            formularioRecuperar.ShowDialog();

            // Una vez que se cierre el formulario, desbloquear el formulario principal
            this.Enabled = true;
        }
    }
}