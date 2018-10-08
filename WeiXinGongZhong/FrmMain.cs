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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Text = $"{this.Text}-{DevCommon.Cloud.AppId}";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnaccess_token_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(DevCommon.Cloud.Access_token);
            this.MsgBox($"{DevCommon.Cloud.Access_token},已复制到剪贴板");
        }
    }
}
