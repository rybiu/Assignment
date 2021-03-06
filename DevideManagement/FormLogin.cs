﻿using DeviceManagement.Models;
using DeviceManagement.Presenters;
using DeviceManagement.Views;
using System;
using System.Windows.Forms;

namespace DeviceManagement
{
    public partial class FormLogin : Form, ILoginView
    {
        LoginPresenter LoginPresenter;

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
                    Dispose();
                } else
                {
                    MessageBox.Show("Incorrect username or password!", "Login failed");
                }
            }
            catch (Exception ex)
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
    }
}
