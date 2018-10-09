using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeiXinGongZhong.Models
{
    public class Article
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 图文消息的封面图片素材id
        /// </summary>
        public string thumb_media_id { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        public string author { get; set; }
        /// <summary>
        /// 图文消息的摘要，仅单图文消息才有摘要，多图文此处为空。
        /// </summary>
        public string digest { get; set; }
        /// <summary>
        /// 是否显示封面，0为false，不显示
        /// </summary>
        public string show_cover_pic { get; set; }
        /// <summary>
        /// 图文消息的具体内容，支持HTML标签
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 图文消息的原文地址，即点击“阅读原文”后的URL
        /// </summary>
        public string content_source_url { get; set; }
    }
    public class Articles
    {
        public List<Article> articles { get; set; } = new List<Article>();
        public override string ToString()
        {
            string content = JsonConvert.SerializeObject(this);
            return content;
        }
    }
}
