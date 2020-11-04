using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceManagement.Views
{
    
    // respresents login view with credentials.
    public interface IRequestView : IView
    {
        int Id { get; }
        int DeviceId { get; }
        int UserId { get; }
        string RequestDescription { get; }
        string RepairDescription { get; }

    }
}
