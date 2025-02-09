using Microsoft.VisualBasic.Logging;
using System;
using System.Windows.Forms;
namespace Restaurant_Reservation_System
{
    public partial class EntrieForm : Form
    {
        public EntrieForm()
        {
            InitializeComponent();
        }
        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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
    }
}