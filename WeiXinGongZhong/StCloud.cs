using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WeiXinGongZhong
{
    public class StCloud
    {
        private HttpClient httpClient = new HttpClient();
        public string Access_token { get; private set; }
        public string BaseUrl => "https://api.weixin.qq.com/cgi-bin/";
        public string AppId { get; private set; }
        public string Secret { get; private set; }
        private string Get(string api)
        {
            string url = $"{this.BaseUrl}{api}";
            return this.httpClient.GetStringAsync(url).Result;
        }
        private string Post(string api, string content)
        {
            string url = $"{this.BaseUrl}{api}";
            StringContent stringContent = new StringContent(content);
            return this.httpClient.PostAsync(url, stringContent).Result.Content.ReadAsStringAsync().Result;
        }
        public Result GetToken(string appid, string secret)
        {
            string api = $"token?grant_type=client_credential&appid={appid}&secret={secret}";
            string content = this.Get(api);
            Result result = JsonConvert.DeserializeObject<Result>(content);
            if (!string.IsNullOrEmpty(result.Access_token))
            {
                this.Access_token = result.Access_token;
                StConfig.Access_Token = this.Access_token;
                this.AppId = appid;
                this.Secret = secret;
            }
            return result;
        }
    }
}
