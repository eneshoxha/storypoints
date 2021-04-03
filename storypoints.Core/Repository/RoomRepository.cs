using storypoints.Core.Abstraction;
using storypoints.Data.Model;
using System.Collections.Concurrent;

namespace storypoints.Core.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ConcurrentDictionary<string, Room> _rooms;
        public RoomRepository()
        {
            _rooms = new ConcurrentDictionary<string, Room>();
        }

        public bool AddUserInRoom(RoomUser roomUser)
        {
            if (!_rooms.ContainsKey(roomUser.RoomId))
                return false;

            return _rooms[roomUser.RoomId].Users.TryAdd(roomUser.ConnectionId, roomUser);
        }

        public bool UpdateVote(string roomId, string connectionId, string vote)
        {
            if (!_rooms.ContainsKey(roomId))
                return false;

            if (!_rooms[roomId].Users.ContainsKey(connectionId))
                return false;

            _rooms[roomId].Users[connectionId].Vote = vote;
            return true;
        }
    }
}
