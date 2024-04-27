namespace Proyecto_de_catedra
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btneditar = new Button();
            pictureBox1 = new PictureBox();
            btneliminar = new Button();
            dgv = new DataGridView();
            usuario = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            contrasena = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
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
            btneditar.Location = new Point(607, 456);
            btneditar.Margin = new Padding(0);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(101, 30);
            btneditar.TabIndex = 42;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(436, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.FromArgb(245, 71, 71);
            btneliminar.Cursor = Cursors.Hand;
            btneliminar.FlatAppearance.BorderColor = Color.FromArgb(245, 71, 71);
            btneliminar.FlatAppearance.BorderSize = 0;
            btneliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 71, 71);
            btneliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 71, 71);
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminar.ForeColor = Color.White;
            btneliminar.Location = new Point(724, 456);
            btneliminar.Margin = new Padding(0);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(101, 30);
            btneliminar.TabIndex = 43;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
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
            dgv.Columns.AddRange(new DataGridViewColumn[] { usuario, correo, contrasena });
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
            dgv.Location = new Point(384, 184);
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
            dgv.Size = new Size(460, 284);
            dgv.TabIndex = 41;
            // 
            // usuario
            // 
            usuario.HeaderText = "Usuario";
            usuario.MaxInputLength = 200;
            usuario.Name = "usuario";
            usuario.Width = 125;
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.MaxInputLength = 200;
            correo.Name = "correo";
            correo.Width = 125;
            // 
            // contrasena
            // 
            contrasena.HeaderText = "Contraseña";
            contrasena.MaxInputLength = 200;
            contrasena.Name = "contrasena";
            contrasena.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 41);
            label1.Name = "label1";
            label1.Size = new Size(203, 28);
            label1.TabIndex = 39;
            label1.Text = "Lista de usuarios";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 91);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(350, 464);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(790, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = SystemColors.ButtonFace;
            btnCerrar.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.Red;
            btnCerrar.Location = new Point(700, 22);
            btnCerrar.Margin = new Padding(0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.RightToLeft = RightToLeft.No;
            btnCerrar.Size = new Size(126, 29);
            btnCerrar.TabIndex = 46;
            btnCerrar.Text = "Cerrar sesión";
            btnCerrar.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 557);
            Controls.Add(pictureBox3);
            Controls.Add(btnCerrar);
            Controls.Add(btneditar);
            Controls.Add(btneliminar);
            Controls.Add(dgv);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Admin";
            Text = "AdminLista";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btneditar;
        private PictureBox pictureBox1;
        private Button btneliminar;
        private DataGridView dgv;
        private Label label1;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn contrasena;
        private PictureBox pictureBox3;
        private Button btnCerrar;
    }
}