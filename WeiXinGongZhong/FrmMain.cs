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

        private void btnCreateMenu_Click(object sender, EventArgs e)
        {
            FrmCreateMenu frmCreateMenu = new FrmCreateMenu();
            if(frmCreateMenu.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void btnIP_Click(object sender, EventArgs e)
        {
            FrmCallbackIP frmCallbackIP = new FrmCallbackIP();
            if(frmCallbackIP.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            FrmMedia frmMedia = new FrmMedia();
            if(frmMedia.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void btnmaterial_Click(object sender, EventArgs e)
        {
            FrmMaterial frmMaterial = new FrmMaterial();
            if(frmMaterial.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            FrmTags frmTags = new FrmTags();
            if(frmTags.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmUser frmUser = new FrmUser();
            if(frmUser.ShowDialog(this) == DialogResult.OK)
            {

            }
        }
    }
}
