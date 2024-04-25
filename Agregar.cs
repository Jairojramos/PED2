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
    public partial class Agregar : Form
    {
        private string cadenaConexion = "Server=DESKTOP-C340CT0;Database=Contactos;Integrated Security=True;";
        private string usuario;

        public Agregar(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario; // Guardar el nombre de usuario
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            string correo = txtcorreo.Text;
            string telefono = txttelefono.Text;
            string direccion = txtdireccion.Text;
            string ciudad = txtcuidad.Text;
            string pais = cmbpais.SelectedItem?.ToString();
            DateTime fechaNacimiento = dtpfecha.Value;

            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(ciudad) ||
                string.IsNullOrWhiteSpace(pais))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener identificadores de grupo y organización seleccionados
            int idGrupo = cmbgrupo.SelectedIndex != -1 ? cmbgrupo.SelectedIndex + 1 : 0;
            int idOrganizacion = cmborg.SelectedIndex != -1 ? cmborg.SelectedIndex + 1 : 0;

            // Obtener identificador de usuario actual
            int idUsuario = ObtenerIdUsuarioActual();

            // Crear nuevo contacto
            ContactoNodo nuevoContacto = new ContactoNodo(nombre, apellido, correo, telefono, direccion, ciudad, pais, fechaNacimiento, idGrupo, idOrganizacion, idUsuario);

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Insertar contacto en la base de datos
                    string consulta = "INSERT INTO Contactos (nombre, apellido, correo, telefono, direccion, ciudad, pais, fecha_nacimiento, id_grupo, id_organizacion, id_usuario) " +
                                      "VALUES (@Nombre, @Apellido, @Correo, @Telefono, @Direccion, @Ciudad, @Pais, @FechaNacimiento, @IdGrupo, @IdOrganizacion, @IdUsuario)";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@Nombre", nuevoContacto.Nombre);
                    comando.Parameters.AddWithValue("@Apellido", nuevoContacto.Apellido);
                    comando.Parameters.AddWithValue("@Correo", nuevoContacto.Correo);
                    comando.Parameters.AddWithValue("@Telefono", nuevoContacto.Telefono);
                    comando.Parameters.AddWithValue("@Direccion", nuevoContacto.Direccion);
                    comando.Parameters.AddWithValue("@Ciudad", nuevoContacto.Ciudad);
                    comando.Parameters.AddWithValue("@Pais", nuevoContacto.Pais);
                    comando.Parameters.AddWithValue("@FechaNacimiento", nuevoContacto.FechaNacimiento);
                    comando.Parameters.AddWithValue("@IdGrupo", nuevoContacto.IdGrupo);
                    comando.Parameters.AddWithValue("@IdOrganizacion", nuevoContacto.IdOrganizacion);
                    comando.Parameters.AddWithValue("@IdUsuario", nuevoContacto.IdUsuario);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Contacto registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos(); // Limpiar campos después de registrar el contacto
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el contacto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerIdUsuarioActual()
        {
            int idUsuario = -1; // Valor predeterminado

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Consulta para obtener ID del usuario actual
                    string consultaIdUsuario = "SELECT id_usuario FROM Usuarios WHERE usuario = @Usuario";
                    SqlCommand comandoIdUsuario = new SqlCommand(consultaIdUsuario, conexion);
                    comandoIdUsuario.Parameters.AddWithValue("@Usuario", usuario); // Pasar el valor del usuario al parámetro
                    idUsuario = (int)comandoIdUsuario.ExecuteScalar();

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return idUsuario;
        }

        private void LimpiarCampos()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtcorreo.Clear();
            txttelefono.Clear();
            txtdireccion.Clear();
            txtcuidad.Clear();
            cmbpais.SelectedIndex = -1; // Limpiar selección del ComboBox de países
            dtpfecha.Value = DateTime.Today; // Restablecer fecha de nacimiento al día actual
            cmbgrupo.SelectedIndex = -1;
            cmborg.SelectedIndex = -1;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LimpiarCampos(); // Limpiar campos del formulario
        }
        private void Agregar_Load(object sender, EventArgs e)
        {
            // Quita el borde del control DateTimePicker
            dateTimePicker1.BorderStyle = BorderStyle.None;
        }
        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}