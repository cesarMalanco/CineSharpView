namespace WinFormsFinalProject
{
    partial class FormMovie6
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
            lblPrice6 = new Label();
            txtPrice6 = new TextBox();
            txtStock6 = new TextBox();
            lblStock6 = new Label();
            btnAddCartMovie6 = new Button();
            rtxtMovie6 = new RichTextBox();
            pictureBox_Movie1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie1).BeginInit();
            SuspendLayout();
            // 
            // lblPrice6
            // 
            lblPrice6.AutoSize = true;
            lblPrice6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice6.ImageAlign = ContentAlignment.TopCenter;
            lblPrice6.Location = new Point(704, 91);
            lblPrice6.Name = "lblPrice6";
            lblPrice6.Size = new Size(38, 46);
            lblPrice6.TabIndex = 32;
            lblPrice6.Text = "$";
            lblPrice6.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPrice6
            // 
            txtPrice6.BorderStyle = BorderStyle.None;
            txtPrice6.Enabled = false;
            txtPrice6.Location = new Point(747, 97);
            txtPrice6.Margin = new Padding(3, 4, 3, 4);
            txtPrice6.Multiline = true;
            txtPrice6.Name = "txtPrice6";
            txtPrice6.Size = new Size(65, 43);
            txtPrice6.TabIndex = 31;
            // 
            // txtStock6
            // 
            txtStock6.BorderStyle = BorderStyle.None;
            txtStock6.Enabled = false;
            txtStock6.Location = new Point(771, 257);
            txtStock6.Margin = new Padding(3, 4, 3, 4);
            txtStock6.Multiline = true;
            txtStock6.Name = "txtStock6";
            txtStock6.Size = new Size(51, 31);
            txtStock6.TabIndex = 30;
            // 
            // lblStock6
            // 
            lblStock6.AutoSize = true;
            lblStock6.Location = new Point(705, 268);
            lblStock6.Name = "lblStock6";
            lblStock6.Size = new Size(64, 20);
            lblStock6.TabIndex = 29;
            lblStock6.Text = "Quedan:";
            // 
            // btnAddCartMovie6
            // 
            btnAddCartMovie6.BackColor = Color.DarkRed;
            btnAddCartMovie6.FlatAppearance.BorderSize = 0;
            btnAddCartMovie6.FlatAppearance.MouseDownBackColor = Color.White;
            btnAddCartMovie6.FlatAppearance.MouseOverBackColor = Color.Salmon;
            btnAddCartMovie6.FlatStyle = FlatStyle.Flat;
            btnAddCartMovie6.ForeColor = SystemColors.ControlLightLight;
            btnAddCartMovie6.Location = new Point(690, 315);
            btnAddCartMovie6.Margin = new Padding(3, 4, 3, 4);
            btnAddCartMovie6.Name = "btnAddCartMovie6";
            btnAddCartMovie6.Size = new Size(151, 52);
            btnAddCartMovie6.TabIndex = 28;
            btnAddCartMovie6.Text = "Añadir al carrito";
            btnAddCartMovie6.UseVisualStyleBackColor = false;
            btnAddCartMovie6.Click += btnAddCartMovie6_Click;
            // 
            // rtxtMovie6
            // 
            rtxtMovie6.BackColor = Color.FromArgb(255, 224, 192);
            rtxtMovie6.BorderStyle = BorderStyle.None;
            rtxtMovie6.Enabled = false;
            rtxtMovie6.Location = new Point(257, 69);
            rtxtMovie6.Margin = new Padding(3, 4, 3, 4);
            rtxtMovie6.Name = "rtxtMovie6";
            rtxtMovie6.ReadOnly = true;
            rtxtMovie6.Size = new Size(373, 320);
            rtxtMovie6.TabIndex = 27;
            rtxtMovie6.Text = "";
            rtxtMovie6.TextChanged += rtxtMovie6_TextChanged;
            // 
            // pictureBox_Movie1
            // 
            pictureBox_Movie1.Cursor = Cursors.Hand;
            pictureBox_Movie1.Location = new Point(26, 69);
            pictureBox_Movie1.Margin = new Padding(3, 4, 3, 4);
            pictureBox_Movie1.Name = "pictureBox_Movie1";
            pictureBox_Movie1.Size = new Size(199, 315);
            pictureBox_Movie1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Movie1.TabIndex = 33;
            pictureBox_Movie1.TabStop = false;
            // 
            // FormMovie6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox_Movie1);
            Controls.Add(lblPrice6);
            Controls.Add(txtPrice6);
            Controls.Add(txtStock6);
            Controls.Add(lblStock6);
            Controls.Add(btnAddCartMovie6);
            Controls.Add(rtxtMovie6);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMovie6";
            Text = "FormMovie6";
            Load += FormMovie6_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrice6;
        private TextBox txtPrice6;
        private TextBox txtStock6;
        private Label lblStock6;
        private Button btnAddCartMovie6;
        private RichTextBox rtxtMovie6;
        private PictureBox pictureBox_Movie1;
    }
}