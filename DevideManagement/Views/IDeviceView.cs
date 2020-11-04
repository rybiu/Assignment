using DeviceManagement.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceManagement.Views
{
    
    // respresents login view with credentials.
    public interface IDeviceView : IView
    {
        int Id { get; }
        string DeviceName { get; }
        string Description { get; }
        string CategoryName { get; }
        Image Image { get; }
        DateTime? BoughtDate { get; }
        DateTime? WarrantyDate { get; }
        string SearchValue { get; }
        UserModel UserModel { get; }
    }
}
