using System.Collections.Generic;
using DeviceManagement.Models;
using DeviceManagement.Views;

namespace DeviceManagement.Presenters
{
    /// <summary>
    /// Room Presenter class.
    /// </summary>
    /// <remarks>
    /// MV Patterns: MVP design pattern.
    /// </remarks>
    public class RoomPresenter : Presenter<IRoomView>, IPagination<RoomModel>
    {
        protected IPagination<RoomModel> Pagination;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="view">The view</param>
        public RoomPresenter(IRoomView view)
            : base(view)
        {
            Pagination = new PaginationImp<RoomModel>(_GetRoomList, _GetRoomListCount);
        }

        /// <summary>
        /// Perform room management. Gets data from view and calls model.
        /// </summary>
        /// 
        private List<RoomModel> _GetRoomList(int pageIndex, int pageSize)
        {
            return Model.GetRoomList(View.SearchValue, pageIndex, pageSize);
        }

        private int _GetRoomListCount()
        {
            return Model.GetRoomListCount(View.SearchValue);
        }

        public List<RoomModel> GetCurrentPage()
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

        public void AddRoomModel()
        {
            RoomModel model = new RoomModel
            {
                Name = View.RoomName
            };
            Model.AddRoom(model);
        }

        public void UpdateRoomModel()
        {
            RoomModel model = new RoomModel
            {
                Id = View.Id,
                Name = View.RoomName
            };
            Model.UpdateRoom(model);
        }

        public void DeleteRoomModel()
        {
            Model.DeleteRoom(View.Id);
        }

        public List<UserModel> GetUserListInRoom()
        {
            return Model.GetUserListInRoom(View.Id);
        }

        public List<UserModel> GetUserListNoneRoom()
        {
            return Model.GetUserListNoneRoom();
        }

        public List<DeviceModel> GetDeviceListInRoom()
        {
            return Model.GetDeviceListInRoom(View.Id);
        }

        public List<DeviceModel> GetDeviceListNoneRoom()
        {
            return Model.GetDeviceListNoneRoom();
        }

        public void SaveFeatureUser()
        {
            foreach (var item in View.LeftTableData) {
                Model.UpdateUserRoomId(item.id, -1);
            }
            foreach (var item in View.RightTableData)
            {
                Model.UpdateUserRoomId(item.id, View.Id);
            }
        }

        public void SaveFeatureDevice()
        {
            foreach (var item in View.LeftTableData)
            {
                Model.UpdateDeviceRoomId(item.id, -1);
            }
            foreach (var item in View.RightTableData)
            {
                Model.UpdateDeviceRoomId(item.id, View.Id);
            }
        }

    }
}
