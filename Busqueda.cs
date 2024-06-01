using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_de_catedra
{
    public partial class Busqueda : Form
    {
        // Cadena de conexión a la base de datos
        private string cadenaConexion = "Server=DESKTOP-C340CT0;Database=Contactos;Integrated Security=True;";

        public Busqueda()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta al cargar el formulario
        private void Busqueda_Load(object sender, EventArgs e)
        {
            CargarFiltros();
        }

        // Método para cargar los datos en los ComboBoxes
        private void CargarFiltros()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                // Cargar datos en cmbciudad
                SqlDataAdapter adaptadorCiudad = new SqlDataAdapter("SELECT DISTINCT ciudad FROM Contactos", conexion);
                DataTable tablaCiudad = new DataTable();
                adaptadorCiudad.Fill(tablaCiudad);
                cmbciudad.DataSource = tablaCiudad;
                cmbciudad.DisplayMember = "ciudad";

                conexion.Close();
            }

        }

        // Método para buscar contactos según los filtros
        private void BuscarContactos()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT nombre, apellido, correo, telefono, direccion, ciudad, pais, fecha_nacimiento FROM Contactos WHERE 1=1";

                if (!string.IsNullOrEmpty(cmbciudad.Text))
                {
                    consulta += " AND ciudad = @Ciudad";
                }
                if (!string.IsNullOrEmpty(cmbpais.Text))
                {
                    consulta += " AND pais = @Pais";
                }
                if (cmbgrupo.SelectedIndex != -1)
                {
                    consulta += " AND id_grupo = @IdGrupo";
                }
                if (cmborg.SelectedIndex != -1)
                {
                    consulta += " AND id_organizacion = @IdOrganizacion";
                }

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

                if (!string.IsNullOrEmpty(cmbciudad.Text))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@Ciudad", cmbciudad.Text);
                }
                if (!string.IsNullOrEmpty(cmbpais.Text))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@Pais", cmbpais.Text);
                }
                if (cmbgrupo.SelectedIndex != -1)
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@IdGrupo", cmbgrupo.SelectedIndex + 1);
                }
                if (cmborg.SelectedIndex != -1)
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@IdOrganizacion", cmborg.SelectedIndex + 1);
                }

                DataTable tablaContactos = new DataTable();
                adaptador.Fill(tablaContactos);
                dgvbuscar.DataSource = tablaContactos;

                // Actualizar TreeView
                treeView1.Nodes.Clear();
                foreach (DataRow row in tablaContactos.Rows)
                {
                    TreeNode node = new TreeNode(row["nombre"].ToString());
                    node.Nodes.Add("Apellido: " + row["apellido"]);
                    node.Nodes.Add("Correo: " + row["correo"]);
                    node.Nodes.Add("Teléfono: " + row["telefono"]);
                    node.Nodes.Add("Dirección: " + row["direccion"]);
                    node.Nodes.Add("Ciudad: " + row["ciudad"]);
                    node.Nodes.Add("País: " + row["pais"]);
                    node.Nodes.Add("Fecha de Nacimiento: " + Convert.ToDateTime(row["fecha_nacimiento"]).ToString("dd/MM/yyyy"));
                    treeView1.Nodes.Add(node);
                }

                conexion.Close();
            }
        }

        // Evento que se ejecuta al hacer clic en el botón para regresar al formulario anterior
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            BuscarContactos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Limpiar campos de búsqueda
            cmbciudad.SelectedIndex = -1;
            cmbpais.SelectedIndex = -1;
            cmbgrupo.SelectedIndex = -1;
            cmborg.SelectedIndex = -1;
            dgvbuscar.DataSource = null;
            treeView1.Nodes.Clear();
        }
    }
}
