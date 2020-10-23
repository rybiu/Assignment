using DeviceManagement.DAO;
using DeviceManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceManagement
{
    public partial class frmLogin : Form
    {
        int x, y;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            AccountDAO dao = new AccountDAO();
            AccountDTO dto = dao.GetAccount(username, password);
            if (dto != null)
            {
                Dispose();
                new FrmManager(dto).Show();
            } else
            {
                MessageBox.Show("Incorrect username or password!");
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
