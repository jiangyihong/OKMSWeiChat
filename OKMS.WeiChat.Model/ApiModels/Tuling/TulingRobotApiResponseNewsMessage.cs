using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKMS.WeiChat.Model.ApiModels.Tuling
{
    public class TulingRobotApiResponseNewsMessage : TulingRobotApiResponseBaseMessage
    {
        /// <summary>
        /// 新闻详情列表
        /// </summary>
        public IList<TulingRobotApiResponseNewsDetail> List { get; set; }
    }
}
