using BusinessObjects;

namespace DataObjects
{

    public interface IStatusDao
    {
        Status GetStatus(int statusId);
        Status GetStatus(string statusName);
    }
}
