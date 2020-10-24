using DeviceManagement.DAO;
using DeviceManagement.DTO;
using DeviceManagement.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DeviceManagement
{
    public partial class FrmRoom : Form
    {
        Pagination Pagination;
        List<dynamic> leftTableData, rightTableData;

        public FrmRoom()
        {
            InitializeComponent();
            Pagination = new Pagination();
            leftTableData = new List<dynamic>();
            rightTableData = new List<dynamic>();
        }

        private void LoadTable()
        {
            RoomDAO dao = new RoomDAO();
            List<RoomDTO> list = dao.GetRooms();
            dgvRoom.DataSource = null;
            dgvRoom.DataSource = list;
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Enter room name", "New Room");
            RoomDAO dao = new RoomDAO();
            if (name != null && dao.AddRoom(name))
            {
                MessageBox.Show("Add success");
                LoadTable();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count == 0) return;
            int roomId = (int)dgvRoom.SelectedRows[0].Cells[0].Value;
            if (cboFeature.SelectedItem.Equals("ACCOUNT"))
            {
                AccountDAO dao = new AccountDAO();
                foreach (dynamic item in leftTableData) {
                    dao.SetRoomId(item.id, -1);
                }
                foreach (dynamic item in rightTableData)
                {
                    dao.SetRoomId(item.id, roomId);
                }
            }
            if (cboFeature.SelectedItem.Equals("DEVICE"))
            {
                DeviceDAO dao = new DeviceDAO();
                foreach (dynamic item in leftTableData)
                {
                    dao.SetRoomId(item.id, -1);
                }
                foreach (dynamic item in rightTableData)
                {
                    dao.SetRoomId(item.id, roomId);
                }
            }
            MessageBox.Show("Save success");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count == 0) return;
            int id = (int)dgvRoom.SelectedRows[0].Cells[0].Value;
            string name = Interaction.InputBox("Enter room name", "Update Room");
            RoomDAO dao = new RoomDAO();
            if (name != null && dao.UpdateRoom(id, name))
            {
                MessageBox.Show("Update success");
                LoadTable();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count == 0) return;
            int id = (int)dgvRoom.SelectedRows[0].Cells[0].Value;
            //string name = Interaction;
            RoomDAO dao = new RoomDAO();
            if (dao.DeleteRoom(id))
            {
                MessageBox.Show("Delete success");
                LoadTable();
            }
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

        private void FrmRoom_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            if (dgvRightTable.SelectedRows.Count == 0) return;
            int id = dgvRightTable.SelectedRows[0].Index;
            if (leftTableData == null) leftTableData = new List<dynamic>();
            leftTableData.Add(rightTableData[id]);
            rightTableData.RemoveAt(id);
            dgvLeftTable.DataSource = null;
            dgvLeftTable.DataSource = leftTableData;
            dgvRightTable.DataSource = null;
            dgvRightTable.DataSource = rightTableData;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (dgvLeftTable.SelectedRows.Count == 0) return;
            int id = dgvLeftTable.SelectedRows[0].Index;
            if (rightTableData == null) rightTableData = new List<dynamic>();
            rightTableData.Add(leftTableData[id]);
            leftTableData.RemoveAt(id);
            dgvLeftTable.DataSource = null;
            dgvLeftTable.DataSource = leftTableData;
            dgvRightTable.DataSource = null;
            dgvRightTable.DataSource = rightTableData;
        }

        private void cboFeature_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count == 0) return;
            if (cboFeature.SelectedIndex == 0) return;
            btnDrop.Visible = true;
            btnMove.Visible = true;
            lbLeftTableTitle.Text = "OUTSIDE";
            lbRightTableTitle.Text = "INSIDE";
            int roomId = (int)dgvRoom.SelectedRows[0].Cells[0].Value;
            if (cboFeature.SelectedItem.Equals("ACCOUNT"))
            {
                AccountDAO dao = new AccountDAO();
                List<AccountDTO> inRoom = dao.GetAccounts(roomId);
                List<AccountDTO> noneRoom = dao.GetAccountsNoneRoom();
                if (leftTableData != null) leftTableData.Clear();
                if (noneRoom != null)
                {
                    foreach (AccountDTO item in noneRoom)
                    {
                        if (leftTableData == null) leftTableData = new List<dynamic>();
                        leftTableData.Add(new { id = item.id, name = item.username });
                    }
                }
                else
                {
                    leftTableData = null;
                }
                dgvLeftTable.DataSource = null;
                dgvLeftTable.DataSource = leftTableData;
                if (rightTableData != null) rightTableData.Clear();
                if (inRoom != null)
                {
                    foreach (AccountDTO item in inRoom)
                    {
                        if (rightTableData == null) rightTableData = new List<dynamic>();
                        rightTableData.Add(new { id = item.id, name = item.username });
                    }
                } else
                {
                    rightTableData = null;
                }
                dgvRightTable.DataSource = null;
                dgvRightTable.DataSource = rightTableData;
            } else 
            if (cboFeature.SelectedItem.Equals("DEVICE"))
            {
                DeviceDAO dao = new DeviceDAO();
                List<DeviceDTO> inRoom = dao.GetDevices(roomId);
                List<DeviceDTO> noneRoom = dao.GetDevicesNoneRoom();
                if (leftTableData != null) leftTableData.Clear();
                if (noneRoom != null)
                {
                    foreach (DeviceDTO item in noneRoom)
                    {
                        if (leftTableData == null) leftTableData = new List<dynamic>();
                        leftTableData.Add(new { id = item.id, name = item.name });
                    }
                }
                else
                {
                    leftTableData = null;
                }
                dgvLeftTable.DataSource = null;
                dgvLeftTable.DataSource = leftTableData;
                if (rightTableData != null) rightTableData.Clear();
                if (inRoom != null)
                {
                    foreach (DeviceDTO item in inRoom)
                    {
                        if (rightTableData == null) rightTableData = new List<dynamic>();
                        rightTableData.Add(new { id = item.id, name = item.name });
                    }
                }
                else
                {
                    rightTableData = null;
                }
                dgvRightTable.DataSource = null;
                dgvRightTable.DataSource = rightTableData;
            } else
            {
                dgvRoom_SelectionChanged(null, null);
            }
        }

        private void dgvRoom_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count == 0) return;
            int id = (int)dgvRoom.SelectedRows[0].Cells[0].Value;
            AccountDAO accountDAO = new AccountDAO();
            List<AccountDTO> accountList = accountDAO.GetAccounts(id);
            DeviceDAO deviceDAO = new DeviceDAO();
            List<DeviceDTO> deviceList = deviceDAO.GetDevices(id);
            lbLeftTableTitle.Text = "ACCOUNT";
            if (leftTableData != null) leftTableData.Clear();
            if (accountList != null)
            {
                foreach (AccountDTO item in accountList)
                {
                    if (leftTableData == null) leftTableData = new List<dynamic>();
                    leftTableData.Add(new { id = item.id, name = item.username });
                }
            } else
            {
                leftTableData = null;
            }
            dgvLeftTable.DataSource = leftTableData;
            lbRightTableTitle.Text = "DEVICE";
            if (rightTableData != null) rightTableData.Clear();
            if (deviceList != null)
            {
                foreach (DeviceDTO item in deviceList)
                {
                    if (rightTableData == null) rightTableData = new List<dynamic>();
                    rightTableData.Add(new { id = item.id, name = item.name });
                }
            } else
            {
                rightTableData = null;
            }
            dgvRightTable.DataSource = rightTableData;
            cboFeature.SelectedIndex = 0;
            btnDrop.Visible = false;
            btnMove.Visible = false;
        }
    }
}
