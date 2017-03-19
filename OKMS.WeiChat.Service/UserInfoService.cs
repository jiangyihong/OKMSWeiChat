using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKMS.WeiChat.IReopsitory;
using OKMS.WeiChat.IService;
using OKMS.WeiChat.Model.Models;

namespace OKMS.WeiChat.Service
{
    public class UserInfoService : IUserInfoService
    {
        private readonly IUserInfoRepository _userInfoRepository;

        public UserInfoService(IUserInfoRepository userInfoRepository)
        {
            _userInfoRepository = userInfoRepository;
        }


        public bool Add(UserInfo entity)
        {
            return _userInfoRepository.Add(entity);
        }

        public bool Update(UserInfo entity)
        {
            return _userInfoRepository.Update(entity);
        }

        public bool Delete(UserInfo entity)
        {
            return _userInfoRepository.Delete(entity);
        }

        public UserInfo Get(int id)
        {
            return _userInfoRepository.Get(x => x.Id == id);
        }

        public IEnumerable<UserInfo> GetList(int pageIndex, int pageSize, out int count)
        {
            return _userInfoRepository.GetList((pageIndex - 1) * pageSize, pageSize, u => u.PostTime, true, out count);
        }
    }
}
