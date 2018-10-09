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
            this.btnIP = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnmaterial = new System.Windows.Forms.Button();
            this.btnTags = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
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
            this.btnCreateMenu.Location = new System.Drawing.Point(164, 24);
            this.btnCreateMenu.Name = "btnCreateMenu";
            this.btnCreateMenu.Size = new System.Drawing.Size(142, 23);
            this.btnCreateMenu.TabIndex = 1;
            this.btnCreateMenu.Text = "自定义菜单创建";
            this.btnCreateMenu.UseVisualStyleBackColor = true;
            this.btnCreateMenu.Click += new System.EventHandler(this.btnCreateMenu_Click);
            // 
            // btnIP
            // 
            this.btnIP.Location = new System.Drawing.Point(316, 24);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(142, 23);
            this.btnIP.TabIndex = 2;
            this.btnIP.Text = "微信服务器IP地址";
            this.btnIP.UseVisualStyleBackColor = true;
            this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(468, 24);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(142, 23);
            this.btnMedia.TabIndex = 3;
            this.btnMedia.Text = "素材管理";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnmaterial
            // 
            this.btnmaterial.Location = new System.Drawing.Point(12, 71);
            this.btnmaterial.Name = "btnmaterial";
            this.btnmaterial.Size = new System.Drawing.Size(142, 23);
            this.btnmaterial.TabIndex = 4;
            this.btnmaterial.Text = "图文管理";
            this.btnmaterial.UseVisualStyleBackColor = true;
            this.btnmaterial.Click += new System.EventHandler(this.btnmaterial_Click);
            // 
            // btnTags
            // 
            this.btnTags.Location = new System.Drawing.Point(164, 71);
            this.btnTags.Name = "btnTags";
            this.btnTags.Size = new System.Drawing.Size(142, 23);
            this.btnTags.TabIndex = 5;
            this.btnTags.Text = "用户标签管理";
            this.btnTags.UseVisualStyleBackColor = true;
            this.btnTags.Click += new System.EventHandler(this.btnTags_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(316, 71);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(142, 23);
            this.btnUser.TabIndex = 6;
            this.btnUser.Text = "用户列表";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 327);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnTags);
            this.Controls.Add(this.btnmaterial);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnIP);
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
        private System.Windows.Forms.Button btnIP;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnmaterial;
        private System.Windows.Forms.Button btnTags;
        private System.Windows.Forms.Button btnUser;
    }
}

