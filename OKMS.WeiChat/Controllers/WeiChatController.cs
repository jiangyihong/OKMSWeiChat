using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OKMS.WeiChat.Controllers
{
    public class WeiChatController : Controller
    {
        // GET: WeiChat
        /// <summary>
        /// 微信接口验证
        /// </summary>
        /// <param name="sgnature">加密后的签名</param>
        /// <param name="timestamp">时间戳</param>
        /// <param name="nonce">随机数</param>
        /// <param name="echostr">需要返回给微信服务器的随机字符串</param>
        /// <returns>返回微信服务器发送过来的随机字符串</returns>
        // GET: Chat
        [HttpGet]
        public ActionResult Index(string sgnature, string timestamp, string nonce, string echostr)
        {
            return Content(echostr);
        }

        /// <summary>
        /// 微信消息回复接口 ToDo 使用观察者模式记录当前请求的用户
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }
    }
}