using System;

namespace DeviceManagement.Models
{
    // Request business object as seen by the Service client.
    public class RequestModel
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public string StatusName { get; set; }
        public string RequestDescription { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? StartDate { get; set;  }
        public DateTime? FinishDate { get; set;  }
        public string RepairDescription { get; set;  }
        public int DeviceId { get; set; }
        public int WorkerId { get; set; }

    }
}
