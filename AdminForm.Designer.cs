namespace Restaurant_Reservation_System
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelButtons;
        private Panel panelContent;
        private Button btnNotifications;
        private Button btnProfile;
        private Button btnTables;
        private DataGridView dgvNotifications;
        private DataGridView dgvReservations;
        private DataGridView dgvReports;
        private Label lblWelcome;
        private Button btnLogout;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnSaveProfile;

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
            panelButtons = new Panel();
            btnNotifications = new Button();
            btnProfile = new Button();
            btnTables = new Button();
            panelContent = new Panel();
            dgvNotifications = new DataGridView();
            dgvReservations = new DataGridView();
            dgvReports = new DataGridView();
            lblWelcome = new Label();
            btnLogout = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnSaveProfile = new Button();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(45, 45, 48);
            panelButtons.Controls.Add(btnNotifications);
            panelButtons.Controls.Add(btnProfile);
            panelButtons.Controls.Add(btnTables);
            panelButtons.Location = new Point(12, 42);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(200, 380);
            panelButtons.TabIndex = 0;
            // 
            // btnNotifications
            // 
            btnNotifications.BackColor = Color.FromArgb(28, 28, 28);
            btnNotifications.FlatStyle = FlatStyle.Flat;
            btnNotifications.ForeColor = Color.White;
            btnNotifications.Location = new Point(0, 76);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(200, 70);
            btnNotifications.TabIndex = 0;
            btnNotifications.Text = "Notifications";
            btnNotifications.UseVisualStyleBackColor = false;
            btnNotifications.Click += btnNotifications_Click;
            btnNotifications.MouseEnter += Button_MouseEnter;
            btnNotifications.MouseLeave += Button_MouseLeave;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(28, 28, 28);
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(0, 0);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(200, 70);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            btnProfile.MouseEnter += Button_MouseEnter;
            btnProfile.MouseLeave += Button_MouseLeave;
            // 
            // btnTables
            // 
            btnTables.BackColor = Color.FromArgb(28, 28, 28);
            btnTables.FlatStyle = FlatStyle.Flat;
            btnTables.ForeColor = Color.White;
            btnTables.Location = new Point(0, 152);
            btnTables.Name = "btnTables";
            btnTables.Size = new Size(200, 70);
            btnTables.TabIndex = 2;
            btnTables.Text = "Tables";
            btnTables.UseVisualStyleBackColor = false;
            btnTables.Click += btnTables_Click;
            btnTables.MouseEnter += Button_MouseEnter;
            btnTables.MouseLeave += Button_MouseLeave;
            // 
            // panelContent
            // 
            panelContent.Location = new Point(218, 42);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(554, 380);
            panelContent.TabIndex = 1;
            // 
            // dgvNotifications
            // 
            dgvNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotifications.Dock = DockStyle.Fill;
            dgvNotifications.Location = new Point(6, 6);
            dgvNotifications.Name = "dgvNotifications";
            dgvNotifications.Size = new Size(540, 368);
            dgvNotifications.TabIndex = 0;
            // 
            // dgvReservations
            // 
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Dock = DockStyle.Fill;
            dgvReservations.Location = new Point(6, 6);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.Size = new Size(540, 368);
            dgvReservations.TabIndex = 0;
            // 
            // dgvReports
            // 
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Dock = DockStyle.Fill;
            dgvReports.Location = new Point(6, 6);
            dgvReports.Name = "dgvReports";
            dgvReports.Size = new Size(540, 368);
            dgvReports.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.FromArgb(0, 122, 204);
            lblWelcome.Location = new Point(12, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(175, 26);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, User";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 69, 58);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(697, 428);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 30);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(20, 20);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(20, 60);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(20, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(20, 140);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 6;
            // 
            // btnSaveProfile
            // 
            btnSaveProfile.BackColor = Color.FromArgb(0, 122, 204);
            btnSaveProfile.FlatStyle = FlatStyle.Flat;
            btnSaveProfile.ForeColor = Color.White;
            btnSaveProfile.Location = new Point(20, 180);
            btnSaveProfile.Name = "btnSaveProfile";
            btnSaveProfile.Size = new Size(75, 30);
            btnSaveProfile.TabIndex = 7;
            btnSaveProfile.Text = "Save";
            btnSaveProfile.UseVisualStyleBackColor = false;
            btnSaveProfile.Click += btnSaveProfile_Click;
            // 
            // AdminForm
            // 
            ClientSize = new Size(784, 461);
            Controls.Add(panelContent);
            Controls.Add(panelButtons);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogout);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminForm";
            Text = "Admin Dashboard";
            Load += AdminForm_Load;
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.DarkGray;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(28, 28, 28);
        }
    }
}
