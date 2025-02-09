using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Restaurant_Reservation_System
{
    public partial class UserForm : Form
    {
        private string userEmail;
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public UserForm(string email)
        {
            InitializeComponent();
            userEmail = email;
            LoadUserData();
            LoadUserProfile();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeTabs();
        }

        private void InitializeTabs()
        {
            tabControl.TabPages.Clear();
            tabControl.TabPages.Add(tabPageAvailableTables);
            tabControl.TabPages.Add(tabPageYourReservations);
            tabControl.TabPages.Add(tabPageNotification);
            tabControl.TabPages.Add(tabPageProfile);

        }


        private void LoadUserData()
        {
            LoadUserReservations();
            LoadTables();
            LoadUserReservations();
            LoadNotifications();
        }
        private void LoadTables()
        {
            string connectionString = "Data Source=DESKTOP-T2P23L4\\SQLEXPRESS;Initial Catalog=RestaurantReservationDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string tablesQuery = "SELECT TableNumber AS [Table Number], Capacity AS [Capacity], AvailabilityStatus AS [Availability] FROM Tables";
                    SqlDataAdapter tablesAdapter = new SqlDataAdapter(tablesQuery, conn);
                    DataTable tablesTable = new DataTable();
                    tablesAdapter.Fill(tablesTable);
                    dgvAvailableTables.DataSource = tablesTable;
                    dgvAvailableTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Ensure full row selection
                    dgvAvailableTables.MultiSelect = false; // Allow only single row selection
                    dgvAvailableTables.SelectionChanged += DgvAvailableTables_SelectionChanged;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }
            }
        }
        private void LoadNotifications()
        {
            string connectionString = "Data Source=DESKTOP-T2P23L4\\SQLEXPRESS;Initial Catalog=RestaurantReservationDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // SQL query to get notifications based on user email
                    string query = "SELECT UserEmail AS Email , Message, CreatedAt AS Date FROM Notifications WHERE UserEmail = @UserEmail";
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@UserEmail", userEmail);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvNotifications.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading notifications: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void LoadUserProfile()
        {
            string connectionString = "Data Source=DESKTOP-T2P23L4\\SQLEXPRESS;Initial Catalog=RestaurantReservationDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Email, Password, FirstName, LastName FROM Users WHERE Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtEmail.Text = reader["Email"].ToString();
                                txtPassword.Text = reader["Password"].ToString();
                                txtFirstName.Text = reader["FirstName"].ToString();
                                txtLastName.Text = reader["LastName"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading user profile: " + ex.Message);
                }
            }
        }

        private void LoadUserReservations()
        {
            string connectionString = "Data Source=DESKTOP-T2P23L4\\SQLEXPRESS;Initial Catalog=RestaurantReservationDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string reservationsQuery = @"
                SELECT  r.ReservationID, t.TableNumber AS [Table Number], r.ReservationDate AS [Reservation Date], r.Status AS [Status]
                FROM Reservations r
                JOIN Tables t ON r.TableID = t.TableID
                JOIN Users u ON r.UserID = u.UserID
                WHERE u.Email = @Email";
                    SqlDataAdapter reservationsAdapter = new SqlDataAdapter(reservationsQuery, conn);
                    reservationsAdapter.SelectCommand.Parameters.AddWithValue("@Email", userEmail);
                    DataTable reservationsTable = new DataTable();
                    reservationsAdapter.Fill(reservationsTable);

                    dgvYourReservations.DataSource = reservationsTable;
                    dgvYourReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvYourReservations.MultiSelect = false;

                    // Ensure the ReservationID column is visible
                    if (dgvYourReservations.Columns.Contains("ReservationID"))
                    {
                        dgvYourReservations.Columns["ReservationID"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading reservations: " + ex.Message);
                }
            }
        }


        private void DgvAvailableTables_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAvailableTables.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAvailableTables.SelectedRows[0];
                string availability = selectedRow.Cells["Availability"].Value.ToString();
                if (availability == "Available")
                {
                    btnMakeReservation.Enabled = true;
                }
                else
                {
                    btnMakeReservation.Enabled = false;
                }
            }
            else
            {
                btnMakeReservation.Enabled = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(userEmail);
            reportForm.Show();
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string email = userEmail;
            string password = txtPassword.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string connectionString = "Data Source=DESKTOP-T2P23L4\\SQLEXPRESS;Initial Catalog=RestaurantReservationDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    await conn.OpenAsync();
                    string query = @"
                UPDATE Users 
                SET 
                    Password = @Password, 
                    PasswordHash = @PasswordHash,
                    FirstName = @FirstName, 
                    LastName = @LastName
                WHERE Email = @Email";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@PasswordHash", HashPassword(password));
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);

                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No profile found with the given email.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving changes: " + ex.Message);
                }
            }
        }

        private async void btnMakeReservation_Click(object sender, EventArgs e)
        {
            if (dgvAvailableTables.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAvailableTables.SelectedRows[0];
                if (selectedRow != null)
                {
                    string tableNumber = selectedRow.Cells["Table Number"].Value.ToString();

                    string connectionString = "Data Source=DESKTOP-T2P23L4\\SQLEXPRESS;Initial Catalog=RestaurantReservationDB;Integrated Security=True";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            await conn.OpenAsync();

                            // Check if the user already has a reservation
                            string checkReservationQuery = "SELECT COUNT(*) FROM Reservations WHERE UserID = (SELECT UserID FROM Users WHERE Email = @Email)";
                            using (SqlCommand checkCmd = new SqlCommand(checkReservationQuery, conn))
                            {
                                checkCmd.Parameters.AddWithValue("@Email", userEmail);
                                int existingReservations = (int)await checkCmd.ExecuteScalarAsync();

                                if (existingReservations > 0)
                                {
                                    MessageBox.Show("You already have an active reservation. Please cancel it before making a new one.");
                                    return;
                                }
                            }

                            // Get user ID
                            string userQuery = "SELECT UserID FROM Users WHERE Email = @Email";
                            using (SqlCommand userCmd = new SqlCommand(userQuery, conn))
                            {
                                userCmd.Parameters.AddWithValue("@Email", userEmail);
                                int userId = (int)await userCmd.ExecuteScalarAsync();

                                // Get table ID
                                string tableQuery = "SELECT TableID FROM Tables WHERE TableNumber = @TableNumber";
                                using (SqlCommand tableCmd = new SqlCommand(tableQuery, conn))
                                {
                                    tableCmd.Parameters.AddWithValue("@TableNumber", tableNumber);
                                    int tableId = (int)await tableCmd.ExecuteScalarAsync();

                                    // Insert new reservation
                                    string insertQuery = "INSERT INTO Reservations (UserID, TableID, ReservationDate, Status) VALUES (@UserID, @TableID, @ReservationDate, 'Reserved')";
                                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                                    {
                                        insertCmd.Parameters.AddWithValue("@UserID", userId);
                                        insertCmd.Parameters.AddWithValue("@TableID", tableId);
                                        insertCmd.Parameters.AddWithValue("@ReservationDate", DateTime.Now);
                                        await insertCmd.ExecuteNonQueryAsync();

                                        // Update table status to Reserved
                                        string updateTableQuery = "UPDATE Tables SET AvailabilityStatus = 'Reserved' WHERE TableID = @TableID";
                                        using (SqlCommand updateCmd = new SqlCommand(updateTableQuery, conn))
                                        {
                                            updateCmd.Parameters.AddWithValue("@TableID", tableId);
                                            await updateCmd.ExecuteNonQueryAsync();
                                        }
                                    }
                                }
                            }
                            MessageBox.Show("Reservation made successfully!");
                            LoadUserData(); // Refresh data
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while making the reservation: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No row selected.");
                }
            }
            else
            {
                MessageBox.Show("Please select a table first.");
            }
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            if (dgvYourReservations.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvYourReservations.SelectedRows[0];
                if (selectedRow != null)
                {
                    var reservationIDCell = selectedRow.Cells["ReservationID"].Value;
                    if (reservationIDCell != null && int.TryParse(reservationIDCell.ToString(), out int reservationID))
                    {
                        string connectionString = "Data Source=DESKTOP-T2P23L4\\SQLEXPRESS;Initial Catalog=RestaurantReservationDB;Integrated Security=True";
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            try
                            {
                                conn.Open();

                                // Get table ID associated with the reservation
                                string tableIdQuery = "SELECT TableID FROM Reservations WHERE ReservationID = @ReservationID";
                                int tableId;
                                using (SqlCommand tableIdCmd = new SqlCommand(tableIdQuery, conn))
                                {
                                    tableIdCmd.Parameters.AddWithValue("@ReservationID", reservationID);
                                    object result = tableIdCmd.ExecuteScalar();
                                    if (result != null && int.TryParse(result.ToString(), out tableId))
                                    {
                                        // Delete reservation
                                        string deleteQuery = "DELETE FROM Reservations WHERE ReservationID = @ReservationID";
                                        using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                                        {
                                            deleteCmd.Parameters.AddWithValue("@ReservationID", reservationID);
                                            deleteCmd.ExecuteNonQuery();
                                            MessageBox.Show("Reservation cancelled successfully!");
                                        }

                                        // Update table status to Available
                                        string updateTableQuery = "UPDATE Tables SET AvailabilityStatus = 'Available' WHERE TableID = @TableID";
                                        using (SqlCommand updateCmd = new SqlCommand(updateTableQuery, conn))
                                        {
                                            updateCmd.Parameters.AddWithValue("@TableID", tableId);
                                            updateCmd.ExecuteNonQuery();
                                        }

                                        LoadUserReservations(); // Refresh data
                                        LoadTables(); // Refresh available tables
                                    }
                                    else
                                    {
                                        MessageBox.Show("TableID not found for the reservation.");
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred while cancelling the reservation: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid reservation ID.");
                    }
                }
                else
                {
                    MessageBox.Show("No row selected.");
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation first.");
            }
        }

    }
}
