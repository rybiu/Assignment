using DeviceManagement.Models;
using DeviceManagement.Presenters;
using DeviceManagement.Views;
using DevideManagement;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DeviceManagement
{
    public partial class FormDevice: Form, IDeviceView
    {
    
        bool isChangeImage = false;

        private DevicePresenter DevicePresenter;

        public int Id { get => int.Parse(txtDeviceId.Text); }

        public string DeviceName { get => txtDeviceName.Text.Trim(); }

        public string Description { get => txtDeviceDescription.Text.Trim(); }

        public string CategoryName { get => cbCategory.Text.Trim(); }

        public Image Image { get => pbImage.Image; }

        public DateTime? BoughtDate 
        { 
            get 
            {    
                DateTime.TryParse(txtBoughtDate.Text.Trim(), out DateTime value);
                return value;
            }
        }

        public DateTime? WarrantyDate
        {
            get
            {
                DateTime.TryParse(txtWarrantyDate.Text.Trim(), out DateTime value);
                return value;
            }
        }

        public string SearchValue { get => txtSearch.Text; }

        public UserModel UserModel { get; set; }

        public FormDevice(UserModel userModel)
        {
            InitializeComponent();
            UserModel = userModel;
            DevicePresenter = new DevicePresenter(this);
        }

        private void LoadTable()
        {
            List<DeviceModel> data = DevicePresenter.GetCurrentPage();
            if (data.Count == 0) return;
            List<dynamic> devices = new List<dynamic>();
            foreach(var item in data)
            {
                devices.Add(new
                {
                    Id = item.Id,
                    Name = item.Name,
                    CategoryName = item.CategoryName,
                    ImageView = item.ImageView,
                    Description = item.Description,
                    BoughtDate = item.BoughtDate,
                    WarrantyDate = item.WarrantyDate,
                    StatusName = item.StatusName
                });
            }
            dgvDevice.DataSource = devices;
            // hide some column
            for (int i = 2; i <= 7; i++) dgvDevice.Columns[i].Visible = false;
            txtDeviceId.DataBindings.Clear();
            txtDeviceName.DataBindings.Clear();
            cbCategory.DataBindings.Clear();
            pbImage.DataBindings.Clear();
            txtDeviceDescription.DataBindings.Clear();
            txtBoughtDate.DataBindings.Clear();
            txtWarrantyDate.DataBindings.Clear();
            lbStatus.DataBindings.Clear();
            txtDeviceId.DataBindings.Add("Text", devices, "Id");
            txtDeviceName.DataBindings.Add("Text", devices, "Name");
            cbCategory.DataBindings.Add("Text", devices, "CategoryName");
            pbImage.DataBindings.Add(new Binding("Image", devices, "ImageView", true));
            txtDeviceDescription.DataBindings.Add("Text", devices, "Description");
            txtBoughtDate.DataBindings.Add("Text", devices, "BoughtDate");
            txtWarrantyDate.DataBindings.Add("Text", devices, "WarrantyDate");
            lbStatus.DataBindings.Add("Text", devices, "StatusName");
            dgvDevice.ClearSelection();
            btnPrePage.Enabled = DevicePresenter.HasPreviousPage();
            btnNextPage.Enabled = DevicePresenter.HasNextPage();
        }

        private void FrmDevice_Load(object sender, EventArgs e)
        {
            LoadTable();
            // if user role is not admin, un-enable all command button
            if (!UserModel.RoleName.Equals("ADMIN"))
            {
                btnNew.Enabled = false;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnRemoveImage.Enabled = false;
                btnChooseImage.Enabled = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtDeviceId.Text = string.Empty;
            txtDeviceName.Text = string.Empty;
            cbCategory.Text = string.Empty;
            txtDeviceDescription.Text = string.Empty;
            txtBoughtDate.Text = string.Empty;
            txtWarrantyDate.Text = string.Empty;
            lbStatusActive.Visible = true;
            pbImage.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDeviceId.Text.Length != 0) return;
            if (txtDeviceName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Device name must be not empty.", "Error");
                return;
            }
            if (txtDeviceName.Text.Trim().Length > 50)
            {
                MessageBox.Show("Device name must be not greater than 50 chars.", "Error");
                return;
            }
            if (txtDeviceDescription.Text.Trim().Length > 300)
            {
                MessageBox.Show("Device description must be not greater than 300 chars.", "Error");
                return;
            }
            DateTime boughtDate = default;
            try
            {
                if (txtBoughtDate.Text.Trim().Length > 0) 
                { 
                    boughtDate = DateTime.Parse(txtBoughtDate.Text.Trim());
                }
            } catch
            {
                MessageBox.Show("Bought date is wrong format.", "Error");
                return;
            }
            DateTime warrantyDate = default;
            try
            {
                if (txtWarrantyDate.Text.Trim().Length > 0)
                {
                    warrantyDate = DateTime.Parse(txtWarrantyDate.Text.Trim());
                }
            }
            catch
            {
                MessageBox.Show("Warranty date is wrong format.", "Error");
                return;
            }
            if (boughtDate != default && warrantyDate != default && DateTime.Compare(boughtDate, warrantyDate) > 0) 
            {
                MessageBox.Show("Warranty date must be later than bought date.", "Error");
                return;
            }
            try
            {
                DevicePresenter.AddDeviceModel();
                DevicePresenter.GoToLastPage();
                LoadTable();
                MessageBox.Show("Add successful.", "Information");
            }
            catch
            {
                MessageBox.Show("Add failed", "Information");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDeviceId.Text.Length == 0) return;
            if (txtDeviceName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Device name must be not empty.", "Error");
                return;
            }
            DateTime boughtDate = default;
            try
            {
                if (txtBoughtDate.Text.Trim().Length > 0)
                {
                    boughtDate = DateTime.Parse(txtBoughtDate.Text.Trim());
                }
            }
            catch
            {
                MessageBox.Show("Bought date is wrong format.", "Error");
                return;
            }
            DateTime warrantyDate = default;
            try
            {
                if (txtWarrantyDate.Text.Trim().Length > 0)
                {
                    warrantyDate = DateTime.Parse(txtWarrantyDate.Text.Trim());
                }
            }
            catch
            {
                MessageBox.Show("Warranty date is wrong format.", "Error");
                return;
            }
            if (boughtDate != default && warrantyDate != default && DateTime.Compare(boughtDate, warrantyDate) > 0)
            {
                MessageBox.Show("Warranty date must be later than bought date.", "Error");
                return;
            }
            try
            {
                DevicePresenter.UpdateDeviceModel();
                if (isChangeImage) DevicePresenter.UpdateDeviceModelImage();
                LoadTable();
                MessageBox.Show("Update successful.", "Information");
            }
            catch
            {
                MessageBox.Show("Update failed", "Information");
            } finally 
            {
                isChangeImage = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDeviceId.Text.Length == 0) return;
            try
            {
                DevicePresenter.DeleteDeviceModel();
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
            DevicePresenter.GoToPreviousPage();
            LoadTable();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            DevicePresenter.GoToNextPage();
            LoadTable();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(ofd.FileName);
                    pbImage.Image = img;
                    isChangeImage = true;
                }
            }
        }

        private void dgvDevice_SelectionChanged(object sender, EventArgs e)
        {
            cbCategory.Items.Clear();
            List<CategoryModel> categories = DevicePresenter.GetCategories();
            foreach (var category in categories)
            {
                cbCategory.Items.Add(category.Name);
            }
            isChangeImage = false;
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            if (txtDeviceId.Text.Length == 0) return;
            if (pbImage.Image == null) return;
            try
            {
                DevicePresenter.RemoveDeviceModelImage();
                LoadTable();
                MessageBox.Show("Remove successful.", "Information");
            }
            catch
            {
                MessageBox.Show("Remove failed", "Information");
            }
        }

        private void lbStatus_TextChanged(object sender, EventArgs e)
        {
            lbStatusActive.Visible = lbStatus.Text.Equals("DEVICE_ACTIVE");
            lbStatusInactive.Visible = !lbStatusActive.Visible;
        }

        private void txtBoughtDate_Enter(object sender, EventArgs e)
        {
            txtBoughtDate.DataBindings.Clear();
            txtWarrantyDate.DataBindings.Clear();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            new FormRequest(Id, UserModel, ref lbStatus).ShowDialog();
            LoadTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DevicePresenter.GoToFirstPage();
            if (DevicePresenter.GetCurrentPage().Count == 0)
            {
                MessageBox.Show("No devices are matched.", "Information");
            }
            else
            {
                LoadTable();
            }
        }
    }
}
