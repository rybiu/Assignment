namespace DeviceManagement.Models
{
    // Room business object as seen by the Service client.
    public class RoomModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberUser { get; set; }
        public string NumberDevice { get; set; }

    }
}
