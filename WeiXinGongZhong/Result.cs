using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeiXinGongZhong
{
    public class ResultBase
    {
        public string ErrCode { get; set; }
        public string ErrMsg { get; set; }
    }
    public class Result
    {
        public string ErrCode { get; set; }
        public string ErrMsg { get; set; }
        public string Access_token { get; set; }
        public string Expires_in { get; set; }
        public string Type { get; set; }
        public string Media_id { get; set; }
        public string Created_at { get; set; }
        public string Url { get; set; }
    }
    public class ResultTag:ResultBase
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Count { get; set; }
        public override string ToString()
        {
            return $"ID:{this.Id},Name:{this.Name},Count:{this.Count}";
        }
    }
    public class ResultUsers : ResultBase
    {
        public string Total { get; set; }
        public string Count { get; set; }
        public UserData Data { get; set; }
        public class UserData
        {
            public List<string> OpenId { get; set; } = new List<string>();
        }
    }
}
