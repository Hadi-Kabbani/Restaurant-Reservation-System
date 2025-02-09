using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurant_Reservation_System
{
    public partial class ReportForm : Form
    {
        private string userEmail;

        public ReportForm(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            string reportTitle = txtTitle.Text;
            string reportDescription = txtDescription.Text;

            if (string.IsNullOrEmpty(reportTitle) || string.IsNullOrEmpty(reportDescription))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            btnSubmit.Enabled = false; // Disable the button to prevent multiple submissions

            string connectionString = "Data Source=DESKTOP-T2P23L4\\SQLEXPRESS;Initial Catalog=RestaurantReservationDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    await conn.OpenAsync();
                    string query = "INSERT INTO Reports (UserID, ReportTitle, ReportContent, CreatedAt) VALUES ((SELECT UserID FROM Users WHERE Email = @Email), @Title, @Description, @ReportDate)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);
                        cmd.Parameters.AddWithValue("@Title", reportTitle);
                        cmd.Parameters.AddWithValue("@Description", reportDescription);
                        cmd.Parameters.AddWithValue("@ReportDate", DateTime.Now);
                        await cmd.ExecuteNonQueryAsync();
                        MessageBox.Show("Report submitted successfully!");
                        this.Close();
                        UserForm userForm = new UserForm(userEmail);
                        userForm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    btnSubmit.Enabled = true; // Re-enable the button
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(userEmail);
            userForm.ShowDialog();
            this.Close();
        }
    }
}
