namespace Proyecto_de_catedra
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            pictureBox2 = new PictureBox();
            btnCerrar = new Button();
            lblsaludo = new Label();
            pictureBox1 = new PictureBox();
            pbagregar = new PictureBox();
            pictureBox8 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            pictureBox9 = new PictureBox();
            label4 = new Label();
            pictureBox10 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbagregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(698, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
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
            btnCerrar.Location = new Point(608, 28);
            btnCerrar.Margin = new Padding(0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.RightToLeft = RightToLeft.No;
            btnCerrar.Size = new Size(126, 29);
            btnCerrar.TabIndex = 21;
            btnCerrar.Text = "Cerrar sesión";
            btnCerrar.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += button2_Click;
            // 
            // lblsaludo
            // 
            lblsaludo.AutoSize = true;
            lblsaludo.BackColor = Color.White;
            lblsaludo.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsaludo.Location = new Point(101, 38);
            lblsaludo.Name = "lblsaludo";
            lblsaludo.Size = new Size(0, 18);
            lblsaludo.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(33, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pbagregar
            // 
            pbagregar.BackColor = Color.White;
            pbagregar.Cursor = Cursors.Hand;
            pbagregar.Image = (Image)resources.GetObject("pbagregar.Image");
            pbagregar.Location = new Point(48, 92);
            pbagregar.Name = "pbagregar";
            pbagregar.Size = new Size(236, 354);
            pbagregar.SizeMode = PictureBoxSizeMode.Zoom;
            pbagregar.TabIndex = 25;
            pbagregar.TabStop = false;
            pbagregar.Click += pictureBox4_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.White;
            pictureBox8.Cursor = Cursors.Hand;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(294, 92);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(205, 189);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 34;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(105, 120, 147);
            label2.Location = new Point(93, 400);
            label2.Name = "label2";
            label2.Size = new Size(140, 18);
            label2.TabIndex = 35;
            label2.Text = "Agregar contacto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(105, 120, 147);
            label1.Location = new Point(313, 267);
            label1.Name = "label1";
            label1.Size = new Size(167, 18);
            label1.TabIndex = 36;
            label1.Text = "Ver lista de contactos";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(294, 287);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(205, 159);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 37;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(105, 120, 147);
            label3.Location = new Point(341, 436);
            label3.Name = "label3";
            label3.Size = new Size(105, 18);
            label3.TabIndex = 38;
            label3.Text = "Clasificación";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.White;
            pictureBox9.Cursor = Cursors.Hand;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(511, 287);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(205, 159);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 39;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(105, 120, 147);
            label4.Location = new Point(560, 436);
            label4.Name = "label4";
            label4.Size = new Size(114, 18);
            label4.TabIndex = 40;
            label4.Text = "Configuración";
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.White;
            pictureBox10.Cursor = Cursors.Hand;
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(511, 92);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(205, 189);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 41;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(105, 120, 147);
            label5.Location = new Point(543, 267);
            label5.Name = "label5";
            label5.Size = new Size(145, 18);
            label5.TabIndex = 42;
            label5.Text = "Realizar busqueda";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(768, 508);
            Controls.Add(label5);
            Controls.Add(pictureBox10);
            Controls.Add(label4);
            Controls.Add(pictureBox9);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox1);
            Controls.Add(lblsaludo);
            Controls.Add(pictureBox2);
            Controls.Add(btnCerrar);
            Controls.Add(pbagregar);
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbagregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Button btnCerrar;
        private Label lblsaludo;
        private PictureBox pictureBox1;
        private PictureBox pbagregar;
        private PictureBox pictureBox8;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox4;
        private Label label3;
        private PictureBox pictureBox9;
        private Label label4;
        private PictureBox pictureBox10;
        private Label label5;
    }
}