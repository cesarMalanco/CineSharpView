namespace WinFormsFinalProyect
{
    partial class Frm_Dulceria
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
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonLimpiar = new Button();
            Btn_Modificar = new Button();
            Btn_Buscar = new Button();
            Btn_Eliminar = new Button();
            Btn_Agregar = new Button();
            Btn_Close_Page = new PictureBox();
            PnlAddData = new Panel();
            PnlAddPage = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            TextBoxAbout_Sweet = new TextBox();
            label6 = new Label();
            TextBoxStock_Sweet = new TextBox();
            label5 = new Label();
            TextBoxPrice_Sweet = new TextBox();
            label4 = new Label();
            TextBoxName_Sweet = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Pic_photo = new PictureBox();
            TextBoxID_Sweet = new TextBox();
            panel2 = new Panel();
            PnlAddTop = new Panel();
            button_Ok = new Button();
            Timer1 = new System.Windows.Forms.Timer(components);
            Grid_Dulceria = new DataGridView();
            gridSweets = new DataGridView();
            sweetsBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aboutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Close_Page).BeginInit();
            PnlAddData.SuspendLayout();
            PnlAddPage.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_photo).BeginInit();
            PnlAddTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Dulceria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridSweets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sweetsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.Controls.Add(buttonLimpiar, 4, 0);
            tableLayoutPanel1.Controls.Add(Btn_Modificar, 3, 0);
            tableLayoutPanel1.Controls.Add(Btn_Buscar, 2, 0);
            tableLayoutPanel1.Controls.Add(Btn_Eliminar, 1, 0);
            tableLayoutPanel1.Controls.Add(Btn_Agregar, 0, 0);
            tableLayoutPanel1.Controls.Add(Btn_Close_Page, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(819, 60);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.DarkRed;
            buttonLimpiar.Dock = DockStyle.Fill;
            buttonLimpiar.FlatAppearance.BorderSize = 0;
            buttonLimpiar.FlatStyle = FlatStyle.Flat;
            buttonLimpiar.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLimpiar.ForeColor = SystemColors.Control;
            buttonLimpiar.Location = new Point(365, 5);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(84, 50);
            buttonLimpiar.TabIndex = 8;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // Btn_Modificar
            // 
            Btn_Modificar.BackColor = Color.DarkRed;
            Btn_Modificar.Dock = DockStyle.Fill;
            Btn_Modificar.FlatAppearance.BorderSize = 0;
            Btn_Modificar.FlatStyle = FlatStyle.Flat;
            Btn_Modificar.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Modificar.ForeColor = SystemColors.Control;
            Btn_Modificar.Location = new Point(275, 5);
            Btn_Modificar.Name = "Btn_Modificar";
            Btn_Modificar.Size = new Size(84, 50);
            Btn_Modificar.TabIndex = 6;
            Btn_Modificar.Text = "Modificar";
            Btn_Modificar.UseVisualStyleBackColor = false;
            Btn_Modificar.Click += Btn_Modificar_Click;
            // 
            // Btn_Buscar
            // 
            Btn_Buscar.BackColor = Color.DarkRed;
            Btn_Buscar.Dock = DockStyle.Fill;
            Btn_Buscar.FlatAppearance.BorderSize = 0;
            Btn_Buscar.FlatStyle = FlatStyle.Flat;
            Btn_Buscar.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Buscar.ForeColor = SystemColors.Control;
            Btn_Buscar.Location = new Point(185, 5);
            Btn_Buscar.Name = "Btn_Buscar";
            Btn_Buscar.Size = new Size(84, 50);
            Btn_Buscar.TabIndex = 3;
            Btn_Buscar.Text = "Buscar";
            Btn_Buscar.UseVisualStyleBackColor = false;
            Btn_Buscar.Click += Btn_Buscar_Click;
            // 
            // Btn_Eliminar
            // 
            Btn_Eliminar.BackColor = Color.DarkRed;
            Btn_Eliminar.Dock = DockStyle.Fill;
            Btn_Eliminar.FlatAppearance.BorderSize = 0;
            Btn_Eliminar.FlatStyle = FlatStyle.Flat;
            Btn_Eliminar.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Eliminar.ForeColor = SystemColors.Control;
            Btn_Eliminar.Location = new Point(95, 5);
            Btn_Eliminar.Name = "Btn_Eliminar";
            Btn_Eliminar.Size = new Size(84, 50);
            Btn_Eliminar.TabIndex = 2;
            Btn_Eliminar.Text = "Eliminar";
            Btn_Eliminar.UseVisualStyleBackColor = false;
            Btn_Eliminar.Click += Btn_Eliminar_Click;
            // 
            // Btn_Agregar
            // 
            Btn_Agregar.BackColor = Color.DarkRed;
            Btn_Agregar.Dock = DockStyle.Fill;
            Btn_Agregar.FlatAppearance.BorderSize = 0;
            Btn_Agregar.FlatStyle = FlatStyle.Flat;
            Btn_Agregar.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Agregar.ForeColor = SystemColors.Control;
            Btn_Agregar.Location = new Point(5, 5);
            Btn_Agregar.Name = "Btn_Agregar";
            Btn_Agregar.Size = new Size(84, 50);
            Btn_Agregar.TabIndex = 1;
            Btn_Agregar.Text = "Agregar";
            Btn_Agregar.UseVisualStyleBackColor = false;
            Btn_Agregar.Click += Btn_Agregar_Click;
            // 
            // Btn_Close_Page
            // 
            Btn_Close_Page.BackColor = Color.WhiteSmoke;
            Btn_Close_Page.Dock = DockStyle.Right;
            Btn_Close_Page.Image = Properties.Resources.cerrar2;
            Btn_Close_Page.Location = new Point(772, 5);
            Btn_Close_Page.Name = "Btn_Close_Page";
            Btn_Close_Page.Size = new Size(42, 50);
            Btn_Close_Page.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Close_Page.TabIndex = 7;
            Btn_Close_Page.TabStop = false;
            Btn_Close_Page.Click += Btn_Close_Page_Click;
            // 
            // PnlAddData
            // 
            PnlAddData.BackColor = Color.DarkRed;
            PnlAddData.Controls.Add(PnlAddPage);
            PnlAddData.Controls.Add(PnlAddTop);
            PnlAddData.Dock = DockStyle.Right;
            PnlAddData.Location = new Point(524, 65);
            PnlAddData.Name = "PnlAddData";
            PnlAddData.Size = new Size(300, 530);
            PnlAddData.TabIndex = 1;
            // 
            // PnlAddPage
            // 
            PnlAddPage.AutoScroll = true;
            PnlAddPage.Controls.Add(tableLayoutPanel2);
            PnlAddPage.Location = new Point(0, 52);
            PnlAddPage.Margin = new Padding(0);
            PnlAddPage.Name = "PnlAddPage";
            PnlAddPage.Padding = new Padding(10, 5, 10, 5);
            PnlAddPage.Size = new Size(300, 478);
            PnlAddPage.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel2.Controls.Add(TextBoxAbout_Sweet, 0, 11);
            tableLayoutPanel2.Controls.Add(label6, 0, 10);
            tableLayoutPanel2.Controls.Add(TextBoxStock_Sweet, 0, 9);
            tableLayoutPanel2.Controls.Add(label5, 0, 8);
            tableLayoutPanel2.Controls.Add(TextBoxPrice_Sweet, 0, 7);
            tableLayoutPanel2.Controls.Add(label4, 0, 6);
            tableLayoutPanel2.Controls.Add(TextBoxName_Sweet, 0, 5);
            tableLayoutPanel2.Controls.Add(label3, 0, 4);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(Pic_photo, 2, 0);
            tableLayoutPanel2.Controls.Add(TextBoxID_Sweet, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 2, 3);
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
            tableLayoutPanel2.Size = new Size(280, 468);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // TextBoxAbout_Sweet
            // 
            TextBoxAbout_Sweet.BorderStyle = BorderStyle.None;
            tableLayoutPanel2.SetColumnSpan(TextBoxAbout_Sweet, 3);
            TextBoxAbout_Sweet.Dock = DockStyle.Fill;
            TextBoxAbout_Sweet.Location = new Point(10, 335);
            TextBoxAbout_Sweet.Margin = new Padding(5, 0, 5, 0);
            TextBoxAbout_Sweet.Multiline = true;
            TextBoxAbout_Sweet.Name = "TextBoxAbout_Sweet";
            TextBoxAbout_Sweet.Size = new Size(260, 100);
            TextBoxAbout_Sweet.TabIndex = 18;
            // 
            // label6
            // 
            tableLayoutPanel2.SetColumnSpan(label6, 2);
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(10, 305);
            label6.Margin = new Padding(5, 0, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(174, 30);
            label6.TabIndex = 17;
            label6.Text = "Descripción";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxStock_Sweet
            // 
            TextBoxStock_Sweet.BorderStyle = BorderStyle.None;
            tableLayoutPanel2.SetColumnSpan(TextBoxStock_Sweet, 3);
            TextBoxStock_Sweet.Dock = DockStyle.Fill;
            TextBoxStock_Sweet.Location = new Point(10, 275);
            TextBoxStock_Sweet.Margin = new Padding(5, 0, 5, 0);
            TextBoxStock_Sweet.Multiline = true;
            TextBoxStock_Sweet.Name = "TextBoxStock_Sweet";
            TextBoxStock_Sweet.Size = new Size(260, 30);
            TextBoxStock_Sweet.TabIndex = 16;
            // 
            // label5
            // 
            tableLayoutPanel2.SetColumnSpan(label5, 2);
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(10, 245);
            label5.Margin = new Padding(5, 0, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(174, 30);
            label5.TabIndex = 15;
            label5.Text = "Existencias";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxPrice_Sweet
            // 
            TextBoxPrice_Sweet.BorderStyle = BorderStyle.None;
            tableLayoutPanel2.SetColumnSpan(TextBoxPrice_Sweet, 3);
            TextBoxPrice_Sweet.Dock = DockStyle.Fill;
            TextBoxPrice_Sweet.Location = new Point(10, 215);
            TextBoxPrice_Sweet.Margin = new Padding(5, 0, 5, 0);
            TextBoxPrice_Sweet.Multiline = true;
            TextBoxPrice_Sweet.Name = "TextBoxPrice_Sweet";
            TextBoxPrice_Sweet.Size = new Size(260, 30);
            TextBoxPrice_Sweet.TabIndex = 14;
            // 
            // label4
            // 
            tableLayoutPanel2.SetColumnSpan(label4, 2);
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(10, 185);
            label4.Margin = new Padding(5, 0, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(174, 30);
            label4.TabIndex = 13;
            label4.Text = "Precio";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxName_Sweet
            // 
            TextBoxName_Sweet.BorderStyle = BorderStyle.None;
            tableLayoutPanel2.SetColumnSpan(TextBoxName_Sweet, 3);
            TextBoxName_Sweet.Dock = DockStyle.Fill;
            TextBoxName_Sweet.Location = new Point(10, 155);
            TextBoxName_Sweet.Margin = new Padding(5, 0, 5, 0);
            TextBoxName_Sweet.Multiline = true;
            TextBoxName_Sweet.Name = "TextBoxName_Sweet";
            TextBoxName_Sweet.Size = new Size(260, 30);
            TextBoxName_Sweet.TabIndex = 12;
            // 
            // label3
            // 
            tableLayoutPanel2.SetColumnSpan(label3, 2);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(10, 125);
            label3.Margin = new Padding(5, 0, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(174, 30);
            label3.TabIndex = 11;
            label3.Text = "Nombre";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(8, 5);
            label2.Name = "label2";
            label2.Size = new Size(83, 30);
            label2.TabIndex = 8;
            label2.Text = "ID";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Pic_photo
            // 
            Pic_photo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pic_photo.BackColor = Color.Transparent;
            Pic_photo.Image = Properties.Resources.lupa2;
            Pic_photo.Location = new Point(187, 8);
            Pic_photo.Name = "Pic_photo";
            tableLayoutPanel2.SetRowSpan(Pic_photo, 3);
            Pic_photo.Size = new Size(85, 84);
            Pic_photo.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_photo.TabIndex = 7;
            Pic_photo.TabStop = false;
            // 
            // TextBoxID_Sweet
            // 
            TextBoxID_Sweet.BorderStyle = BorderStyle.None;
            TextBoxID_Sweet.Dock = DockStyle.Fill;
            TextBoxID_Sweet.Location = new Point(8, 38);
            TextBoxID_Sweet.Multiline = true;
            TextBoxID_Sweet.Name = "TextBoxID_Sweet";
            TextBoxID_Sweet.Size = new Size(83, 24);
            TextBoxID_Sweet.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(184, 95);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(91, 30);
            panel2.TabIndex = 10;
            // 
            // PnlAddTop
            // 
            PnlAddTop.Controls.Add(button_Ok);
            PnlAddTop.Dock = DockStyle.Top;
            PnlAddTop.Location = new Point(0, 0);
            PnlAddTop.Name = "PnlAddTop";
            PnlAddTop.Size = new Size(300, 52);
            PnlAddTop.TabIndex = 2;
            // 
            // button_Ok
            // 
            button_Ok.BackColor = Color.DarkRed;
            button_Ok.Dock = DockStyle.Left;
            button_Ok.FlatAppearance.BorderSize = 0;
            button_Ok.FlatStyle = FlatStyle.Flat;
            button_Ok.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_Ok.ForeColor = SystemColors.Control;
            button_Ok.Location = new Point(0, 0);
            button_Ok.Name = "button_Ok";
            button_Ok.Size = new Size(78, 52);
            button_Ok.TabIndex = 6;
            button_Ok.Text = "Ok";
            button_Ok.UseVisualStyleBackColor = false;
            button_Ok.Click += button_Ok_Click;
            // 
            // Timer1
            // 
            Timer1.Interval = 50;
            Timer1.Tick += Timer1_Tick;
            // 
            // Grid_Dulceria
            // 
            Grid_Dulceria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Grid_Dulceria.BackgroundColor = SystemColors.Control;
            Grid_Dulceria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Dulceria.Location = new Point(5, 66);
            Grid_Dulceria.Name = "Grid_Dulceria";
            Grid_Dulceria.RowHeadersWidth = 51;
            Grid_Dulceria.RowTemplate.Height = 29;
            Grid_Dulceria.Size = new Size(819, 529);
            Grid_Dulceria.TabIndex = 2;
            // 
            // gridSweets
            // 
            gridSweets.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            gridSweets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridSweets.AutoGenerateColumns = false;
            gridSweets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridSweets.BackgroundColor = SystemColors.Control;
            gridSweets.BorderStyle = BorderStyle.None;
            gridSweets.CellBorderStyle = DataGridViewCellBorderStyle.None;
            gridSweets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Firebrick;
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridSweets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridSweets.ColumnHeadersHeight = 29;
            gridSweets.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn, aboutDataGridViewTextBoxColumn });
            gridSweets.DataSource = sweetsBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridSweets.DefaultCellStyle = dataGridViewCellStyle3;
            gridSweets.Dock = DockStyle.Left;
            gridSweets.EnableHeadersVisualStyles = false;
            gridSweets.Location = new Point(5, 65);
            gridSweets.Margin = new Padding(10, 3, 3, 3);
            gridSweets.Name = "gridSweets";
            gridSweets.RowHeadersVisible = false;
            gridSweets.RowHeadersWidth = 51;
            gridSweets.RowTemplate.Height = 29;
            gridSweets.Size = new Size(526, 530);
            gridSweets.TabIndex = 3;
            // 
            // sweetsBindingSource
            // 
            sweetsBindingSource.DataSource = typeof(Sweets);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // aboutDataGridViewTextBoxColumn
            // 
            aboutDataGridViewTextBoxColumn.DataPropertyName = "About";
            aboutDataGridViewTextBoxColumn.HeaderText = "About";
            aboutDataGridViewTextBoxColumn.MinimumWidth = 6;
            aboutDataGridViewTextBoxColumn.Name = "aboutDataGridViewTextBoxColumn";
            // 
            // Frm_Dulceria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(829, 600);
            Controls.Add(gridSweets);
            Controls.Add(PnlAddData);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Grid_Dulceria);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Dulceria";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Dulceria";
            Load += Frm_Dulceria_Load_1;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Btn_Close_Page).EndInit();
            PnlAddData.ResumeLayout(false);
            PnlAddPage.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_photo).EndInit();
            PnlAddTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_Dulceria).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridSweets).EndInit();
            ((System.ComponentModel.ISupportInitialize)sweetsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button Btn_Buscar;
        private Button Btn_Eliminar;
        private Button Btn_Agregar;
        private Button Btn_Modificar;
        private Panel PnlAddData;
        private Panel PnlAddTop;
        private Panel PnlAddPage;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox Pic_photo;
        private Label label2;
        private TextBox TextBoxID_Sweet;
        private Panel panel2;
        private Label label3;
        private TextBox TextBoxName_Sweet;
        private TextBox TextBoxStock_Sweet;
        private Label label5;
        private TextBox TextBoxPrice_Sweet;
        private Label label4;
        private Label label6;
        private TextBox TextBoxAbout_Sweet;
        private PictureBox Btn_Close_Page;
        private System.Windows.Forms.Timer Timer1;
        private DataGridView Grid_Dulceria;
        private Button button_Ok;
        private Button buttonLimpiar;
        private DataGridView gridSweets;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aboutDataGridViewTextBoxColumn;
        private BindingSource sweetsBindingSource;
    }
}