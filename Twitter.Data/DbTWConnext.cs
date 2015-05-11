using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Twitter.Models;

namespace Twitter.Data
{
    public class DbTWConnext : DbContext
    {
        public DbTWConnext():base("Twitter")
        {

        }

        public IDbSet<User> Users { get; set; }

        public IDbSet<Notification> Notifications { get; set; }

        public IDbSet<Tweet> Tweets { get; set; }

        public IDbSet<Message> Messages { get; set; }
    }
}
