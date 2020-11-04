using DeviceManagement.Models;
using DeviceManagement.Presenters;
using DeviceManagement.Views;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DevideManagement
{
    public partial class FormRequest : Form, IRequestView
    {

        int x, y;
        Label DeviceStatus;

        RequestPresenter RequestPresenter;

        public int DeviceId { get; set; }

        public UserModel UserModel { get; set; }

        public int Id { get => int.Parse(txtRequestId.Text); }

        public int UserId { get => UserModel.Id; }

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
            List<RequestModel> requests = RequestPresenter.GetCurrentPage();
            dgvRequest.DataSource = requests;
            for (int i = 3; i < 10; i++) dgvRequest.Columns[i].Visible = false;
            txtRequestId.DataBindings.Clear();
            txtUserId.DataBindings.Clear();
            txtRequestDate.DataBindings.Clear();
            txtRequestDescription.DataBindings.Clear();
            txtWorkerId.DataBindings.Clear();
            txtStartDate.DataBindings.Clear();
            txtFinishDate.DataBindings.Clear();
            txtRepairDescription.DataBindings.Clear();
            lbRequestStatus.DataBindings.Clear();
            txtRequestId.DataBindings.Add("Text", requests, "Id");
            txtUserId.DataBindings.Add("Text", requests, "UserId");
            txtRequestDate.DataBindings.Add("Text", requests, "RequestDate");
            txtRequestDescription.DataBindings.Add("Text", requests, "RequestDescription");
            txtWorkerId.DataBindings.Add("Text", requests, "WorkerId");
            txtStartDate.DataBindings.Add("Text", requests, "StartDate");
            txtFinishDate.DataBindings.Add("Text", requests, "FinishDate");
            txtRepairDescription.DataBindings.Add("Text", requests, "RepairDescription");
            lbRequestStatus.DataBindings.Add("Text", requests, "StatusName");
            dgvRequest.ClearSelection();
            btnPrePage.Enabled = RequestPresenter.HasPreviousPage();
            btnNextPage.Enabled = RequestPresenter.HasNextPage();
        }
        

        private void lbBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbBackIcon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void plMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Location.X + e.X - x, Location.Y + e.Y - y);
            }
        }

        private void plEdge_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void plEdge_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Location.X + e.X - x, Location.Y + e.Y - y);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string requestDescription = Interaction.InputBox("Enter the request description", "New Request");
            if (string.IsNullOrWhiteSpace(requestDescription)) return;
            if (requestDescription.Length > 300)
            {
                MessageBox.Show("Request description must be not greater than 300 chars.", "Error");
                return;
            }
            txtRequestDescription.Text = requestDescription;
            try
            {
                RequestPresenter.AddRequestModel();
                RequestPresenter.GoToLastPage();
                LoadTable();
                DeviceStatus.Text = "DEVICE_BROKEN";
                btnNew.Enabled = false;
                MessageBox.Show("Add successful.", "Information");
            }
            catch
            {
                MessageBox.Show("Add failed", "Information");
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
                RequestPresenter.StartRequestModel();
                LoadTable();
                MessageBox.Show("Start successful.", "Information");
            }
            catch
            {
                MessageBox.Show("Start failed", "Information");
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            string repairDescription = Interaction.InputBox("Enter the repair description", "Finish Request");
            if (string.IsNullOrWhiteSpace(repairDescription)) return;
            if (repairDescription.Length > 300)
            {
                MessageBox.Show("Repair description must be not greater than 300 chars.", "Error");
                return;
            }
            txtRepairDescription.Text = repairDescription;
            try
            {
                RequestPresenter.FinishRequestModel();
                LoadTable();
                DeviceStatus.Text = "DEVICE_ACTIVE";
                MessageBox.Show("Finish successful.", "Information");
            }
            catch
            {
                MessageBox.Show("Finish failed", "Information");
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

        private void dgvRequest_SelectionChanged(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            btnFix.Enabled = false;
            btnFinish.Enabled = false;
            if (UserModel.RoleName.Equals("USER"))
            {
                btnNew.Enabled = DeviceStatus.Text.Equals("DEVICE_ACTIVE");
            }
            if (UserModel.RoleName.Equals("WORKER") && (lbRequestStatus.Text.Equals("REQUEST_INITIAL") || lbRequestStatus.Text.Equals("REQUEST_START")))
            {
                btnFix.Enabled = txtWorkerId.Text.Equals(string.Empty);
                btnFinish.Enabled = txtWorkerId.Text.Equals(UserModel.Id.ToString());
            }
        }

        private void plMain_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
    }
}
