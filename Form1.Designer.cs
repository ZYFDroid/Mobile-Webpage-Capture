namespace UP主抓包神器
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.browserPanel = new System.Windows.Forms.Panel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDevTools = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGoto = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentAddress = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilterHost = new System.Windows.Forms.TextBox();
            this.btnClearPost = new System.Windows.Forms.Button();
            this.txtPostDetail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listPost = new System.Windows.Forms.ListBox();
            this.chkUsesCapture = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtAddressRecord = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = global::UP主抓包神器.Properties.Resources.bg_phone;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.btnClear);
            this.mainPanel.Controls.Add(this.lblClock);
            this.mainPanel.Controls.Add(this.lblTitle);
            this.mainPanel.Controls.Add(this.browserPanel);
            this.mainPanel.Location = new System.Drawing.Point(13, 13);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(383, 719);
            this.mainPanel.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(17, 60);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(37, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "   ";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblClock
            // 
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(27, 24);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(119, 17);
            this.lblClock.TabIndex = 2;
            this.lblClock.Text = "00:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(51, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "载入中...";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // browserPanel
            // 
            this.browserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browserPanel.BackColor = System.Drawing.Color.White;
            this.browserPanel.Location = new System.Drawing.Point(13, 91);
            this.browserPanel.Name = "browserPanel";
            this.browserPanel.Size = new System.Drawing.Size(355, 544);
            this.browserPanel.TabIndex = 0;
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 333;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDevTools);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnForward);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnGoto);
            this.groupBox1.Controls.Add(this.txtUrl);
            this.groupBox1.Location = new System.Drawing.Point(403, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制";
            // 
            // btnDevTools
            // 
            this.btnDevTools.Location = new System.Drawing.Point(290, 47);
            this.btnDevTools.Name = "btnDevTools";
            this.btnDevTools.Size = new System.Drawing.Size(115, 24);
            this.btnDevTools.TabIndex = 2;
            this.btnDevTools.Text = "F12原生抓包";
            this.btnDevTools.UseVisualStyleBackColor = true;
            this.btnDevTools.Click += new System.EventHandler(this.btnDevTools_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(218, 47);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(66, 24);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(150, 47);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(62, 24);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(80, 47);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(64, 24);
            this.btnForward.TabIndex = 2;
            this.btnForward.Text = "前进";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(11, 47);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 24);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "后退";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGoto
            // 
            this.btnGoto.Location = new System.Drawing.Point(351, 19);
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Size = new System.Drawing.Size(54, 22);
            this.btnGoto.TabIndex = 1;
            this.btnGoto.Text = "转到";
            this.btnGoto.UseVisualStyleBackColor = true;
            this.btnGoto.Click += new System.EventHandler(this.btnGoto_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(11, 19);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(334, 22);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "http://";
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCurrentAddress);
            this.groupBox2.Location = new System.Drawing.Point(403, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 96);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(53, 76);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(345, 13);
            this.progressBar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "进度:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "地址:";
            // 
            // txtCurrentAddress
            // 
            this.txtCurrentAddress.Location = new System.Drawing.Point(52, 16);
            this.txtCurrentAddress.Multiline = true;
            this.txtCurrentAddress.Name = "txtCurrentAddress";
            this.txtCurrentAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCurrentAddress.Size = new System.Drawing.Size(346, 54);
            this.txtCurrentAddress.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.chkUsesCapture);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(403, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(411, 485);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "　　简易抓包";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtFilterHost);
            this.groupBox5.Controls.Add(this.btnClearPost);
            this.groupBox5.Controls.Add(this.txtPostDetail);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.listPost);
            this.groupBox5.Location = new System.Drawing.Point(6, 177);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(399, 302);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "请求抓包";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "排除域名(英文逗号分割):";
            // 
            // txtFilterHost
            // 
            this.txtFilterHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterHost.Location = new System.Drawing.Point(161, 32);
            this.txtFilterHost.Multiline = true;
            this.txtFilterHost.Name = "txtFilterHost";
            this.txtFilterHost.Size = new System.Drawing.Size(230, 23);
            this.txtFilterHost.TabIndex = 4;
            this.txtFilterHost.Text = "qq.com,cnzz.com";
            this.txtFilterHost.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnClearPost
            // 
            this.btnClearPost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearPost.Location = new System.Drawing.Point(312, 182);
            this.btnClearPost.Margin = new System.Windows.Forms.Padding(1);
            this.btnClearPost.Name = "btnClearPost";
            this.btnClearPost.Size = new System.Drawing.Size(79, 23);
            this.btnClearPost.TabIndex = 3;
            this.btnClearPost.Text = "清空列表";
            this.btnClearPost.UseVisualStyleBackColor = true;
            this.btnClearPost.Click += new System.EventHandler(this.btnClearPost_Click);
            // 
            // txtPostDetail
            // 
            this.txtPostDetail.Location = new System.Drawing.Point(8, 209);
            this.txtPostDetail.Multiline = true;
            this.txtPostDetail.Name = "txtPostDetail";
            this.txtPostDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPostDetail.Size = new System.Drawing.Size(383, 87);
            this.txtPostDetail.TabIndex = 2;
            this.txtPostDetail.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "抓包内容/BomberStudio游戏目标:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "请求列表:";
            // 
            // listPost
            // 
            this.listPost.FormattingEnabled = true;
            this.listPost.ItemHeight = 12;
            this.listPost.Location = new System.Drawing.Point(8, 54);
            this.listPost.Name = "listPost";
            this.listPost.Size = new System.Drawing.Size(383, 124);
            this.listPost.TabIndex = 0;
            this.listPost.SelectedIndexChanged += new System.EventHandler(this.listPost_SelectedIndexChanged);
            // 
            // chkUsesCapture
            // 
            this.chkUsesCapture.AutoSize = true;
            this.chkUsesCapture.Location = new System.Drawing.Point(13, 0);
            this.chkUsesCapture.Name = "chkUsesCapture";
            this.chkUsesCapture.Size = new System.Drawing.Size(15, 14);
            this.chkUsesCapture.TabIndex = 1;
            this.chkUsesCapture.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAddressRecord);
            this.groupBox4.Location = new System.Drawing.Point(6, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 152);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "地址记录:";
            // 
            // txtAddressRecord
            // 
            this.txtAddressRecord.BackColor = System.Drawing.Color.Black;
            this.txtAddressRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddressRecord.ForeColor = System.Drawing.Color.Lime;
            this.txtAddressRecord.Location = new System.Drawing.Point(8, 16);
            this.txtAddressRecord.Multiline = true;
            this.txtAddressRecord.Name = "txtAddressRecord";
            this.txtAddressRecord.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddressRecord.Size = new System.Drawing.Size(384, 126);
            this.txtAddressRecord.TabIndex = 0;
            this.txtAddressRecord.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 692);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "抓包神器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel browserPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDevTools;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGoto;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrentAddress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnClear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkUsesCapture;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtAddressRecord;
        private System.Windows.Forms.TextBox txtPostDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listPost;
        private System.Windows.Forms.Button btnClearPost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilterHost;
    }
}

