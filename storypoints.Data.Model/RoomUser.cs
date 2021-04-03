using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storypoints.Data.Model
{
    public class RoomUser
    {
        public string ConnectionId { get; set; }
        public bool IsAdmin { get; set; }
        public string RoomId { get; set; }
        public string UserName { get; set; }

        public string Vote { get; set; }
    }
}
