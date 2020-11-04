using DeviceManagement.Models;
using DeviceManagement.Presenters;
using DeviceManagement.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DeviceManagement
{
    public partial class FormLogin : Form, ILoginView
    {
        private int x, y;
        private LoginPresenter LoginPresenter;

        public string Username { get => txtUsername.Text.Trim(); }

        public string Password { get => txtPassword.Text.Trim(); }

        public FormLogin()
        {
            InitializeComponent();
            LoginPresenter = new LoginPresenter(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginPresenter.Login(out UserModel userModel))
                {
                    new FormDashboard(userModel).Show();
                } else
                {
                    MessageBox.Show("Incorrect username or password!");
                }
                Dispose();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Login failed");
            }
        }

        private void ckShow_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*') {
                txtPassword.PasswordChar = '\0';
            } else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void pnRight_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void pnRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Location.X + e.X - x, Location.Y + e.Y - y);
            }
        }

        private void pnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void pnLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Location.X + e.X - x, Location.Y + e.Y - y);
            }
        }
    }
}
