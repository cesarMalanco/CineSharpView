namespace Forms_individuales_proyecto
{
    partial class Frm_Carrito
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label9 = new Label();
            Btn_Eliminar = new Button();
            PnlAddData = new Panel();
            PnlAddPage = new Panel();
            panelContenedor = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            panel2 = new Panel();
            Btn_Buscar = new Button();
            PnlAddTop = new Panel();
            btn_cancel_id = new Button();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            grid_productos = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            button1 = new Button();
            BtnTarjeta = new Button();
            Pnl_Info = new Panel();
            panel3 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel4 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            panel5 = new Panel();
            BtnOK = new Button();
            label4 = new Label();
            Btn_Cancel = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            Pnl_Total = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            Pnl_Pagos = new TableLayoutPanel();
            Btn_OXXO = new Button();
            pictureBox5 = new PictureBox();
            Btn_Efectivo = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            lbl_metodos = new Label();
            lbl_iva = new Label();
            Pnl_oxxo = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel8 = new Panel();
            pictureBox6 = new PictureBox();
            panel9 = new Panel();
            Btn_Close_oxxo = new Button();
            label11 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            PnlAddData.SuspendLayout();
            PnlAddPage.SuspendLayout();
            panelContenedor.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            PnlAddTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_productos).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            Pnl_Info.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            Pnl_Total.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Pnl_Pagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Pnl_oxxo.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.Controls.Add(label9, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(10, 11);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2, 3, 2, 3);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.Size = new Size(1198, 91);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(5, 3);
            label9.Name = "label9";
            label9.Size = new Size(1098, 85);
            label9.TabIndex = 17;
            label9.Text = "Carrito";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Btn_Eliminar
            // 
            Btn_Eliminar.BackColor = Color.Black;
            Btn_Eliminar.FlatAppearance.BorderSize = 0;
            Btn_Eliminar.FlatStyle = FlatStyle.Flat;
            Btn_Eliminar.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Eliminar.ForeColor = SystemColors.Control;
            Btn_Eliminar.Location = new Point(5, 6);
            Btn_Eliminar.Name = "Btn_Eliminar";
            Btn_Eliminar.Size = new Size(259, 80);
            Btn_Eliminar.TabIndex = 21;
            Btn_Eliminar.Text = "Eliminar Productos";
            Btn_Eliminar.UseVisualStyleBackColor = false;
            Btn_Eliminar.Click += Btn_Eliminar_Click;
            // 
            // PnlAddData
            // 
            PnlAddData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PnlAddData.BackColor = Color.DarkRed;
            PnlAddData.Controls.Add(PnlAddPage);
            PnlAddData.Location = new Point(893, 140);
            PnlAddData.Name = "PnlAddData";
            PnlAddData.Size = new Size(315, 188);
            PnlAddData.TabIndex = 9;
            PnlAddData.Visible = false;
            // 
            // PnlAddPage
            // 
            PnlAddPage.AutoScroll = true;
            PnlAddPage.Controls.Add(panelContenedor);
            PnlAddPage.Controls.Add(PnlAddTop);
            PnlAddPage.Location = new Point(18, 0);
            PnlAddPage.Margin = new Padding(0);
            PnlAddPage.Name = "PnlAddPage";
            PnlAddPage.Padding = new Padding(10, 5, 10, 5);
            PnlAddPage.Size = new Size(297, 188);
            PnlAddPage.TabIndex = 3;
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(tableLayoutPanel2);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(10, 57);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(277, 126);
            panelContenedor.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 2, 3);
            tableLayoutPanel2.Controls.Add(Btn_Buscar, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5);
            tableLayoutPanel2.RowCount = 17;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.Size = new Size(277, 126);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            tableLayoutPanel2.SetColumnSpan(label2, 3);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(8, 5);
            label2.Name = "label2";
            tableLayoutPanel2.SetRowSpan(label2, 2);
            label2.Size = new Size(261, 58);
            label2.TabIndex = 8;
            label2.Text = "¿Está seguro de eliminar los elementos del carrito?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(182, 92);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(90, 29);
            panel2.TabIndex = 10;
            // 
            // Btn_Buscar
            // 
            Btn_Buscar.BackColor = Color.MistyRose;
            Btn_Buscar.Dock = DockStyle.Fill;
            Btn_Buscar.FlatAppearance.BorderSize = 0;
            Btn_Buscar.FlatStyle = FlatStyle.Flat;
            Btn_Buscar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Buscar.ForeColor = SystemColors.ActiveCaptionText;
            Btn_Buscar.Location = new Point(96, 95);
            Btn_Buscar.Name = "Btn_Buscar";
            Btn_Buscar.Size = new Size(83, 23);
            Btn_Buscar.TabIndex = 21;
            Btn_Buscar.Text = "Eliminar";
            Btn_Buscar.UseVisualStyleBackColor = false;
            Btn_Buscar.Click += Btn_Buscar_Click;
            // 
            // PnlAddTop
            // 
            PnlAddTop.Controls.Add(btn_cancel_id);
            PnlAddTop.Controls.Add(label1);
            PnlAddTop.Dock = DockStyle.Top;
            PnlAddTop.Location = new Point(10, 5);
            PnlAddTop.Name = "PnlAddTop";
            PnlAddTop.Size = new Size(277, 52);
            PnlAddTop.TabIndex = 2;
            // 
            // btn_cancel_id
            // 
            btn_cancel_id.BackColor = Color.DarkRed;
            btn_cancel_id.Dock = DockStyle.Right;
            btn_cancel_id.FlatAppearance.BorderSize = 0;
            btn_cancel_id.FlatStyle = FlatStyle.Flat;
            btn_cancel_id.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancel_id.ForeColor = SystemColors.Control;
            btn_cancel_id.Location = new Point(222, 0);
            btn_cancel_id.Name = "btn_cancel_id";
            btn_cancel_id.Size = new Size(55, 52);
            btn_cancel_id.TabIndex = 5;
            btn_cancel_id.Text = "x";
            btn_cancel_id.UseVisualStyleBackColor = false;
            btn_cancel_id.Click += btn_cancel_id_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(8, 13);
            label1.Name = "label1";
            label1.Size = new Size(145, 27);
            label1.TabIndex = 4;
            label1.Text = "Eliminar carrito";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(10, 102);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(2, 3, 2, 3);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel3.Size = new Size(1198, 29);
            tableLayoutPanel3.TabIndex = 10;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // grid_productos
            // 
            grid_productos.BackgroundColor = SystemColors.Info;
            grid_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_productos.Location = new Point(10, 129);
            grid_productos.Margin = new Padding(5);
            grid_productos.Name = "grid_productos";
            grid_productos.RowHeadersWidth = 51;
            grid_productos.RowTemplate.Height = 29;
            grid_productos.Size = new Size(687, 461);
            grid_productos.TabIndex = 11;
            grid_productos.CellContentClick += grid_productos_CellContentClick;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel4.Controls.Add(button1, 1, 0);
            tableLayoutPanel4.Controls.Add(Btn_Eliminar, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(10, 597);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(2, 3, 2, 3);
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutPanel4.Size = new Size(1198, 99);
            tableLayoutPanel4.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(1109, 6);
            button1.Name = "button1";
            button1.Size = new Size(83, 80);
            button1.TabIndex = 22;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BtnTarjeta
            // 
            BtnTarjeta.BackColor = Color.DarkRed;
            BtnTarjeta.Dock = DockStyle.Fill;
            BtnTarjeta.FlatAppearance.BorderSize = 0;
            BtnTarjeta.FlatStyle = FlatStyle.Flat;
            BtnTarjeta.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnTarjeta.ForeColor = SystemColors.Control;
            BtnTarjeta.Location = new Point(104, 87);
            BtnTarjeta.Name = "BtnTarjeta";
            BtnTarjeta.Size = new Size(394, 78);
            BtnTarjeta.TabIndex = 22;
            BtnTarjeta.Text = "Tarjeta";
            BtnTarjeta.TextAlign = ContentAlignment.MiddleLeft;
            BtnTarjeta.UseVisualStyleBackColor = false;
            BtnTarjeta.Click += BtnTarjeta_Click;
            // 
            // Pnl_Info
            // 
            Pnl_Info.AutoScroll = true;
            Pnl_Info.BackColor = Color.DarkRed;
            Pnl_Info.Controls.Add(panel3);
            Pnl_Info.Controls.Add(panel5);
            Pnl_Info.Dock = DockStyle.Right;
            Pnl_Info.Location = new Point(749, 131);
            Pnl_Info.Name = "Pnl_Info";
            Pnl_Info.Size = new Size(459, 466);
            Pnl_Info.TabIndex = 13;
            Pnl_Info.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 52);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10, 5, 10, 5);
            panel3.Size = new Size(459, 414);
            panel3.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoScroll = true;
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Controls.Add(panel4, 2, 3);
            tableLayoutPanel5.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel5.Controls.Add(textBox2, 0, 5);
            tableLayoutPanel5.Controls.Add(dateTimePicker1, 0, 11);
            tableLayoutPanel5.Controls.Add(label7, 0, 10);
            tableLayoutPanel5.Controls.Add(textBox1, 2, 11);
            tableLayoutPanel5.Controls.Add(label3, 2, 10);
            tableLayoutPanel5.Controls.Add(label5, 0, 7);
            tableLayoutPanel5.Controls.Add(textBox3, 0, 8);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(10, 5);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Padding = new Padding(5);
            tableLayoutPanel5.RowCount = 13;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(439, 404);
            tableLayoutPanel5.TabIndex = 0;
            tableLayoutPanel5.Paint += tableLayoutPanel5_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(5, 121);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(107, 29);
            panel4.TabIndex = 10;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(21, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 29);
            label6.TabIndex = 13;
            label6.Text = "Nombre:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.Transparent;
            tableLayoutPanel5.SetColumnSpan(pictureBox1, 4);
            pictureBox1.ErrorImage = WinFormsFinalProyect.Properties.Resources.diferencia_tarjeta_credito_debito1;
            pictureBox1.Image = WinFormsFinalProyect.Properties.Resources.diferencia_tarjeta_credito_debito3;
            pictureBox1.Location = new Point(79, 8);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanel5.SetRowSpan(pictureBox1, 4);
            pictureBox1.Size = new Size(281, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            tableLayoutPanel5.SetColumnSpan(textBox2, 4);
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(26, 153);
            textBox2.Margin = new Padding(21, 3, 21, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(387, 23);
            textBox2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            tableLayoutPanel5.SetColumnSpan(dateTimePicker1, 2);
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(26, 327);
            dateTimePicker1.Margin = new Padding(21, 3, 3, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(190, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // label7
            // 
            tableLayoutPanel5.SetColumnSpan(label7, 2);
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(26, 295);
            label7.Margin = new Padding(21, 0, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(113, 29);
            label7.TabIndex = 14;
            label7.Text = "Vencimiento:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            tableLayoutPanel5.SetColumnSpan(textBox1, 2);
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(240, 327);
            textBox1.Margin = new Padding(21, 3, 21, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 17;
            // 
            // label3
            // 
            tableLayoutPanel5.SetColumnSpan(label3, 2);
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(240, 295);
            label3.Margin = new Padding(21, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 29);
            label3.TabIndex = 16;
            label3.Text = "CVV:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            tableLayoutPanel5.SetColumnSpan(label5, 2);
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(26, 208);
            label5.Margin = new Padding(21, 0, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 29);
            label5.TabIndex = 11;
            label5.Text = "No. de Tarjeta:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            tableLayoutPanel5.SetColumnSpan(textBox3, 4);
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(26, 240);
            textBox3.Margin = new Padding(21, 3, 21, 3);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(387, 23);
            textBox3.TabIndex = 18;
            // 
            // panel5
            // 
            panel5.Controls.Add(BtnOK);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(Btn_Cancel);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(459, 52);
            panel5.TabIndex = 2;
            // 
            // BtnOK
            // 
            BtnOK.BackColor = Color.DarkRed;
            BtnOK.Dock = DockStyle.Left;
            BtnOK.FlatAppearance.BorderSize = 0;
            BtnOK.FlatStyle = FlatStyle.Flat;
            BtnOK.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOK.ForeColor = SystemColors.Control;
            BtnOK.Location = new Point(55, 0);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(55, 52);
            BtnOK.TabIndex = 5;
            BtnOK.Text = "Ok";
            BtnOK.UseVisualStyleBackColor = false;
            BtnOK.Click += BtnOK_Click;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(55, 0);
            label4.Margin = new Padding(3, 0, 10, 0);
            label4.Name = "label4";
            label4.Size = new Size(404, 52);
            label4.TabIndex = 4;
            label4.Text = "Información de Pago";
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
            // timer2
            // 
            timer2.Interval = 50;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 50;
            timer3.Tick += timer3_Tick;
            // 
            // Pnl_Total
            // 
            Pnl_Total.BackColor = Color.DarkRed;
            Pnl_Total.ColumnCount = 2;
            Pnl_Total.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 101F));
            Pnl_Total.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Pnl_Total.Controls.Add(pictureBox2, 0, 0);
            Pnl_Total.Controls.Add(label8, 1, 0);
            Pnl_Total.Location = new Point(709, 129);
            Pnl_Total.Name = "Pnl_Total";
            Pnl_Total.RowCount = 1;
            Pnl_Total.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Pnl_Total.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            Pnl_Total.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            Pnl_Total.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            Pnl_Total.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            Pnl_Total.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            Pnl_Total.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            Pnl_Total.Size = new Size(501, 91);
            Pnl_Total.TabIndex = 14;
            Pnl_Total.Paint += Pnl_Total_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = WinFormsFinalProyect.Properties.Resources.dinero;
            pictureBox2.Location = new Point(21, 20);
            pictureBox2.Margin = new Padding(21, 20, 21, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(104, 0);
            label8.Name = "label8";
            label8.Size = new Size(394, 91);
            label8.TabIndex = 1;
            label8.Text = "$0.00";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Pnl_Pagos
            // 
            Pnl_Pagos.BackColor = Color.DarkRed;
            Pnl_Pagos.ColumnCount = 2;
            Pnl_Pagos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 101F));
            Pnl_Pagos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Pnl_Pagos.Controls.Add(Btn_OXXO, 1, 2);
            Pnl_Pagos.Controls.Add(pictureBox5, 0, 2);
            Pnl_Pagos.Controls.Add(Btn_Efectivo, 1, 0);
            Pnl_Pagos.Controls.Add(BtnTarjeta, 1, 1);
            Pnl_Pagos.Controls.Add(pictureBox4, 0, 1);
            Pnl_Pagos.Controls.Add(pictureBox3, 0, 0);
            Pnl_Pagos.Location = new Point(709, 333);
            Pnl_Pagos.Name = "Pnl_Pagos";
            Pnl_Pagos.RowCount = 3;
            Pnl_Pagos.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Pnl_Pagos.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Pnl_Pagos.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Pnl_Pagos.Size = new Size(501, 253);
            Pnl_Pagos.TabIndex = 15;
            // 
            // Btn_OXXO
            // 
            Btn_OXXO.BackColor = Color.DarkRed;
            Btn_OXXO.Dock = DockStyle.Fill;
            Btn_OXXO.FlatAppearance.BorderSize = 0;
            Btn_OXXO.FlatStyle = FlatStyle.Flat;
            Btn_OXXO.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_OXXO.ForeColor = SystemColors.Control;
            Btn_OXXO.Location = new Point(104, 171);
            Btn_OXXO.Name = "Btn_OXXO";
            Btn_OXXO.Size = new Size(394, 79);
            Btn_OXXO.TabIndex = 25;
            Btn_OXXO.Text = "Pago en OXXO";
            Btn_OXXO.TextAlign = ContentAlignment.MiddleLeft;
            Btn_OXXO.UseVisualStyleBackColor = false;
            Btn_OXXO.Click += Btn_OXXO_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.ErrorImage = WinFormsFinalProyect.Properties.Resources.OXXO_Logo;
            pictureBox5.Image = WinFormsFinalProyect.Properties.Resources.OXXO_Logo1;
            pictureBox5.Location = new Point(21, 197);
            pictureBox5.Margin = new Padding(21, 29, 21, 29);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(59, 27);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // Btn_Efectivo
            // 
            Btn_Efectivo.BackColor = Color.DarkRed;
            Btn_Efectivo.Dock = DockStyle.Fill;
            Btn_Efectivo.FlatAppearance.BorderSize = 0;
            Btn_Efectivo.FlatStyle = FlatStyle.Flat;
            Btn_Efectivo.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Efectivo.ForeColor = SystemColors.Control;
            Btn_Efectivo.Location = new Point(104, 3);
            Btn_Efectivo.Name = "Btn_Efectivo";
            Btn_Efectivo.Size = new Size(394, 78);
            Btn_Efectivo.TabIndex = 23;
            Btn_Efectivo.Text = "Efectivo";
            Btn_Efectivo.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Efectivo.UseVisualStyleBackColor = false;
            Btn_Efectivo.Click += Btn_Efectivo_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.ErrorImage = WinFormsFinalProyect.Properties.Resources.diferencia_tarjeta_credito_debito;
            pictureBox4.Image = WinFormsFinalProyect.Properties.Resources.diferencia_tarjeta_credito_debito2;
            pictureBox4.Location = new Point(21, 113);
            pictureBox4.Margin = new Padding(21, 29, 21, 29);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = WinFormsFinalProyect.Properties.Resources.dinero;
            pictureBox3.Location = new Point(21, 29);
            pictureBox3.Margin = new Padding(21, 29, 21, 29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // lbl_metodos
            // 
            lbl_metodos.AutoSize = true;
            lbl_metodos.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_metodos.ForeColor = Color.Black;
            lbl_metodos.Location = new Point(705, 261);
            lbl_metodos.Name = "lbl_metodos";
            lbl_metodos.Size = new Size(225, 37);
            lbl_metodos.TabIndex = 16;
            lbl_metodos.Text = "Métodos de Pago";
            lbl_metodos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_iva
            // 
            lbl_iva.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_iva.ForeColor = Color.Black;
            lbl_iva.Location = new Point(728, 299);
            lbl_iva.Name = "lbl_iva";
            lbl_iva.Size = new Size(210, 29);
            lbl_iva.TabIndex = 17;
            lbl_iva.Text = "IVA incluido";
            lbl_iva.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Pnl_oxxo
            // 
            Pnl_oxxo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pnl_oxxo.BackColor = Color.DarkRed;
            Pnl_oxxo.Controls.Add(panel6);
            Pnl_oxxo.Location = new Point(893, 331);
            Pnl_oxxo.Name = "Pnl_oxxo";
            Pnl_oxxo.Size = new Size(315, 188);
            Pnl_oxxo.TabIndex = 18;
            Pnl_oxxo.Visible = false;
            // 
            // panel6
            // 
            panel6.AutoScroll = true;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel9);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(10, 5, 10, 5);
            panel6.Size = new Size(315, 188);
            panel6.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(tableLayoutPanel6);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(10, 57);
            panel7.Name = "panel7";
            panel7.Size = new Size(295, 126);
            panel7.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel6.Controls.Add(panel8, 2, 3);
            tableLayoutPanel6.Controls.Add(pictureBox6, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.Padding = new Padding(5);
            tableLayoutPanel6.RowCount = 17;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel6.Size = new Size(295, 126);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(5, 121);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(94, 29);
            panel8.TabIndex = 10;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top;
            pictureBox6.BackColor = Color.Transparent;
            tableLayoutPanel6.SetColumnSpan(pictureBox6, 3);
            pictureBox6.ErrorImage = WinFormsFinalProyect.Properties.Resources.PAGO_EN_OXXO;
            pictureBox6.Image = WinFormsFinalProyect.Properties.Resources.PAGO_EN_OXXO1;
            pictureBox6.Location = new Point(17, 8);
            pictureBox6.Name = "pictureBox6";
            tableLayoutPanel6.SetRowSpan(pictureBox6, 4);
            pictureBox6.Size = new Size(261, 109);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(Btn_Close_oxxo);
            panel9.Controls.Add(label11);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(10, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(295, 52);
            panel9.TabIndex = 2;
            // 
            // Btn_Close_oxxo
            // 
            Btn_Close_oxxo.BackColor = Color.DarkRed;
            Btn_Close_oxxo.Dock = DockStyle.Right;
            Btn_Close_oxxo.FlatAppearance.BorderSize = 0;
            Btn_Close_oxxo.FlatStyle = FlatStyle.Flat;
            Btn_Close_oxxo.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Close_oxxo.ForeColor = SystemColors.Control;
            Btn_Close_oxxo.Location = new Point(240, 0);
            Btn_Close_oxxo.Name = "Btn_Close_oxxo";
            Btn_Close_oxxo.Size = new Size(55, 52);
            Btn_Close_oxxo.TabIndex = 5;
            Btn_Close_oxxo.Text = "x";
            Btn_Close_oxxo.UseVisualStyleBackColor = false;
            Btn_Close_oxxo.Click += Btn_Close_oxxo_Click;
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(8, 13);
            label11.Name = "label11";
            label11.Size = new Size(141, 27);
            label11.TabIndex = 4;
            label11.Text = "QR EN OXXO";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // Frm_Carrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 707);
            Controls.Add(Pnl_Info);
            Controls.Add(Pnl_oxxo);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(grid_productos);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(PnlAddData);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Pnl_Total);
            Controls.Add(lbl_metodos);
            Controls.Add(lbl_iva);
            Controls.Add(Pnl_Pagos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Carrito";
            Padding = new Padding(10, 11, 10, 11);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Carrito";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            PnlAddData.ResumeLayout(false);
            PnlAddPage.ResumeLayout(false);
            panelContenedor.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            PnlAddTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_productos).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            Pnl_Info.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            Pnl_Total.ResumeLayout(false);
            Pnl_Total.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Pnl_Pagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            Pnl_oxxo.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel9.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button Btn_Eliminar;
        private Panel PnlAddData;
        private Panel PnlAddPage;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Panel panel2;
        private Button Btn_Buscar;
        private Panel PnlAddTop;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView grid_productos;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel Pnl_Info;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label7;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label label6;
        private Label label5;
        private Panel panel5;
        private Label label4;
        private Button Btn_Cancel;
        
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Button BtnTarjeta;
        private Panel panelContenedor;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox3;
        private Button btn_cancel_id;
        private Button BtnOK;
        private TableLayoutPanel Pnl_Total;
        private PictureBox pictureBox2;
        private Label label8;
        private TableLayoutPanel Pnl_Pagos;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label lbl_metodos;
        private Button Btn_Efectivo;
        private Label lbl_iva;
        private Label label9;
        private Button button1;
        private Button Btn_OXXO;
        private PictureBox pictureBox5;
        private Panel Pnl_oxxo;
        private Panel panel6;
        private Panel panel7;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel8;
        private Panel panel9;
        private Button Btn_Close_oxxo;
        private Label label11;
        private PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
    }
}