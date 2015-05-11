using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Models
{
    public class Tweet
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public HashSet<Tweet> Tweets { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public HashSet<User> Favorites { get; set; }

    }
}
