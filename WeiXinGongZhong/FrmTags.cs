using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeiXinGongZhong.Models;

namespace WeiXinGongZhong
{
    public partial class FrmTags : FrmBase
    {
        public FrmTags()
        {
            InitializeComponent();
        }

        private void FrmTags_Load(object sender, EventArgs e)
        {
            this.lstTag.Items.Clear();
            List<ResultTag> lst = DevCommon.Cloud.GetTags();
            lst.ForEach(item => {
                this.lstTag.Items.Add(item);
            });
        }

        private void btnCreateTag_Click(object sender, EventArgs e)
        {
            Tags tags = new Tags();
            tags.tag.name = this.txtTagName.Text;

            ResultTag tag = DevCommon.Cloud.PostTags(tags.ToString());
            if (!string.IsNullOrEmpty(tag.Id))
            {
                this.MsgBox($"创建成功,ID:{tag.Id}");
            }
            else
            {
                this.MsgBox($"创建失败，errcode:{tag.ErrCode},errmsg:{tag.ErrMsg}");
            }
        }

        private void btnGetTags_Click(object sender, EventArgs e)
        {
            this.lstTag.Items.Clear();
            List<ResultTag> lst = DevCommon.Cloud.GetTags();
            lst.ForEach(item => {
                this.lstTag.Items.Add(item);
            });
        }
    }
}
