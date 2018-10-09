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
using System.IO;

namespace WeiXinGongZhong
{
    public partial class FrmMaterial : FrmBase
    {
        public FrmMaterial()
        {
            InitializeComponent();
        }

        private void FrmMaterial_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Article article = new Article();
            article.title = this.txtTitle.Text;
            article.author = this.txtAuthor.Text;
            article.content = this.rtbContent.Text;
            Articles articles = new Articles();
            articles.articles.Add(article);
            DevCommon.Cloud.PostMaterial(articles.ToString());
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.txtFileName.Text))
            {
                Result result = DevCommon.Cloud.PostMaterialImage(this.txtFileName.Text);
                if(!string.IsNullOrEmpty(result.Url))
                {
                    this.txtURL.Text = result.Url;
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg|*.jpg";
            if(ofd.ShowDialog(this) == DialogResult.OK)
            {
                this.txtFileName.Text = ofd.FileName;
            }
        }
    }
}
