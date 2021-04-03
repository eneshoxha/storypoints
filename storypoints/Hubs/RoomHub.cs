using Microsoft.AspNetCore.SignalR;
using storypoints.Core.Abstraction;
using storypoints.Hubs.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storypoints.Hubs
{
    public class RoomHub : Hub<IRoomHub>
    {
        private readonly IRoomRepository _roomRepository;
        public RoomHub(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }

    }
}
