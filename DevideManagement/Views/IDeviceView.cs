using DeviceManagement.Models;
using System;
using System.Drawing;

namespace DeviceManagement.Views
{
    
    // respresents device view with credentials.
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
