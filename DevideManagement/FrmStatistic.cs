using DeviceManagement.DAO;
using DeviceManagement.DTO;
using DeviceManagement.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace DeviceManagement
{
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }

        private void rdByFixTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rdByFixTime.Checked)
            {
                plFixedTime.Visible = true;
                plStatus.Visible = false;
            }
        }

        private void rdByStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdByStatus.Checked)
            {
                plStatus.Visible = true;
                plFixedTime.Visible = false;
            }
        }

        private void btnFilterFixedTime_Click(object sender, EventArgs e)
        {
            int min = int.Parse(txtMinTime.Text);
            int max = int.Parse(txtMaxTime.Text);
            DeviceDAO dao = new DeviceDAO();
            dgvDevice.DataSource = null;
            dgvDevice.DataSource = dao.GetDevicesByFixedTime(min, max);
        }

        private void btnFilterStatus_Click(object sender, EventArgs e)
        {
            string startDate = txtFromDate.Text;
            string endDate = txtToDate.Text;
            bool status = cbStatus.Text.Equals("ACTIVE");
            DeviceDAO dao = new DeviceDAO();
            dgvDevice.DataSource = null;
            dgvDevice.DataSource = dao.GetDevicesByStatus(status, startDate, endDate);
        }
    }
}
