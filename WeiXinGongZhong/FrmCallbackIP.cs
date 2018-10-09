using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeiXinGongZhong
{
    public partial class FrmCallbackIP : FrmBase
    {
        public FrmCallbackIP()
        {
            InitializeComponent();
        }

        private void FrmCallbackIP_Load(object sender, EventArgs e)
        {
            List<string> lst = DevCommon.Cloud.GetCallbackIP();
            lst.ForEach(item => {
                this.lstIP.Items.Add(item);
            });
        }
    }
}
