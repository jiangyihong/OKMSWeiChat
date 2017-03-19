using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKMS.WeiChat.IReopsitory;
using OKMS.WeiChat.Model.Models;

namespace OKMS.WeiChat.Repository
{
    public class MessageRepository : BaseRepository<Message>, IMessageRepository
    {
        public MessageRepository(DbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
