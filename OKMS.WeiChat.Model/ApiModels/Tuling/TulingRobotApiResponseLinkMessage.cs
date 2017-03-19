using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OKMS.WeiChat.Model.ApiModels.Tuling
{
    public class TulingRobotApiResponseLinkMessage : TulingRobotApiResponseBaseMessage
    {
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
