using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OKMS.WeiChat.IService;

namespace OKMS.WeiChat.Controllers
{
    public class UserInfoController : Controller
    {
        private readonly IUserInfoService _userInfoService;

        public UserInfoController(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }

        // GET: UserInfo
        public ActionResult Index(int pageIndex = 1, int pageSize = 10)
        {
            int count;
            var result = _userInfoService.GetList(pageIndex, pageSize, out count);
            return View(result);
        }
    }
}