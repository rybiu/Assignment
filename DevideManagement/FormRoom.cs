using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using DeviceManagement.Models;
using DeviceManagement.Views;
using DeviceManagement.Presenters;

namespace DeviceManagement
{
    public partial class FormRoom : Form, IRoomView
    {

        RoomPresenter RoomPresenter;
        List<dynamic> leftTableData, rightTableData;

        public int Id { get => int.Parse(lbRoomId.Text); }

        public string RoomName { get => lbRoomName.Text; }

        List<dynamic> IRoomView.LeftTableData { get => leftTableData; }

        List<dynamic> IRoomView.RightTableData { get => rightTableData; }

        public string SearchValue { get => txtSearch.Text; }

        public FormRoom()
        {
            InitializeComponent();
            RoomPresenter = new RoomPresenter(this);
        }

        private void LoadTable()
        {
            List<RoomModel> rooms = RoomPresenter.GetCurrentPage();
            dgvRoom.DataSource = rooms;
            lbRoomId.DataBindings.Clear();
            lbRoomName.DataBindings.Clear();
            lbRoomId.DataBindings.Add("Text", rooms, "Id");
            lbRoomName.DataBindings.Add("Text", rooms, "Name");
            dgvRoom.ClearSelection();
            btnPrePage.Enabled = RoomPresenter.HasPreviousPage();
            btnNextPage.Enabled = RoomPresenter.HasNextPage();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string roomName = Interaction.InputBox("Enter the room name", "New Room");
            if (string.IsNullOrWhiteSpace(roomName)) return;
            if (roomName.Length > 50)
            {
                MessageBox.Show("Room name must be not greater than 50 chars.", "Error");
                return;
            }
            lbRoomName.Text = roomName;
            try
            {
                RoomPresenter.AddRoomModel();
                RoomPresenter.GoToLastPage();
                LoadTable();
                MessageBox.Show("Add successful.", "Information");
            }
            catch
            {
                MessageBox.Show("Add failed", "Information");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count == 0) return;
            if (cboFeature.SelectedItem.Equals("ACCOUNT"))
            {
                try
                {
                    RoomPresenter.SaveFeatureUser();
                    LoadTable();
                    MessageBox.Show("Save successful.", "Information");
                }
                catch
                {
                    MessageBox.Show("Save failed", "Information");
                }
            }
            if (cboFeature.SelectedItem.Equals("DEVICE"))
            {
                try
                {
                    RoomPresenter.SaveFeatureDevice();
                    LoadTable();
                    MessageBox.Show("Save successful.", "Information");
                }
                catch
                {
                    MessageBox.Show("Save failed", "Information");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count == 0) return;
            string roomName = Interaction.InputBox("Enter the room name", "Update Room");
            if (string.IsNullOrWhiteSpace(roomName)) return;
            lbRoomName.Text = roomName;
            try
            {
                RoomPresenter.UpdateRoomModel();
                LoadTable();
                MessageBox.Show("Update successful.", "Information");
            }
            catch
            {
                MessageBox.Show("Update failed", "Information");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count == 0) return;
            DialogResult dr = MessageBox.Show("Are you sure to delete this room?", 
                "Delete Room", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr != DialogResult.Yes) return;
            try
            {
                RoomPresenter.DeleteRoomModel();
                LoadTable();
                MessageBox.Show("Delete successful.", "Information");
            }
            catch
            {
                MessageBox.Show("Delete failed", "Information");
            }
        }

        private void btnPrePage_Click(object sender, EventArgs e)
        {
            RoomPresenter.GoToPreviousPage();
            LoadTable();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            RoomPresenter.GoToNextPage();
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
            GetViewByFeature(cboFeature.Text);
            btnDrop.Visible = true;
            btnMove.Visible = true;
        }

        private List<dynamic> ConvertUsersToView(List<UserModel> users)
        {
            if (users == null) return null;
            List<dynamic> result = new List<dynamic>();
            foreach (var user in users)
            {
                result.Add(new { id = user.Id, name = user.Username });
            }
            return result;
        }

        private List<dynamic> ConvertDevicesToView(List<DeviceModel> devices)
        {
            if (devices == null) return null;
            List<dynamic> result = new List<dynamic>();
            foreach (var device in devices)
            {
                result.Add(new { id = device.Id, name = device.Name });
            }
            return result;
        }

        private void lbRoomId_TextChanged(object sender, EventArgs e)
        {
            cboFeature.SelectedIndex = 0;
            GetViewByFeature(string.Empty);
            btnDrop.Visible = false;
            btnMove.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RoomPresenter.GoToFirstPage();
            if (RoomPresenter.GetCurrentPage().Count == 0)
            {
                MessageBox.Show("No rooms are matched.", "Information");
            }
            else
            {
                LoadTable();
            }
        }

        private void GetViewByFeature(string feature)
        {
            switch (feature)
            {
                case "ACCOUNT":
                    lbLeftTableTitle.Text = "INSIDE";
                    List<UserModel> usersNoneRoom = RoomPresenter.GetUserListNoneRoom();
                    leftTableData = ConvertUsersToView(usersNoneRoom);
                    dgvLeftTable.DataSource = leftTableData;
                    lbRightTableTitle.Text = "OUTSIDE";
                    List<UserModel> usersInRoom = RoomPresenter.GetUserListInRoom();
                    rightTableData = ConvertUsersToView(usersInRoom);
                    dgvRightTable.DataSource = rightTableData;
                    break;
                case "DEVICE":
                    lbLeftTableTitle.Text = "INSIDE";
                    List<DeviceModel> devicesNoneRoom = RoomPresenter.GetDeviceListNoneRoom();
                    leftTableData = ConvertDevicesToView(devicesNoneRoom);
                    dgvLeftTable.DataSource = leftTableData;
                    lbRightTableTitle.Text = "OUTSIDE";
                    List<DeviceModel> devicesInRoom = RoomPresenter.GetDeviceListInRoom();
                    rightTableData = ConvertDevicesToView(devicesInRoom);
                    dgvRightTable.DataSource = rightTableData;
                    break;
                default:
                    lbLeftTableTitle.Text = "USER";
                    List<UserModel> users = RoomPresenter.GetUserListInRoom();
                    leftTableData = ConvertUsersToView(users);
                    dgvLeftTable.DataSource = leftTableData;
                    lbRightTableTitle.Text = "DEVICE";
                    List<DeviceModel> devices = RoomPresenter.GetDeviceListInRoom();
                    rightTableData = ConvertDevicesToView(devices);
                    dgvRightTable.DataSource = rightTableData;
                    break;
            }
        }
    }
}
