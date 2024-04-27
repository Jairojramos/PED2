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
            dgv = new DataGridView();
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
            btneditar = new Button();
            btneliminar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // dgv
            // 
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { nombre, apellido, correo, direccion, cuidad, pais, fechanacimiento, telefono, grupo, organizacion });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.Gainsboro;
            dgv.Location = new Point(383, 136);
            dgv.Name = "dgv";
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv.RowHeadersVisible = false;
            dgv.Size = new Size(706, 386);
            dgv.TabIndex = 34;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nombre.HeaderText = "Nombre";
            nombre.MaxInputLength = 200;
            nombre.Name = "nombre";
            nombre.Width = 82;
            // 
            // apellido
            // 
            apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            apellido.HeaderText = "Apellido";
            apellido.MaxInputLength = 200;
            apellido.Name = "apellido";
            apellido.Width = 86;
            // 
            // correo
            // 
            correo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            correo.HeaderText = "Correo";
            correo.MaxInputLength = 200;
            correo.Name = "correo";
            correo.Width = 74;
            // 
            // direccion
            // 
            direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            direccion.HeaderText = "Dirección";
            direccion.MaxInputLength = 200;
            direccion.Name = "direccion";
            direccion.Width = 92;
            // 
            // cuidad
            // 
            cuidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cuidad.HeaderText = "Cuidad";
            cuidad.MaxInputLength = 200;
            cuidad.Name = "cuidad";
            cuidad.Width = 79;
            // 
            // pais
            // 
            pais.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            pais.HeaderText = "País";
            pais.MaxInputLength = 200;
            pais.Name = "pais";
            pais.Width = 55;
            // 
            // fechanacimiento
            // 
            fechanacimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            fechanacimiento.HeaderText = "Fecha de nacimiento";
            fechanacimiento.MaxInputLength = 200;
            fechanacimiento.Name = "fechanacimiento";
            fechanacimiento.Width = 152;
            // 
            // telefono
            // 
            telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            telefono.HeaderText = "Teléfono";
            telefono.MaxInputLength = 200;
            telefono.Name = "telefono";
            telefono.Width = 84;
            // 
            // grupo
            // 
            grupo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grupo.HeaderText = "Grupo";
            grupo.MaxInputLength = 200;
            grupo.Name = "grupo";
            grupo.Width = 71;
            // 
            // organizacion
            // 
            organizacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            organizacion.HeaderText = "Organización";
            organizacion.MaxInputLength = 200;
            organizacion.Name = "organizacion";
            organizacion.Width = 119;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(759, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // Lista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1119, 638);
            Controls.Add(btneliminar);
            Controls.Add(btneditar);
            Controls.Add(dgv);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Lista";
            Text = "Lista";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Label label1;
        private DataGridView dgv;
        private Button btneditar;
        private Button btneliminar;
        private PictureBox pictureBox1;
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