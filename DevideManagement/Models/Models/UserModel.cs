using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DeviceManagement.Models
{
    // User business object as seen by the Service client.
    public class UserModel
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
        public int RoomId { get; set; }

    }
}
