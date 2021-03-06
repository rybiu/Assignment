﻿using DeviceManagementService;
using AutoMapper;
using BusinessObjects;
using System.Collections.Generic;
using DeviceManagement.Utils;

namespace DeviceManagement.Models
{
    /// <summary>
    /// The Model in MVP design pattern. 
    /// Implements IModel and communicates with WCF Service.
    /// </summary>
    public class Model : IModel
    {
        static Service service = new Service();

        static Model()
        {
            Mapper.CreateMap<User, UserModel>();
            Mapper.CreateMap<UserModel, User>();
            Mapper.CreateMap<Category, CategoryModel>();
            Mapper.CreateMap<Device, DeviceModel>();
            Mapper.CreateMap<DeviceModel, Device>();
            Mapper.CreateMap<Room, RoomModel>();
            Mapper.CreateMap<RoomModel, Room>();
            Mapper.CreateMap<Request, RequestModel> ();
            Mapper.CreateMap<RequestModel, Request> ();
        }

        #region Login / Logout

        // Logs in to the service.
        public UserModel Login(string username, string password)
        {
            var user = service.Login(username, password);
            return Mapper.Map<User, UserModel>(user);
        }

        #endregion

        #region Users
        public List<UserModel> GetUserList(string searchValue, int pageIndex, int pageSize)
        {
            var users = service.GetUserList(searchValue, pageIndex, pageSize);
            return Mapper.Map<List<User>, List<UserModel>>(users);
        }

        public List<UserModel> GetWorkerList(string searchValue, int pageIndex, int pageSize)
        {
            var users = service.GetWorkerList(searchValue, pageIndex, pageSize);
            return Mapper.Map<List<User>, List<UserModel>>(users);
        }

        public int GetUserListCount(string searchValue)
        {
            return service.GetUserListCount(searchValue);
        }

        public int GetWorkerListCount(string searchValue)
        {
            return service.GetWorkerListCount(searchValue);
        }

        public int AddUser(UserModel userModel)
        {
            var user = Mapper.Map<UserModel, User>(userModel);
            return service.AddUser(user);
        }

        public int AddWorker(UserModel userModel)
        {
            var user = Mapper.Map<UserModel, User>(userModel);
            return service.AddWorker(user);
        }

        public bool UpdateUser(UserModel userModel)
        {
            var user = Mapper.Map<UserModel, User>(userModel);
            return service.UpdateUser(user);
        }

        public bool DeleteUser(int userId)
        {
            return service.DeleteUser(userId);
        }

        public bool IsExistUsername(string username)
        {
            return service.IsExistUsername(username);
        }
        #endregion

        #region Categories
        public List<CategoryModel> GetCategories()
        {
            var categories = service.GetCategories();
            return Mapper.Map<List<Category>, List<CategoryModel>>(categories);
        }
        #endregion

        #region Devices
        public List<DeviceModel> GetDeviceList(int roomId, string searchValue, int pageIndex, int pageSize)
        {
            var devices = service.GetDeviceList(roomId, searchValue, pageIndex, pageSize);
            List<DeviceModel> result = Mapper.Map<List<Device>, List<DeviceModel>>(devices);
            foreach (var item in result)
            {
                if (item.Image.Length > 0) item.ImageView = ImageHelper.ByteArrayToImage(item.Image);
            }
            return result;
        }

        public int GetDeviceListCount(int roomId, string searchValue)
        {
            return service.GetDeviceListCount(roomId, searchValue);
        }

        public List<DeviceModel> GetDeviceList(string searchValue, int pageIndex, int pageSize)
        {
            var devices = service.GetDeviceList(searchValue, pageIndex, pageSize);
            List<DeviceModel> result = Mapper.Map<List<Device>, List<DeviceModel>>(devices);
            foreach (var item in result)
            {
                if (item.Image.Length > 0) item.ImageView = ImageHelper.ByteArrayToImage(item.Image);
            }
            return result;
        }

        public int GetDeviceListCount(string searchValue)
        {
            return service.GetDeviceListCount(searchValue);
        }

        public int AddDevice(DeviceModel deviceModel)
        {
            if (deviceModel.ImageView != null) 
                deviceModel.Image = ImageHelper.ImageToByteArray(deviceModel.ImageView);
            var device = Mapper.Map<DeviceModel, Device>(deviceModel);
            device.CategoryId = service.GetCategoryId(device.CategoryName);
            return service.AddDevice(device);
        }

        public bool UpdateDevice(DeviceModel deviceModel)
        {
            var device = Mapper.Map<DeviceModel, Device>(deviceModel);
            device.CategoryId = service.GetCategoryId(device.CategoryName);
            return service.UpdateDevice(device);
        }

        public bool UpdateDeviceImage(DeviceModel deviceModel)
        {
            if (deviceModel.ImageView != null)
                deviceModel.Image = ImageHelper.ImageToByteArray(deviceModel.ImageView);
            var device = Mapper.Map<DeviceModel, Device>(deviceModel);
            return service.UpdateDeviceImage(device.Id, device.Image);
        }

        public bool DeleteDevice(int deviceId)
        {
            return service.DeleteDevice(deviceId);
        }

        public DeviceModel GetDevice(int deviceId)
        {
            var device = service.GetDevice(deviceId);
            return Mapper.Map<Device, DeviceModel>(device);
        }

        public List<dynamic> GetDeviceListByFixedTime(int minTime, int maxTime)
        {
            return service.GetDevicesByFixedTime(minTime, maxTime);
        }

        public List<dynamic> GetDeviceListByStatus(string fromDate, string toDate, bool status)
        {
            return service.GetDevicesByStatus(fromDate, toDate, status);
        }
        #endregion

        #region Room
        public int AddRoom(RoomModel RoomModel)
        {
            Room room = Mapper.Map<RoomModel, Room>(RoomModel);
            return service.AddRoom(room);
        }

        public bool UpdateRoom(RoomModel RoomModel)
        {
            Room room = Mapper.Map<RoomModel, Room>(RoomModel);
            return service.UpdateRoom(room);
        }

        public bool DeleteRoom(int roomId)
        {
            return service.DeleteRoom(roomId) && service.RemoveRoom(roomId);
        }

        public bool UpdateUserRoomId(int userId, int roomId)
        {
            return service.UpdateUserRoomId(userId, roomId);
        }

        public bool UpdateDeviceRoomId(int deviceId, int roomId)
        {
            return service.UpdateDeviceRoomId(deviceId, roomId);
        }

        public List<RoomModel> GetRoomList(string searchValue, int pageIndex, int pageSize)
        {
            var rooms = service.GetRooms(searchValue, pageIndex, pageSize);
            return Mapper.Map<List<Room>, List<RoomModel>>(rooms);
        }

        public int GetRoomListCount(string searchValue)
        {
            return service.GetRoomsCount(searchValue);
        }

        public List<UserModel> GetUserListInRoom(int roomId)
        {
            var users = service.GetUserListInRoom(roomId);
            return Mapper.Map<List<User>, List<UserModel>>(users);
        }

        public List<UserModel> GetUserListNoneRoom()
        {
            var users = service.GetUserListNoneRoom();
            return Mapper.Map<List<User>, List<UserModel>>(users);
        }

        public List<DeviceModel> GetDeviceListInRoom(int roomId)
        {
            var devices = service.GetDeviceListInRoom(roomId);
            return Mapper.Map<List<Device>, List<DeviceModel>>(devices);
        }

        public List<DeviceModel> GetDeviceListNoneRoom()
        {
            var devices = service.GetDeviceListNoneRoom();
            return Mapper.Map<List<Device>, List<DeviceModel>>(devices);
        }
        #endregion

        #region Request
        public int AddRequest(int userId, string requestDescription, int deviceId)
        {
            return service.AddRequest(userId, requestDescription, deviceId);
        }

        public bool StartRequest(int id, int workerId)
        {
            return service.StartRequest(id, workerId);
        }

        public bool FinishRequest(int id, string repairDescription)
        {
            return service.FinishRequest(id, repairDescription);
        }

        public List<RequestModel> GetRequestList(int deviceId, int pageIndex, int pageSize)
        {
            var requests = service.GetRequests(deviceId, pageIndex, pageSize);
            return Mapper.Map<List<Request>, List<RequestModel>>(requests);
        }

        public int GetRequestListCount(int deviceId)
        {
            return service.GetRequestsCount(deviceId);
        }

        public bool ChangeDeviceStatus(int deviceId, bool isActive)
        {
            return service.ChangeDeviceStatus(deviceId, isActive);
        }

        public string GetLastRequestStatusName(int deviceId)
        {
            return service.GetLastRequestStatusName(deviceId);
        }
        #endregion

    }
}
