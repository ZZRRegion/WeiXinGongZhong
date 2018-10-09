namespace WeiXinGongZhong
{
    partial class FrmMedia
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblMedia_id = new System.Windows.Forms.Label();
            this.txtMedia_id = new System.Windows.Forms.TextBox();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.txtGet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(600, 21);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(113, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "选择文件...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(96, 21);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(498, 21);
            this.txtFileName.TabIndex = 1;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(22, 25);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(65, 12);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "文件路径：";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(600, 58);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(113, 23);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "上传文件";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblMedia_id
            // 
            this.lblMedia_id.AutoSize = true;
            this.lblMedia_id.Location = new System.Drawing.Point(22, 63);
            this.lblMedia_id.Name = "lblMedia_id";
            this.lblMedia_id.Size = new System.Drawing.Size(65, 12);
            this.lblMedia_id.TabIndex = 4;
            this.lblMedia_id.Text = "Media_id：";
            // 
            // txtMedia_id
            // 
            this.txtMedia_id.Location = new System.Drawing.Point(96, 59);
            this.txtMedia_id.Name = "txtMedia_id";
            this.txtMedia_id.ReadOnly = true;
            this.txtMedia_id.Size = new System.Drawing.Size(498, 21);
            this.txtMedia_id.TabIndex = 5;
            // 
            // btnGetFile
            // 
            this.btnGetFile.Location = new System.Drawing.Point(600, 92);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(113, 23);
            this.btnGetFile.TabIndex = 6;
            this.btnGetFile.Text = "获取文件";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // pic
            // 
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic.Location = new System.Drawing.Point(22, 124);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(571, 324);
            this.pic.TabIndex = 7;
            this.pic.TabStop = false;
            // 
            // txtGet
            // 
            this.txtGet.Location = new System.Drawing.Point(96, 92);
            this.txtGet.Name = "txtGet";
            this.txtGet.Size = new System.Drawing.Size(498, 21);
            this.txtGet.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Media_id：";
            // 
            // FrmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGet);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btnGetFile);
            this.Controls.Add(this.txtMedia_id);
            this.Controls.Add(this.lblMedia_id);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnSelect);
            this.Name = "FrmMedia";
            this.Text = "素材管理";
            this.Load += new System.EventHandler(this.FrmMedia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblMedia_id;
        private System.Windows.Forms.TextBox txtMedia_id;
        private System.Windows.Forms.Button btnGetFile;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TextBox txtGet;
        private System.Windows.Forms.Label label1;
    }
}