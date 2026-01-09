namespace WinFormsFinalProject
{
    partial class FormMainPage
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
            panelHead = new Panel();
            label1 = new Label();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            btnLogOut = new Button();
            label6 = new Label();
            btnMP_Movies = new Button();
            btnMP_Food = new Button();
            btnMP_Home = new Button();
            panelMP = new Panel();
            label2 = new Label();
            panelCartButton = new Panel();
            btnSeeCart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMP.SuspendLayout();
            panelCartButton.SuspendLayout();
            SuspendLayout();
            // 
            // panelHead
            // 
            panelHead.BackColor = Color.DarkRed;
            panelHead.Controls.Add(label1);
            panelHead.Controls.Add(label9);
            panelHead.Controls.Add(label7);
            panelHead.Controls.Add(label8);
            panelHead.Controls.Add(pictureBox1);
            panelHead.Controls.Add(btnLogOut);
            panelHead.Controls.Add(label6);
            panelHead.Controls.Add(btnMP_Movies);
            panelHead.Controls.Add(btnMP_Food);
            panelHead.Controls.Add(btnMP_Home);
            panelHead.Location = new Point(0, 0);
            panelHead.Margin = new Padding(3, 4, 3, 4);
            panelHead.Name = "panelHead";
            panelHead.Size = new Size(914, 105);
            panelHead.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(569, 63);
            label1.Name = "label1";
            label1.Size = new Size(181, 23);
            label1.TabIndex = 15;
            label1.Text = "Cine Sharp View User";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(43, 25);
            label9.Name = "label9";
            label9.Size = new Size(251, 15);
            label9.TabIndex = 14;
            label9.Text = "No hay nada mas sharp que nuestras pantallas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(557, 7);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 10;
            label7.Text = "Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(43, 4);
            label8.Name = "label8";
            label8.Size = new Size(141, 23);
            label8.TabIndex = 13;
            label8.Text = "Cine Sharp View";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = WinFormsFinalProyect.Properties.Resources.download;
            pictureBox1.Location = new Point(11, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            btnLogOut.ForeColor = SystemColors.ButtonHighlight;
            btnLogOut.Location = new Point(833, 36);
            btnLogOut.Margin = new Padding(3, 4, 3, 4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(67, 39);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(800, 7);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 9;
            label6.Text = "Time";
            // 
            // btnMP_Movies
            // 
            btnMP_Movies.FlatAppearance.BorderSize = 0;
            btnMP_Movies.FlatStyle = FlatStyle.Flat;
            btnMP_Movies.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMP_Movies.ForeColor = SystemColors.ButtonHighlight;
            btnMP_Movies.Location = new Point(213, 59);
            btnMP_Movies.Margin = new Padding(3, 4, 3, 4);
            btnMP_Movies.Name = "btnMP_Movies";
            btnMP_Movies.Size = new Size(107, 31);
            btnMP_Movies.TabIndex = 3;
            btnMP_Movies.Text = "Cartelera";
            btnMP_Movies.UseVisualStyleBackColor = true;
            btnMP_Movies.Click += btnMP_Movies_Click;
            // 
            // btnMP_Food
            // 
            btnMP_Food.FlatAppearance.BorderSize = 0;
            btnMP_Food.FlatStyle = FlatStyle.Flat;
            btnMP_Food.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMP_Food.ForeColor = SystemColors.ButtonHighlight;
            btnMP_Food.Location = new Point(394, 59);
            btnMP_Food.Margin = new Padding(3, 4, 3, 4);
            btnMP_Food.Name = "btnMP_Food";
            btnMP_Food.Size = new Size(105, 31);
            btnMP_Food.TabIndex = 2;
            btnMP_Food.Text = "Dulcería";
            btnMP_Food.UseVisualStyleBackColor = true;
            btnMP_Food.Click += btnMP_Food_Click;
            // 
            // btnMP_Home
            // 
            btnMP_Home.FlatAppearance.BorderSize = 0;
            btnMP_Home.FlatStyle = FlatStyle.Flat;
            btnMP_Home.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMP_Home.ForeColor = SystemColors.ButtonHighlight;
            btnMP_Home.Location = new Point(59, 59);
            btnMP_Home.Margin = new Padding(3, 4, 3, 4);
            btnMP_Home.Name = "btnMP_Home";
            btnMP_Home.Size = new Size(86, 31);
            btnMP_Home.TabIndex = 1;
            btnMP_Home.Text = "Inicio";
            btnMP_Home.UseVisualStyleBackColor = true;
            btnMP_Home.Click += btnMP_Home_Click;
            // 
            // panelMP
            // 
            panelMP.AutoScroll = true;
            panelMP.BackColor = SystemColors.Control;
            panelMP.Controls.Add(label2);
            panelMP.Controls.Add(panelCartButton);
            panelMP.Dock = DockStyle.Bottom;
            panelMP.Location = new Point(0, 97);
            panelMP.Margin = new Padding(3, 4, 3, 4);
            panelMP.Name = "panelMP";
            panelMP.Size = new Size(914, 503);
            panelMP.TabIndex = 1;
            panelMP.Paint += panelMP_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(43, 31);
            label2.Name = "label2";
            label2.Size = new Size(623, 50);
            label2.TabIndex = 16;
            label2.Text = "¡Bienvenido Cine Sharp View User!";
            label2.Click += label2_Click;
            // 
            // panelCartButton
            // 
            panelCartButton.BackColor = SystemColors.ActiveCaption;
            panelCartButton.Controls.Add(btnSeeCart);
            panelCartButton.Location = new Point(706, 412);
            panelCartButton.Margin = new Padding(3, 4, 3, 4);
            panelCartButton.Name = "panelCartButton";
            panelCartButton.Size = new Size(185, 75);
            panelCartButton.TabIndex = 0;
            // 
            // btnSeeCart
            // 
            btnSeeCart.BackColor = Color.Brown;
            btnSeeCart.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeeCart.ForeColor = SystemColors.ButtonHighlight;
            btnSeeCart.Location = new Point(0, 0);
            btnSeeCart.Margin = new Padding(3, 4, 3, 4);
            btnSeeCart.Name = "btnSeeCart";
            btnSeeCart.Size = new Size(185, 75);
            btnSeeCart.TabIndex = 0;
            btnSeeCart.Text = "Carrito";
            btnSeeCart.UseVisualStyleBackColor = false;
            btnSeeCart.Click += btnSeeCart_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // FormMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panelMP);
            Controls.Add(panelHead);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMainPage";
            Load += FormMainPage_Load;
            panelHead.ResumeLayout(false);
            panelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMP.ResumeLayout(false);
            panelMP.PerformLayout();
            panelCartButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHead;
        private Button btnMP_Home;
        private Button btnMP_Food;
        private Button btnMP_Movies;
        public Panel panelMP;
        private Button btnLogOut;
        private Panel panelCartButton;
        private Button btnSeeCart;
        private Label label7;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}