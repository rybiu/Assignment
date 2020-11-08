using DeviceManagement.Models;
using DeviceManagement.Presenters;
using DeviceManagement.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DeviceManagement
{
    public partial class FormWorker : Form, IUserView
    {

        WorkerPresenter WorkerPresenter;

        public int Id { get => int.Parse(txtUserID.Text); }

        public string Username { get => txtUsername.Text; }

        public string Password { get => txtPassword.Text; }

        public string SearchValue { get => txtSearch.Text; }

        public FormWorker()
        {
            InitializeComponent();
            WorkerPresenter = new WorkerPresenter(this);
        }

        private void LoadTable()
        {
            try
            {
                List<UserModel> list = WorkerPresenter.GetCurrentPage();
                btnPrePage.Enabled = WorkerPresenter.HasPreviousPage();
                btnNextPage.Enabled = WorkerPresenter.HasNextPage();
                if (list.Count == 0) return;
                dgvUser.DataSource = list;
                // Hide some columns
                dgvUser.Columns[2].Visible = false;
                dgvUser.Columns[3].Visible = false;
                dgvUser.Columns[4].Visible = false;
                // Data bindings
                txtUserID.DataBindings.Clear();
                txtUsername.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtUserID.DataBindings.Add("Text", list, "id");
                txtUsername.DataBindings.Add("Text", list, "username");
                txtPassword.DataBindings.Add("Text", list, "password");
                dgvUser.ClearSelection();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load failed");
            }
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
            txtUsername.ReadOnly = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text.Length != 0) return;
            if (!IsValidInput()) return;
            if (WorkerPresenter.IsExistUsername())
            {
                MessageBox.Show("This username has existed.", "Error");
                return;
            }
            try
            {
                WorkerPresenter.AddUserModel();
                WorkerPresenter.GoToLastPage();
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
                WorkerPresenter.UpdateUserModel();
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
            DialogResult dr = MessageBox.Show("Are you sure to delete this worker?",
                "Delete Worker", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr != DialogResult.Yes) return;
            try
            {
                WorkerPresenter.DeleteUserModel();
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
            WorkerPresenter.GoToPreviousPage();
            LoadTable();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            WorkerPresenter.GoToNextPage();
            LoadTable();
        }

        private void FormWorker_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            WorkerPresenter.GoToFirstPage();
            try
            {
                int records = WorkerPresenter.GetCurrentPage().Count;
                if (records == 0)
                {
                    MessageBox.Show("No workers are matched.", "Information");
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
