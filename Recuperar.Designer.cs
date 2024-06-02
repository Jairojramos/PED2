namespace Proyecto_de_catedra
{
    partial class Recuperar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recuperar));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btncambiar = new Button();
            txtcorreo = new TextBox();
            btnRegistrarse = new Button();
            pictureBox3 = new PictureBox();
            txtcontra = new TextBox();
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
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label1.Location = new Point(493, 461);
            label1.Name = "label1";
            label1.Size = new Size(142, 16);
            label1.TabIndex = 14;
            label1.Text = "¿Ya tienes una cuenta?";
            // 
            // btncambiar
            // 
            btncambiar.BackColor = Color.FromArgb(5, 92, 231);
            btncambiar.Cursor = Cursors.Hand;
            btncambiar.FlatAppearance.BorderColor = Color.FromArgb(5, 92, 231);
            btncambiar.FlatAppearance.BorderSize = 0;
            btncambiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 92, 231);
            btncambiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 92, 231);
            btncambiar.FlatStyle = FlatStyle.Flat;
            btncambiar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncambiar.ForeColor = Color.White;
            btncambiar.Location = new Point(486, 418);
            btncambiar.Margin = new Padding(0);
            btncambiar.Name = "btncambiar";
            btncambiar.Size = new Size(206, 28);
            btncambiar.TabIndex = 10;
            btncambiar.Text = "Cambiar contraseña";
            btncambiar.UseVisualStyleBackColor = false;
            btncambiar.Click += btncambiar_Click;
            // 
            // txtcorreo
            // 
            txtcorreo.BackColor = Color.FromArgb(76, 147, 237);
            txtcorreo.BorderStyle = BorderStyle.None;
            txtcorreo.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcorreo.ForeColor = Color.White;
            txtcorreo.Location = new Point(493, 242);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(201, 19);
            txtcorreo.TabIndex = 11;
            txtcorreo.Text = "Correo";
            txtcorreo.TextChanged += txtcorreo_TextChanged;
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
            btnRegistrarse.Location = new Point(626, 452);
            btnRegistrarse.Margin = new Padding(0);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.RightToLeft = RightToLeft.No;
            btnRegistrarse.Size = new Size(93, 32);
            btnRegistrarse.TabIndex = 16;
            btnRegistrarse.Text = "Inicia sesión";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Control;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(241, 41);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(696, 477);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // txtcontra
            // 
            txtcontra.BackColor = Color.FromArgb(76, 147, 237);
            txtcontra.BorderStyle = BorderStyle.None;
            txtcontra.Enabled = false;
            txtcontra.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcontra.ForeColor = Color.White;
            txtcontra.Location = new Point(493, 288);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(201, 19);
            txtcontra.TabIndex = 18;
            txtcontra.Text = "Nueva contraseña";
            txtcontra.TextChanged += txtcontra_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(76, 147, 237);
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(656, 283);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // Recuperar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 547);
            Controls.Add(pictureBox2);
            Controls.Add(txtcontra);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btncambiar);
            Controls.Add(txtcorreo);
            Controls.Add(btnRegistrarse);
            Controls.Add(pictureBox3);
            Name = "Recuperar";
            Text = "Recuperar";
            Load += Recuperar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Button btncambiar;
        private TextBox txtcorreo;
        private Button btnRegistrarse;
        private PictureBox pictureBox3;
        private TextBox txtcontra;
        private PictureBox pictureBox2;
    }
}