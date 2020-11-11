using DeviceManagement.Models;
using DeviceManagement.Presenters;
using DeviceManagement.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DeviceManagement
{
    public partial class FormUser : Form, IUserView
    {

        UserPresenter UserPresenter;

        public int Id { get => int.Parse(txtUserID.Text); }

        public string Username { get => txtUsername.Text; }

        public string Password { get => txtPassword.Text; }

        public string SearchValue { get => txtSearch.Text; }

        public FormUser()
        {
            InitializeComponent();
            UserPresenter = new UserPresenter(this);
        }

        private void LoadTable()
        {
            try
            {
                List<UserModel> list = UserPresenter.GetCurrentPage();
                btnPrePage.Enabled = UserPresenter.HasPreviousPage();
                btnNextPage.Enabled = UserPresenter.HasNextPage();
                if (list.Count == 0) return;
                List<dynamic> users = new List<dynamic>();
                foreach (var item in list)
                {
                    users.Add(new
                    {
                        Id = item.Id,
                        Username = item.Username,
                        Password = item.Password,
                        RoleName = item.RoleName,
                        RoomId = item.RoomId
                    });
                }
                dgvUser.DataSource = users;
                // Hide some columns
                dgvUser.Columns[2].Visible = false;
                dgvUser.Columns[3].Visible = false;
                dgvUser.Columns[4].Visible = false;
                // Data bindings
                txtUserID.DataBindings.Clear();
                txtUsername.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtRoomID.DataBindings.Clear();
                txtUserID.DataBindings.Add("Text", users, "Id");
                txtUsername.DataBindings.Add("Text", users, "Username");
                txtPassword.DataBindings.Add("Text", users, "Password");
                txtRoomID.DataBindings.Add("Text", users, "RoomId");
                dgvUser.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load failed");
            }
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void ckShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtUserID.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtRoomID.Text = string.Empty;
            txtUsername.ReadOnly = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text.Length != 0) return;
            if (!IsValidInput()) return;
            if (UserPresenter.IsExistUsername())
            {
                MessageBox.Show("This username has existed.", "Error");
                return;
            }
            try 
            {
                UserPresenter.AddUserModel();
                UserPresenter.GoToLastPage();
                LoadTable();
                MessageBox.Show("Add successful.", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add failed");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text.Length == 0) return;
            if (!IsValidInput()) return;
            try
            {
                UserPresenter.UpdateUserModel();
                LoadTable();
                MessageBox.Show("Update successful.", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update failed");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text.Length == 0) return;
            DialogResult dr = MessageBox.Show("Are you sure to delete this user?",
                "Delete User", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr != DialogResult.Yes) return;
            try
            {
                UserPresenter.DeleteUserModel();
                LoadTable();
                MessageBox.Show("Delete successful.", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete failed");
            }
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            ckShowPassword.Checked = false;
            txtUsername.ReadOnly = true;
        }

        private void btnPrePage_Click(object sender, EventArgs e)
        {
            UserPresenter.GoToPreviousPage();
            LoadTable();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            UserPresenter.GoToNextPage();
            LoadTable();
        }

        private void txtRoomID_TextChanged(object sender, EventArgs e)
        {
            if (txtRoomID.Text.Equals("0")) txtRoomID.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UserPresenter.GoToFirstPage();
            try
            {
                int records = UserPresenter.GetCurrentPage().Count;
                if (records == 0)
                {
                    MessageBox.Show("No users are matched.", "Information");
                }
                else
                {
                    LoadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search failed");
            }
        }

        private bool IsValidInput()
        {
            // Validate username
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username must be not empty.", "Error");
                return false;
            }
            if (txtUsername.Text.Length > 50)
            {
                MessageBox.Show("Username must be not greater than 50 chars.", "Error");
                return false;
            }

            // Validate password
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password must be not empty.", "Error");
                return false;
            }
            if (txtPassword.Text.Length > 50)
            {
                MessageBox.Show("Password must be not greater than 50 chars.", "Error");
                return false;
            }

            // No error
            return true;
        }
    }
}
