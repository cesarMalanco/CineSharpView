namespace WinFormsFinalProject
{
    partial class FormMovie5
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
            lblPrice5 = new Label();
            txtPrice5 = new TextBox();
            txtStock5 = new TextBox();
            lblStock5 = new Label();
            btnAddCartMovie5 = new Button();
            rtxtMovie5 = new RichTextBox();
            pictureBox_Movie1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie1).BeginInit();
            SuspendLayout();
            // 
            // lblPrice5
            // 
            lblPrice5.AutoSize = true;
            lblPrice5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice5.ImageAlign = ContentAlignment.TopCenter;
            lblPrice5.Location = new Point(707, 93);
            lblPrice5.Name = "lblPrice5";
            lblPrice5.Size = new Size(38, 46);
            lblPrice5.TabIndex = 25;
            lblPrice5.Text = "$";
            lblPrice5.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPrice5
            // 
            txtPrice5.BorderStyle = BorderStyle.None;
            txtPrice5.Enabled = false;
            txtPrice5.Location = new Point(751, 100);
            txtPrice5.Margin = new Padding(3, 4, 3, 4);
            txtPrice5.Multiline = true;
            txtPrice5.Name = "txtPrice5";
            txtPrice5.Size = new Size(65, 43);
            txtPrice5.TabIndex = 24;
            // 
            // txtStock5
            // 
            txtStock5.BorderStyle = BorderStyle.None;
            txtStock5.Enabled = false;
            txtStock5.Location = new Point(775, 260);
            txtStock5.Margin = new Padding(3, 4, 3, 4);
            txtStock5.Multiline = true;
            txtStock5.Name = "txtStock5";
            txtStock5.Size = new Size(51, 31);
            txtStock5.TabIndex = 23;
            // 
            // lblStock5
            // 
            lblStock5.AutoSize = true;
            lblStock5.Location = new Point(709, 271);
            lblStock5.Name = "lblStock5";
            lblStock5.Size = new Size(64, 20);
            lblStock5.TabIndex = 22;
            lblStock5.Text = "Quedan:";
            // 
            // btnAddCartMovie5
            // 
            btnAddCartMovie5.BackColor = Color.DarkRed;
            btnAddCartMovie5.FlatAppearance.BorderSize = 0;
            btnAddCartMovie5.FlatAppearance.MouseDownBackColor = Color.White;
            btnAddCartMovie5.FlatAppearance.MouseOverBackColor = Color.Salmon;
            btnAddCartMovie5.FlatStyle = FlatStyle.Flat;
            btnAddCartMovie5.ForeColor = SystemColors.ControlLightLight;
            btnAddCartMovie5.Location = new Point(694, 317);
            btnAddCartMovie5.Margin = new Padding(3, 4, 3, 4);
            btnAddCartMovie5.Name = "btnAddCartMovie5";
            btnAddCartMovie5.Size = new Size(151, 52);
            btnAddCartMovie5.TabIndex = 21;
            btnAddCartMovie5.Text = "Añadir al carrito";
            btnAddCartMovie5.UseVisualStyleBackColor = false;
            btnAddCartMovie5.Click += btnAddCartMovie5_Click;
            // 
            // rtxtMovie5
            // 
            rtxtMovie5.BackColor = Color.FromArgb(255, 224, 192);
            rtxtMovie5.BorderStyle = BorderStyle.None;
            rtxtMovie5.Enabled = false;
            rtxtMovie5.Location = new Point(261, 72);
            rtxtMovie5.Margin = new Padding(3, 4, 3, 4);
            rtxtMovie5.Name = "rtxtMovie5";
            rtxtMovie5.ReadOnly = true;
            rtxtMovie5.Size = new Size(373, 320);
            rtxtMovie5.TabIndex = 20;
            rtxtMovie5.Text = "";
            // 
            // pictureBox_Movie1
            // 
            pictureBox_Movie1.Cursor = Cursors.Hand;
            pictureBox_Movie1.Location = new Point(37, 72);
            pictureBox_Movie1.Margin = new Padding(3, 4, 3, 4);
            pictureBox_Movie1.Name = "pictureBox_Movie1";
            pictureBox_Movie1.Size = new Size(199, 315);
            pictureBox_Movie1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Movie1.TabIndex = 26;
            pictureBox_Movie1.TabStop = false;
            // 
            // FormMovie5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox_Movie1);
            Controls.Add(lblPrice5);
            Controls.Add(txtPrice5);
            Controls.Add(txtStock5);
            Controls.Add(lblStock5);
            Controls.Add(btnAddCartMovie5);
            Controls.Add(rtxtMovie5);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMovie5";
            Text = "FormMovie5";
            Load += FormMovie5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrice5;
        private TextBox txtPrice5;
        private TextBox txtStock5;
        private Label lblStock5;
        private Button btnAddCartMovie5;
        private RichTextBox rtxtMovie5;
        private PictureBox pictureBox_Movie1;
    }
}