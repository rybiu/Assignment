using System.Collections.Generic;

namespace DeviceManagement.Views
{
    
    // respresents room view with credentials.
    public interface IRoomView : IView
    {
        int Id { get; }
        string RoomName { get; }
        List<dynamic> LeftTableData { get; }
        List<dynamic> RightTableData { get; }
        string SearchValue { get; }
    }
}
