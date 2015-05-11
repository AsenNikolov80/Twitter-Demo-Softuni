using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Models
{
    public class Message
    {
        public int Id { get; set; }

        public int SenderId { get; set; }

        public int RecipientId { get; set; }

        public virtual User Sender { get; set; }

        public virtual User Recipient { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; set; }


    }
}
