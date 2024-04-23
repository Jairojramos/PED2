

namespace Proyecto_de_catedra
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            btnIngresar = new Button();
            txtuser = new TextBox();
            txtpass = new TextBox();
            label1 = new Label();
            button2 = new Button();
            btnRegistrarse = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(463, 413);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(5, 92, 231);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(5, 92, 231);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 92, 231);
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 92, 231);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(486, 418);
            btnIngresar.Margin = new Padding(0);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(206, 28);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Iniciar sesión";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.FromArgb(76, 147, 237);
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.ForeColor = Color.White;
            txtuser.Location = new Point(493, 242);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(201, 19);
            txtuser.TabIndex = 3;
            txtuser.Text = "Usuario";
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(76, 147, 237);
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.ForeColor = Color.White;
            txtpass.Location = new Point(493, 288);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(197, 19);
            txtpass.TabIndex = 4;
            txtpass.Text = "*****";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label1.Location = new Point(493, 461);
            label1.Name = "label1";
            label1.Size = new Size(144, 16);
            label1.TabIndex = 5;
            label1.Text = "¿No tienes una cuenta?";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(4, 101, 234);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(4, 101, 234);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 101, 234);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 101, 234);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(529, 316);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(174, 29);
            button2.TabIndex = 6;
            button2.Text = "¿Olvidaste la contraseña?";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.White;
            btnRegistrarse.Cursor = Cursors.Hand;
            btnRegistrarse.FlatAppearance.BorderColor = Color.White;
            btnRegistrarse.FlatAppearance.BorderSize = 0;
            btnRegistrarse.FlatAppearance.MouseDownBackColor = Color.White;
            btnRegistrarse.FlatAppearance.MouseOverBackColor = Color.White;
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnRegistrarse.ForeColor = Color.FromArgb(5, 92, 231);
            btnRegistrarse.Location = new Point(625, 453);
            btnRegistrarse.Margin = new Padding(0);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.RightToLeft = RightToLeft.No;
            btnRegistrarse.Size = new Size(83, 32);
            btnRegistrarse.TabIndex = 7;
            btnRegistrarse.Text = "Registrate";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Control;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(241, 41);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(696, 477);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(76, 147, 237);
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(654, 283);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 547);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(btnIngresar);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(btnRegistrarse);
            Controls.Add(pictureBox3);
            Name = "Login";
            Text = "Inicio de sesión";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion
        private PictureBox pictureBox1;
        private Button btnIngresar;
        private TextBox txtuser;
        private TextBox txtpass;
        private Label label1;
        private Button button2;
        private Button btnRegistrarse;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}
