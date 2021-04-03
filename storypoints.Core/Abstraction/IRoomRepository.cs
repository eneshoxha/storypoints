using storypoints.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storypoints.Core.Abstraction
{
    public interface IRoomRepository
    {
        bool AddUserInRoom(RoomUser roomUser);
        bool UpdateVote(string roomId, string connectionId, string vote);
    }
}
