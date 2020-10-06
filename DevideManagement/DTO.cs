﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevideManagement.DTO
{
    public class AccountDTO
    {
        public enum ROLE { USER, WORKER, ADMIN };
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public ROLE role { get; set; }
        public int roomId { get; set; }

        public AccountDTO(int id, String username)
        {
            this.id = id;
            this.username = username;
        }

        public AccountDTO(String username, String password, ROLE role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public AccountDTO(int id, String username, String password, ROLE role, int roomId)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.role = role;
            this.roomId = roomId;
        }
    }

    public class DeviceDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public FileInfo image { get; set; }
        public DateTime boughtDate { get; set; }
        public DateTime warrantyDate { get; set; }
        public bool action { get; set; }
        public int roomId { get; set; }

        public DeviceDTO(int id, String name, bool action)
        {
            this.id = id;
            this.name = name;
            this.action = action;
        }

        public DeviceDTO(String name, String type, String description, FileInfo image, DateTime boughtDate, DateTime warrantyDate)
        {
            this.name = name;
            this.type = type;
            this.description = description;
            this.image = image;
            this.boughtDate = boughtDate;
            this.warrantyDate = warrantyDate;
        }

    }

    public class RequestDTO
    {
        public enum STATUS { SENT, STARTED, FINISHED }
        public int id { get; set; }
        public string requestDescription { get; set; }
        public DateTime requestDate { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string takeoverDescription { get; set; }
        public int userId { get; set; }
        public int deviceId { get; set; }
        public int workerId { get; set; }
        public STATUS status { get; set; }

        public RequestDTO(int id, int userId, int workerId, STATUS status)
        {
            this.id = id;
            this.userId = userId;
            this.workerId = workerId;
            this.status = status;
        }

        public RequestDTO(int id, String requestDes, DateTime requestDate, DateTime startDate, DateTime endDate, String takeoverDes, int userId, int workerId, STATUS status)
        {
            this.id = id;
            this.requestDescription = requestDes;
            this.requestDate = requestDate;
            this.startDate = startDate;
            this.endDate = endDate;
            this.takeoverDescription = takeoverDes;
            this.userId = userId;
            this.workerId = workerId;
            this.status = status;
        }
    }

    public class RoomDTO
    {
        public int id { get; set; }
        public int name { get; set; }
        public int numberUser { get; set; }
        public int numberDevide { get; set; }

        public RoomDTO(int id, int name, int numberUser, int numberDevide)
        {
            this.id = id;
            this.name = name;
            this.numberUser = numberUser;
            this.numberDevide = numberDevide;
        }
    }
}
