using BusinessObjects;
using System.Collections.Generic;

namespace DataObjects
{
  
    public interface IRequestDao
    {
        int AddRequest(int userId, string requestDescription, int statusRequestInitialId, int deviceId);

        bool StartRequest(int id, int workerId, int statusRequestStartId);

        bool FinishRequest(int id, string repairDescription, int statusRequestFinishId);

        List<Request> GetRequests(int deviceId, int startRow, int pageSize);

        int GetRequestsCount(int deviceId);

    }
}
