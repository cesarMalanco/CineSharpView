namespace WinFormsFinalProject
{
    partial class FormMovie2
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
            rtxtMovie2 = new RichTextBox();
            lblPrice2 = new Label();
            txtPrice2 = new TextBox();
            txtStock2 = new TextBox();
            lblStock2 = new Label();
            btnAddCartMovie2 = new Button();
            pictureBox_Movie1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie1).BeginInit();
            SuspendLayout();
            // 
            // rtxtMovie2
            // 
            rtxtMovie2.BackColor = Color.FromArgb(255, 224, 192);
            rtxtMovie2.BorderStyle = BorderStyle.None;
            rtxtMovie2.Enabled = false;
            rtxtMovie2.Location = new Point(269, 69);
            rtxtMovie2.Margin = new Padding(3, 4, 3, 4);
            rtxtMovie2.Name = "rtxtMovie2";
            rtxtMovie2.ReadOnly = true;
            rtxtMovie2.Size = new Size(373, 320);
            rtxtMovie2.TabIndex = 10;
            rtxtMovie2.Text = "";
            // 
            // lblPrice2
            // 
            lblPrice2.AutoSize = true;
            lblPrice2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice2.ImageAlign = ContentAlignment.TopCenter;
            lblPrice2.Location = new Point(709, 96);
            lblPrice2.Name = "lblPrice2";
            lblPrice2.Size = new Size(38, 46);
            lblPrice2.TabIndex = 16;
            lblPrice2.Text = "$";
            lblPrice2.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPrice2
            // 
            txtPrice2.BorderStyle = BorderStyle.None;
            txtPrice2.Enabled = false;
            txtPrice2.Location = new Point(752, 103);
            txtPrice2.Margin = new Padding(3, 4, 3, 4);
            txtPrice2.Multiline = true;
            txtPrice2.Name = "txtPrice2";
            txtPrice2.Size = new Size(65, 43);
            txtPrice2.TabIndex = 15;
            // 
            // txtStock2
            // 
            txtStock2.BorderStyle = BorderStyle.None;
            txtStock2.Enabled = false;
            txtStock2.Location = new Point(776, 263);
            txtStock2.Margin = new Padding(3, 4, 3, 4);
            txtStock2.Multiline = true;
            txtStock2.Name = "txtStock2";
            txtStock2.Size = new Size(51, 31);
            txtStock2.TabIndex = 14;
            // 
            // lblStock2
            // 
            lblStock2.AutoSize = true;
            lblStock2.Location = new Point(710, 273);
            lblStock2.Name = "lblStock2";
            lblStock2.Size = new Size(64, 20);
            lblStock2.TabIndex = 13;
            lblStock2.Text = "Quedan:";
            // 
            // btnAddCartMovie2
            // 
            btnAddCartMovie2.BackColor = Color.DarkRed;
            btnAddCartMovie2.FlatAppearance.BorderSize = 0;
            btnAddCartMovie2.FlatAppearance.MouseDownBackColor = Color.White;
            btnAddCartMovie2.FlatAppearance.MouseOverBackColor = Color.Salmon;
            btnAddCartMovie2.FlatStyle = FlatStyle.Flat;
            btnAddCartMovie2.ForeColor = SystemColors.ControlLightLight;
            btnAddCartMovie2.Location = new Point(695, 320);
            btnAddCartMovie2.Margin = new Padding(3, 4, 3, 4);
            btnAddCartMovie2.Name = "btnAddCartMovie2";
            btnAddCartMovie2.Size = new Size(151, 52);
            btnAddCartMovie2.TabIndex = 12;
            btnAddCartMovie2.Text = "Añadir al carrito";
            btnAddCartMovie2.UseVisualStyleBackColor = false;
            btnAddCartMovie2.Click += btnAddCartMovie2_Click;
            // 
            // pictureBox_Movie1
            // 
            pictureBox_Movie1.Cursor = Cursors.Hand;
            pictureBox_Movie1.Location = new Point(41, 69);
            pictureBox_Movie1.Margin = new Padding(3, 4, 3, 4);
            pictureBox_Movie1.Name = "pictureBox_Movie1";
            pictureBox_Movie1.Size = new Size(199, 315);
            pictureBox_Movie1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Movie1.TabIndex = 17;
            pictureBox_Movie1.TabStop = false;
            // 
            // FormMovie2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 655);
            Controls.Add(pictureBox_Movie1);
            Controls.Add(lblPrice2);
            Controls.Add(txtPrice2);
            Controls.Add(txtStock2);
            Controls.Add(lblStock2);
            Controls.Add(btnAddCartMovie2);
            Controls.Add(rtxtMovie2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMovie2";
            Text = "FormMovie2";
            Load += FormMovie2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox rtxtMovie2;
        private Label lblPrice2;
        private TextBox txtPrice2;
        private TextBox txtStock2;
        private Label lblStock2;
        private Button btnAddCartMovie2;
        private PictureBox pictureBox_Movie1;
    }
}