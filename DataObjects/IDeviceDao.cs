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

        bool DeleteDevice(int deviceId, int statusInactiveId);

        Device GetDevice(int deviceId, int statusInactiveId);

        List<Device> GetDevices(int roomId, string searchValue, int statusInactiveId, int startRow, int pageSize);

        List<Device> GetDevices(string searchValue, int statusInactiveId, int startRow, int pageSize);

        int GetDevicesCount(int roomId, string searchValue, int statusInactiveId);

        int GetDevicesCount(string searchValue, int statusInactiveId);

        List<Device> GetDevices(int roomId, int statusInactiveId);

        List<Device> GetDevicesNoneRoom(int statusInactiveId);

        List<dynamic> GetDevicesByFixedTime(int min, int max, int statusInactiveId);

        List<dynamic> GetDevicesByStatus(bool isActive, string startDate, string finishDate, int statusInactiveId);

    }
}
