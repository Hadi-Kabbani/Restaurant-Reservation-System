using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Restaurant_Reservation_System
{
    public partial class AdminForm : Form
    {
        private string userEmail;

        public AdminForm(string email)
        {
            InitializeComponent();
            userEmail = email;
            LoadAdminData();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            ShowNotifications();
        }

        private void LoadAdminData()
        {
            string connectionString = "Data Source=DESKTOP-T2P23L4\\SQLEXPRESS;Initial Catalog=RestaurantReservationDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Load reservations
                    string reservationsQuery = "SELECT T.TableNumber AS [Table Number], U.Email AS [User Email], U.FirstName AS [First Name], R.ReservationDate AS [Date], R.Status AS Status " +
                             "FROM Reservations R " +
                             "JOIN Users U ON R.UserID = U.UserID " +
                             "JOIN Tables T ON T.TableID = R.TableID";
                    SqlDataAdapter reservationsAdapter = new SqlDataAdapter(reservationsQuery, conn);
                    DataTable reservationsTable = new DataTable();
                    reservationsAdapter.Fill(reservationsTable);
                    dgvReservations.DataSource = reservationsTable;

                    // Load notifications
                    string notificationsQuery = "SELECT * FROM Notifications";
                    SqlDataAdapter notificationsAdapter = new SqlDataAdapter(notificationsQuery, conn);
                    DataTable notificationsTable = new DataTable();
                    notificationsAdapter.Fill(notificationsTable);
                    dgvNotifications.DataSource = notificationsTable;

                    // Load reports
                    string reportsQuery = "SELECT * FROM Reports";
                    SqlDataAdapter reportsAdapter = new SqlDataAdapter(reportsQuery, conn);
                    DataTable reportsTable = new DataTable();
                    reportsAdapter.Fill(reportsTable);
                    dgvReports.DataSource = reportsTable;

                    // Load admin profile data
                    string userQuery = "SELECT FirstName, LastName, Email, PasswordHash, Password FROM Users WHERE Email = @Email";
                    SqlCommand cmd = new SqlCommand(userQuery, conn);
                    cmd.Parameters.AddWithValue("@Email", userEmail);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtFirstName.Text = reader["FirstName"].ToString();
                        txtLastName.Text = reader["LastName"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtPassword.Text = reader["Password"].ToString();
                        lblWelcome.Text = $"Welcome, {reader["FirstName"]} {reader["LastName"]}";
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void ShowNotifications()
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(dgvNotifications);
            dgvNotifications.Dock = DockStyle.Fill;
        }

        private void ShowProfile()
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(txtFirstName);
            panelContent.Controls.Add(txtLastName);
            panelContent.Controls.Add(txtEmail);
            panelContent.Controls.Add(txtPassword);
            panelContent.Controls.Add(btnSaveProfile);
            txtFirstName.Location = new Point(20, 20);
            txtLastName.Location = new Point(20, 60);
            txtEmail.Location = new Point(20, 100);
            txtPassword.Location = new Point(20, 140);
            btnSaveProfile.Location = new Point(20, 180);
        }

        private void ShowTables()
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(dgvReservations);
            dgvReservations.Dock = DockStyle.Fill;
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            ShowNotifications();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ShowProfile();
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            ShowTables();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-T2P23L4\\SQLEXPRESS;Initial Catalog=RestaurantReservationDB;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                conn.Open();
                string updateQuery = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, PasswordHash = @PasswordHash, password = @password WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@PasswordHash", HashPassword(txtPassword.Text));
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Profile updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the profile: " + ex.Message);
            }
        }
    }
}
