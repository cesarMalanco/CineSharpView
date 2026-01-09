namespace WinFormsFinalProject
{
    partial class FormMovie3
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
            lblPrice3 = new Label();
            txtPrice3 = new TextBox();
            txtStock3 = new TextBox();
            lblStock3 = new Label();
            btnAddCartMovie3 = new Button();
            rtxtMovie3 = new RichTextBox();
            pictureBox_Movie1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie1).BeginInit();
            SuspendLayout();
            // 
            // lblPrice3
            // 
            lblPrice3.AutoSize = true;
            lblPrice3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice3.ImageAlign = ContentAlignment.TopCenter;
            lblPrice3.Location = new Point(711, 96);
            lblPrice3.Name = "lblPrice3";
            lblPrice3.Size = new Size(38, 46);
            lblPrice3.TabIndex = 23;
            lblPrice3.Text = "$";
            lblPrice3.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPrice3
            // 
            txtPrice3.BorderStyle = BorderStyle.None;
            txtPrice3.Enabled = false;
            txtPrice3.Location = new Point(754, 103);
            txtPrice3.Margin = new Padding(3, 4, 3, 4);
            txtPrice3.Multiline = true;
            txtPrice3.Name = "txtPrice3";
            txtPrice3.Size = new Size(65, 43);
            txtPrice3.TabIndex = 22;
            // 
            // txtStock3
            // 
            txtStock3.BorderStyle = BorderStyle.None;
            txtStock3.Enabled = false;
            txtStock3.Location = new Point(778, 263);
            txtStock3.Margin = new Padding(3, 4, 3, 4);
            txtStock3.Multiline = true;
            txtStock3.Name = "txtStock3";
            txtStock3.Size = new Size(51, 31);
            txtStock3.TabIndex = 21;
            // 
            // lblStock3
            // 
            lblStock3.AutoSize = true;
            lblStock3.Location = new Point(712, 273);
            lblStock3.Name = "lblStock3";
            lblStock3.Size = new Size(64, 20);
            lblStock3.TabIndex = 20;
            lblStock3.Text = "Quedan:";
            // 
            // btnAddCartMovie3
            // 
            btnAddCartMovie3.BackColor = Color.DarkRed;
            btnAddCartMovie3.FlatAppearance.BorderSize = 0;
            btnAddCartMovie3.FlatAppearance.MouseDownBackColor = Color.White;
            btnAddCartMovie3.FlatAppearance.MouseOverBackColor = Color.Salmon;
            btnAddCartMovie3.FlatStyle = FlatStyle.Flat;
            btnAddCartMovie3.ForeColor = SystemColors.ControlLightLight;
            btnAddCartMovie3.Location = new Point(697, 320);
            btnAddCartMovie3.Margin = new Padding(3, 4, 3, 4);
            btnAddCartMovie3.Name = "btnAddCartMovie3";
            btnAddCartMovie3.Size = new Size(151, 52);
            btnAddCartMovie3.TabIndex = 19;
            btnAddCartMovie3.Text = "Añadir al carrito";
            btnAddCartMovie3.UseVisualStyleBackColor = false;
            btnAddCartMovie3.Click += btnAddCartMovie3_Click;
            // 
            // rtxtMovie3
            // 
            rtxtMovie3.BackColor = Color.FromArgb(255, 224, 192);
            rtxtMovie3.BorderStyle = BorderStyle.None;
            rtxtMovie3.Enabled = false;
            rtxtMovie3.Location = new Point(270, 72);
            rtxtMovie3.Margin = new Padding(3, 4, 3, 4);
            rtxtMovie3.Name = "rtxtMovie3";
            rtxtMovie3.ReadOnly = true;
            rtxtMovie3.Size = new Size(373, 320);
            rtxtMovie3.TabIndex = 18;
            rtxtMovie3.Text = "";
            // 
            // pictureBox_Movie1
            // 
            pictureBox_Movie1.Cursor = Cursors.Hand;
            pictureBox_Movie1.Location = new Point(48, 72);
            pictureBox_Movie1.Margin = new Padding(3, 4, 3, 4);
            pictureBox_Movie1.Name = "pictureBox_Movie1";
            pictureBox_Movie1.Size = new Size(199, 315);
            pictureBox_Movie1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Movie1.TabIndex = 24;
            pictureBox_Movie1.TabStop = false;
            // 
            // FormMovie3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox_Movie1);
            Controls.Add(lblPrice3);
            Controls.Add(txtPrice3);
            Controls.Add(txtStock3);
            Controls.Add(lblStock3);
            Controls.Add(btnAddCartMovie3);
            Controls.Add(rtxtMovie3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMovie3";
            Text = "FormMovie3";
            Load += FormMovie3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrice3;
        private TextBox txtPrice3;
        private TextBox txtStock3;
        private Label lblStock3;
        private Button btnAddCartMovie3;
        private RichTextBox rtxtMovie3;
        private PictureBox pictureBox_Movie1;
    }
}