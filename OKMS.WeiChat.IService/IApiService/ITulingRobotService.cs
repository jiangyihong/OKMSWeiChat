using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKMS.WeiChat.Model.ApiModels.Tuling;

namespace OKMS.WeiChat.IService.IApiService
{
    public interface ITulingRobotService
    {
        TulingRobotApiResponseBaseMessage Chat(TulingRobotApiRequestMessage requestMessage);
    }
}
