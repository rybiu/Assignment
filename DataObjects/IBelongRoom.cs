namespace DataObjects
{

    public interface IBelongRoom
    {

        bool UpdateRoomId(int objectId, int roomId);

        bool RemoveRoomId(int roomId);

    }
}
