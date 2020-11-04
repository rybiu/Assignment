using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{

    public interface IBelongRoom
    {

        bool UpdateRoomId(int objectId, int roomId);

        bool RemoveRoomId(int roomId);

    }
}
