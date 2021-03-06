using System;
using System.Drawing;

namespace DeviceManagement.Models
{
    // Device business object as seen by the Service client.
    public class DeviceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public byte[] Image { get; set; }
        public Image ImageView { get; set; }
        public DateTime? BoughtDate { get; set; }
        public DateTime? WarrantyDate { get; set; }
        public int RoomId { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }

    }
}
