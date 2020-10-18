using DevideManagement.DAO;
using DevideManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevideManagement
{
    public partial class bnLeft : Form
    {
        int x, y;

        public bnLeft()
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
                Hide();
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

        private void bnLeft_MouseMove(object sender, MouseEventArgs e)
        {
            //Location = new Point(x = x - e.X, y = y - e.Y);
        }

        private void bnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
    }
}
