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
    public partial class FrmUser : FrmBase
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            ResultUsers resultUsers = DevCommon.Cloud.GetUsers();
            resultUsers.Data.OpenId.ForEach(item => {
                this.lstUser.Items.Add(item);
            });
        }
    }
}
