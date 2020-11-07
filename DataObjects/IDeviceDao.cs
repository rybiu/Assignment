using BusinessObjects;
using System.Collections.Generic;

namespace DataObjects
{
    
    public interface IDeviceDao : IBelongRoom
    {
        int AddDevice(Device device);

        bool UpdateDevice(Device device);

        bool UpdateDeviceImage(int deviceId, byte[] image);

        bool UpdateDeviceStatusId(int deviceId, int statusId);

        bool DeleteDevice(int deviceId, int statusId);

        Device GetDevice(int deviceId, int statusId);

        List<Device> GetDevices(int statusId, int startRow, int pageSize);

        List<Device> GetDevices(int roomId, string searchValue, int statusId, int startRow, int pageSize);

        List<Device> GetDevices(string searchValue, int statusId, int startRow, int pageSize);

        int GetDevicesCount(int statusId);

        int GetDevicesCount(int roomId, string searchValue, int statusId);

        int GetDevicesCount(string searchValue, int statusId);

        List<Device> GetDevices(int roomId, int statusId);

        List<Device> GetDevicesNoneRoom(int statusId);

        List<dynamic> GetDevicesByFixedTime(int min, int max, int statusId);

        List<dynamic> GetDevicesByStatus(bool isActive, string startDate, string finishDate, int statusActiveId);

    }
}
