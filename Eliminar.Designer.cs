namespace WinFormsFinalProyect
{
    partial class Eliminar
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Contenedor_Peliculas = new FlowLayoutPanel();
            gridB = new DataGridView();
            Pnl_Info = new Panel();
            panel3 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            textBoxDescripcion_E = new TextBox();
            label7 = new Label();
            textBoxStock_E = new TextBox();
            textBoxPrecio_E = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            textBoxTitulo_E = new TextBox();
            panel4 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel5 = new Panel();
            button2 = new Button();
            label4 = new Label();
            Btn_Cancel = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            Btn_Eliminar = new Button();
            Btn_Close_Page = new PictureBox();
            PnlAddData = new Panel();
            PnlAddPage = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            Pic_photo = new PictureBox();
            TextBoxID_Eliminar = new TextBox();
            panel2 = new Panel();
            Btn_Buscar = new Button();
            PnlAddTop = new Panel();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            timer2 = new System.Windows.Forms.Timer(components);
            Contenedor_Peliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridB).BeginInit();
            Pnl_Info.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Close_Page).BeginInit();
            PnlAddData.SuspendLayout();
            PnlAddPage.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_photo).BeginInit();
            PnlAddTop.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Contenedor_Peliculas
            // 
            Contenedor_Peliculas.BackColor = SystemColors.Control;
            Contenedor_Peliculas.Controls.Add(gridB);
            Contenedor_Peliculas.Location = new Point(12, 69);
            Contenedor_Peliculas.Name = "Contenedor_Peliculas";
            Contenedor_Peliculas.Size = new Size(496, 526);
            Contenedor_Peliculas.TabIndex = 6;
            Contenedor_Peliculas.Paint += Contenedor_Peliculas_Paint;
            // 
            // gridB
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            gridB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridB.BackgroundColor = Color.White;
            gridB.BorderStyle = BorderStyle.None;
            gridB.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Firebrick;
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridB.DefaultCellStyle = dataGridViewCellStyle3;
            gridB.Location = new Point(3, 3);
            gridB.Name = "gridB";
            gridB.RowHeadersVisible = false;
            gridB.RowHeadersWidth = 51;
            gridB.RowTemplate.Height = 29;
            gridB.Size = new Size(496, 518);
            gridB.TabIndex = 0;
            gridB.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Pnl_Info
            // 
            Pnl_Info.AutoScroll = true;
            Pnl_Info.BackColor = Color.DarkRed;
            Pnl_Info.Controls.Add(panel3);
            Pnl_Info.Controls.Add(panel5);
            Pnl_Info.Dock = DockStyle.Right;
            Pnl_Info.Location = new Point(514, 65);
            Pnl_Info.Name = "Pnl_Info";
            Pnl_Info.Size = new Size(315, 530);
            Pnl_Info.TabIndex = 9;
            Pnl_Info.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 52);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10, 5, 10, 5);
            panel3.Size = new Size(315, 478);
            panel3.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoScroll = true;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel3.Controls.Add(textBoxDescripcion_E, 0, 7);
            tableLayoutPanel3.Controls.Add(label7, 0, 6);
            tableLayoutPanel3.Controls.Add(textBoxStock_E, 0, 5);
            tableLayoutPanel3.Controls.Add(textBoxPrecio_E, 0, 3);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(pictureBox1, 2, 0);
            tableLayoutPanel3.Controls.Add(textBoxTitulo_E, 0, 1);
            tableLayoutPanel3.Controls.Add(panel4, 2, 3);
            tableLayoutPanel3.Controls.Add(label5, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(10, 5);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(5);
            tableLayoutPanel3.RowCount = 11;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.Size = new Size(295, 468);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // textBoxDescripcion_E
            // 
            textBoxDescripcion_E.BorderStyle = BorderStyle.None;
            tableLayoutPanel3.SetColumnSpan(textBoxDescripcion_E, 3);
            textBoxDescripcion_E.Dock = DockStyle.Fill;
            textBoxDescripcion_E.Location = new Point(10, 215);
            textBoxDescripcion_E.Margin = new Padding(5, 0, 5, 0);
            textBoxDescripcion_E.Multiline = true;
            textBoxDescripcion_E.Name = "textBoxDescripcion_E";
            textBoxDescripcion_E.ReadOnly = true;
            tableLayoutPanel3.SetRowSpan(textBoxDescripcion_E, 4);
            textBoxDescripcion_E.Size = new Size(275, 248);
            textBoxDescripcion_E.TabIndex = 19;
            textBoxDescripcion_E.TextChanged += textBox4_TextChanged;
            // 
            // label7
            // 
            tableLayoutPanel3.SetColumnSpan(label7, 2);
            label7.Font = new Font("Georgia", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(8, 185);
            label7.Name = "label7";
            label7.Size = new Size(101, 30);
            label7.TabIndex = 14;
            label7.Text = "Descripción";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            label7.Click += label7_Click;
            // 
            // textBoxStock_E
            // 
            textBoxStock_E.BorderStyle = BorderStyle.None;
            tableLayoutPanel3.SetColumnSpan(textBoxStock_E, 3);
            textBoxStock_E.Dock = DockStyle.Fill;
            textBoxStock_E.Location = new Point(8, 158);
            textBoxStock_E.Multiline = true;
            textBoxStock_E.Name = "textBoxStock_E";
            textBoxStock_E.ReadOnly = true;
            textBoxStock_E.Size = new Size(279, 24);
            textBoxStock_E.TabIndex = 14;
            // 
            // textBoxPrecio_E
            // 
            textBoxPrecio_E.BorderStyle = BorderStyle.None;
            tableLayoutPanel3.SetColumnSpan(textBoxPrecio_E, 2);
            textBoxPrecio_E.Dock = DockStyle.Fill;
            textBoxPrecio_E.Location = new Point(8, 98);
            textBoxPrecio_E.Multiline = true;
            textBoxPrecio_E.Name = "textBoxPrecio_E";
            textBoxPrecio_E.ReadOnly = true;
            textBoxPrecio_E.Size = new Size(183, 24);
            textBoxPrecio_E.TabIndex = 12;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(8, 5);
            label3.Name = "label3";
            label3.Size = new Size(88, 30);
            label3.TabIndex = 8;
            label3.Text = "Título";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.lupa21;
            pictureBox1.Location = new Point(221, 8);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanel3.SetRowSpan(pictureBox1, 4);
            pictureBox1.Size = new Size(66, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // textBoxTitulo_E
            // 
            textBoxTitulo_E.BorderStyle = BorderStyle.None;
            tableLayoutPanel3.SetColumnSpan(textBoxTitulo_E, 2);
            textBoxTitulo_E.Dock = DockStyle.Fill;
            textBoxTitulo_E.Location = new Point(8, 38);
            textBoxTitulo_E.Multiline = true;
            textBoxTitulo_E.Name = "textBoxTitulo_E";
            textBoxTitulo_E.ReadOnly = true;
            textBoxTitulo_E.Size = new Size(183, 24);
            textBoxTitulo_E.TabIndex = 9;
            textBoxTitulo_E.TextChanged += textBox1_TextChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(5, 125);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(94, 30);
            panel4.TabIndex = 10;
            // 
            // label6
            // 
            label6.Font = new Font("Georgia", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 30);
            label6.TabIndex = 13;
            label6.Text = "Existencias";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(8, 65);
            label5.Name = "label5";
            label5.Size = new Size(65, 30);
            label5.TabIndex = 11;
            label5.Text = "Precio";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(Btn_Cancel);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(315, 52);
            panel5.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.Dock = DockStyle.Left;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(55, 0);
            button2.Name = "button2";
            button2.Size = new Size(78, 52);
            button2.TabIndex = 5;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(139, 14);
            label4.Name = "label4";
            label4.Size = new Size(149, 26);
            label4.TabIndex = 4;
            label4.Text = "Producto";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.BackColor = Color.DarkRed;
            Btn_Cancel.Dock = DockStyle.Left;
            Btn_Cancel.FlatAppearance.BorderSize = 0;
            Btn_Cancel.FlatStyle = FlatStyle.Flat;
            Btn_Cancel.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Cancel.ForeColor = SystemColors.Control;
            Btn_Cancel.Location = new Point(0, 0);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(55, 52);
            Btn_Cancel.TabIndex = 2;
            Btn_Cancel.Text = "x";
            Btn_Cancel.UseVisualStyleBackColor = false;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.Controls.Add(Btn_Eliminar, 0, 0);
            tableLayoutPanel1.Controls.Add(Btn_Close_Page, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(824, 60);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // Btn_Eliminar
            // 
            Btn_Eliminar.BackColor = Color.DarkRed;
            Btn_Eliminar.Dock = DockStyle.Left;
            Btn_Eliminar.FlatAppearance.BorderSize = 0;
            Btn_Eliminar.FlatStyle = FlatStyle.Flat;
            Btn_Eliminar.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Eliminar.ForeColor = SystemColors.Control;
            Btn_Eliminar.Location = new Point(5, 5);
            Btn_Eliminar.Name = "Btn_Eliminar";
            Btn_Eliminar.Size = new Size(170, 50);
            Btn_Eliminar.TabIndex = 21;
            Btn_Eliminar.Text = "Eliminar";
            Btn_Eliminar.UseVisualStyleBackColor = false;
            Btn_Eliminar.Click += Btn_Eliminar_Click;
            // 
            // Btn_Close_Page
            // 
            Btn_Close_Page.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Close_Page.BackColor = Color.Transparent;
            Btn_Close_Page.Image = Properties.Resources.cerrar1;
            Btn_Close_Page.Location = new Point(774, 5);
            Btn_Close_Page.Name = "Btn_Close_Page";
            Btn_Close_Page.Size = new Size(45, 43);
            Btn_Close_Page.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Close_Page.TabIndex = 19;
            Btn_Close_Page.TabStop = false;
            Btn_Close_Page.Click += Btn_Close_Page_Click;
            // 
            // PnlAddData
            // 
            PnlAddData.BackColor = Color.DarkRed;
            PnlAddData.Controls.Add(PnlAddPage);
            PnlAddData.Controls.Add(PnlAddTop);
            PnlAddData.Location = new Point(3, 3);
            PnlAddData.Name = "PnlAddData";
            PnlAddData.Size = new Size(315, 188);
            PnlAddData.TabIndex = 8;
            PnlAddData.Visible = false;
            // 
            // PnlAddPage
            // 
            PnlAddPage.AutoScroll = true;
            PnlAddPage.Controls.Add(tableLayoutPanel2);
            PnlAddPage.Dock = DockStyle.Fill;
            PnlAddPage.Location = new Point(0, 52);
            PnlAddPage.Margin = new Padding(0);
            PnlAddPage.Name = "PnlAddPage";
            PnlAddPage.Padding = new Padding(10, 5, 10, 5);
            PnlAddPage.Size = new Size(315, 136);
            PnlAddPage.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(Pic_photo, 2, 0);
            tableLayoutPanel2.Controls.Add(TextBoxID_Eliminar, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 2, 3);
            tableLayoutPanel2.Controls.Add(Btn_Buscar, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 5);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5);
            tableLayoutPanel2.RowCount = 17;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.Size = new Size(295, 126);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(8, 5);
            label2.Name = "label2";
            label2.Size = new Size(88, 30);
            label2.TabIndex = 8;
            label2.Text = "ID";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Pic_photo
            // 
            Pic_photo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pic_photo.BackColor = Color.Transparent;
            Pic_photo.Image = Properties.Resources.lupa2;
            Pic_photo.Location = new Point(215, 8);
            Pic_photo.Name = "Pic_photo";
            tableLayoutPanel2.SetRowSpan(Pic_photo, 3);
            Pic_photo.Size = new Size(72, 84);
            Pic_photo.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_photo.TabIndex = 7;
            Pic_photo.TabStop = false;
            // 
            // TextBoxID_Eliminar
            // 
            TextBoxID_Eliminar.BorderStyle = BorderStyle.None;
            tableLayoutPanel2.SetColumnSpan(TextBoxID_Eliminar, 2);
            TextBoxID_Eliminar.Dock = DockStyle.Fill;
            TextBoxID_Eliminar.Location = new Point(8, 38);
            TextBoxID_Eliminar.Multiline = true;
            TextBoxID_Eliminar.Name = "TextBoxID_Eliminar";
            TextBoxID_Eliminar.Size = new Size(183, 24);
            TextBoxID_Eliminar.TabIndex = 9;
            TextBoxID_Eliminar.TextChanged += TextBoxID_TextChanged;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(194, 95);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(96, 30);
            panel2.TabIndex = 10;
            // 
            // Btn_Buscar
            // 
            Btn_Buscar.BackColor = Color.MistyRose;
            Btn_Buscar.Dock = DockStyle.Fill;
            Btn_Buscar.FlatAppearance.BorderSize = 0;
            Btn_Buscar.FlatStyle = FlatStyle.Flat;
            Btn_Buscar.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Buscar.ForeColor = SystemColors.ActiveCaptionText;
            Btn_Buscar.Location = new Point(8, 68);
            Btn_Buscar.Name = "Btn_Buscar";
            Btn_Buscar.Size = new Size(88, 24);
            Btn_Buscar.TabIndex = 21;
            Btn_Buscar.Text = "Buscar";
            Btn_Buscar.UseVisualStyleBackColor = false;
            Btn_Buscar.Click += Btn_Buscar_Click;
            // 
            // PnlAddTop
            // 
            PnlAddTop.Controls.Add(label1);
            PnlAddTop.Dock = DockStyle.Top;
            PnlAddTop.Location = new Point(0, 0);
            PnlAddTop.Name = "PnlAddTop";
            PnlAddTop.Size = new Size(315, 52);
            PnlAddTop.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(157, 26);
            label1.TabIndex = 4;
            label1.Text = "Buscar ID";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += Timer1_Tick;
            // 
            // panel1
            // 
            panel1.Controls.Add(PnlAddData);
            panel1.Location = new Point(514, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 196);
            panel1.TabIndex = 8;
            // 
            // Eliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 600);
            Controls.Add(Pnl_Info);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Contenedor_Peliculas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Eliminar";
            Padding = new Padding(5, 5, 0, 5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar";
            Contenedor_Peliculas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridB).EndInit();
            Pnl_Info.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Btn_Close_Page).EndInit();
            PnlAddData.ResumeLayout(false);
            PnlAddPage.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_photo).EndInit();
            PnlAddTop.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel Contenedor_Peliculas;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox Btn_Close_Page;
        private Panel PnlAddData;
        private Panel PnlAddPage;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private PictureBox Pic_photo;
        private TextBox TextBoxID_Eliminar;
        private Panel panel2;
        private Panel PnlAddTop;
        private Label label1;
        private Button Btn_Buscar;
        private Button Btn_Eliminar;
        private Panel Pnl_Info;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox textBoxTitulo_E;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Button Btn_Cancel;
        private TextBox textBoxStock_E;
        private TextBox textBoxPrecio_E;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxDescripcion_E;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private System.Windows.Forms.Timer timer2;
        private DataGridView gridB;
    }
}