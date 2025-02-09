using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Restaurant_Reservation_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            string connectionString = "Data Source=DESKTOP-T2P23L4\\SQLEXPRESS;Initial Catalog=RestaurantReservationDB;Integrated Security=True";
            SqlConnection conn = null;
            SqlCommand cmd = null;

            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                // Query to get the user's role and password hash
                string query = "SELECT PasswordHash, Role FROM Users WHERE Email = @Email";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                // Execute query and retrieve results
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string storedPasswordHash = reader["PasswordHash"] as string;
                    string userRole = reader["Role"] as string;

                    if (storedPasswordHash != null && VerifyPassword(password, storedPasswordHash))
                    {
                        MessageBox.Show("Login successful!");

                        if (userRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                        {
                            AdminForm nextForm = new AdminForm(email); 
                            nextForm.Show();
                        }
                        else
                        {
                            UserForm nextForm = new UserForm(email); 
                            nextForm.Show();
                        }

                        
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Manually close and dispose of the connection and command
                if (cmd != null)
                {
                    cmd.Parameters.Clear();
                }
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        private bool VerifyPassword(string password, string storedPasswordHash)
        {
            string passwordHash = HashPassword(password);
            return passwordHash == storedPasswordHash;
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

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.LightBlue;
                btn.ForeColor = Color.White;
            }
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = SystemColors.Control;
                btn.ForeColor = SystemColors.ControlText;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EntrieForm form1 = new EntrieForm();
            form1.Show();
            this.Close();
        }
    }
}
