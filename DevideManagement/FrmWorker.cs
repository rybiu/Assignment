using DevideManagement.DAO;
using DevideManagement.DTO;
using DevideManagement.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace DevideManagement
{
    public partial class FrmWorker : Form
    {
        Pagination Pagination;
        DataTable dtUserList;

        public FrmWorker()
        {
            InitializeComponent();
            Pagination = new Pagination();
            AccountDAO dao = new AccountDAO();
            DataTable list = dao.GetAccounts(AccountDTO.ROLE.WORKER);
            list.PrimaryKey = new DataColumn[] { list.Columns["id"] };
            Pagination.Data = list;
        }

        private void LoadTable()
        {
            dtUserList = Pagination.GetCurrentPage();
            dgvUser.DataSource = dtUserList;
            dgvUser.Columns[2].Visible = false;
            dgvUser.Columns[3].Visible = false;
            txtUserID.DataBindings.Clear();
            txtUsername.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtUserID.DataBindings.Add("Text", dtUserList, "id");
            txtUsername.DataBindings.Add("Text", dtUserList, "username");
            txtPassword.DataBindings.Add("Text", dtUserList, "password");
            btnPrePage.Enabled = Pagination.HasPrePage();
            btnNextPage.Enabled = Pagination.HasNextPage();
        }

        private void FrmWorker_Load(object sender, EventArgs e)
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            AccountDAO dao = new AccountDAO();
            if (username.Length == 0)
            {
                MessageBox.Show("Username must be not empty.");
                return;
            }
            if (dao.IsExist(username) != -1)
            {
                MessageBox.Show("This username has existed.");
                return;
            }
            string password = txtPassword.Text.Trim();
            if (password.Length == 0)
            {
                MessageBox.Show("Password must be not empty.");
                return;
            }
            AccountDTO dto = new AccountDTO { username = username, password = password, role = AccountDTO.ROLE.WORKER };
            if (dao.AddAccount(dto))
            {
                int id = dao.GetLastAccountId();
                Pagination.Data.Rows.Add(id, username, password);
                Pagination.GoToLastPage();
                LoadTable();
                MessageBox.Show("Add success.");
            }
            else
            {
                MessageBox.Show("Add fail.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text.Length == 0) return;
            int id = int.Parse(txtUserID.Text);
            AccountDAO dao = new AccountDAO();
            AccountDTO dto = new AccountDTO
            {
                id = id,
                username = txtUsername.Text.Trim(),
                password = txtPassword.Text.Trim()
            };
            if (dao.UpdateAccount(dto))
            {
                DataRow row = Pagination.Data.Rows.Find(id);
                row["username"] = dto.username;
                row["password"] = dto.password;
                LoadTable();
                MessageBox.Show("Update success.");
            } else
            {
                MessageBox.Show("Update fail.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text.Length == 0) return;
            int id = int.Parse(txtUserID.Text);
            AccountDAO dao = new AccountDAO();
            if (dao.DeleteAccount(id))
            {
                DataRow row = Pagination.Data.Rows.Find(id);
                Pagination.Data.Rows.Remove(row);
                LoadTable();
                MessageBox.Show("Delete success.");
            }
            else
            {
                MessageBox.Show("Delete fail.");
            }
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            ckShowPassword.Checked = false;
        }

        private void btnPrePage_Click(object sender, EventArgs e)
        {
            Pagination.GoToPrePage();
            LoadTable();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            Pagination.GoToNextPage();
            LoadTable();
        }
    }
}
