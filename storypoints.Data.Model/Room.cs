using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storypoints.Data.Model
{
    public class Room
    {
        public string RoomId { get; set; }
        public ConcurrentDictionary<string, RoomUser> Users { get; set; }
    }
}
