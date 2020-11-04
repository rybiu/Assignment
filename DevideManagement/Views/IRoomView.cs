using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceManagement.Views
{
    
    // respresents login view with credentials.
    public interface IRoomView : IView
    {
        int Id { get; }
        string RoomName { get; }
        List<dynamic> LeftTableData { get; }
        List<dynamic> RightTableData { get; }
        string SearchValue { get; }
    }
}
