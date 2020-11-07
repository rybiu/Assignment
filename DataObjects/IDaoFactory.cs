namespace DataObjects
{
    
    public interface IDaoFactory
    {
        IUserDao UserDao { get; }
        IDeviceDao DeviceDao { get; }
        IRoomDao RoomDao { get; }
        IRequestDao RequestDao { get; }
        ICategoryDao CategoryDao { get; }
        IStatusDao StatusDao { get; }
        IRoleDao RoleDao { get; }
    }

}
