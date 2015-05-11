using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Models
{
   public class User
    {
        public int Id { get; set; }

        public HashSet<User> UsersToFollow { get; set; }

        public HashSet<User> UsersFollowing { get; set; }
    }
}
