using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeiXinGongZhong
{
    public static class DevCommon
    {
        public static string Version => "1.0.0.0";
        public static string VersionTime => "2018-10-08 21:59:00";
        public static StCloud Cloud { get; set; }
        public static void Init()
        {
            Cloud = new StCloud();
        }
        
    }
}
