using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{

    public class Status : BusinessObject
    {
        public enum VALUE
        { 
            USER_ACTIVE,
            USER_INACTIVE,
            DEVICE_ACTIVE,
            DEVICE_BROKEN,
            DEVICE_INACTIVE,
            REQUEST_INITIAL,
            REQUEST_START,
            REQUEST_FINISH,
            ROOM_ACTIVE,
            ROOM_INACTIVE,
            CATEGORY_ACTIVE,
            CATEGORY_INACTIVE
        };

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
