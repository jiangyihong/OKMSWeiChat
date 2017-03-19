using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OKMS.WeiChat.Model.ApiModels.Tuling
{
    /// <summary>
    /// 请求消息
    /// </summary>
    public class TulingRobotApiRequestMessage
    {
        /// <summary>
        /// 开发者密钥
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [JsonProperty(PropertyName = "userid")]
        public string UserId { get; set; }

        /// <summary>
        /// 聊天内容
        /// </summary>
        [JsonProperty(PropertyName = "info")]
        public string Info { get; set; }

        /// <summary>
        /// 地理位置 非必须
        /// </summary>
        [JsonProperty(PropertyName = "loc")]
        public string Location { get; set; }
    }
}
