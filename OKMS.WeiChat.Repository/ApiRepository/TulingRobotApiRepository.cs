using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient.Memcached;
using Newtonsoft.Json;
using OKMS.WeiChat.Common;
using OKMS.WeiChat.IReopsitory.ApiRepository;
using OKMS.WeiChat.Model.ApiModels.Tuling;

namespace OKMS.WeiChat.Repository.ApiRepository
{
    public class TulingRobotApiRepository : ITulingRobotApiRepository
    {
        public TulingRobotApiResponseBaseMessage Chat(TulingRobotApiRequestMessage requestMessage)
        {
            requestMessage.Key = GlobalSettingConfig.TulingRobotApiKey;

            return ApiRequestHandler<TulingRobotApiResponseBaseMessage>.ProcessRequest(
                GlobalSettingConfig.TulingRobotApiAddress, requestMessage);
        }
    }
}
