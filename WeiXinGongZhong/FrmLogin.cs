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
    public partial class FrmLogin : FrmBase
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string appid = this.txtAppID.Text;
            string secret = this.txtAppsecret.Text;
            Result result = DevCommon.Cloud.GetToken(appid, secret);
            if (string.IsNullOrEmpty(result.Access_token))
            {
                this.MsgBox($"{result.ErrCode},{result.ErrMsg}");
                return;
            }
            this.DialogResult = DialogResult.OK;

        }
    }
}
