using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WeiXinGongZhong
{
    public partial class FrmCreateMenu : FrmBase
    {
        public FrmCreateMenu()
        {
            InitializeComponent();
        }

        private void FrmCreateMenu_Load(object sender, EventArgs e)
        {
            string content = File.ReadAllText("menu.json");
            this.rtbMenu.Text = content;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            Result result = DevCommon.Cloud.PostCreateMenu(this.rtbMenu.Text);
            if(result.ErrCode != "0")
            {
                this.MsgBox($"{result.ErrCode},{result.ErrMsg}");
            }
            else
            {
                this.MsgBox("设置成功");
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            this.rtbMenu.Clear();
            string content = DevCommon.Cloud.GetMenu();
            this.rtbMenu.Text = content;
        }
    }
}
