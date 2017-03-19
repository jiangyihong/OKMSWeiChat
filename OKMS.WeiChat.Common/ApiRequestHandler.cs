using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OKMS.WeiChat.Common
{
    public class ApiRequestHandler<T> where T : class,new()
    {
        private static readonly HttpClient client = new HttpClient();

        public static T ProcessRequest(string url, object requestMessage)
        {
            var content = JsonConvert.SerializeObject(requestMessage);

            try
            {
                var response =
               client.PostAsync(url, new StringContent(content, Encoding.UTF8))
                   .Result.Content.ReadAsStringAsync()
                   .Result;

                return JsonConvert.DeserializeObject<T>(response);
            }
            catch (Exception e)
            {
                return default(T);
            }
        }
    }
}
