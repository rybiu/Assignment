using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Login : Form
    {
        public Login()
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
    }
}
