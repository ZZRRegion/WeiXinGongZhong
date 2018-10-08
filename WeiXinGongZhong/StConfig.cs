using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

namespace WeiXinGongZhong
{
    public static class StConfig
    {
        private static string configFileName => "config.json";
        private static void Write(string key, string value)
        {
            string config = string.Empty;
            JObject json = new JObject();
            if (File.Exists(configFileName))
            {
                config = File.ReadAllText(configFileName);
                json = JObject.Parse(config);
            }
            json[key] = value;
            config = json.ToString();
            File.WriteAllText(configFileName, config);
        }
        private static T Read<T>(string key, T defaultvalue = default(T))
        {
            if (File.Exists(configFileName))
            {
                string config = File.ReadAllText(configFileName);
                JObject json = JObject.Parse(config);
                if(json.Value<T>(key) != null)
                {
                    return json.Value<T>(key);
                }
            }
            return defaultvalue;
        }
        public static int UseCount
        {
            get
            {
                return Read<int>(nameof(UseCount));
            }
            set
            {
                Write(nameof(UseCount), value.ToString());
            }
        }
        public static string Access_Token
        {
            get
            {
                return Read<string>(nameof(Access_Token));
            }
            set
            {
                Write(nameof(Access_Token), value);
            }
        }
    }
}
