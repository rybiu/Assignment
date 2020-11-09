using System.Collections.Generic;
using DeviceManagement.Models;
using DeviceManagement.Views;

namespace DeviceManagement.Presenters
{
    /// <summary>
    /// Request Presenter class.
    /// </summary>
    /// <remarks>
    /// MV Patterns: MVP design pattern.
    /// </remarks>
    public class RequestPresenter : Presenter<IRequestView>, IPagination<RequestModel>
    {
        protected PaginationImp<RequestModel> Pagination;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="view">The view</param>
        public RequestPresenter(IRequestView view)
            : base(view)
        {
            Pagination = new PaginationImp<RequestModel>(_GetRequestList, _GetRequestListCount);
        }

        /// <summary>
        /// Perform request management. Gets data from view and calls model.
        /// </summary>
        /// 

        private List<RequestModel> _GetRequestList(int pageIndex, int pageSize)
        {
            return Model.GetRequestList(View.DeviceId, pageIndex, pageSize);
        }

        private int _GetRequestListCount()
        {
            return Model.GetRequestListCount(View.DeviceId);
        }

        public List<RequestModel> GetCurrentPage()
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

        public void AddRequestModel()
        {  
            Model.AddRequest(View.UserModel.Id, View.RequestDescription, View.DeviceId);
            Model.ChangeDeviceStatus(View.DeviceId, false);
        }

        public void StartRequestModel()
        {
            Model.StartRequest(View.Id, View.UserModel.Id);
        }

        public void FinishRequestModel()
        {
            Model.FinishRequest(View.Id, View.RepairDescription);
            Model.ChangeDeviceStatus(View.DeviceId, true);
        }

        public UserModel GetUserModel()
        {
            return Model.Login(View.UserModel.Username, View.UserModel.Password);
        }

        public DeviceModel GetDeviceModel()
        {
            return Model.GetDevice(View.DeviceId);
        }
    }
}
