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
    /// Login Presenter class.
    /// </summary>
    /// <remarks>
    /// MV Patterns: MVP design pattern.
    /// </remarks>
    public class LoginPresenter : Presenter<ILoginView>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="view">The view</param>
        public LoginPresenter(ILoginView view)
            : base(view)
        {
        }

        /// <summary>
        /// Perform login. Gets data from view and calls model.
        /// </summary>
        public bool Login(out UserModel user)
        {
            string username = View.Username;
            string password = View.Password;
            user = Model.Login(username, password);
            return user != null;
        }
    }
}
