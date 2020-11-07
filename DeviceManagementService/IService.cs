using BusinessObjects;
using System.Collections.Generic;

namespace DeviceManagementService
{
    // single interface to all 'repositories'

    public interface IService
    {
        #region User Repository
        User Login(string username, string password);
        int AddUser(User user);
        bool UpdateUser(User user);
        bool UpdateUserRoomId(int userId, int roomId);
        bool DeleteUser(int userId);
        List<User> GetUserList(string searchValue, int pageIndex, int pageSize);
        int GetUserListCount(string searchValue);
        int AddWorker(User user);
        List<User> GetWorkerList(string searchValue, int pageIndex, int pageSize);
        int GetWorkerListCount(string searchValue);
        bool IsExistUsername(string username);
        #endregion

        #region Category Repository
        List<Category> GetCategories();
        string GetCategoryName(int categoryId);
        int GetCategoryId(string categoryName);
        #endregion

        #region Device Repository
        int AddDevice(Device device);
        bool UpdateDevice(Device device);
        bool UpdateDeviceImage(int deviceId, byte[] image);
        bool UpdateDeviceRoomId(int deviceId, int roomId);
        bool ChangeDeviceStatus(int deviceId, bool isActive);
        bool DeleteDevice(int deviceId);
        List<Device> GetDeviceList(int pageIndex, int pageSize);
        int GetDeviceListCount();
        List<Device> GetDeviceList(int roomId, string searchValue, int pageIndex, int pageSize);
        int GetDeviceListCount(int roomId, string searchValue);
        List<Device> GetDeviceList(string searchValue, int pageIndex, int pageSize);
        int GetDeviceListCount(string searchValue);
        List<dynamic> GetDevicesByFixedTime(int min, int max);
        List<dynamic> GetDevicesByStatus(string fromDate, string toDate, bool status);
        #endregion

        #region Room Repository
        int AddRoom(Room room);
        bool UpdateRoom(Room room);
        bool DeleteRoom(int roomId);
        List<User> GetUserListInRoom(int roomId);
        List<User> GetUserListNoneRoom();
        List<Device> GetDeviceListInRoom(int roomId);
        List<Device> GetDeviceListNoneRoom();
        List<Room> GetRooms(string searchValue, int pageIndex, int pageSize);
        int GetRoomsCount(string searchValue);
        bool RemoveRoom(int roomId);
        #endregion

        #region Request Repository
        int AddRequest(int userId, string requestDescription, int deviceId);

        bool StartRequest(int id, int workerId);

        bool FinishRequest(int id, string repairDescription);

        List<Request> GetRequests(int deviceId, int pageIndex, int pageSize);
        int GetRequestsCount(int deviceId);
        #endregion

    }
}
