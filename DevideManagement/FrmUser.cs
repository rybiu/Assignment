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
    public partial class FrmUser : Form
    {
        int pageIndex = 1;

        public FrmUser()
        {
            InitializeComponent();
        }

        private void LoadTable()
        {
            AccountDAO dao = new AccountDAO();
            List<AccountDTO> list = dao.GetAccounts(AccountDTO.ROLE.USER);
            dgvUser.DataSource = list;
            dgvUser.Columns[2].Visible = false;
            dgvUser.Columns[3].Visible = false;
            dgvUser.Columns[4].Visible = false;
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

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUser.SelectedCells.Count == 0) return;
            int rowIndex = (int)dgvUser.SelectedCells[0].RowIndex;
            int id = (int)dgvUser.Rows[rowIndex].Cells[0].Value;
            AccountDAO dao = new AccountDAO();
            AccountDTO dto = dao.GetAccount(id);
            txtUserID.Text = dto.id.ToString();
            txtUsername.Text = dto.username;
            txtPassword.Text = dto.password;
            txtRoomID.Text = string.Empty;
            ckShowPassword.Checked = false;
            if (dto.roomId != -1) txtRoomID.Text = dto.roomId.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtUserID.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtRoomID.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
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
            if (txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Password must be not empty.");
                return;
            }
            AccountDTO dto = new AccountDTO
            {
                username = txtUsername.Text.Trim(),
                password = txtPassword.Text.Trim()
            };
            if (dao.AddAccount(dto))
            {
                MessageBox.Show("Add success.");
                LoadTable();
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
                MessageBox.Show("Update success!");
                LoadTable();
            } else
            {
                MessageBox.Show("Update fail!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text.Length == 0) return;
            int id = int.Parse(txtUserID.Text);
            AccountDAO dao = new AccountDAO();
            if (dao.DeleteAccount(id))
            {
                MessageBox.Show("Delete success!");
                LoadTable();
            }
            else
            {
                MessageBox.Show("Delete fail!");
            }
        }
    }
}
