namespace WinFormsFinalProject
{
    partial class FormHome
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
            label2 = new Label();
            labeln = new Label();
            cart = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(109, 147);
            label2.Name = "label2";
            label2.Size = new Size(0, 60);
            label2.TabIndex = 17;
            label2.Click += label2_Click;
            // 
            // labeln
            // 
            labeln.AutoSize = true;
            labeln.BackColor = Color.Transparent;
            labeln.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labeln.ForeColor = Color.DarkRed;
            labeln.Location = new Point(12, 9);
            labeln.Name = "labeln";
            labeln.Size = new Size(672, 54);
            labeln.TabIndex = 18;
            labeln.Text = "¡Bienvenido Cine Sharp View User!";
            labeln.Click += labeln_Click;
            // 
            // cart
            // 
            cart.BackColor = Color.Brown;
            cart.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cart.ForeColor = SystemColors.ButtonHighlight;
            cart.Location = new Point(694, 400);
            cart.Margin = new Padding(3, 4, 3, 4);
            cart.Name = "cart";
            cart.Size = new Size(185, 75);
            cart.TabIndex = 19;
            cart.Text = "Carrito";
            cart.UseVisualStyleBackColor = false;
            cart.Click += cart_Click_1;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(891, 488);
            Controls.Add(cart);
            Controls.Add(labeln);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormHome";
            Text = "FormHome";
            Load += FormHome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label labeln;
        private Button cart;
    }
}