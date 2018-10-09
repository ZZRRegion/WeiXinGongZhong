namespace WeiXinGongZhong
{
    partial class FrmCallbackIP
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
            this.lstIP = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstIP
            // 
            this.lstIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstIP.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstIP.FormattingEnabled = true;
            this.lstIP.ItemHeight = 20;
            this.lstIP.Location = new System.Drawing.Point(0, 0);
            this.lstIP.Name = "lstIP";
            this.lstIP.Size = new System.Drawing.Size(356, 450);
            this.lstIP.TabIndex = 0;
            // 
            // FrmCallbackIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.lstIP);
            this.Name = "FrmCallbackIP";
            this.Text = "微信服务器IP地址";
            this.Load += new System.EventHandler(this.FrmCallbackIP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstIP;
    }
}