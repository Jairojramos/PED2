namespace Proyecto_de_catedra
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            btnRegistrar = new Button();
            txtuser = new TextBox();
            pictureBox3 = new PictureBox();
            txtpass = new TextBox();
            btnRegresar = new Button();
            pictureBox2 = new PictureBox();
            txtcorreo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(5, 92, 231);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderColor = Color.FromArgb(5, 92, 231);
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 92, 231);
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 92, 231);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(470, 349);
            btnRegistrar.Margin = new Padding(0);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(275, 46);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrarse";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.FromArgb(240, 239, 240);
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.ForeColor = Color.DimGray;
            txtuser.Location = new Point(480, 169);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(265, 19);
            txtuser.TabIndex = 10;
            txtuser.Text = "Usuario";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Control;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, -34);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(839, 612);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(240, 239, 240);
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.ForeColor = Color.DimGray;
            txtpass.Location = new Point(480, 284);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(265, 19);
            txtpass.TabIndex = 16;
            txtpass.Text = "*****";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(15, 79, 210);
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.FlatAppearance.BorderColor = Color.FromArgb(15, 79, 210);
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 79, 210);
            btnRegresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 79, 210);
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(85, 341);
            btnRegresar.Margin = new Padding(0);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(212, 34);
            btnRegresar.TabIndex = 18;
            btnRegresar.Text = "¿Ya tienes una cuenta? Inicia sesión";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(240, 239, 240);
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(704, 280);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txtcorreo
            // 
            txtcorreo.BackColor = Color.FromArgb(240, 239, 240);
            txtcorreo.BorderStyle = BorderStyle.None;
            txtcorreo.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcorreo.ForeColor = Color.DimGray;
            txtcorreo.Location = new Point(476, 227);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(265, 19);
            txtcorreo.TabIndex = 20;
            txtcorreo.Text = "Correo";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 547);
            Controls.Add(txtcorreo);
            Controls.Add(pictureBox2);
            Controls.Add(btnRegresar);
            Controls.Add(txtpass);
            Controls.Add(btnRegistrar);
            Controls.Add(txtuser);
            Controls.Add(pictureBox3);
            Name = "Registro";
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegistrar;
        private TextBox txtuser;
        private PictureBox pictureBox3;
        private TextBox txtpass;
        private Button btnRegresar;
        private PictureBox pictureBox2;
        private TextBox txtcorreo;
    }
}