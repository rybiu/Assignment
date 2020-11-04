using DeviceManagement.Models;
using DeviceManagement.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DeviceManagement
{
    public partial class FormDashboard : Form, IDashboard
    {
        int x, y;
        UserModel UserModel;

        FormHome FormHome;
        FormUser FormUser;
        FormWorker FormWorker;
        FormStatistic FormStatistic;
        FormDevice FormDevice;
        FormRoom FormRoom;

        Label[] MenuItems;

        public FormDashboard(UserModel userModel)
        {
            InitializeComponent();
            UserModel = userModel;
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            MenuResetColor();
            MenuFocusColor(lblHome);

            FormHome.BringToFront();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            MenuResetColor();
            MenuFocusColor(lblUser);

            if (!plContent.Controls.Contains(FormUser))
            {
                FormUser = new FormUser();
                FormUser.TopLevel = false;
                plContent.Controls.Add(FormUser);
                FormUser.Dock = DockStyle.Fill;
                FormUser.Show();
            }
            FormUser.BringToFront();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            Dispose();
            new FormLogin().Show();
        }

        private void lblWorker_Click(object sender, EventArgs e)
        {
            MenuResetColor();
            MenuFocusColor(lblWorker);

            if (!plContent.Controls.Contains(FormWorker))
            {
                FormWorker = new FormWorker();
                FormWorker.TopLevel = false;
                plContent.Controls.Add(FormWorker);
                FormWorker.Dock = DockStyle.Fill;
                FormWorker.Show();
            }
            FormWorker.BringToFront();
        }

        private void lblDevice_Click(object sender, EventArgs e)
        {
            MenuResetColor();
            MenuFocusColor(lblDevice);

            if (!plContent.Controls.Contains(FormDevice))
            {
                FormDevice = new FormDevice(UserModel);
                FormDevice.TopLevel = false;
                plContent.Controls.Add(FormDevice);
                FormDevice.Dock = DockStyle.Fill;
                FormDevice.Show();
            }
            FormDevice.BringToFront();
        }

        private void lblRoom_Click(object sender, EventArgs e)
        {
            MenuResetColor();
            MenuFocusColor(lblRoom);

            if (!plContent.Controls.Contains(FormRoom))
            {
                FormRoom = new FormRoom();
                FormRoom.TopLevel = false;
                plContent.Controls.Add(FormRoom);
                FormRoom.Dock = DockStyle.Fill;
                FormRoom.Show();
            }
            FormRoom.BringToFront();
        }

        private void panelEdge_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void panelEdge_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Location.X + e.X - x, Location.Y + e.Y - y);
            }
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            MenuItems = new Label[] { lblHome, lblUser, lblWorker, lblDevice, lblRoom, lblStatistic };
            MenuResetColor();
            MenuFocusColor(lblHome);

            if (!UserModel.RoleName.Equals("ADMIN"))
            {
                lblUser.Visible = false;
                lblWorker.Visible = false;
                lblRoom.Visible = false;
                lblStatistic.Visible = false;
            }
            lbRole.Text = UserModel.RoleName.ToUpper();
            if (UserModel.Username.Length > 8)
            {
                lbUsername.Text = UserModel.Username.Substring(0, 7).ToUpper() + "*";
            }
            else
            {
                lbUsername.Text = UserModel.Username.ToUpper();
            }

            FormHome = new FormHome();
            FormHome.TopLevel = false;
            plContent.Controls.Add(FormHome);
            FormHome.Dock = DockStyle.Fill;
            FormHome.Show();
        }

        private void FormDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void FormDashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Location.X + e.X - x, Location.Y + e.Y - y);
            }
        }

        private void lblStatistic_Click(object sender, EventArgs e)
        {
            MenuResetColor();
            MenuFocusColor(lblStatistic);

            if (!plContent.Controls.Contains(FormStatistic))
            {
                FormStatistic = new FormStatistic();
                FormStatistic.TopLevel = false;
                plContent.Controls.Add(FormStatistic);
                FormStatistic.Dock = DockStyle.Fill;
                FormStatistic.Show();
            }
            FormStatistic.BringToFront();
        }

        private void MenuResetColor()
        {
            foreach (var item in MenuItems)
            {
                item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            }
        }

        private void FormDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormLogin().Show();
        }

        private void MenuFocusColor(Label label)
        {
            label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
        }

    }
}
