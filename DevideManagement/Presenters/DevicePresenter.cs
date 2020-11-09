using System.Collections.Generic;
using DeviceManagement.Models;
using DeviceManagement.Views;

namespace DeviceManagement.Presenters
{
    /// <summary>
    /// Device Presenter class.
    /// </summary>
    /// <remarks>
    /// MV Patterns: MVP design pattern.
    /// </remarks>
    public class DevicePresenter : Presenter<IDeviceView>, IPagination<DeviceModel>
    {
        protected IPagination<DeviceModel> Pagination;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="view">The view</param>
        public DevicePresenter(IDeviceView view)
            : base(view)
        {
            if (!View.UserModel.RoleName.Equals("USER"))
            {
                Pagination = new PaginationImp<DeviceModel>(_GetDeviceList, _GetDeviceListCount);
            }
            else
            {
                Pagination = new PaginationImp<DeviceModel>(_GetDeviceListForUser, _GetDeviceListCountForUser);
            }
        }

        /// <summary>
        /// Perform device management. Gets data from view and calls model.
        /// </summary>
        /// 

        private List<DeviceModel> _GetDeviceList(int pageIndex, int pageSize)
        {
            return Model.GetDeviceList(View.SearchValue, pageIndex, pageSize);
        }

        private int _GetDeviceListCount()
        {
            return Model.GetDeviceListCount(View.SearchValue);
        }

        private List<DeviceModel> _GetDeviceListForUser(int pageIndex, int pageSize)
        {
            return Model.GetDeviceList(View.UserModel.RoomId, View.SearchValue, pageIndex, pageSize);
        }

        private int _GetDeviceListCountForUser()
        {
            return Model.GetDeviceListCount(View.UserModel.RoomId, View.SearchValue);
        }

        public List<DeviceModel> GetCurrentPage()
        {
            return Pagination.GetCurrentPage();
        }

        public void GoToPreviousPage()
        {
            Pagination.GoToPreviousPage();
        }

        public void GoToNextPage()
        {
            Pagination.GoToNextPage();
        }

        public void GoToFirstPage()
        {
            Pagination.GoToFirstPage();
        }

        public void GoToLastPage()
        {
            Pagination.GoToLastPage();
        }

        public bool HasPreviousPage()
        {
            return Pagination.HasPreviousPage();
        }

        public bool HasNextPage()
        {
            return Pagination.HasNextPage();
        }

        public List<CategoryModel> GetCategories()
        {
            return Model.GetCategories();
        }

        public void AddDeviceModel()
        {
            DeviceModel model = new DeviceModel
            {
                Name = View.DeviceName,
                CategoryName = View.CategoryName,
                Description = View.Description,
                BoughtDate = View.BoughtDate,
                WarrantyDate = View.WarrantyDate,
                ImageView = View.Image
            };
            Model.AddDevice(model);
        }

        public void UpdateDeviceModel()
        {
            DeviceModel model = new DeviceModel
            {
                Id = View.Id,
                Name = View.DeviceName,
                CategoryName = View.CategoryName,
                Description = View.Description,
                BoughtDate = View.BoughtDate,
                WarrantyDate = View.WarrantyDate,
            };
            Model.UpdateDevice(model);
        }

        public void UpdateDeviceModelImage()
        {
            DeviceModel model = new DeviceModel
            {
                Id = View.Id,
                ImageView = View.Image
            };
            Model.UpdateDeviceImage(model);
        }

        public void DeleteDeviceModel()
        {
            Model.DeleteDevice(View.Id);
        }

        public void RemoveDeviceModelImage()
        {
            DeviceModel model = new DeviceModel
            {
                Id = View.Id,
                ImageView = null
            };
            Model.UpdateDeviceImage(model);
        }

        public UserModel GetUserModel()
        {
            return Model.Login(View.UserModel.Username, View.UserModel.Password);
        }

    }
}
