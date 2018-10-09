namespace WeiXinGongZhong
{
    partial class FrmTags
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
            this.btnCreateTag = new System.Windows.Forms.Button();
            this.txtTagName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetTags = new System.Windows.Forms.Button();
            this.lstTag = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCreateTag
            // 
            this.btnCreateTag.Location = new System.Drawing.Point(222, 14);
            this.btnCreateTag.Name = "btnCreateTag";
            this.btnCreateTag.Size = new System.Drawing.Size(98, 23);
            this.btnCreateTag.TabIndex = 0;
            this.btnCreateTag.Text = "创建标签";
            this.btnCreateTag.UseVisualStyleBackColor = true;
            this.btnCreateTag.Click += new System.EventHandler(this.btnCreateTag_Click);
            // 
            // txtTagName
            // 
            this.txtTagName.Location = new System.Drawing.Point(75, 15);
            this.txtTagName.Name = "txtTagName";
            this.txtTagName.Size = new System.Drawing.Size(131, 21);
            this.txtTagName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "标签名：";
            // 
            // btnGetTags
            // 
            this.btnGetTags.Location = new System.Drawing.Point(18, 54);
            this.btnGetTags.Name = "btnGetTags";
            this.btnGetTags.Size = new System.Drawing.Size(98, 23);
            this.btnGetTags.TabIndex = 3;
            this.btnGetTags.Text = "获取标签";
            this.btnGetTags.UseVisualStyleBackColor = true;
            this.btnGetTags.Click += new System.EventHandler(this.btnGetTags_Click);
            // 
            // lstTag
            // 
            this.lstTag.FormattingEnabled = true;
            this.lstTag.ItemHeight = 12;
            this.lstTag.Location = new System.Drawing.Point(18, 90);
            this.lstTag.Name = "lstTag";
            this.lstTag.Size = new System.Drawing.Size(302, 328);
            this.lstTag.TabIndex = 4;
            // 
            // FrmTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 424);
            this.Controls.Add(this.lstTag);
            this.Controls.Add(this.btnGetTags);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTagName);
            this.Controls.Add(this.btnCreateTag);
            this.Name = "FrmTags";
            this.Text = "用户标签管理";
            this.Load += new System.EventHandler(this.FrmTags_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTag;
        private System.Windows.Forms.TextBox txtTagName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetTags;
        private System.Windows.Forms.ListBox lstTag;
    }
}