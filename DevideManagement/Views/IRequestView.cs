namespace DeviceManagement.Views
{
    
    // respresents request view with credentials.
    public interface IRequestView : IView
    {
        int Id { get; }
        int DeviceId { get; }
        int UserId { get; }
        string RequestDescription { get; }
        string RepairDescription { get; }

    }
}
