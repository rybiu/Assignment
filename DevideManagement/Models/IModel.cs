using System.Collections.Generic;

namespace DeviceManagement.Models
{
    // IModel interface, part of MVP design pattern. 

    public interface IModel
    {
        #region User
        UserModel Login(string userName, string password);
        List<UserModel> GetUserList(string searchValue, int pageIndex, int pageSize);
        int GetUserListCount(string searchValue);
        List<UserModel> GetWorkerList(string searchValue, int pageIndex, int pageSize);
        int GetWorkerListCount(string searchValue);
        int AddUser(UserModel userModel);
        int AddWorker(UserModel userModel);
        bool UpdateUser(UserModel userModel);
        bool DeleteUser(int userId);
        bool IsExistUsername(string username);
        #endregion

        #region Category
        List<CategoryModel> GetCategories();
        #endregion

        #region Device
        List<DeviceModel> GetDeviceList(int roomId, string searchValue, int pageIndex, int pageSize);
        int GetDeviceListCount(int roomId, string searchValue);
        List<DeviceModel> GetDeviceList(string searchValue, int pageIndex, int pageSize);
        int GetDeviceListCount(string searchValue);
        int AddDevice(DeviceModel deviceModel);
        bool UpdateDevice(DeviceModel deviceModel);
        bool UpdateDeviceImage(DeviceModel deviceModel);
        bool DeleteDevice(int deviceId);
        DeviceModel GetDevice(int deviceId);
        List<dynamic> GetDeviceListByFixedTime(int minTime, int maxTime);
        List<dynamic> GetDeviceListByStatus(string fromDate, string toDate, bool status);
        #endregion

        #region Room
        int AddRoom(RoomModel roomModel);
        bool UpdateRoom(RoomModel roomModel);
        bool DeleteRoom(int roomId);
        bool UpdateUserRoomId(int userId, int roomId);
        bool UpdateDeviceRoomId(int deviceId, int roomId);
        List<RoomModel> GetRoomList(string searchValue, int pageIndex, int pageSize);
        int GetRoomListCount(string searchValue);
        List<UserModel> GetUserListInRoom(int roomId);
        List<UserModel> GetUserListNoneRoom();
        List<DeviceModel> GetDeviceListInRoom(int roomId);
        List<DeviceModel> GetDeviceListNoneRoom();
        #endregion

        #region Request
        int AddRequest(int userId, string requestDescription, int deviceId);
        bool StartRequest(int id, int workerId);
        bool FinishRequest(int id, string repairDescription);
        List<RequestModel> GetRequestList(int deviceId, int pageIndex, int pageSize);
        int GetRequestListCount(int deviceId);
        bool ChangeDeviceStatus(int deviceId, bool isActive);
        string GetLastRequestStatusName(int deviceId);
        #endregion
    }
}
