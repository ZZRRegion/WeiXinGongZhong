namespace WeiXinGongZhong
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAppID = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblAppsecret = new System.Windows.Forms.Label();
            this.txtAppID = new System.Windows.Forms.TextBox();
            this.txtAppsecret = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.Location = new System.Drawing.Point(82, 53);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(96, 27);
            this.lblAppID.TabIndex = 0;
            this.lblAppID.Text = "appID:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(101, 174);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(271, 44);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblAppsecret
            // 
            this.lblAppsecret.AutoSize = true;
            this.lblAppsecret.Location = new System.Drawing.Point(26, 121);
            this.lblAppsecret.Name = "lblAppsecret";
            this.lblAppsecret.Size = new System.Drawing.Size(152, 27);
            this.lblAppsecret.TabIndex = 2;
            this.lblAppsecret.Text = "appsecret:";
            // 
            // txtAppID
            // 
            this.txtAppID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAppID.Location = new System.Drawing.Point(184, 53);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.Size = new System.Drawing.Size(271, 26);
            this.txtAppID.TabIndex = 3;
            this.txtAppID.Text = "wxf05ab4e604c44ebd";
            // 
            // txtAppsecret
            // 
            this.txtAppsecret.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAppsecret.Location = new System.Drawing.Point(184, 121);
            this.txtAppsecret.Name = "txtAppsecret";
            this.txtAppsecret.Size = new System.Drawing.Size(271, 26);
            this.txtAppsecret.TabIndex = 4;
            this.txtAppsecret.Text = "1bace5d67045669beabfb8e52614b830";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 226);
            this.Controls.Add(this.txtAppsecret);
            this.Controls.Add(this.txtAppID);
            this.Controls.Add(this.lblAppsecret);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblAppID);
            this.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmLogin";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppID;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblAppsecret;
        private System.Windows.Forms.TextBox txtAppID;
        private System.Windows.Forms.TextBox txtAppsecret;
    }
}