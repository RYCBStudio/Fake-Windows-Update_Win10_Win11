namespace Update
{
    partial class WindowsUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsUpdate));
            this.Updating = new System.Windows.Forms.Label();
            this.Completed = new System.Windows.Forms.Label();
            this.CompletedNumber = new System.Windows.Forms.Label();
            this.DoNotShutDownTip = new System.Windows.Forms.Label();
            this.Loading = new System.Windows.Forms.PictureBox();
            this.Percent = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Loading)).BeginInit();
            this.SuspendLayout();
            // 
            // Updating
            // 
            this.Updating.AutoSize = true;
            this.Updating.BackColor = System.Drawing.Color.Transparent;
            this.Updating.Font = new System.Drawing.Font("Microsoft YaHei UI", 25F);
            this.Updating.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Updating.Location = new System.Drawing.Point(377, 266);
            this.Updating.Name = "Updating";
            this.Updating.Size = new System.Drawing.Size(276, 55);
            this.Updating.TabIndex = 0;
            this.Updating.Text = "正在配置更新";
            this.Updating.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Completed
            // 
            this.Completed.AutoSize = true;
            this.Completed.BackColor = System.Drawing.Color.Transparent;
            this.Completed.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.Completed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Completed.Location = new System.Drawing.Point(408, 310);
            this.Completed.Name = "Completed";
            this.Completed.Size = new System.Drawing.Size(122, 45);
            this.Completed.TabIndex = 1;
            this.Completed.Text = "已完成";
            this.Completed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CompletedNumber
            // 
            this.CompletedNumber.AutoSize = true;
            this.CompletedNumber.BackColor = System.Drawing.Color.Transparent;
            this.CompletedNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.CompletedNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CompletedNumber.Location = new System.Drawing.Point(507, 310);
            this.CompletedNumber.Name = "CompletedNumber";
            this.CompletedNumber.Size = new System.Drawing.Size(60, 45);
            this.CompletedNumber.TabIndex = 2;
            this.CompletedNumber.Text = "  0";
            this.CompletedNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DoNotShutDownTip
            // 
            this.DoNotShutDownTip.AutoSize = true;
            this.DoNotShutDownTip.BackColor = System.Drawing.Color.Transparent;
            this.DoNotShutDownTip.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.DoNotShutDownTip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DoNotShutDownTip.Location = new System.Drawing.Point(344, 345);
            this.DoNotShutDownTip.Name = "DoNotShutDownTip";
            this.DoNotShutDownTip.Size = new System.Drawing.Size(394, 45);
            this.DoNotShutDownTip.TabIndex = 3;
            this.DoNotShutDownTip.Text = "请不要关闭您的计算机。";
            this.DoNotShutDownTip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Loading
            // 
            this.Loading.Image = ((System.Drawing.Image)(resources.GetObject("Loading.Image")));
            this.Loading.Location = new System.Drawing.Point(463, 155);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(64, 64);
            this.Loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Loading.TabIndex = 4;
            this.Loading.TabStop = false;
            // 
            // Percent
            // 
            this.Percent.AutoSize = true;
            this.Percent.BackColor = System.Drawing.Color.Transparent;
            this.Percent.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.Percent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Percent.Location = new System.Drawing.Point(568, 310);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(50, 45);
            this.Percent.TabIndex = 5;
            this.Percent.Text = "%";
            this.Percent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 5000;
            this.UpdateTimer.Tick += new System.EventHandler(this.DZUpdate);
            // 
            // WindowsUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(990, 610);
            this.ControlBox = false;
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.DoNotShutDownTip);
            this.Controls.Add(this.Completed);
            this.Controls.Add(this.CompletedNumber);
            this.Controls.Add(this.Updating);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowsUpdate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Windows 更新";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WindowsUpdate_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WindowsUpdate_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Updating;
        private System.Windows.Forms.Label Completed;
        private System.Windows.Forms.Label CompletedNumber;
        private System.Windows.Forms.Label DoNotShutDownTip;
        private System.Windows.Forms.PictureBox Loading;
        private System.Windows.Forms.Label Percent;
        public System.Windows.Forms.Timer UpdateTimer;
    }
}

