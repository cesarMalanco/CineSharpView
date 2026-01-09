namespace WinFormsFinalProyect
{
    partial class Frm_Grafica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            Btn_Close_Page = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            chart_Admin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            label3 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Close_Page).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_Admin).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2, 3, 2, 3);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.Size = new Size(819, 52);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(5, 3);
            label4.Name = "label4";
            label4.Size = new Size(331, 46);
            label4.TabIndex = 5;
            label4.Text = "Gráfica";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Btn_Close_Page
            // 
            Btn_Close_Page.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Close_Page.BackColor = Color.Transparent;
            Btn_Close_Page.Image = Properties.Resources.cerrar;
            Btn_Close_Page.Location = new Point(769, 6);
            Btn_Close_Page.Name = "Btn_Close_Page";
            Btn_Close_Page.Size = new Size(45, 40);
            Btn_Close_Page.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Close_Page.TabIndex = 19;
            Btn_Close_Page.TabStop = false;
            Btn_Close_Page.Click += Btn_Close_Page_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkRed;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(21, 99);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5, 5, 5, 5);
            panel3.Size = new Size(213, 207);
            panel3.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(96, 161);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 21;
            label2.Text = "0";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 129);
            label1.Margin = new Padding(10, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 0;
            label1.Text = "Total Recaudado";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.tickets_vip;
            pictureBox1.Location = new Point(54, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // chart_Admin
            // 
            chartArea1.Name = "ChartArea1";
            chart_Admin.ChartAreas.Add(chartArea1);
            legend1.BackColor = Color.White;
            legend1.Name = "Legend1";
            chart_Admin.Legends.Add(legend1);
            chart_Admin.Location = new Point(265, 99);
            chart_Admin.Name = "chart_Admin";
            chart_Admin.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_Admin.Series.Add(series1);
            chart_Admin.Size = new Size(545, 420);
            chart_Admin.TabIndex = 0;
            chart_Admin.Text = "Gráfica";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(21, 312);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5, 5, 5, 5);
            panel1.Size = new Size(213, 207);
            panel1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(8, 171);
            label3.Name = "label3";
            label3.Size = new Size(17, 19);
            label3.TabIndex = 21;
            label3.Text = "0";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(34, 135);
            label5.Margin = new Padding(10, 11, 10, 11);
            label5.Name = "label5";
            label5.Size = new Size(139, 21);
            label5.TabIndex = 0;
            label5.Text = "Mayor Comprador:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.tickets_vip1;
            pictureBox2.Location = new Point(54, -11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 133);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // Frm_Grafica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 600);
            Controls.Add(panel1);
            Controls.Add(chart_Admin);
            Controls.Add(panel3);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Grafica";
            Padding = new Padding(5, 5, 5, 5);
            Text = "Frm_Grafica";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Btn_Close_Page).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_Admin).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private PictureBox Btn_Close_Page;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Admin;
        private Panel panel1;
        private Label label3;
        private Label label5;
        private PictureBox pictureBox2;
    }
}