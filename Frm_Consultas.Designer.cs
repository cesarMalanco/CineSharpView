namespace WinFormsFinalProyect
{
    partial class Frm_Consultas
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            Btn_Consultas = new Button();
            Btn_Close_Page = new PictureBox();
            PnlAddData = new Panel();
            PnlAddPage = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            Pic_photo = new PictureBox();
            TextBoxID = new TextBox();
            panel2 = new Panel();
            Btn_Buscar = new Button();
            PnlAddTop = new Panel();
            BtnCancel = new Button();
            label1 = new Label();
            Grid_Usuarios = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            gridPelicula = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Close_Page).BeginInit();
            PnlAddData.SuspendLayout();
            PnlAddPage.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_photo).BeginInit();
            PnlAddTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Usuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridPelicula).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6F));
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(Btn_Consultas, 0, 0);
            tableLayoutPanel1.Controls.Add(Btn_Close_Page, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2, 3, 2, 3);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(819, 60);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(168, 6);
            button1.Name = "button1";
            button1.Size = new Size(157, 48);
            button1.TabIndex = 21;
            button1.Text = "Regresar a tabla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Btn_Consultas
            // 
            Btn_Consultas.BackColor = Color.DarkRed;
            Btn_Consultas.Dock = DockStyle.Left;
            Btn_Consultas.FlatAppearance.BorderSize = 0;
            Btn_Consultas.FlatStyle = FlatStyle.Flat;
            Btn_Consultas.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Consultas.ForeColor = SystemColors.Control;
            Btn_Consultas.Location = new Point(5, 6);
            Btn_Consultas.Name = "Btn_Consultas";
            Btn_Consultas.Size = new Size(157, 48);
            Btn_Consultas.TabIndex = 20;
            Btn_Consultas.Text = "Consultar";
            Btn_Consultas.UseVisualStyleBackColor = false;
            Btn_Consultas.Click += Btn_Consultas_Click;
            // 
            // Btn_Close_Page
            // 
            Btn_Close_Page.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Close_Page.BackColor = Color.Transparent;
            Btn_Close_Page.Image = Properties.Resources.cerrar;
            Btn_Close_Page.Location = new Point(771, 6);
            Btn_Close_Page.Name = "Btn_Close_Page";
            Btn_Close_Page.Size = new Size(43, 43);
            Btn_Close_Page.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Close_Page.TabIndex = 19;
            Btn_Close_Page.TabStop = false;
            Btn_Close_Page.Click += Btn_Close_Page_Click;
            // 
            // PnlAddData
            // 
            PnlAddData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PnlAddData.BackColor = Color.DarkRed;
            PnlAddData.Controls.Add(PnlAddPage);
            PnlAddData.Controls.Add(PnlAddTop);
            PnlAddData.Location = new Point(509, 71);
            PnlAddData.Name = "PnlAddData";
            PnlAddData.Size = new Size(315, 188);
            PnlAddData.TabIndex = 9;
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
            tableLayoutPanel2.Controls.Add(TextBoxID, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 2, 3);
            tableLayoutPanel2.Controls.Add(Btn_Buscar, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 5);
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
            label2.Size = new Size(88, 29);
            label2.TabIndex = 8;
            label2.Text = "Monto";
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
            Pic_photo.Size = new Size(72, 81);
            Pic_photo.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_photo.TabIndex = 7;
            Pic_photo.TabStop = false;
            // 
            // TextBoxID
            // 
            TextBoxID.BorderStyle = BorderStyle.None;
            tableLayoutPanel2.SetColumnSpan(TextBoxID, 2);
            TextBoxID.Dock = DockStyle.Fill;
            TextBoxID.Location = new Point(8, 37);
            TextBoxID.Multiline = true;
            TextBoxID.Name = "TextBoxID";
            TextBoxID.Size = new Size(183, 23);
            TextBoxID.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(194, 92);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(96, 29);
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
            Btn_Buscar.Location = new Point(8, 66);
            Btn_Buscar.Name = "Btn_Buscar";
            Btn_Buscar.Size = new Size(88, 23);
            Btn_Buscar.TabIndex = 21;
            Btn_Buscar.Text = "Buscar";
            Btn_Buscar.UseVisualStyleBackColor = false;
            Btn_Buscar.Click += Btn_Buscar_Click;
            // 
            // PnlAddTop
            // 
            PnlAddTop.Controls.Add(BtnCancel);
            PnlAddTop.Controls.Add(label1);
            PnlAddTop.Dock = DockStyle.Top;
            PnlAddTop.Location = new Point(0, 0);
            PnlAddTop.Name = "PnlAddTop";
            PnlAddTop.Size = new Size(315, 52);
            PnlAddTop.TabIndex = 2;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.DarkRed;
            BtnCancel.Dock = DockStyle.Left;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancel.ForeColor = SystemColors.Control;
            BtnCancel.Location = new Point(0, 0);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(55, 52);
            BtnCancel.TabIndex = 5;
            BtnCancel.Text = "x";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Microsoft YaHei UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(158, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 52);
            label1.TabIndex = 4;
            label1.Text = "Buscar por Monto";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Grid_Usuarios
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            Grid_Usuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Grid_Usuarios.BackgroundColor = Color.White;
            Grid_Usuarios.BorderStyle = BorderStyle.None;
            Grid_Usuarios.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Firebrick;
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Grid_Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Grid_Usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Grid_Usuarios.DefaultCellStyle = dataGridViewCellStyle3;
            Grid_Usuarios.Location = new Point(509, 65);
            Grid_Usuarios.Name = "Grid_Usuarios";
            Grid_Usuarios.RowHeadersVisible = false;
            Grid_Usuarios.RowHeadersWidth = 51;
            Grid_Usuarios.RowTemplate.Height = 29;
            Grid_Usuarios.Size = new Size(315, 523);
            Grid_Usuarios.TabIndex = 11;
            Grid_Usuarios.CellContentClick += Grid_Usuarios_CellContentClick;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // gridPelicula
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle4.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            gridPelicula.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            gridPelicula.BackgroundColor = Color.White;
            gridPelicula.CellBorderStyle = DataGridViewCellBorderStyle.None;
            gridPelicula.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Firebrick;
            dataGridViewCellStyle5.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridPelicula.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            gridPelicula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle6.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            gridPelicula.DefaultCellStyle = dataGridViewCellStyle6;
            gridPelicula.Dock = DockStyle.Left;
            gridPelicula.EnableHeadersVisualStyles = false;
            gridPelicula.Location = new Point(5, 65);
            gridPelicula.Margin = new Padding(10, 3, 3, 3);
            gridPelicula.Name = "gridPelicula";
            gridPelicula.RowHeadersVisible = false;
            gridPelicula.RowHeadersWidth = 51;
            gridPelicula.RowTemplate.Height = 29;
            gridPelicula.Size = new Size(497, 530);
            gridPelicula.TabIndex = 12;
            gridPelicula.CellContentClick += gridPelicula_CellContentClick_1;
            // 
            // Frm_Consultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 600);
            Controls.Add(gridPelicula);
            Controls.Add(Grid_Usuarios);
            Controls.Add(PnlAddData);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Consultas";
            Padding = new Padding(5);
            Text = "Frm_Consultas";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Btn_Close_Page).EndInit();
            PnlAddData.ResumeLayout(false);
            PnlAddPage.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_photo).EndInit();
            PnlAddTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_Usuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridPelicula).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button Btn_Consultas;
        private Panel PnlAddData;
        private Panel PnlAddPage;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private PictureBox Pic_photo;
        private TextBox TextBoxID;
        private Panel panel2;
        private Button Btn_Buscar;
        private Panel PnlAddTop;
        private Label label1;
        private DataGridView Grid_Usuarios;
        private Button BtnCancel;
        private System.Windows.Forms.Timer timer1;
        private DataGridView gridPelicula;
        private Button button1;
        private PictureBox Btn_Close_Page;
    }
}