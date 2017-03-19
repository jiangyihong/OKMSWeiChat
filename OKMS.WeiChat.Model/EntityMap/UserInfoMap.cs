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
  public  class UserInfoMap:EntityTypeConfiguration<UserInfo>
    {
        public UserInfoMap()
        {
            ToTable("userinfo");
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(m => m.UserName).IsRequired();
            Property(m => m.PostTime)
                .HasColumnName("RegTime")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

        }
    }
}
