using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKMS.WeiChat.IReopsitory.ApiRepository;
using OKMS.WeiChat.IService.IApiService;
using OKMS.WeiChat.Model.ApiModels.Tuling;

namespace OKMS.WeiChat.Service.ApiService
{
    public class TulingRobotService : ITulingRobotService
    {
        private readonly ITulingRobotApiRepository _tulingRobotApiRepository;

        public TulingRobotService(ITulingRobotApiRepository tulingRobotApiRepository)
        {
            _tulingRobotApiRepository = tulingRobotApiRepository;
        }

        public TulingRobotApiResponseBaseMessage Chat(TulingRobotApiRequestMessage requestMessage)
        {
            return _tulingRobotApiRepository.Chat(requestMessage);
        }
    }
}
