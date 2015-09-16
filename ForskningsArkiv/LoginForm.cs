using System;
using System.Windows.Forms;

namespace ForskningsArkiv
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (kodeordTextbox.Text == "admin")
            {
                var brugerAdmin = new VælgBrugerAdmin();
                Hide();
                brugerAdmin.Show();
            }
            else
            {
                MessageBox.Show("Adgangskoden er forkert.");
            }
        }
    }
}