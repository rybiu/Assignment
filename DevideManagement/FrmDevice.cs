using DeviceManagement.DAO;
using DeviceManagement.DTO;
using DeviceManagement.Utils;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace DeviceManagement
{
    public partial class FrmDevice: Form
    {
        Pagination Pagination;
        DataTable dtDeviceList;
        bool isChangeImage = false;

        public FrmDevice()
        {
            InitializeComponent();
            Pagination = new Pagination();
            DeviceDAO dao = new DeviceDAO();
            DataTable list = dao.GetDevices();
            list.PrimaryKey = new DataColumn[] { list.Columns["id"] };
            Pagination.Data = list;
        }

        private void LoadTable()
        {
            dtDeviceList = Pagination.GetCurrentPage();
            dgvDevice.DataSource = dtDeviceList;
            dgvDevice.Columns[3].Visible = false;
            dgvDevice.Columns[4].Visible = false;
            dgvDevice.Columns[5].Visible = false;
            dgvDevice.Columns[6].Visible = false;
            dgvDevice.Columns[7].Visible = false;
            txtDeviceId.DataBindings.Clear();
            txtDeviceName.DataBindings.Clear();
            txtDeviceType.DataBindings.Clear();
            txtDeviceDescription.DataBindings.Clear();
            txtBoughtDate.DataBindings.Clear();
            txtWarrantyDate.DataBindings.Clear();
            lbStatusActive.DataBindings.Clear();
            lbStatusInactive.DataBindings.Clear();
            txtDeviceId.DataBindings.Add("Text", dtDeviceList, "id");
            txtDeviceName.DataBindings.Add("Text", dtDeviceList, "name");
            txtDeviceType.DataBindings.Add("Text", dtDeviceList, "type");
            txtDeviceDescription.DataBindings.Add("Text", dtDeviceList, "description");
            txtBoughtDate.DataBindings.Add("Text", dtDeviceList, "bought_date");
            txtWarrantyDate.DataBindings.Add("Text", dtDeviceList, "warranty_date");
            lbStatusActive.DataBindings.Add("Visible", dtDeviceList, "action");
            btnPrePage.Enabled = Pagination.HasPrePage();
            btnNextPage.Enabled = Pagination.HasNextPage();
        }

        private void FrmDevice_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void lbStatusActive_VisibleChanged(object sender, EventArgs e)
        {
            lbStatusInactive.Visible = !lbStatusActive.Visible;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtDeviceId.Text = string.Empty;
            txtDeviceName.Text = string.Empty;
            txtDeviceType.Text = string.Empty;
            txtDeviceDescription.Text = string.Empty;
            txtBoughtDate.Text = string.Empty;
            txtWarrantyDate.Text = string.Empty;
            lbStatusActive.Visible = true;
            pbImage.Image = null;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDeviceName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Device name must be not empty.");
                return;
            }
            DateTime? boughtDate = null;
            try
            {
                if (txtBoughtDate.Text.Length > 0)
                {
                    boughtDate = DateTime.Parse(txtBoughtDate.Text.Trim());
                }
            } catch (FormatException ex)
            {
                MessageBox.Show("Bought date is wrong format.");
                return;
            }
            DateTime? warrantyDate = null;
            try
            {
                if (txtWarrantyDate.Text.Length > 0)
                {
                    warrantyDate = DateTime.Parse(txtWarrantyDate.Text.Trim());
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Warranty date is wrong format.");
                return;
            }
            DeviceDAO dao = new DeviceDAO();
            DeviceDTO dto = new DeviceDTO
            {
                name = txtDeviceName.Text.Trim(),
                type = txtDeviceType.Text.Trim(),
                description = txtDeviceDescription.Text.Trim(),
                boughtDate = boughtDate,
                warrantyDate = warrantyDate,
                image = ImageHelper.ImageToByteArray(pbImage.Image)
            };
            if (dao.AddDevice(dto))
            {
                int id = dao.GetLastId();
                Pagination.Data.Rows.Add(id, dto.name, dto.type, dto.description, dto.image, dto.boughtDate, dto.warrantyDate, true);
                Pagination.GoToLastPage();
                LoadTable();
                MessageBox.Show("Add success.");
            }
            else
            {
                MessageBox.Show("Add fail.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDeviceId.Text.Length == 0) return;
            if (txtDeviceName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Device name must be not empty.");
                return;
            }
            DateTime? boughtDate = null;
            try
            {
                if (txtBoughtDate.Text.Length > 0)
                {
                    boughtDate = DateTime.Parse(txtBoughtDate.Text.Trim());
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Bought date is wrong format.");
                return;
            }
            DateTime? warrantyDate = null;
            try
            {
                if (txtWarrantyDate.Text.Length > 0)
                {
                    warrantyDate = DateTime.Parse(txtWarrantyDate.Text.Trim());
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Warranty date is wrong format.");
                return;
            }
            DeviceDAO dao = new DeviceDAO();
            DeviceDTO dto = new DeviceDTO
            {
                id = int.Parse(txtDeviceId.Text),
                name = txtDeviceName.Text.Trim(),
                type = txtDeviceType.Text.Trim(),
                description = txtDeviceDescription.Text.Trim(),
                boughtDate = boughtDate,
                warrantyDate = warrantyDate
            };
            if (dao.UpdateDevice(dto))
            {
                DataRow row = Pagination.Data.Rows.Find(dto.id);
                row["name"] = dto.name;
                row["type"] = dto.type;
                row["description"] = dto.description;
                row["bought_date"] = dto.boughtDate;
                row["warranty_date"] = dto.warrantyDate;
                if (isChangeImage && pbImage.Image != null && dao.UpdateDeviceImage(dto.id, ImageHelper.ImageToByteArray(pbImage.Image))) 
                {
                    row["image"] = ImageHelper.ImageToByteArray(pbImage.Image);
                }
                LoadTable();
                MessageBox.Show("Update success.");
            } else
            {
                MessageBox.Show("Update fail.");
            }
            isChangeImage = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDeviceId.Text.Length == 0) return;
            int id = int.Parse(txtDeviceId.Text);
            DeviceDAO dao = new DeviceDAO();
            if (dao.DeleteDevice(id))
            {
                DataRow row = Pagination.Data.Rows.Find(id);
                Pagination.Data.Rows.Remove(row);
                LoadTable();
                MessageBox.Show("Delete success.");
            }
            else
            {
                MessageBox.Show("Delete fail.");
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
            if (txtDeviceId.Text.Length == 0) return;
            DataRow row = dtDeviceList.Rows.Find(txtDeviceId.Text);
            if (row == null) return;
            if (row[4] == DBNull.Value)
            {
                pbImage.Image = null;
            }
            else
            {
                using (MemoryStream ms = new MemoryStream((byte[])row[4]))
                {
                    pbImage.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            if (txtDeviceId.Text.Length == 0) return;
            int id = int.Parse(txtDeviceId.Text);
            DeviceDAO dao = new DeviceDAO();
            if (dao.UpdateDeviceImage(id, null))
            {
                DataRow row = Pagination.Data.Rows.Find(id);
                row["image"] = null;
                pbImage.Image = null;
                MessageBox.Show("Remove success.");
            } else
            {
                MessageBox.Show("Remove fail.");
            }
        }
    }
}
