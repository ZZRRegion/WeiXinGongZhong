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
    public partial class FrmMedia : FrmBase
    {
        public FrmMedia()
        {
            InitializeComponent();
        }

        private void FrmMedia_Load(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg|*.jpg|png|*.png|gif|*.gif";
            if(ofd.ShowDialog(this) == DialogResult.OK)
            {
                this.txtFileName.Text = ofd.FileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.txtFileName.Text))
            {
                Result result = DevCommon.Cloud.PostImage(this.txtFileName.Text);
                if (!string.IsNullOrEmpty(result.Media_id))
                {
                    this.txtMedia_id.Text = result.Media_id;
                    this.txtGet.Text = result.Media_id;
                }
            }
        }

        private void btnGetFile_Click(object sender, EventArgs e)
        {
            this.pic.BackgroundImage = null;
            Stream stream = DevCommon.Cloud.GetImage(this.txtGet.Text);
            Bitmap bitmap = new Bitmap(stream);
            this.pic.BackgroundImage = bitmap;
        }
    }
}
