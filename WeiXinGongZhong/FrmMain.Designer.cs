namespace WeiXinGongZhong
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnaccess_token = new System.Windows.Forms.Button();
            this.btnCreateMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnaccess_token
            // 
            this.btnaccess_token.Location = new System.Drawing.Point(12, 24);
            this.btnaccess_token.Name = "btnaccess_token";
            this.btnaccess_token.Size = new System.Drawing.Size(142, 23);
            this.btnaccess_token.TabIndex = 0;
            this.btnaccess_token.Text = "access_token";
            this.btnaccess_token.UseVisualStyleBackColor = true;
            this.btnaccess_token.Click += new System.EventHandler(this.btnaccess_token_Click);
            // 
            // btnCreateMenu
            // 
            this.btnCreateMenu.Location = new System.Drawing.Point(203, 24);
            this.btnCreateMenu.Name = "btnCreateMenu";
            this.btnCreateMenu.Size = new System.Drawing.Size(117, 23);
            this.btnCreateMenu.TabIndex = 1;
            this.btnCreateMenu.Text = "自定义菜单创建";
            this.btnCreateMenu.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateMenu);
            this.Controls.Add(this.btnaccess_token);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "微信公众号工具";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnaccess_token;
        private System.Windows.Forms.Button btnCreateMenu;
    }
}

