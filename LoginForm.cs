using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Username and password cannot be empty.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Hide();

            using (ChooseForm choose = new ChooseForm())
            {
                choose.ShowDialog();

                if (choose.LogoutRequested)
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                    Show();
                    txtUsername.Focus();
                }
                else
                {
                    Close();
                }
            }
        }
    }
}
