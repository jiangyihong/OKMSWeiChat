using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OKMS.WeiChat.Model.ApiModels.Tuling
{
    /// <summary>
    /// 普通文本消息
    /// </summary>
    public class TulingRobotApiResponseBaseMessage
    {
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
    }
}
