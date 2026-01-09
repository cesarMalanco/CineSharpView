namespace WinFormsFinalProject
{
    partial class FormLoadingScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            progressBarLoadingScreen = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            labelLoading = new Label();
            labelPercentage = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBarLoadingScreen
            // 
            progressBarLoadingScreen.BackColor = Color.WhiteSmoke;
            progressBarLoadingScreen.ForeColor = Color.Firebrick;
            progressBarLoadingScreen.Location = new Point(131, 315);
            progressBarLoadingScreen.Margin = new Padding(3, 4, 3, 4);
            progressBarLoadingScreen.Name = "progressBarLoadingScreen";
            progressBarLoadingScreen.Size = new Size(323, 39);
            progressBarLoadingScreen.Style = ProgressBarStyle.Continuous;
            progressBarLoadingScreen.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 40;
            timer1.Tick += timer1_Tick;
            // 
            // labelLoading
            // 
            labelLoading.AutoSize = true;
            labelLoading.BackColor = Color.Transparent;
            labelLoading.Font = new Font("Myanmar Text", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelLoading.Location = new Point(131, 251);
            labelLoading.Name = "labelLoading";
            labelLoading.Size = new Size(142, 48);
            labelLoading.TabIndex = 1;
            labelLoading.Text = "Loading ...";
            // 
            // labelPercentage
            // 
            labelPercentage.AutoSize = true;
            labelPercentage.BackColor = Color.Transparent;
            labelPercentage.Font = new Font("Myanmar Text", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPercentage.Location = new Point(462, 323);
            labelPercentage.Name = "labelPercentage";
            labelPercentage.Size = new Size(21, 27);
            labelPercentage.TabIndex = 2;
            labelPercentage.Text = "0";
            labelPercentage.Click += labelPercentage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = WinFormsFinalProyect.Properties.Resources.popcorn;
            pictureBox1.Location = new Point(373, 197);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormLoadingScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(605, 432);
            Controls.Add(pictureBox1);
            Controls.Add(labelPercentage);
            Controls.Add(labelLoading);
            Controls.Add(progressBarLoadingScreen);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLoadingScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading Screen";
            Load += FormLoadingScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBarLoadingScreen;
        private System.Windows.Forms.Timer timer1;
        private Label labelLoading;
        private Label labelPercentage;
        private PictureBox pictureBox1;
    }
}
