using BusinessObjects;
using DataObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManagementService
{

    public class Service : IService
    {
        static readonly string provider = ConfigurationManager.AppSettings.Get("DataProvider");
        static readonly IDaoFactory factory = DaoFactories.GetFactory(provider);
        
        static readonly ICategoryDao categoryDao = factory.CategoryDao;
        static readonly IUserDao userDao = factory.UserDao;
        static readonly IDeviceDao deviceDao = factory.DeviceDao;
        static readonly IRoomDao roomDao = factory.RoomDao;
        static readonly IRequestDao requestDao = factory.RequestDao;
        static readonly IRoleDao roleDao = factory.RoleDao;
        static readonly IStatusDao statusDao = factory.StatusDao;

        #region User Service

        public int AddUser(User user)
        {
            user.RoleId = roleDao.GetRole(Role.VALUE.USER.ToString()).Id;
            user.StatusId = statusDao.GetStatus(Status.VALUE.USER_ACTIVE.ToString()).Id;
            return userDao.AddUser(user);
        }

        public int AddWorker(User user)
        {
            user.RoleId = roleDao.GetRole(Role.VALUE.WORKER.ToString()).Id;
            user.StatusId = statusDao.GetStatus(Status.VALUE.USER_ACTIVE.ToString()).Id;
            return userDao.AddUser(user);
        }

        public bool DeleteUser(int userId)
        {
            int statusId = statusDao.GetStatus(Status.VALUE.USER_INACTIVE.ToString()).Id;
            return userDao.DeleteUser(userId, statusId);
        }

        public int GetUserListCount(string searchValue)
        {
            int roleId = roleDao.GetRole(Role.VALUE.USER.ToString()).Id;
            int statusId = statusDao.GetStatus(Status.VALUE.USER_ACTIVE.ToString()).Id;
            return userDao.GetUsersCount(searchValue, roleId, statusId);
        }

        public List<User> GetUserList(string searchValue, int pageIndex, int pageSize)
        {
            int roleId = roleDao.GetRole(Role.VALUE.USER.ToString()).Id;
            int statusId = statusDao.GetStatus(Status.VALUE.USER_ACTIVE.ToString()).Id;
            return userDao.GetUsers(searchValue, roleId, statusId, (pageIndex - 1) * pageSize, pageSize);
        }

        public int GetWorkerListCount(string searchValue)
        {
            int roleId = roleDao.GetRole(Role.VALUE.WORKER.ToString()).Id;
            int statusId = statusDao.GetStatus(Status.VALUE.USER_ACTIVE.ToString()).Id;
            return userDao.GetUsersCount(searchValue, roleId, statusId);
        }

        public List<User> GetWorkerList(string searchValue, int pageIndex, int pageSize)
        {
            int roleId = roleDao.GetRole(Role.VALUE.WORKER.ToString()).Id;
            int statusId = statusDao.GetStatus(Status.VALUE.USER_ACTIVE.ToString()).Id;
            return userDao.GetUsers(searchValue, roleId, statusId, (pageIndex - 1) * pageSize, pageSize);
        }

        public bool UpdateUser(User user)
        {
            return userDao.UpdateUser(user);
        }

        public bool UpdateUserRoomId(int userId, int roomId)
        {
            return userDao.UpdateRoomId(userId, roomId);
        }

        public User Login(string username, string password)
        {
            int statusId = statusDao.GetStatus(Status.VALUE.USER_ACTIVE.ToString()).Id;
            User user = userDao.GetUser(username, password, statusId);
            if (user != null)
            {
                user.RoleName = roleDao.GetRole(user.RoleId).Name;
            }
            return user;
        }

        public bool IsExistUsername(string username)
        {
            return userDao.IsExist(username);
        }

        #endregion

        #region Category Service
        public List<Category> GetCategories()
        {
            int statusId = statusDao.GetStatus(Status.VALUE.CATEGORY_ACTIVE.ToString()).Id;
            return categoryDao.GetCategories(statusId);
        }

        public string GetCategoryName(int categoryId)
        {
            int statusId = statusDao.GetStatus(Status.VALUE.CATEGORY_ACTIVE.ToString()).Id;
            return categoryDao.GetCategory(categoryId, statusId).Name;
        }

        public int GetCategoryId(string categoryName)
        {
            int statusId = statusDao.GetStatus(Status.VALUE.CATEGORY_ACTIVE.ToString()).Id;
            return categoryDao.IsExist(categoryName, statusId);
        }
        #endregion

        #region Device Service
        public int AddDevice(Device device)
        {
            device.StatusId = statusDao.GetStatus(Status.VALUE.DEVICE_ACTIVE.ToString()).Id;
            return deviceDao.AddDevice(device);
        }

        public bool UpdateDevice(Device device)
        {
            return deviceDao.UpdateDevice(device);
        }

        public bool UpdateDeviceImage(int deviceId, byte[] image)
        {
            return deviceDao.UpdateDeviceImage(deviceId, image);
        }

        public bool UpdateDeviceRoomId(int deviceId, int roomId)
        {
            return deviceDao.UpdateRoomId(deviceId, roomId);
        }

        public bool ChangeDeviceStatus(int deviceId, bool isActive)
        {
            string statusName = isActive ? Status.VALUE.DEVICE_ACTIVE.ToString() : Status.VALUE.DEVICE_BROKEN.ToString();
            int statusId = statusDao.GetStatus(statusName).Id;
            return deviceDao.UpdateDeviceStatusId(deviceId, statusId);
        }

        public bool DeleteDevice(int deviceId)
        {
            int statusId = statusDao.GetStatus(Status.VALUE.DEVICE_INACTIVE.ToString()).Id;
            return deviceDao.DeleteDevice(deviceId, statusId);
        }

        public List<Device> GetDeviceList(int pageIndex, int pageSize)
        {
            int statusId = statusDao.GetStatus(Status.VALUE.DEVICE_INACTIVE.ToString()).Id;
            List<Device> devices = deviceDao.GetDevices(statusId, (pageIndex - 1) * pageSize, pageSize);
            int categoryStatusId = statusDao.GetStatus(Status.VALUE.CATEGORY_ACTIVE.ToString()).Id;
            foreach (var device in devices)
            {
                device.StatusName = statusDao.GetStatus(device.StatusId).Name;
                if (device.CategoryId != 0)
                {
                    device.CategoryName = categoryDao.GetCategory(device.CategoryId, categoryStatusId).Name;
                }
            }
            return devices;
        }

        public int GetDeviceListCount()
        {
            int statusId = statusDao.GetStatus(Status.VALUE.DEVICE_INACTIVE.ToString()).Id;
            return deviceDao.GetDevicesCount(statusId);
        }

        public List<Device> GetDeviceList(int roomId, string searchValue, int pageIndex, int pageSize)
        {
            int statusId = statusDao.GetStatus(Status.VALUE.DEVICE_INACTIVE.ToString()).Id;
            List<Device> devices = deviceDao.GetDevices(roomId, searchValue, statusId, (pageIndex - 1) * pageSize, pageSize);
            int categoryStatusId = statusDao.GetStatus(Status.VALUE.CATEGORY_ACTIVE.ToString()).Id;
            foreach (var device in devices)
            {
                device.StatusName = statusDao.GetStatus(device.StatusId).Name;
                if (device.CategoryId != 0)
                {
                    device.CategoryName = categoryDao.GetCategory(device.CategoryId, categoryStatusId).Name;
                }
            }
            return devices;
        }

        public int GetDeviceListCount(int roomId, string searchValue)
        {
            int statusId = statusDao.GetStatus(Status.VALUE.DEVICE_INACTIVE.ToString()).Id;
            return deviceDao.GetDevicesCount(roomId, searchValue, statusId);
        }

        public List<Device> GetDeviceList(string searchValue, int pageIndex, int pageSize)
        {
            int statusId = statusDao.GetStatus(Status.VALUE.DEVICE_INACTIVE.ToString()).Id;
            List<Device> devices = deviceDao.GetDevices(searchValue, statusId, (pageIndex - 1) * pageSize, pageSize);
            int categoryStatusId = statusDao.GetStatus(Status.VALUE.CATEGORY_ACTIVE.ToString()).Id;
            foreach (var device in devices)
            {
                device.StatusName = statusDao.GetStatus(device.StatusId).Name;
                if (device.CategoryId != 0)
                {
                    device.CategoryName = categoryDao.GetCategory(device.CategoryId, categoryStatusId).Name;
                }
            }
            return devices;
        }

        public int GetDeviceListCount(string searchValue)
        {
            int statusId = statusDao.GetStatus(Status.VALUE.DEVICE_INACTIVE.ToString()).Id;
            return deviceDao.GetDevicesCount(searchValue, statusId);
        }

        public List<dynamic> GetDevicesByFixedTime(int min, int max)
        {
            int statusId = statusDao.GetStatus(Status.VALUE.DEVICE_INACTIVE.ToString()).Id;
            return deviceDao.GetDevicesByFixedTime(min, max, statusId);
        }

        public List<dynamic> GetDevicesByStatus(string fromDate, string toDate, bool status)
        {
            int statusId = statusDao.GetStatus(Status.VALUE.DEVICE_INACTIVE.ToString()).Id;
            return deviceDao.GetDevicesByStatus(status, fromDate, toDate, statusId);
        }
        #endregion

        #region Room Service
        public int AddRoom(Room room)
        {
            room.StatusId = statusDao.GetStatus(Status.VALUE.ROOM_ACTIVE.ToString()).Id;
            return roomDao.AddRoom(room);
        }

        public bool UpdateRoom(Room room)
        {
            return roomDao.UpdateRoom(room);
        }

        public bool DeleteRoom(int roomId)
        {
            int statusInactiveId = statusDao.GetStatus(Status.VALUE.ROOM_INACTIVE.ToString()).Id;
            return roomDao.DeleteRoom(roomId, statusInactiveId);
        }

        public List<User> GetUserListInRoom(int roomId)
        {
            int roleId = roleDao.GetRole(Role.VALUE.USER.ToString()).Id;
            int statusId = statusDao.GetStatus(Status.VALUE.USER_ACTIVE.ToString()).Id;
            return userDao.GetUsers(roomId, roleId, statusId);
        }

        public List<User> GetUserListNoneRoom()
        {
            int roleId = roleDao.GetRole(Role.VALUE.USER.ToString()).Id;
            int statusId = statusDao.GetStatus(Status.VALUE.USER_ACTIVE.ToString()).Id;
            return userDao.GetUsersNoneRoom(roleId, statusId);
        }

        public List<Device> GetDeviceListInRoom(int roomId)
        {
            int statusId = statusDao.GetStatus(Status.VALUE.DEVICE_INACTIVE.ToString()).Id;
            return deviceDao.GetDevices(roomId, statusId);
        }

        public List<Device> GetDeviceListNoneRoom()
        {
            int statusId = statusDao.GetStatus(Status.VALUE.DEVICE_INACTIVE.ToString()).Id;
            return deviceDao.GetDevicesNoneRoom(statusId);
        }

        public bool RemoveRoom(int roomId)
        {
            return userDao.RemoveRoomId(roomId) && deviceDao.RemoveRoomId(roomId);
        }

        public List<Room> GetRooms(string searchValue, int pageIndex, int pageSize)
        {
            int statusRoomActiveId = statusDao.GetStatus(Status.VALUE.ROOM_ACTIVE.ToString()).Id;
            int statusUserActiveId = statusDao.GetStatus(Status.VALUE.USER_ACTIVE.ToString()).Id;
            int statusDeviceActiveId = statusDao.GetStatus(Status.VALUE.DEVICE_ACTIVE.ToString()).Id;
            return roomDao.GetRooms(searchValue, statusRoomActiveId, statusUserActiveId, 
                statusDeviceActiveId, (pageIndex - 1) * pageSize, pageSize);
        }

        public int GetRoomsCount(string searchValue)
        {
            int statusRoomActiveId = statusDao.GetStatus(Status.VALUE.ROOM_ACTIVE.ToString()).Id;
            int statusUserActiveId = statusDao.GetStatus(Status.VALUE.USER_ACTIVE.ToString()).Id;
            int statusDeviceActiveId = statusDao.GetStatus(Status.VALUE.DEVICE_ACTIVE.ToString()).Id;
            return roomDao.GetRoomsCount(searchValue, statusRoomActiveId, statusUserActiveId, statusDeviceActiveId);
        }
        #endregion

        #region Request Service
        public int AddRequest(int userId, string requestDescription, int deviceId)
        { 
            int statusRequestInitialId = statusDao.GetStatus(Status.VALUE.REQUEST_INITIAL.ToString()).Id;
            return requestDao.AddRequest(userId, requestDescription, statusRequestInitialId, deviceId);
        }

        public bool StartRequest(int id, int workerId)
        {
            int statusRequestStartId = statusDao.GetStatus(Status.VALUE.REQUEST_START.ToString()).Id;
            return requestDao.StartRequest(id, workerId, statusRequestStartId);
        }

        public bool FinishRequest(int id, string repairDescription)
        {
            int statusRequestFinishId = statusDao.GetStatus(Status.VALUE.REQUEST_FINISH.ToString()).Id;
            return requestDao.FinishRequest(id, repairDescription, statusRequestFinishId);
        }

        public List<Request> GetRequests(int deviceId, int pageIndex, int pageSize)
        {
            List<Request> requests = requestDao.GetRequests(deviceId, (pageIndex - 1) * pageSize, pageSize);
            foreach (var request in requests)
            {
                request.StatusName = statusDao.GetStatus(request.StatusId).Name;
            }
            return requests;
        }

        public int GetRequestsCount(int deviceId)
        {
            return requestDao.GetRequestsCount(deviceId);
        }
        #endregion

    }
}
