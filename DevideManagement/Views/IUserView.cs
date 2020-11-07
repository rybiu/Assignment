namespace DeviceManagement.Views
{
    
    // respresents user view with credentials.
    public interface IUserView : IView
    {
        int Id { get; }
        string Username { get; }
        string Password { get; }
        string SearchValue { get; }

    }
}
