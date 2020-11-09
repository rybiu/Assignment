using DeviceManagement.Models;

namespace DeviceManagement.Views
{
    
    // respresents request view with credentials.
    public interface IRequestView : IView
    {
        int Id { get; }
        int DeviceId { get; }
        UserModel UserModel { get; }
        string RequestDescription { get; }
        string RepairDescription { get; }

    }
}
