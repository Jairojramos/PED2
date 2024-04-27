namespace Proyecto_de_catedra
{
    partial class Busqueda
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busqueda));
            btnbuscar = new Button();
            organizacion = new DataGridViewTextBoxColumn();
            grupo = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            fechanacimiento = new DataGridViewTextBoxColumn();
            pais = new DataGridViewTextBoxColumn();
            cuidad = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            dgv = new DataGridView();
            direccion = new DataGridViewTextBoxColumn();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            cmbpais = new ComboBox();
            pictureBox3 = new PictureBox();
            comboBox1 = new ComboBox();
            pictureBox5 = new PictureBox();
            label11 = new Label();
            label10 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            pictureBox1 = new PictureBox();
            comboBox3 = new ComboBox();
            pictureBox6 = new PictureBox();
            treeView1 = new TreeView();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.FromArgb(57, 126, 246);
            btnbuscar.Cursor = Cursors.Hand;
            btnbuscar.FlatAppearance.BorderColor = Color.FromArgb(57, 126, 246);
            btnbuscar.FlatAppearance.BorderSize = 0;
            btnbuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(57, 126, 246);
            btnbuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(57, 126, 246);
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbuscar.ForeColor = Color.White;
            btnbuscar.Location = new Point(613, 597);
            btnbuscar.Margin = new Padding(0);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(101, 30);
            btnbuscar.TabIndex = 42;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = false;
            // 
            // organizacion
            // 
            organizacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            organizacion.HeaderText = "Organización";
            organizacion.MaxInputLength = 200;
            organizacion.Name = "organizacion";
            organizacion.Width = 119;
            // 
            // grupo
            // 
            grupo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grupo.HeaderText = "Grupo";
            grupo.MaxInputLength = 200;
            grupo.Name = "grupo";
            grupo.Width = 71;
            // 
            // telefono
            // 
            telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            telefono.HeaderText = "Teléfono";
            telefono.MaxInputLength = 200;
            telefono.Name = "telefono";
            telefono.Width = 84;
            // 
            // fechanacimiento
            // 
            fechanacimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            fechanacimiento.HeaderText = "Fecha de nacimiento";
            fechanacimiento.MaxInputLength = 200;
            fechanacimiento.Name = "fechanacimiento";
            fechanacimiento.Width = 152;
            // 
            // pais
            // 
            pais.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            pais.HeaderText = "País";
            pais.MaxInputLength = 200;
            pais.Name = "pais";
            pais.Width = 55;
            // 
            // cuidad
            // 
            cuidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cuidad.HeaderText = "Cuidad";
            cuidad.MaxInputLength = 200;
            cuidad.Name = "cuidad";
            cuidad.Width = 79;
            // 
            // correo
            // 
            correo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            correo.HeaderText = "Correo";
            correo.MaxInputLength = 200;
            correo.Name = "correo";
            correo.Width = 74;
            // 
            // apellido
            // 
            apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            apellido.HeaderText = "Apellido";
            apellido.MaxInputLength = 200;
            apellido.Name = "apellido";
            apellido.Width = 86;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nombre.HeaderText = "Nombre";
            nombre.MaxInputLength = 200;
            nombre.Name = "nombre";
            nombre.Width = 82;
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
            dgv.Location = new Point(27, 187);
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
            dgv.Size = new Size(687, 386);
            dgv.TabIndex = 41;
            // 
            // direccion
            // 
            direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            direccion.HeaderText = "Dirección";
            direccion.MaxInputLength = 200;
            direccion.Name = "direccion";
            direccion.Width = 92;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(16, 21);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 38;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 39);
            label1.Name = "label1";
            label1.Size = new Size(378, 28);
            label1.TabIndex = 39;
            label1.Text = "Realizar busqueda de contacto";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(566, 597);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            // 
            // cmbpais
            // 
            cmbpais.BackColor = Color.White;
            cmbpais.FlatStyle = FlatStyle.Flat;
            cmbpais.Font = new Font("Century Gothic", 9.75F);
            cmbpais.ForeColor = Color.Black;
            cmbpais.FormattingEnabled = true;
            cmbpais.Items.AddRange(new object[] { "Afganistán", "Albania", "Alemania", "Andorra", "Angola", "Antigua y Barbuda", "Arabia Saudita", "Argelia", "Argentina", "Armenia", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bangladés", "Barbados", "Baréin", "Bélgica", "Belice", "Benín", "Bielorrusia", "Birmania", "Bolivia", "Bosnia y Herzegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Catar", "Chad", "Chile", "China", "Chipre", "Ciudad del Vaticano", "Colombia", "Comoras", "Corea del Norte", "Corea del Sur", "Costa de Marfil", "Costa Rica", "Croacia", "Cuba", "Dinamarca", "Dominica", "Ecuador", "Egipto", "El Salvador", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Etiopía", "Filipinas", "Finlandia", "Fiyi", "Francia", "Gabón", "Gambia", "Georgia", "Ghana", "Granada", "Grecia", "Guatemala", "Guyana", "Guinea", "Guinea ecuatorial", "Guinea-Bisáu", "Haití", "Honduras", "Hungría", "India", "Indonesia", "Irak", "Irán", "Irlanda", "Islandia", "Islas Marshall", "Islas Salomón", "Israel", "Italia", "Jamaica", "Japón", "Jordania", "Kazajistán", "Kenia", "Kirguistán", "Kiribati", "Kuwait", "Laos", "Lesoto", "Letonia", "Líbano", "Liberia", "Libia", "Liechtenstein", "Lituania", "Luxemburgo", "Macedonia del Norte", "Madagascar", "Malasia", "Malaui", "Maldivas", "Malí", "Malta", "Marruecos", "Mauricio", "Mauritania", "México", "Micronesia", "Moldavia", "Mónaco", "Mongolia", "Montenegro", "Mozambique", "Namibia", "Nauru", "Nepal", "Nicaragua", "Níger", "Nigeria", "Noruega", "Nueva Zelanda", "Omán", "Países Bajos", "Pakistán", "Palaos", "Panamá", "Papúa Nueva Guinea", "Paraguay", "Perú", "Polonia", "Portugal", "Reino Unido", "República Centroafricana", "República Checa", "República del Congo", "República Democrática del Congo", "República Dominicana", "Ruanda", "Rumania", "Rusia", "Samoa", "San Cristóbal y Nieves", "San Marino", "San Vicente y las Granadinas", "Santa Lucía", "Santo Tomé y Príncipe", "Senegal", "Serbia", "Seychelles", "Sierra Leona", "Singapur", "Siria", "Somalia", "Sri Lanka", "Suazilandia", "Sudáfrica", "Sudán", "Sudán del Sur", "Suecia", "Suiza", "Surinam", "Tailandia", "Tanzania", "Tayikistán", "Timor Oriental", "Togo", "Tonga", "Trinidad y Tobago", "Túnez", "Turkmenistán", "Turquía", "Tuvalu", "Ucrania", "Uganda", "Uruguay", "Uzbekistán", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Yibuti", "Zimbabue" });
            cmbpais.Location = new Point(382, 131);
            cmbpais.Name = "cmbpais";
            cmbpais.Size = new Size(86, 25);
            cmbpais.TabIndex = 56;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(342, 120);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(164, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 57;
            pictureBox3.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Century Gothic", 9.75F);
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Afganistán", "Albania", "Alemania", "Andorra", "Angola", "Antigua y Barbuda", "Arabia Saudita", "Argelia", "Argentina", "Armenia", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bangladés", "Barbados", "Baréin", "Bélgica", "Belice", "Benín", "Bielorrusia", "Birmania", "Bolivia", "Bosnia y Herzegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Catar", "Chad", "Chile", "China", "Chipre", "Ciudad del Vaticano", "Colombia", "Comoras", "Corea del Norte", "Corea del Sur", "Costa de Marfil", "Costa Rica", "Croacia", "Cuba", "Dinamarca", "Dominica", "Ecuador", "Egipto", "El Salvador", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Etiopía", "Filipinas", "Finlandia", "Fiyi", "Francia", "Gabón", "Gambia", "Georgia", "Ghana", "Granada", "Grecia", "Guatemala", "Guyana", "Guinea", "Guinea ecuatorial", "Guinea-Bisáu", "Haití", "Honduras", "Hungría", "India", "Indonesia", "Irak", "Irán", "Irlanda", "Islandia", "Islas Marshall", "Islas Salomón", "Israel", "Italia", "Jamaica", "Japón", "Jordania", "Kazajistán", "Kenia", "Kirguistán", "Kiribati", "Kuwait", "Laos", "Lesoto", "Letonia", "Líbano", "Liberia", "Libia", "Liechtenstein", "Lituania", "Luxemburgo", "Macedonia del Norte", "Madagascar", "Malasia", "Malaui", "Maldivas", "Malí", "Malta", "Marruecos", "Mauricio", "Mauritania", "México", "Micronesia", "Moldavia", "Mónaco", "Mongolia", "Montenegro", "Mozambique", "Namibia", "Nauru", "Nepal", "Nicaragua", "Níger", "Nigeria", "Noruega", "Nueva Zelanda", "Omán", "Países Bajos", "Pakistán", "Palaos", "Panamá", "Papúa Nueva Guinea", "Paraguay", "Perú", "Polonia", "Portugal", "Reino Unido", "República Centroafricana", "República Checa", "República del Congo", "República Democrática del Congo", "República Dominicana", "Ruanda", "Rumania", "Rusia", "Samoa", "San Cristóbal y Nieves", "San Marino", "San Vicente y las Granadinas", "Santa Lucía", "Santo Tomé y Príncipe", "Senegal", "Serbia", "Seychelles", "Sierra Leona", "Singapur", "Siria", "Somalia", "Sri Lanka", "Suazilandia", "Sudáfrica", "Sudán", "Sudán del Sur", "Suecia", "Suiza", "Surinam", "Tailandia", "Tanzania", "Tayikistán", "Timor Oriental", "Togo", "Tonga", "Trinidad y Tobago", "Túnez", "Turkmenistán", "Turquía", "Tuvalu", "Ucrania", "Uganda", "Uruguay", "Uzbekistán", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Yibuti", "Zimbabue" });
            comboBox1.Location = new Point(516, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(86, 25);
            comboBox1.TabIndex = 58;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(476, 120);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(164, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 59;
            pictureBox5.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(105, 120, 147);
            label11.Location = new Point(506, 101);
            label11.Name = "label11";
            label11.Size = new Size(96, 16);
            label11.TabIndex = 61;
            label11.Text = "Organización";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(105, 120, 147);
            label10.Location = new Point(396, 101);
            label10.Name = "label10";
            label10.Size = new Size(48, 16);
            label10.TabIndex = 60;
            label10.Text = "Grupo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(105, 120, 147);
            label2.Location = new Point(270, 101);
            label2.Name = "label2";
            label2.Size = new Size(32, 16);
            label2.TabIndex = 67;
            label2.Text = "País";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(105, 120, 147);
            label3.Location = new Point(126, 101);
            label3.Name = "label3";
            label3.Size = new Size(56, 16);
            label3.TabIndex = 66;
            label3.Text = "Cuidad";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.White;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Century Gothic", 9.75F);
            comboBox2.ForeColor = Color.Black;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Afganistán", "Albania", "Alemania", "Andorra", "Angola", "Antigua y Barbuda", "Arabia Saudita", "Argelia", "Argentina", "Armenia", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bangladés", "Barbados", "Baréin", "Bélgica", "Belice", "Benín", "Bielorrusia", "Birmania", "Bolivia", "Bosnia y Herzegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Catar", "Chad", "Chile", "China", "Chipre", "Ciudad del Vaticano", "Colombia", "Comoras", "Corea del Norte", "Corea del Sur", "Costa de Marfil", "Costa Rica", "Croacia", "Cuba", "Dinamarca", "Dominica", "Ecuador", "Egipto", "El Salvador", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Etiopía", "Filipinas", "Finlandia", "Fiyi", "Francia", "Gabón", "Gambia", "Georgia", "Ghana", "Granada", "Grecia", "Guatemala", "Guyana", "Guinea", "Guinea ecuatorial", "Guinea-Bisáu", "Haití", "Honduras", "Hungría", "India", "Indonesia", "Irak", "Irán", "Irlanda", "Islandia", "Islas Marshall", "Islas Salomón", "Israel", "Italia", "Jamaica", "Japón", "Jordania", "Kazajistán", "Kenia", "Kirguistán", "Kiribati", "Kuwait", "Laos", "Lesoto", "Letonia", "Líbano", "Liberia", "Libia", "Liechtenstein", "Lituania", "Luxemburgo", "Macedonia del Norte", "Madagascar", "Malasia", "Malaui", "Maldivas", "Malí", "Malta", "Marruecos", "Mauricio", "Mauritania", "México", "Micronesia", "Moldavia", "Mónaco", "Mongolia", "Montenegro", "Mozambique", "Namibia", "Nauru", "Nepal", "Nicaragua", "Níger", "Nigeria", "Noruega", "Nueva Zelanda", "Omán", "Países Bajos", "Pakistán", "Palaos", "Panamá", "Papúa Nueva Guinea", "Paraguay", "Perú", "Polonia", "Portugal", "Reino Unido", "República Centroafricana", "República Checa", "República del Congo", "República Democrática del Congo", "República Dominicana", "Ruanda", "Rumania", "Rusia", "Samoa", "San Cristóbal y Nieves", "San Marino", "San Vicente y las Granadinas", "Santa Lucía", "Santo Tomé y Príncipe", "Senegal", "Serbia", "Seychelles", "Sierra Leona", "Singapur", "Siria", "Somalia", "Sri Lanka", "Suazilandia", "Sudáfrica", "Sudán", "Sudán del Sur", "Suecia", "Suiza", "Surinam", "Tailandia", "Tanzania", "Tayikistán", "Timor Oriental", "Togo", "Tonga", "Trinidad y Tobago", "Túnez", "Turkmenistán", "Turquía", "Tuvalu", "Ucrania", "Uganda", "Uruguay", "Uzbekistán", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Yibuti", "Zimbabue" });
            comboBox2.Location = new Point(250, 131);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(86, 25);
            comboBox2.TabIndex = 64;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(210, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.White;
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.Font = new Font("Century Gothic", 9.75F);
            comboBox3.ForeColor = Color.Black;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Afganistán", "Albania", "Alemania", "Andorra", "Angola", "Antigua y Barbuda", "Arabia Saudita", "Argelia", "Argentina", "Armenia", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bangladés", "Barbados", "Baréin", "Bélgica", "Belice", "Benín", "Bielorrusia", "Birmania", "Bolivia", "Bosnia y Herzegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Catar", "Chad", "Chile", "China", "Chipre", "Ciudad del Vaticano", "Colombia", "Comoras", "Corea del Norte", "Corea del Sur", "Costa de Marfil", "Costa Rica", "Croacia", "Cuba", "Dinamarca", "Dominica", "Ecuador", "Egipto", "El Salvador", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Etiopía", "Filipinas", "Finlandia", "Fiyi", "Francia", "Gabón", "Gambia", "Georgia", "Ghana", "Granada", "Grecia", "Guatemala", "Guyana", "Guinea", "Guinea ecuatorial", "Guinea-Bisáu", "Haití", "Honduras", "Hungría", "India", "Indonesia", "Irak", "Irán", "Irlanda", "Islandia", "Islas Marshall", "Islas Salomón", "Israel", "Italia", "Jamaica", "Japón", "Jordania", "Kazajistán", "Kenia", "Kirguistán", "Kiribati", "Kuwait", "Laos", "Lesoto", "Letonia", "Líbano", "Liberia", "Libia", "Liechtenstein", "Lituania", "Luxemburgo", "Macedonia del Norte", "Madagascar", "Malasia", "Malaui", "Maldivas", "Malí", "Malta", "Marruecos", "Mauricio", "Mauritania", "México", "Micronesia", "Moldavia", "Mónaco", "Mongolia", "Montenegro", "Mozambique", "Namibia", "Nauru", "Nepal", "Nicaragua", "Níger", "Nigeria", "Noruega", "Nueva Zelanda", "Omán", "Países Bajos", "Pakistán", "Palaos", "Panamá", "Papúa Nueva Guinea", "Paraguay", "Perú", "Polonia", "Portugal", "Reino Unido", "República Centroafricana", "República Checa", "República del Congo", "República Democrática del Congo", "República Dominicana", "Ruanda", "Rumania", "Rusia", "Samoa", "San Cristóbal y Nieves", "San Marino", "San Vicente y las Granadinas", "Santa Lucía", "Santo Tomé y Príncipe", "Senegal", "Serbia", "Seychelles", "Sierra Leona", "Singapur", "Siria", "Somalia", "Sri Lanka", "Suazilandia", "Sudáfrica", "Sudán", "Sudán del Sur", "Suecia", "Suiza", "Surinam", "Tailandia", "Tanzania", "Tayikistán", "Timor Oriental", "Togo", "Tonga", "Trinidad y Tobago", "Túnez", "Turkmenistán", "Turquía", "Tuvalu", "Ucrania", "Uganda", "Uruguay", "Uzbekistán", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Yibuti", "Zimbabue" });
            comboBox3.Location = new Point(116, 131);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(86, 25);
            comboBox3.TabIndex = 62;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(76, 120);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(164, 45);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 63;
            pictureBox6.TabStop = false;
            // 
            // treeView1
            // 
            treeView1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            treeView1.ForeColor = Color.DarkGray;
            treeView1.Location = new Point(740, 101);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(379, 472);
            treeView1.TabIndex = 68;
            // 
            // Busqueda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1145, 659);
            Controls.Add(treeView1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox3);
            Controls.Add(pictureBox6);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox5);
            Controls.Add(cmbpais);
            Controls.Add(pictureBox2);
            Controls.Add(btnbuscar);
            Controls.Add(dgv);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Name = "Busqueda";
            Text = "Busqueda";
            Load += Busqueda_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnbuscar;
        private DataGridViewTextBoxColumn organizacion;
        private DataGridViewTextBoxColumn grupo;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn fechanacimiento;
        private DataGridViewTextBoxColumn pais;
        private DataGridViewTextBoxColumn cuidad;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn nombre;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn direccion;
        private PictureBox pictureBox4;
        private Label label1;
        private PictureBox pictureBox2;
        private ComboBox cmbpais;
        private PictureBox pictureBox3;
        private ComboBox comboBox1;
        private PictureBox pictureBox5;
        private Label label11;
        private Label label10;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private PictureBox pictureBox1;
        private ComboBox comboBox3;
        private PictureBox pictureBox6;
        private TreeView treeView1;
    }
}