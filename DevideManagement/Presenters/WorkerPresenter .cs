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
    /// Worker Presenter class.
    /// </summary>
    /// <remarks>
    /// MV Patterns: MVP design pattern.
    /// </remarks>
    public class WorkerPresenter : UserPresenter
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="view">The view</param>
        public WorkerPresenter(IUserView view)
            : base(view)
        {
            Pagination = new PaginationImp<UserModel>(_GetWorkerList, _GetWorkerListCount);
        }

        /// <summary>
        /// Perform worker management. Gets data from view and calls model.
        /// </summary>
        /// 
        private List<UserModel> _GetWorkerList(int pageIndex, int pageSize)
        {
            return Model.GetWorkerList(View.SearchValue, pageIndex, pageSize);
        }

        private int _GetWorkerListCount()
        {
            return Model.GetWorkerListCount(View.SearchValue);
        }

        public new void AddUserModel()
        {
            UserModel model = new UserModel { Username = View.Username, Password = View.Password };
            Model.AddWorker(model);        
        }
    }
}
