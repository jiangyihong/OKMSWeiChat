using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKMS.WeiChat.Model.EntityMap;
using OKMS.WeiChat.Model.Models;

namespace OKMS.WeiChat.Model
{
    public class WeiChatDataContext : DbContext
    {
        public WeiChatDataContext(string connectionString)
            : base(connectionString)
        {
        }

        public DbSet<UserInfo> UserInfos { get; set; }

        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserInfoMap());
            modelBuilder.Configurations.Add(new MessageMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
