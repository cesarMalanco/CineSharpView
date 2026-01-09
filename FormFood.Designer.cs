namespace WinFormsFinalProject
{
    partial class FormFood
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
            gridPelicula = new DataGridView();
            PnlAddPage = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridPelicula).BeginInit();
            PnlAddPage.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // gridPelicula
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            gridPelicula.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridPelicula.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridPelicula.BackgroundColor = SystemColors.Control;
            gridPelicula.BorderStyle = BorderStyle.None;
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
            gridPelicula.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridPelicula.DefaultCellStyle = dataGridViewCellStyle3;
            gridPelicula.Dock = DockStyle.Left;
            gridPelicula.EnableHeadersVisualStyles = false;
            gridPelicula.Location = new Point(0, 0);
            gridPelicula.Margin = new Padding(10, 3, 3, 3);
            gridPelicula.Name = "gridPelicula";
            gridPelicula.RowHeadersVisible = false;
            gridPelicula.RowHeadersWidth = 51;
            gridPelicula.RowTemplate.Height = 29;
            gridPelicula.Size = new Size(643, 600);
            gridPelicula.TabIndex = 1;
            gridPelicula.CellContentClick += gridPelicula_CellContentClick;
            // 
            // PnlAddPage
            // 
            PnlAddPage.AutoScroll = true;
            PnlAddPage.Controls.Add(tableLayoutPanel2);
            PnlAddPage.Dock = DockStyle.Right;
            PnlAddPage.Location = new Point(615, 0);
            PnlAddPage.Margin = new Padding(0);
            PnlAddPage.Name = "PnlAddPage";
            PnlAddPage.Padding = new Padding(10, 5, 10, 5);
            PnlAddPage.Size = new Size(299, 600);
            PnlAddPage.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(button1, 0, 1);
            tableLayoutPanel2.Controls.Add(button2, 0, 2);
            tableLayoutPanel2.Controls.Add(button3, 0, 3);
            tableLayoutPanel2.Controls.Add(button4, 0, 4);
            tableLayoutPanel2.Controls.Add(button5, 0, 5);
            tableLayoutPanel2.Controls.Add(button6, 0, 6);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 5);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5);
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 4.436435F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.597228F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.597228F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.597228F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.597228F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.597228F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.597065F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 55.98036F));
            tableLayoutPanel2.Size = new Size(279, 590);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(8, 34);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(263, 30);
            button1.TabIndex = 2;
            button1.Text = "Añadir al carrito";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(8, 72);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(263, 30);
            button2.TabIndex = 3;
            button2.Text = "Añadir al carrito";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkRed;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(8, 110);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(263, 30);
            button3.TabIndex = 4;
            button3.Text = "Añadir al carrito";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkRed;
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(8, 148);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(263, 30);
            button4.TabIndex = 5;
            button4.Text = "Añadir al carrito";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkRed;
            button5.Dock = DockStyle.Fill;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(8, 186);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(263, 30);
            button5.TabIndex = 6;
            button5.Text = "Añadir al carrito";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkRed;
            button6.Dock = DockStyle.Fill;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(8, 224);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(263, 30);
            button6.TabIndex = 7;
            button6.Text = "Añadir al carrito";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // FormFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(914, 600);
            Controls.Add(PnlAddPage);
            Controls.Add(gridPelicula);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormFood";
            Text = "FormFood";
            ((System.ComponentModel.ISupportInitialize)gridPelicula).EndInit();
            PnlAddPage.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridPelicula;
        private Panel PnlAddPage;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}