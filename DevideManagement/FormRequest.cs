using DeviceManagement.Models;
using DeviceManagement.Presenters;
using DeviceManagement.Views;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevideManagement
{
    public partial class FormRequest : Form, IRequestView
    {

        Label DeviceStatus;
        RequestModel LastRequestModel;

        RequestPresenter RequestPresenter;

        public int DeviceId { get; set; }

        public UserModel UserModel { get; set; }

        public int Id { get => LastRequestModel.Id; }

        public string RequestDescription { get => txtRequestDescription.Text; }

        public string RepairDescription { get => txtRepairDescription.Text; }

        public FormRequest(int deviceId, UserModel userModel, ref Label deviceStatus)
        {
            InitializeComponent();
            DeviceId = deviceId;
            DeviceStatus = deviceStatus;
            UserModel = userModel;
            RequestPresenter = new RequestPresenter(this);
        }

        private void LoadTable()
        {
            try
            {
                LastRequestModel = null;
                List<RequestModel> requests = RequestPresenter.GetCurrentPage();              
                btnPrePage.Enabled = RequestPresenter.HasPreviousPage();
                btnNextPage.Enabled = RequestPresenter.HasNextPage();
                if (requests.Count == 0) return;
                dgvRequest.DataSource = requests;
                LastRequestModel = requests[requests.Count - 1];
                // Hide some column
                for (int i = 3; i < 10; i++) dgvRequest.Columns[i].Visible = false;

                // Data bindings
                txtRequestId.DataBindings.Clear();
                txtUserId.DataBindings.Clear();
                txtRequestDate.DataBindings.Clear();
                txtRequestDescription.DataBindings.Clear();
                txtWorkerId.DataBindings.Clear();
                txtStartDate.DataBindings.Clear();
                txtFinishDate.DataBindings.Clear();
                txtRepairDescription.DataBindings.Clear();
                txtRequestId.DataBindings.Add("Text", requests, "Id");
                txtUserId.DataBindings.Add("Text", requests, "UserId");
                txtRequestDate.DataBindings.Add("Text", requests, "RequestDate");
                txtRequestDescription.DataBindings.Add("Text", requests, "RequestDescription");
                txtWorkerId.DataBindings.Add("Text", requests, "WorkerId");
                txtStartDate.DataBindings.Add("Text", requests, "StartDate");
                txtFinishDate.DataBindings.Add("Text", requests, "FinishDate");
                txtRepairDescription.DataBindings.Add("Text", requests, "RepairDescription");
                dgvRequest.ClearSelection();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load failed");
            }
        }
        

        private void lbBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbBackIcon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try 
            {
                // Check if user or device has been changed
                UserModel user = RequestPresenter.GetUserModel();
                DeviceModel device = RequestPresenter.GetDeviceModel();
                if (user == null || device == null) { Close(); return; }
                // Check user role
                if (!user.RoleName.Equals("USER")) return;
                // Check roomId
                if (device.RoomId != user.RoomId || user.RoomId == -1 || device.RoomId == -1) { Close(); return; }
                // Move to last page
                RequestPresenter.GoToLastPage();
                LoadTable();
                // Check last request status
                if (LastRequestModel != null && !LastRequestModel.StatusName.Equals("REQUEST_FINISH")) return;
                // Is valid
                string requestDescription = Interaction.InputBox("Enter the request description", "New Request");
                if (string.IsNullOrWhiteSpace(requestDescription)) return;
                if (requestDescription.Length > 300)
                {
                    MessageBox.Show("Request description must be not greater than 300 chars.", "Error");
                    return;
                }
                txtRequestDescription.Text = requestDescription;

                RequestPresenter.AddRequestModel();
                LoadTable();
                DeviceStatus.Text = "DEVICE_BROKEN";
                btnNew.Enabled = false;
                MessageBox.Show("Add successful.", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add failed");
            }
        }

        private void FormRequest_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if user or device has been changed
                UserModel user = RequestPresenter.GetUserModel();
                DeviceModel device = RequestPresenter.GetDeviceModel();
                if (user == null || device == null)
                {
                    Close();
                    return;
                }
                // Check user role
                if (!user.RoleName.Equals("WORKER")) return;
                // Move to last page
                RequestPresenter.GoToLastPage();
                LoadTable();
                // Check last request status
                if (LastRequestModel == null || !LastRequestModel.StatusName.Equals("REQUEST_INITIAL")) return;
                // Is valid
                RequestPresenter.StartRequestModel();
                LoadTable();
                MessageBox.Show("Start successful.", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Start failed");
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if user or device has been changed
                UserModel user = RequestPresenter.GetUserModel();
                DeviceModel device = RequestPresenter.GetDeviceModel();
                if (user == null || device == null)
                { 
                    Close(); 
                    return; 
                }
                // Check user role
                if (!user.RoleName.Equals("WORKER")) return;
                // Move to last page
                RequestPresenter.GoToLastPage();
                LoadTable();
                // Check last request status
                if (LastRequestModel == null || !LastRequestModel.StatusName.Equals("REQUEST_START") || LastRequestModel.WorkerId != user.Id) return;
                // Is valid
                string repairDescription = Interaction.InputBox("Enter the repair description", "Finish Request");
                if (string.IsNullOrWhiteSpace(repairDescription)) return;
                if (repairDescription.Length > 300)
                {
                    MessageBox.Show("Repair description must be not greater than 300 chars.", "Error");
                    return;
                }
                txtRepairDescription.Text = repairDescription;

                RequestPresenter.FinishRequestModel();
                LoadTable();
                DeviceStatus.Text = "DEVICE_ACTIVE";
                MessageBox.Show("Finish successful.", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Finish failed");
            }
        }

        private void txtWorkerId_TextChanged(object sender, EventArgs e)
        {
            if (txtWorkerId.Text.Equals("-1")) txtWorkerId.Text = string.Empty;
        }

        private void btnPrePage_Click(object sender, EventArgs e)
        {
            RequestPresenter.GoToPreviousPage();
            LoadTable();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            RequestPresenter.GoToNextPage();
            LoadTable();
        }
    }
}
