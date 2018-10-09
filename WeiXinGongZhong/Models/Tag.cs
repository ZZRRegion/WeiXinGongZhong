using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeiXinGongZhong.Models
{
    public class Tags
    {
        public Tag tag { get; set; } = new Tag();
        public override string ToString()
        {
            string content = JsonConvert.SerializeObject(this);
            return content;
        }
    }
    public class Tag
    {
        public string name { get; set; }
    }
}
