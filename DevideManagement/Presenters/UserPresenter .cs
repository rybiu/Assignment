using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObjects;
using DeviceManagement.Models;
using DeviceManagement.Views;

namespace DeviceManagement.Presenters
{
    /// <summary>
    /// User Presenter class.
    /// </summary>
    /// <remarks>
    /// MV Patterns: MVP design pattern.
    /// </remarks>
    public class UserPresenter : Presenter<IUserView>, IPagination<UserModel>
    {
        protected PaginationImp<UserModel> Pagination;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="view">The view</param>
        public UserPresenter(IUserView view)
            : base(view)
        {
            Pagination = new PaginationImp<UserModel>(_GetUserList, _GetUserListCount);
        }

        /// <summary>
        /// Perform user management. Gets data from view and calls model.
        /// </summary>
        /// 
        private List<UserModel> _GetUserList(int pageIndex, int pageSize)
        {
            return Model.GetUserList(View.SearchValue, pageIndex, pageSize);
        }

        private int _GetUserListCount()
        {
            return Model.GetUserListCount(View.SearchValue);
        }

        public List<UserModel> GetCurrentPage()
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

        public bool IsExistUsername()
        {
            return Model.IsExistUsername(View.Username);
        }

        public void AddUserModel()
        {
            UserModel model = new UserModel { Username = View.Username, Password = View.Password };
            Model.AddUser(model);        
        }

        public void UpdateUserModel()
        {
            UserModel model = new UserModel { Id = View.Id, Username = View.Username, Password = View.Password };
            Model.UpdateUser(model);
        }

        public void DeleteUserModel()
        {
            Model.DeleteUser(View.Id);
        }
    }
}
