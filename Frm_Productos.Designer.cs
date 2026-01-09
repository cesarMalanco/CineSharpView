namespace WinFormsFinalProyect
{
    partial class Frm_Productos
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            Btn_Close_Page = new PictureBox();
            Contenedor_Peliculas = new FlowLayoutPanel();
            gridPelicula = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            buttonLimpiar_Peliculas = new Button();
            buttonBuscar_Peliculas = new Button();
            textBoxStock_Peliculas = new TextBox();
            label3 = new Label();
            textBoxTitulo_Peliculas = new TextBox();
            label2 = new Label();
            textBoxID_Pelicula = new TextBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Close_Page).BeginInit();
            Contenedor_Peliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPelicula).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(Btn_Close_Page, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(809, 60);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(5, 2);
            label4.Name = "label4";
            label4.Size = new Size(332, 56);
            label4.TabIndex = 5;
            label4.Text = "Peliculas Disponibles";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Btn_Close_Page
            // 
            Btn_Close_Page.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Close_Page.BackColor = Color.Transparent;
            Btn_Close_Page.Image = Properties.Resources.cerrar;
            Btn_Close_Page.Location = new Point(759, 5);
            Btn_Close_Page.Name = "Btn_Close_Page";
            Btn_Close_Page.Size = new Size(45, 43);
            Btn_Close_Page.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Close_Page.TabIndex = 19;
            Btn_Close_Page.TabStop = false;
            Btn_Close_Page.Click += Btn_Close_Page_Click;
            // 
            // Contenedor_Peliculas
            // 
            Contenedor_Peliculas.BackColor = SystemColors.Control;
            Contenedor_Peliculas.Controls.Add(gridPelicula);
            Contenedor_Peliculas.FlowDirection = FlowDirection.TopDown;
            Contenedor_Peliculas.Location = new Point(0, 66);
            Contenedor_Peliculas.Name = "Contenedor_Peliculas";
            Contenedor_Peliculas.Size = new Size(599, 522);
            Contenedor_Peliculas.TabIndex = 9;
            // 
            // gridPelicula
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            gridPelicula.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridPelicula.Anchor = AnchorStyles.Top;
            gridPelicula.BackgroundColor = Color.White;
            gridPelicula.CellBorderStyle = DataGridViewCellBorderStyle.None;
            gridPelicula.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Firebrick;
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridPelicula.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridPelicula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridPelicula.DefaultCellStyle = dataGridViewCellStyle3;
            gridPelicula.EnableHeadersVisualStyles = false;
            gridPelicula.Location = new Point(10, 3);
            gridPelicula.Margin = new Padding(10, 3, 3, 3);
            gridPelicula.Name = "gridPelicula";
            gridPelicula.RowHeadersVisible = false;
            gridPelicula.RowHeadersWidth = 51;
            gridPelicula.RowTemplate.Height = 29;
            gridPelicula.Size = new Size(587, 519);
            gridPelicula.TabIndex = 0;
            gridPelicula.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonLimpiar_Peliculas);
            panel1.Controls.Add(buttonBuscar_Peliculas);
            panel1.Controls.Add(textBoxStock_Peliculas);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxTitulo_Peliculas);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxID_Pelicula);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(605, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 535);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lupa2;
            pictureBox1.Location = new Point(147, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // buttonLimpiar_Peliculas
            // 
            buttonLimpiar_Peliculas.BackColor = Color.LightCoral;
            buttonLimpiar_Peliculas.FlatAppearance.BorderSize = 0;
            buttonLimpiar_Peliculas.FlatStyle = FlatStyle.Flat;
            buttonLimpiar_Peliculas.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimpiar_Peliculas.ForeColor = SystemColors.ButtonFace;
            buttonLimpiar_Peliculas.Location = new Point(111, 155);
            buttonLimpiar_Peliculas.Name = "buttonLimpiar_Peliculas";
            buttonLimpiar_Peliculas.Size = new Size(101, 30);
            buttonLimpiar_Peliculas.TabIndex = 8;
            buttonLimpiar_Peliculas.Text = "Limpiar";
            buttonLimpiar_Peliculas.UseVisualStyleBackColor = false;
            buttonLimpiar_Peliculas.Click += buttonLimpiar_Peliculas_Click;
            // 
            // buttonBuscar_Peliculas
            // 
            buttonBuscar_Peliculas.BackColor = Color.LightCoral;
            buttonBuscar_Peliculas.FlatAppearance.BorderSize = 0;
            buttonBuscar_Peliculas.FlatStyle = FlatStyle.Flat;
            buttonBuscar_Peliculas.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscar_Peliculas.ForeColor = SystemColors.ButtonFace;
            buttonBuscar_Peliculas.Location = new Point(12, 155);
            buttonBuscar_Peliculas.Name = "buttonBuscar_Peliculas";
            buttonBuscar_Peliculas.Size = new Size(93, 30);
            buttonBuscar_Peliculas.TabIndex = 7;
            buttonBuscar_Peliculas.Text = "Buscar";
            buttonBuscar_Peliculas.UseVisualStyleBackColor = false;
            buttonBuscar_Peliculas.Click += buttonBuscar_Peliculas_Click;
            // 
            // textBoxStock_Peliculas
            // 
            textBoxStock_Peliculas.Location = new Point(12, 339);
            textBoxStock_Peliculas.Name = "textBoxStock_Peliculas";
            textBoxStock_Peliculas.Size = new Size(200, 27);
            textBoxStock_Peliculas.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 304);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Stock:";
            // 
            // textBoxTitulo_Peliculas
            // 
            textBoxTitulo_Peliculas.Location = new Point(12, 256);
            textBoxTitulo_Peliculas.Name = "textBoxTitulo_Peliculas";
            textBoxTitulo_Peliculas.Size = new Size(200, 27);
            textBoxTitulo_Peliculas.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 220);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Título:";
            // 
            // textBoxID_Pelicula
            // 
            textBoxID_Pelicula.Location = new Point(12, 87);
            textBoxID_Pelicula.Name = "textBoxID_Pelicula";
            textBoxID_Pelicula.Size = new Size(117, 27);
            textBoxID_Pelicula.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "ID Película:";
            // 
            // Frm_Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 600);
            Controls.Add(panel1);
            Controls.Add(Contenedor_Peliculas);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Productos";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Productos";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Btn_Close_Page).EndInit();
            Contenedor_Peliculas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridPelicula).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox Btn_Close_Page;
        private FlowLayoutPanel Contenedor_Peliculas;
        private Label label4;
        private DataGridView gridPelicula;
        private Panel panel1;
        private TextBox textBoxID_Pelicula;
        private Label label1;
        private TextBox textBoxStock_Peliculas;
        private Label label3;
        private TextBox textBoxTitulo_Peliculas;
        private Label label2;
        private Button buttonBuscar_Peliculas;
        private Button buttonLimpiar_Peliculas;
        private PictureBox pictureBox1;
    }
}