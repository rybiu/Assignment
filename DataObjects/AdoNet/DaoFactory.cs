namespace DataObjects.AdoNet
{
    // Data access object factory
    // ** Factory Pattern

    public class DaoFactory : IDaoFactory
    {
        public IUserDao UserDao { get => new UserDao(); }

        public IDeviceDao DeviceDao { get => new DeviceDao(); }

        public IRoomDao RoomDao { get => new RoomDao(); }

        public IRequestDao RequestDao { get => new RequestDao(); }

        public ICategoryDao CategoryDao { get => new CategoryDao(); }

        public IStatusDao StatusDao { get => new StatusDao(); }

        public IRoleDao RoleDao { get => new RoleDao(); }

    }
}
