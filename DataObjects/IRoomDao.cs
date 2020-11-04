using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    
    public interface IRoomDao
    {
        int AddRoom(Room room);

        bool UpdateRoom(Room room);

        bool DeleteRoom(int roomId, int statusRoomInactiveId);

        List<Room> GetRooms(string searchValue, int statusRoomActiveId, 
            int statusUserActiveId, int statusDeviceActiveId, int startRow, int pageSize);

        int GetRoomsCount(string searchValue, int statusRoomActiveId, int statusUserActiveId, int statusDeviceActiveId);

    }
}
