using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceManagement.Views
{
    
    // respresents login view with credentials.
    public interface IUserView : IView
    {
        int Id { get; }
        string Username { get; }
        string Password { get; }
        string SearchValue { get; }

    }
}
