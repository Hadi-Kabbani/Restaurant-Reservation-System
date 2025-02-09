namespace Restaurant_Reservation_System
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnLogout;
        private Button btnReport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnLogout = new Button();
            btnReport = new Button();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            tabPageAvailableTables = new TabPage();
            pictureBox3 = new PictureBox();
            btnMakeReservation = new Button();
            dgvAvailableTables = new DataGridView();
            tabPageProfile = new TabPage();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblProfileTitle = new Label();
            tabControl = new TabControl();
            tabPageYourReservations = new TabPage();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            dgvYourReservations = new DataGridView();
            btnCancelReservation = new Button();
            tabPageNotification = new TabPage();
            pictureBox7 = new PictureBox();
            dgvNotifications = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPageAvailableTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableTables).BeginInit();
            tabPageProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl.SuspendLayout();
            tabPageYourReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvYourReservations).BeginInit();
            tabPageNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(693, 433);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            btnLogout.MouseEnter += Button_MouseEnter;
            btnLogout.MouseLeave += Button_MouseLeave;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(602, 433);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(75, 23);
            btnReport.TabIndex = 3;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            btnReport.MouseEnter += Button_MouseEnter;
            btnReport.MouseLeave += Button_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.images1;
            pictureBox2.Location = new Point(0, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Script MT Bold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(78, 9);
            label5.Name = "label5";
            label5.Size = new Size(232, 23);
            label5.TabIndex = 5;
            label5.Text = "Welcome to Niga Restaurant";
            // 
            // tabPageAvailableTables
            // 
            tabPageAvailableTables.BackColor = Color.Black;
            tabPageAvailableTables.Controls.Add(pictureBox3);
            tabPageAvailableTables.Controls.Add(btnMakeReservation);
            tabPageAvailableTables.Controls.Add(dgvAvailableTables);
            tabPageAvailableTables.Location = new Point(4, 24);
            tabPageAvailableTables.Name = "tabPageAvailableTables";
            tabPageAvailableTables.Padding = new Padding(3);
            tabPageAvailableTables.Size = new Size(752, 352);
            tabPageAvailableTables.TabIndex = 2;
            tabPageAvailableTables.Text = "Available Tables";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.images__8_;
            pictureBox3.Location = new Point(399, 78);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(275, 184);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // btnMakeReservation
            // 
            btnMakeReservation.Location = new Point(628, 287);
            btnMakeReservation.Name = "btnMakeReservation";
            btnMakeReservation.Size = new Size(87, 46);
            btnMakeReservation.TabIndex = 1;
            btnMakeReservation.Text = "Make a Reservation";
            btnMakeReservation.UseVisualStyleBackColor = true;
            btnMakeReservation.Click += btnMakeReservation_Click;
            btnMakeReservation.MouseEnter += Button_MouseEnter;
            btnMakeReservation.MouseLeave += Button_MouseLeave;
            // 
            // dgvAvailableTables
            // 
            dgvAvailableTables.BackgroundColor = Color.Black;
            dgvAvailableTables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableTables.Dock = DockStyle.Fill;
            dgvAvailableTables.Location = new Point(3, 3);
            dgvAvailableTables.Name = "dgvAvailableTables";
            dgvAvailableTables.Size = new Size(746, 346);
            dgvAvailableTables.TabIndex = 0;
            // 
            // tabPageProfile
            // 
            tabPageProfile.BackColor = Color.Black;
            tabPageProfile.Controls.Add(pictureBox1);
            tabPageProfile.Controls.Add(label4);
            tabPageProfile.Controls.Add(label3);
            tabPageProfile.Controls.Add(label2);
            tabPageProfile.Controls.Add(label1);
            tabPageProfile.Controls.Add(btnSave);
            tabPageProfile.Controls.Add(txtLastName);
            tabPageProfile.Controls.Add(txtFirstName);
            tabPageProfile.Controls.Add(txtPassword);
            tabPageProfile.Controls.Add(txtEmail);
            tabPageProfile.Controls.Add(lblProfileTitle);
            tabPageProfile.Location = new Point(4, 24);
            tabPageProfile.Name = "tabPageProfile";
            tabPageProfile.Padding = new Padding(3);
            tabPageProfile.Size = new Size(752, 352);
            tabPageProfile.TabIndex = 1;
            tabPageProfile.Text = "Profile";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(416, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 349);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.White;
            label4.Location = new Point(219, 196);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 10;
            label4.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 196);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 9;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            label2.Location = new Point(219, 142);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 142);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 7;
            label1.Text = "Email";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(316, 259);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            btnSave.MouseEnter += Button_MouseEnter;
            btnSave.MouseLeave += Button_MouseLeave;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(288, 188);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(80, 188);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(288, 134);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(80, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 2;
            // 
            // lblProfileTitle
            // 
            lblProfileTitle.AutoSize = true;
            lblProfileTitle.BackColor = Color.Black;
            lblProfileTitle.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfileTitle.ForeColor = Color.White;
            lblProfileTitle.Location = new Point(10, 48);
            lblProfileTitle.Name = "lblProfileTitle";
            lblProfileTitle.Size = new Size(381, 32);
            lblProfileTitle.TabIndex = 1;
            lblProfileTitle.Text = "Welcome to Your Profile";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageAvailableTables);
            tabControl.Controls.Add(tabPageProfile);
            tabControl.Controls.Add(tabPageYourReservations);
            tabControl.Controls.Add(tabPageNotification);
            tabControl.Location = new Point(12, 51);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(760, 380);
            tabControl.TabIndex = 0;
            // 
            // tabPageYourReservations
            // 
            tabPageYourReservations.BackColor = Color.Black;
            tabPageYourReservations.Controls.Add(pictureBox4);
            tabPageYourReservations.Controls.Add(pictureBox6);
            tabPageYourReservations.Controls.Add(dgvYourReservations);
            tabPageYourReservations.Controls.Add(btnCancelReservation);
            tabPageYourReservations.Location = new Point(4, 24);
            tabPageYourReservations.Name = "tabPageYourReservations";
            tabPageYourReservations.Padding = new Padding(3);
            tabPageYourReservations.Size = new Size(752, 352);
            tabPageYourReservations.TabIndex = 3;
            tabPageYourReservations.Text = "Your Reservations";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(449, 106);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(300, 168);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.images__9_1;
            pictureBox6.Location = new Point(0, 184);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(300, 168);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // dgvYourReservations
            // 
            dgvYourReservations.AllowDrop = true;
            dgvYourReservations.AllowUserToAddRows = false;
            dgvYourReservations.AllowUserToOrderColumns = true;
            dgvYourReservations.AllowUserToResizeColumns = false;
            dgvYourReservations.AllowUserToResizeRows = false;
            dgvYourReservations.BackgroundColor = Color.Black;
            dgvYourReservations.Location = new Point(0, 0);
            dgvYourReservations.Name = "dgvYourReservations";
            dgvYourReservations.RowTemplate.Height = 25;
            dgvYourReservations.Size = new Size(399, 90);
            dgvYourReservations.TabIndex = 0;
            // 
            // btnCancelReservation
            // 
            btnCancelReservation.Location = new Point(504, 30);
            btnCancelReservation.Name = "btnCancelReservation";
            btnCancelReservation.Size = new Size(157, 35);
            btnCancelReservation.TabIndex = 1;
            btnCancelReservation.Text = "Cancel The Reservation";
            btnCancelReservation.UseVisualStyleBackColor = true;
            btnCancelReservation.Click += btnCancelReservation_Click;
            btnCancelReservation.MouseEnter += Button_MouseEnter;
            btnCancelReservation.MouseLeave += Button_MouseLeave;
            // 
            // tabPageNotification
            // 
            tabPageNotification.BackColor = Color.Black;
            tabPageNotification.Controls.Add(pictureBox7);
            tabPageNotification.Controls.Add(dgvNotifications);
            tabPageNotification.Location = new Point(4, 24);
            tabPageNotification.Name = "tabPageNotification";
            tabPageNotification.Padding = new Padding(3);
            tabPageNotification.Size = new Size(752, 352);
            tabPageNotification.TabIndex = 4;
            tabPageNotification.Text = "Notification";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.images__7_;
            pictureBox7.Location = new Point(254, 169);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(275, 183);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 2;
            pictureBox7.TabStop = false;
            // 
            // dgvNotifications
            // 
            dgvNotifications.AllowUserToAddRows = false;
            dgvNotifications.AllowUserToDeleteRows = false;
            dgvNotifications.AllowUserToResizeColumns = false;
            dgvNotifications.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dgvNotifications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvNotifications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotifications.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvNotifications.BackgroundColor = Color.Black;
            dgvNotifications.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvNotifications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvNotifications.Location = new Point(0, 0);
            dgvNotifications.MultiSelect = false;
            dgvNotifications.Name = "dgvNotifications";
            dgvNotifications.ReadOnly = true;
            dgvNotifications.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.White;
            dgvNotifications.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvNotifications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotifications.Size = new Size(752, 114);
            dgvNotifications.TabIndex = 0;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(btnReport);
            Controls.Add(btnLogout);
            Controls.Add(tabControl);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPageAvailableTables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableTables).EndInit();
            tabPageProfile.ResumeLayout(false);
            tabPageProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl.ResumeLayout(false);
            tabPageYourReservations.ResumeLayout(false);
            tabPageYourReservations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvYourReservations).EndInit();
            tabPageNotification.ResumeLayout(false);
            tabPageNotification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = Color.LightBlue;
                button.ForeColor = Color.White;
                button.FlatAppearance.BorderColor = Color.White;
                button.FlatAppearance.BorderSize = 1;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = SystemColors.Control; // Default color
                button.ForeColor = Color.Black;
                button.FlatAppearance.BorderColor = SystemColors.ControlDark; // Default border color
                button.FlatAppearance.BorderSize = 1; // Default border size
            }
        }

        private PictureBox pictureBox2;
        private Label label5;
        private TabPage tabPageAvailableTables;
        private PictureBox pictureBox3;
        private Button btnMakeReservation;
        private DataGridView dgvAvailableTables;
        private TabPage tabPageProfile;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblProfileTitle;
        private TabControl tabControl;
        private TabPage tabPageYourReservations;
        private DataGridView dgvYourReservations;
        private Button btnCancelReservation;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private TabPage tabPageNotification;
        private DataGridView dgvNotifications;
        private PictureBox pictureBox7;
    }
}
