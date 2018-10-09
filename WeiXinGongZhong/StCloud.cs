using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net.Http.Headers;

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
        private Stream GetFile(string api)
        {
            string url = $"{this.BaseUrl}{api}";
            Stream stream = this.httpClient.GetStreamAsync(url).Result;
            return stream;
        }
        private string Post(string api, string content)
        {
            string url = $"{this.BaseUrl}{api}";
            StringContent stringContent = new StringContent(content);
            return this.httpClient.PostAsync(url, stringContent).Result.Content.ReadAsStringAsync().Result;
        }
        public string UploadFile(string api, string filename)
        {
            WebClient webClient = new WebClient();
            string url = $"{this.BaseUrl}{api}";
            byte[] bys = webClient.UploadFile(url, filename);
            string content = Encoding.UTF8.GetString(bys);
            return content;
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
        public Result PostCreateMenu(string menu)
        {
            string api = $"menu/create?access_token={this.Access_token}";
            string content = this.Post(api, menu);
            Result result = JsonConvert.DeserializeObject<Result>(content);
            return result;
        }
        public string GetMenu()
        {
            string api = $"menu/get?access_token={this.Access_token}";
            string content = this.Get(api);
            return content;
        }
        public List<string> GetCallbackIP()
        {
            string api = $"getcallbackip?access_token={this.Access_token}";
            string content = this.Get(api);
            JObject json = JObject.Parse(content);
            List<string> lst = JsonConvert.DeserializeObject<List<string>>(json.Value<JArray>("ip_list").ToString());
            return lst;
        }
        public Result PostImage(string fileName)
        {
            string api = $"media/upload?access_token={this.Access_token}&type=image";
            string content = this.UploadFile(api, fileName);
            Result result = JsonConvert.DeserializeObject<Result>(content);
            return result;
        }
        public Result PostMaterialImage(string fileName)
        {
            string api = $"media/uploadimg?access_token={this.Access_token}";
            string content = this.UploadFile(api, fileName);
            Result result = JsonConvert.DeserializeObject<Result>(content);
            return result;
        }
        public Stream GetImage(string mediaId)
        {
            string api = $"media/get?access_token={this.Access_token}&media_id={mediaId}";
            return this.GetFile(api);
        }
        public string PostMaterial(string content)
        {
            string api = $"material/add_news?access_token={this.Access_token}";
            string result = this.Post(api, content);
            return result;
        }
        public ResultTag PostTags(string content)
        {
            string api = $"tags/create?access_token={this.Access_token}";
            string r = this.Post(api, content);
            JObject json = JObject.Parse(r);
            ResultTag tag = JsonConvert.DeserializeObject<ResultTag>(json.Value<JObject>("tag").ToString());
            return tag;
        }
        public List<ResultTag> GetTags()
        {
            string api = $"tags/get?access_token={this.Access_token}";
            string content = this.Get(api);
            JObject json = JObject.Parse(content);
            List<ResultTag> lstTags = JsonConvert.DeserializeObject<List<ResultTag>>(json.Value<JArray>("tags").ToString());
            return lstTags;
        }
        public ResultUsers GetUsers()
        {
            string api = $"user/get?access_token={this.Access_token}";
            string content = this.Get(api);
            ResultUsers resultUsers = JsonConvert.DeserializeObject<ResultUsers>(content);
            return resultUsers;
        }
    }
}
