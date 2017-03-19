using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKMS.WeiChat.Model.Models;

namespace OKMS.WeiChat.Model.EntityMap
{
    public class MessageMap : EntityTypeConfiguration<Message>
    {
        public MessageMap()
        {
            ToTable("message");
            Property(m => m.UserId).IsRequired();
            Property(m => m.Content).IsRequired();
            Property(m => m.PostTime).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }
}
