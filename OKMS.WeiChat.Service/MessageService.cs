using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKMS.WeiChat.IReopsitory;
using OKMS.WeiChat.IService;

namespace OKMS.WeiChat.Service
{
   public class MessageService:IMessageService
   {
       private readonly IMessageRepository _messageRepository;

       public MessageService(IMessageRepository messageRepository)
       {
           _messageRepository = messageRepository;
       }
   }
}
