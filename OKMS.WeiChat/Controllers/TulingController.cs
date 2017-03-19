using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OKMS.WeiChat.IService.IApiService;
using OKMS.WeiChat.Model.ApiModels.Tuling;

namespace OKMS.WeiChat.Controllers
{
    public class TulingController : Controller
    {
        private readonly ITulingRobotService _tulingRobotService;

        public TulingController(ITulingRobotService tulingRobotService)
        {
            _tulingRobotService = tulingRobotService;
        }

        // GET: Tuling
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Chat(string content)
        {
            var response = _tulingRobotService.Chat(new TulingRobotApiRequestMessage()
            {
                UserId = "Butcher",
                Info = content
            });

            return Json(response);
        }
    }
}