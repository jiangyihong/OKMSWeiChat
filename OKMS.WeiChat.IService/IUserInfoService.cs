using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKMS.WeiChat.Model.Models;

namespace OKMS.WeiChat.IService
{
    public interface IUserInfoService
    {
        bool Add(UserInfo entity);

        bool Update(UserInfo entity);

        bool Delete(UserInfo entity);

        UserInfo Get(int id);

        IEnumerable<UserInfo> GetList(int pageIndex, int pageSize, out int count);
    }
}
