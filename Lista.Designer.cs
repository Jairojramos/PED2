namespace Proyecto_de_catedra
{
    partial class Lista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            dgvcontactos = new DataGridView();
            btneditar = new Button();
            btneliminar = new Button();
            btnbuscar = new PictureBox();
            txtbuscar = new TextBox();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            cuidad = new DataGridViewTextBoxColumn();
            pais = new DataGridViewTextBoxColumn();
            fechanacimiento = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            grupo = new DataGridViewTextBoxColumn();
            organizacion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvcontactos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnbuscar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(350, 571);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(17, 15);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 37);
            label1.Name = "label1";
            label1.Size = new Size(223, 28);
            label1.TabIndex = 32;
            label1.Text = "Lista de contactos";
            // 
            // dgvcontactos
            // 
            dgvcontactos.BackgroundColor = Color.White;
            dgvcontactos.BorderStyle = BorderStyle.None;
            dgvcontactos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvcontactos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvcontactos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvcontactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcontactos.Columns.AddRange(new DataGridViewColumn[] { nombre, apellido, correo, direccion, cuidad, pais, fechanacimiento, telefono, grupo, organizacion });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvcontactos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvcontactos.EnableHeadersVisualStyles = false;
            dgvcontactos.GridColor = Color.Gainsboro;
            dgvcontactos.Location = new Point(383, 137);
            dgvcontactos.Name = "dgvcontactos";
            dgvcontactos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvcontactos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvcontactos.RowHeadersVisible = false;
            dgvcontactos.Size = new Size(706, 386);
            dgvcontactos.TabIndex = 34;
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.FromArgb(57, 126, 246);
            btneditar.Cursor = Cursors.Hand;
            btneditar.FlatAppearance.BorderColor = Color.FromArgb(57, 126, 246);
            btneditar.FlatAppearance.BorderSize = 0;
            btneditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(57, 126, 246);
            btneditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(57, 126, 246);
            btneditar.FlatStyle = FlatStyle.Flat;
            btneditar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneditar.ForeColor = Color.White;
            btneditar.Location = new Point(871, 550);
            btneditar.Margin = new Padding(0);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(101, 30);
            btneditar.TabIndex = 35;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.FromArgb(245, 71, 71);
            btneliminar.Cursor = Cursors.Hand;
            btneliminar.FlatAppearance.BorderColor = Color.FromArgb(57, 126, 246);
            btneliminar.FlatAppearance.BorderSize = 0;
            btneliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(57, 126, 246);
            btneliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(57, 126, 246);
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminar.ForeColor = Color.White;
            btneliminar.Location = new Point(988, 550);
            btneliminar.Margin = new Padding(0);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(101, 30);
            btneliminar.TabIndex = 36;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.White;
            btnbuscar.Cursor = Cursors.Hand;
            btnbuscar.Image = (Image)resources.GetObject("btnbuscar.Image");
            btnbuscar.Location = new Point(759, 12);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(408, 164);
            btnbuscar.SizeMode = PictureBoxSizeMode.Zoom;
            btnbuscar.TabIndex = 37;
            btnbuscar.TabStop = false;
            // 
            // txtbuscar
            // 
            txtbuscar.BackColor = Color.White;
            txtbuscar.BorderStyle = BorderStyle.None;
            txtbuscar.Font = new Font("Century Gothic", 9.75F);
            txtbuscar.ForeColor = Color.Black;
            txtbuscar.Location = new Point(844, 87);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(201, 16);
            txtbuscar.TabIndex = 38;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nombre.DataPropertyName = "nombre";
            nombre.HeaderText = "Nombre";
            nombre.MaxInputLength = 200;
            nombre.Name = "nombre";
            nombre.Width = 82;
            // 
            // apellido
            // 
            apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            apellido.DataPropertyName = "apellido";
            apellido.HeaderText = "Apellido";
            apellido.MaxInputLength = 200;
            apellido.Name = "apellido";
            apellido.Width = 86;
            // 
            // correo
            // 
            correo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            correo.DataPropertyName = "correo";
            correo.HeaderText = "Correo";
            correo.MaxInputLength = 200;
            correo.Name = "correo";
            correo.Width = 74;
            // 
            // direccion
            // 
            direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            direccion.DataPropertyName = "direccion";
            direccion.HeaderText = "Dirección";
            direccion.MaxInputLength = 200;
            direccion.Name = "direccion";
            direccion.Width = 92;
            // 
            // cuidad
            // 
            cuidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cuidad.DataPropertyName = "cuidad";
            cuidad.HeaderText = "Cuidad";
            cuidad.MaxInputLength = 200;
            cuidad.Name = "cuidad";
            cuidad.Width = 79;
            // 
            // pais
            // 
            pais.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            pais.DataPropertyName = "pais";
            pais.HeaderText = "País";
            pais.MaxInputLength = 200;
            pais.Name = "pais";
            pais.Width = 55;
            // 
            // fechanacimiento
            // 
            fechanacimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            fechanacimiento.DataPropertyName = "fecha_nacimiento";
            fechanacimiento.HeaderText = "Fecha de nacimiento";
            fechanacimiento.MaxInputLength = 200;
            fechanacimiento.Name = "fechanacimiento";
            fechanacimiento.Width = 152;
            // 
            // telefono
            // 
            telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            telefono.DataPropertyName = "telefono";
            telefono.HeaderText = "Teléfono";
            telefono.MaxInputLength = 200;
            telefono.Name = "telefono";
            telefono.Width = 84;
            // 
            // grupo
            // 
            grupo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grupo.DataPropertyName = "id_grupo";
            grupo.HeaderText = "Grupo";
            grupo.MaxInputLength = 200;
            grupo.Name = "grupo";
            grupo.Width = 71;
            // 
            // organizacion
            // 
            organizacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            organizacion.DataPropertyName = "id_organizacion";
            organizacion.HeaderText = "Organización";
            organizacion.MaxInputLength = 200;
            organizacion.Name = "organizacion";
            organizacion.Width = 119;
            // 
            // Lista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1119, 638);
            Controls.Add(txtbuscar);
            Controls.Add(btneliminar);
            Controls.Add(btneditar);
            Controls.Add(dgvcontactos);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(btnbuscar);
            Name = "Lista";
            Text = "Lista";
            Load += Lista_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvcontactos).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnbuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Label label1;
        private DataGridView dgvcontactos;
        private Button btneditar;
        private Button btneliminar;
        private PictureBox btnbuscar;
        private TextBox txtbuscar;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn cuidad;
        private DataGridViewTextBoxColumn pais;
        private DataGridViewTextBoxColumn fechanacimiento;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn grupo;
        private DataGridViewTextBoxColumn organizacion;
    }
}