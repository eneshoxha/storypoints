using storypoints.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storypoints.Hubs.Abstraction
{
    public interface IRoomHub
    {
        Task UserConnected(RoomUser userDetails);
        Task UserDisconnected(RoomUser userDetails);
        Task SendVotesResult(Room roomDetail);
    }
}
