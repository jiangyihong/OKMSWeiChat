using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKMS.WeiChat.Common
{
    public static class GlobalSettingConfig
    {
        /// <summary>
        /// 图灵机器人接口地址
        /// </summary>
        public static string TulingRobotApiAddress { get; set; }

        /// <summary>
        /// 图灵机器人接口Key
        /// </summary>
        public static string TulingRobotApiKey { get; set; }

        /// <summary>
        /// 初始化配置信息
        /// </summary>
        public static void RegisterSettings()
        {

            TulingRobotApiAddress = ConfigurationManager.AppSettings["TulingRobotApiAddress"];

            TulingRobotApiKey = ConfigurationManager.AppSettings["TulingRobotApiKey"];
        }
    }
}
