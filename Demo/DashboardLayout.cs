using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class FrmManager : Form
    {
        Panel conntentPanel = null;
        FrmUser frmUser;
        FrmWorker frmWorker;
        FrmStatistic frmStatistic;
        FrmDevice frmDevice;
        FrmRoom frmRoom;
        
        public FrmManager()
        {
            InitializeComponent();

        }

        

        private void lblHome_Click(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.Black;
            lblUser.BackColor = Color.DarkSlateGray;
            lblWorker.BackColor = Color.DarkSlateGray;
            lblDevice.BackColor = Color.DarkSlateGray;
            lblRoom.BackColor = Color.DarkSlateGray;
            lblStatistic.BackColor = Color.DarkSlateGray;

            pnlHome.Controls.Remove(frmUser);
            pnlHome.Controls.Remove(frmWorker);
            pnlHome.Controls.Remove(frmStatistic);
            pnlHome.Controls.Remove(frmRoom);
            pnlHome.Controls.Remove(frmDevice);

        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.DarkSlateGray;
            lblWorker.BackColor = Color.DarkSlateGray;
            lblDevice.BackColor = Color.DarkSlateGray;
            lblRoom.BackColor = Color.DarkSlateGray;
            lblStatistic.BackColor = Color.DarkSlateGray;
            lblUser.BackColor = Color.Black;

            pnlHome.Controls.Remove(frmRoom);
            pnlHome.Controls.Remove(frmDevice);
            pnlHome.Controls.Remove(frmWorker);
            pnlHome.Controls.Remove(frmStatistic);

            frmUser = new FrmUser();
            frmUser.TopLevel = false;
            pnlHome.Controls.Add(frmUser);
            frmUser.Dock = DockStyle.Fill;
            frmUser.Show();
            

        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblWorker_Click(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.DarkSlateGray;
            lblWorker.BackColor = Color.Black;
            lblDevice.BackColor = Color.DarkSlateGray;
            lblRoom.BackColor = Color.DarkSlateGray;
            lblStatistic.BackColor = Color.DarkSlateGray;
            lblUser.BackColor = Color.DarkSlateGray;

            pnlHome.Controls.Remove(frmUser);
            pnlHome.Controls.Remove(frmStatistic);
            pnlHome.Controls.Remove(frmRoom);
            pnlHome.Controls.Remove(frmDevice);

            frmWorker = new FrmWorker();
            frmWorker.TopLevel = false;
            pnlHome.Controls.Add(frmWorker);
            frmWorker.Dock = DockStyle.Fill;
            frmWorker.Show();

        }

        private void lblDevice_Click(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.DarkSlateGray;
            lblWorker.BackColor = Color.DarkSlateGray;
            lblDevice.BackColor = Color.Black;
            lblRoom.BackColor = Color.DarkSlateGray;
            lblStatistic.BackColor = Color.DarkSlateGray;
            lblUser.BackColor = Color.DarkSlateGray;

            pnlHome.Controls.Remove(frmUser);
            pnlHome.Controls.Remove(frmWorker);
            pnlHome.Controls.Remove(frmStatistic);
            pnlHome.Controls.Remove(frmRoom);
            frmDevice = new FrmDevice();
            frmDevice.TopLevel = false;
            pnlHome.Controls.Add(frmDevice);
            frmDevice.Dock = DockStyle.Fill;
            frmDevice.Show();
        }

        private void FrmManager_Load(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.Black;
            lblWorker.BackColor = Color.DarkSlateGray;
            lblDevice.BackColor = Color.DarkSlateGray;
            lblRoom.BackColor = Color.DarkSlateGray;
            lblStatistic.BackColor = Color.DarkSlateGray;
            lblUser.BackColor = Color.DarkSlateGray;
            pnlHome.Visible = true;
            pnlHome.Controls.Remove(frmUser);
            pnlHome.Controls.Remove(frmWorker);
            pnlHome.Controls.Remove(frmStatistic);
            pnlHome.Controls.Remove(frmRoom);
            pnlHome.Controls.Remove(frmDevice);
        }

        private void lblRoom_Click(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.DarkSlateGray;
            lblWorker.BackColor = Color.DarkSlateGray;
            lblDevice.BackColor = Color.DarkSlateGray;
            lblRoom.BackColor = Color.Black;
            lblStatistic.BackColor = Color.DarkSlateGray;
            lblUser.BackColor = Color.DarkSlateGray;

            pnlHome.Controls.Remove(frmUser);
            pnlHome.Controls.Remove(frmWorker);
            pnlHome.Controls.Remove(frmStatistic);
            pnlHome.Controls.Remove(frmDevice);

            frmRoom = new FrmRoom();
            frmRoom.TopLevel = false;
            pnlHome.Controls.Add(frmRoom);
            frmRoom.Dock = DockStyle.Fill;
            frmRoom.Show();
        }

        private void lblStatistic_Click(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.DarkSlateGray;
            lblWorker.BackColor = Color.DarkSlateGray;
            lblDevice.BackColor = Color.DarkSlateGray;
            lblRoom.BackColor = Color.DarkSlateGray;
            lblStatistic.BackColor = Color.Black;
            lblUser.BackColor = Color.DarkSlateGray;

            pnlHome.Controls.Remove(frmUser);
            pnlHome.Controls.Remove(frmWorker);
            pnlHome.Controls.Remove(frmRoom);
            pnlHome.Controls.Remove(frmDevice);

            frmStatistic = new FrmStatistic();
            frmStatistic.TopLevel = false;
            pnlHome.Controls.Add(frmStatistic);
            frmStatistic.Dock = DockStyle.Fill;
            frmStatistic.Show();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ckbByFixTime_CheckedChanged(object sender, EventArgs e)
        {

            //ckbByStatus.Checked = false;
            //pnlByFixedTime.BringToFront();
        }

        private void ckbByStatus_CheckedChanged(object sender, EventArgs e)
        {
            //ckbByFixTime.Checked = false;
            //pnlByStatus.BringToFront();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {

        }
    }
}
