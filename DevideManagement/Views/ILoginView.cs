namespace DeviceManagement.Views
{
    
    // respresents login view with credentials.
    public interface ILoginView : IView
    {
        string Username { get; }
        string Password { get; }
    }
}
