using DeviceManagement.Presenters;
using DeviceManagement.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DeviceManagement
{
    public partial class FormStatistic : Form, IStatisticView
    {

        StatisticPresenter StatisticPresenter;

        public int MinTime { get => int.Parse(txtMinTime.Text); }

        public int MaxTime { get => int.Parse(txtMaxTime.Text); }

        public string FromDate { get => txtFromDate.Text; }

        public string ToDate { get => txtToDate.Text; }

        public bool StatusDevice { get => cbStatus.Text.Equals("ACTIVE"); }

        public FormStatistic()
        {
            InitializeComponent();
            StatisticPresenter = new StatisticPresenter(this);
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
            int min;
            try
            {
                min = int.Parse(txtMinTime.Text);
                if (min < 0) throw new Exception();
            }
            catch
            {
                MessageBox.Show("Min times must be non-negative number.", "Error");
                return;
            }
            try
            {
                int max = int.Parse(txtMaxTime.Text);
                if (max < 0) throw new Exception();
                if (min > max)
                {
                    MessageBox.Show("Max times must be greater than min times.", "Error");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Max times must be non-negative number.", "Error");
                return;
            }
            try
            {
                List<dynamic> devices = StatisticPresenter.GetDeviceListByFixedTime();
                dgvDevice.DataSource = devices;
                if (devices.Count == 0)
                {
                    MessageBox.Show("No devices are matched.", "Information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnFilterStatus_Click(object sender, EventArgs e)
        {
            DateTime fromDate = default;
            try
            {
                fromDate = DateTime.Parse(txtFromDate.Text);
            } catch
            {
                MessageBox.Show("From date is wrong format.", "Error");
                return;
            }
            DateTime toDate = default;
            try
            {
                toDate = DateTime.Parse(txtToDate.Text);
            }
            catch
            {
                MessageBox.Show("To date is wrong format.", "Error");
                return;
            }
            if (fromDate != default && toDate != default && DateTime.Compare(fromDate, toDate) > 0)
            {
                MessageBox.Show("To date must be later than from date.", "Error");
                return;
            }
            try
            {
                List<dynamic> devices = StatisticPresenter.GetDeviceListByStatus();
                dgvDevice.DataSource = devices;
                if (devices.Count == 0)
                {
                    MessageBox.Show("No devices are matched.", "Information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
