﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Models
{
    public class Notification
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int UserId { get; set; }

        public DateTime Date { get; set; }
    }
}
