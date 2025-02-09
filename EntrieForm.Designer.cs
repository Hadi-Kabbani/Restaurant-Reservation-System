namespace Restaurant_Reservation_System
{
    partial class EntrieForm
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
            btnLogin = new Button();
            btnSignUp = new Button();
            lblwelcome = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(55, 170);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 40);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            btnLogin.MouseEnter += Button_MouseEnter;
            btnLogin.MouseLeave += Button_MouseLeave;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.White;
            btnSignUp.ForeColor = Color.Black;
            btnSignUp.Location = new Point(212, 170);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(120, 40);
            btnSignUp.TabIndex = 1;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click_1;
            btnSignUp.MouseEnter += Button_MouseEnter;
            btnSignUp.MouseLeave += Button_MouseLeave;
            // 
            // lblwelcome
            // 
            lblwelcome.AutoSize = true;
            lblwelcome.BackColor = Color.Transparent;
            lblwelcome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblwelcome.ForeColor = Color.White;
            lblwelcome.Location = new Point(119, 130);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(153, 25);
            lblwelcome.TabIndex = 3;
            lblwelcome.Text = "Do You Want to";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.images2;
            pictureBox1.Location = new Point(28, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(119, 45);
            label1.Name = "label1";
            label1.Size = new Size(253, 31);
            label1.TabIndex = 5;
            label1.Text = "Niga restaurant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(181, 178);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 6;
            label2.Text = "or";
            // 
            // EntrieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(384, 261);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblwelcome);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogin);
            ForeColor = Color.Gold;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EntrieForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome to Our Application";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnSignUp;
        private Label lblwelcome;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}