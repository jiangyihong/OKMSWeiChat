using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKMS.WeiChat.Model.Models
{
    public class Message
    {
        public string Id { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }

        public DateTime PostTime { get; set; }
    }
}
