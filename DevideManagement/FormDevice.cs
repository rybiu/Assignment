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
            try
            {
                // Load device list
                List<DeviceModel> data = DevicePresenter.GetCurrentPage();
                btnPrePage.Enabled = DevicePresenter.HasPreviousPage();
                btnNextPage.Enabled = DevicePresenter.HasNextPage();
                if (data.Count == 0) return;
                List<dynamic> devices = new List<dynamic>();
                foreach (var item in data)
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
                // Hide some column
                for (int i = 2; i <= 7; i++) dgvDevice.Columns[i].Visible = false;

                // Data bindings
                txtDeviceId.DataBindings.Clear();
                txtDeviceName.DataBindings.Clear();
                cbCategory.DataBindings.Clear();
                pbImage.DataBindings.Clear();
                txtDeviceDescription.DataBindings.Clear();
                lbBoughtDate.DataBindings.Clear();
                lbWarrantyDate.DataBindings.Clear();
                lbStatus.DataBindings.Clear();
                txtDeviceId.DataBindings.Add("Text", devices, "Id");
                txtDeviceName.DataBindings.Add("Text", devices, "Name");
                cbCategory.DataBindings.Add("Text", devices, "CategoryName");
                pbImage.DataBindings.Add(new Binding("Image", devices, "ImageView", true));
                txtDeviceDescription.DataBindings.Add("Text", devices, "Description");
                lbBoughtDate.DataBindings.Add("Text", devices, "BoughtDate");
                lbWarrantyDate.DataBindings.Add("Text", devices, "WarrantyDate");
                lbStatus.DataBindings.Add("Text", devices, "StatusName");
                dgvDevice.ClearSelection();

                // Load category list
                cbCategory.Items.Clear();
                List<CategoryModel> categories = DevicePresenter.GetCategories();
                foreach (var category in categories)
                {
                    cbCategory.Items.Add(category.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load failed");
            }
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
            lbStatus.Text = "DEVICE_ACTIVE";
            pbImage.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDeviceId.Text.Length != 0) return;
            if (!isValidInput()) return;
            try
            {
                DevicePresenter.AddDeviceModel();
                DevicePresenter.GoToLastPage();
                LoadTable();
                MessageBox.Show("Add successful.", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add failed");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDeviceId.Text.Length == 0) return;
            if (!isValidInput()) return;
            try
            {
                DevicePresenter.UpdateDeviceModel();
                if (isChangeImage) DevicePresenter.UpdateDeviceModelImage();
                LoadTable();
                MessageBox.Show("Update successful.", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update failed");
            }
            finally 
            {
                isChangeImage = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDeviceId.Text.Length == 0) return;
            DialogResult dr = MessageBox.Show("Are you sure to delete this device?",
                "Delete Device", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr != DialogResult.Yes) return;
            try
            {
                DevicePresenter.DeleteDeviceModel();
                LoadTable();
                MessageBox.Show("Delete successful.", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete failed");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove failed");
            }
        }

        private void lbStatus_TextChanged(object sender, EventArgs e)
        {
            lbStatusActive.Visible = lbStatus.Text.Equals("DEVICE_ACTIVE");
            lbStatusInactive.Visible = !lbStatusActive.Visible;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (dgvDevice.SelectedRows.Count == 0) return;
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

        private void lbBoughtDate_TextChanged(object sender, EventArgs e)
        {
            string date = lbBoughtDate.Text.Substring(0, lbBoughtDate.Text.IndexOf(" "));
            txtBoughtDate.Text = date;
        }

        private void lbWarrantyDate_TextChanged(object sender, EventArgs e)
        {
            string date = lbWarrantyDate.Text.Substring(0, lbWarrantyDate.Text.IndexOf(" "));
            txtWarrantyDate.Text = date;
        }

        private bool isValidInput()
        {
            // Validate device name
            if (string.IsNullOrWhiteSpace(txtDeviceName.Text))
            {
                MessageBox.Show("Device name must be not empty.", "Error");
                return false;
            }
            if (txtDeviceName.Text.Trim().Length > 50)
            {
                MessageBox.Show("Device name must be not greater than 50 chars.", "Error");
                return false;
            }

            // Validate device description
            if (txtDeviceDescription.Text.Trim().Length > 300)
            {
                MessageBox.Show("Device description must be not greater than 300 chars.", "Error");
                return false;
            }

            // Validate bought date
            if (string.IsNullOrWhiteSpace(txtBoughtDate.Text))
            {
                MessageBox.Show("Bought date must be not empty.", "Error");
                return false;
            }
            DateTime boughtDate = default;
            try
            {
                boughtDate = DateTime.Parse(txtBoughtDate.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Bought date is wrong format.", "Error");
                return false;
            }

            // Validate warranty date
            if (string.IsNullOrWhiteSpace(txtWarrantyDate.Text))
            {
                MessageBox.Show("Warranty date must be not empty.", "Error");
                return false;
            }
            DateTime warrantyDate = default;
            try
            {
                warrantyDate = DateTime.Parse(txtWarrantyDate.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Warranty date is wrong format.", "Error");
                return false;
            }
            if (boughtDate != default && warrantyDate != default && DateTime.Compare(boughtDate, warrantyDate) > 0)
            {
                MessageBox.Show("Warranty date must be later than bought date.", "Error");
                return false;
            }

            // No error
            return true;
        }
    }
}
