namespace WinFormsFinalProject
{
    partial class FormMovie7
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
            lblPrice7 = new Label();
            txtPrice7 = new TextBox();
            txtStock7 = new TextBox();
            lblStock7 = new Label();
            btnAddCartMovie7 = new Button();
            rtxtMovie7 = new RichTextBox();
            pictureBox_Movie1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie1).BeginInit();
            SuspendLayout();
            // 
            // lblPrice7
            // 
            lblPrice7.AutoSize = true;
            lblPrice7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice7.ImageAlign = ContentAlignment.TopCenter;
            lblPrice7.Location = new Point(704, 92);
            lblPrice7.Name = "lblPrice7";
            lblPrice7.Size = new Size(38, 46);
            lblPrice7.TabIndex = 39;
            lblPrice7.Text = "$";
            lblPrice7.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPrice7
            // 
            txtPrice7.BorderStyle = BorderStyle.None;
            txtPrice7.Enabled = false;
            txtPrice7.Location = new Point(747, 99);
            txtPrice7.Margin = new Padding(3, 4, 3, 4);
            txtPrice7.Multiline = true;
            txtPrice7.Name = "txtPrice7";
            txtPrice7.Size = new Size(65, 43);
            txtPrice7.TabIndex = 38;
            // 
            // txtStock7
            // 
            txtStock7.BorderStyle = BorderStyle.None;
            txtStock7.Enabled = false;
            txtStock7.Location = new Point(771, 259);
            txtStock7.Margin = new Padding(3, 4, 3, 4);
            txtStock7.Multiline = true;
            txtStock7.Name = "txtStock7";
            txtStock7.Size = new Size(51, 31);
            txtStock7.TabIndex = 37;
            // 
            // lblStock7
            // 
            lblStock7.AutoSize = true;
            lblStock7.Location = new Point(705, 269);
            lblStock7.Name = "lblStock7";
            lblStock7.Size = new Size(64, 20);
            lblStock7.TabIndex = 36;
            lblStock7.Text = "Quedan:";
            // 
            // btnAddCartMovie7
            // 
            btnAddCartMovie7.BackColor = Color.DarkRed;
            btnAddCartMovie7.FlatAppearance.BorderSize = 0;
            btnAddCartMovie7.FlatAppearance.MouseDownBackColor = Color.White;
            btnAddCartMovie7.FlatAppearance.MouseOverBackColor = Color.Salmon;
            btnAddCartMovie7.FlatStyle = FlatStyle.Flat;
            btnAddCartMovie7.ForeColor = SystemColors.ControlLightLight;
            btnAddCartMovie7.Location = new Point(690, 316);
            btnAddCartMovie7.Margin = new Padding(3, 4, 3, 4);
            btnAddCartMovie7.Name = "btnAddCartMovie7";
            btnAddCartMovie7.Size = new Size(151, 52);
            btnAddCartMovie7.TabIndex = 35;
            btnAddCartMovie7.Text = "Añadir al carrito";
            btnAddCartMovie7.UseVisualStyleBackColor = false;
            btnAddCartMovie7.Click += btnAddCartMovie7_Click;
            // 
            // rtxtMovie7
            // 
            rtxtMovie7.BackColor = Color.FromArgb(255, 224, 192);
            rtxtMovie7.BorderStyle = BorderStyle.None;
            rtxtMovie7.Enabled = false;
            rtxtMovie7.Location = new Point(258, 72);
            rtxtMovie7.Margin = new Padding(3, 4, 3, 4);
            rtxtMovie7.Name = "rtxtMovie7";
            rtxtMovie7.ReadOnly = true;
            rtxtMovie7.Size = new Size(373, 320);
            rtxtMovie7.TabIndex = 34;
            rtxtMovie7.Text = "";
            rtxtMovie7.TextChanged += rtxtMovie7_TextChanged;
            // 
            // pictureBox_Movie1
            // 
            pictureBox_Movie1.Cursor = Cursors.Hand;
            pictureBox_Movie1.Location = new Point(26, 72);
            pictureBox_Movie1.Margin = new Padding(3, 4, 3, 4);
            pictureBox_Movie1.Name = "pictureBox_Movie1";
            pictureBox_Movie1.Size = new Size(199, 315);
            pictureBox_Movie1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Movie1.TabIndex = 40;
            pictureBox_Movie1.TabStop = false;
            // 
            // FormMovie7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox_Movie1);
            Controls.Add(lblPrice7);
            Controls.Add(txtPrice7);
            Controls.Add(txtStock7);
            Controls.Add(lblStock7);
            Controls.Add(btnAddCartMovie7);
            Controls.Add(rtxtMovie7);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMovie7";
            Text = "FormMovie7";
            Load += FormMovie7_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrice7;
        private TextBox txtPrice7;
        private TextBox txtStock7;
        private Label lblStock7;
        private Button btnAddCartMovie7;
        private RichTextBox rtxtMovie7;
        private PictureBox pictureBox_Movie1;
    }
}