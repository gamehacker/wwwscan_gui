namespace wwwscan_gui
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_startscan = new System.Windows.Forms.Button();
            this.textBox_target = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.textBox_threadnum = new System.Windows.Forms.TextBox();
            this.panel_dics = new System.Windows.Forms.Panel();
            this.button_builddic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_startscan
            // 
            this.button_startscan.Location = new System.Drawing.Point(122, 297);
            this.button_startscan.Name = "button_startscan";
            this.button_startscan.Size = new System.Drawing.Size(75, 23);
            this.button_startscan.TabIndex = 0;
            this.button_startscan.Text = "Scan";
            this.button_startscan.UseVisualStyleBackColor = true;
            this.button_startscan.Click += new System.EventHandler(this.button_startscan_Click);
            // 
            // textBox_target
            // 
            this.textBox_target.Location = new System.Drawing.Point(12, 12);
            this.textBox_target.Name = "textBox_target";
            this.textBox_target.Size = new System.Drawing.Size(251, 21);
            this.textBox_target.TabIndex = 1;
            this.textBox_target.Text = "www.test.com/admin";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(269, 12);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(39, 21);
            this.textBox_port.TabIndex = 2;
            this.textBox_port.Text = "80";
            // 
            // textBox_threadnum
            // 
            this.textBox_threadnum.Location = new System.Drawing.Point(314, 12);
            this.textBox_threadnum.Name = "textBox_threadnum";
            this.textBox_threadnum.Size = new System.Drawing.Size(39, 21);
            this.textBox_threadnum.TabIndex = 3;
            this.textBox_threadnum.Text = "10";
            // 
            // panel_dics
            // 
            this.panel_dics.Location = new System.Drawing.Point(12, 67);
            this.panel_dics.Name = "panel_dics";
            this.panel_dics.Size = new System.Drawing.Size(341, 193);
            this.panel_dics.TabIndex = 13;
            // 
            // button_builddic
            // 
            this.button_builddic.Location = new System.Drawing.Point(13, 297);
            this.button_builddic.Name = "button_builddic";
            this.button_builddic.Size = new System.Drawing.Size(75, 23);
            this.button_builddic.TabIndex = 14;
            this.button_builddic.Text = "导入字典";
            this.button_builddic.UseVisualStyleBackColor = true;
            this.button_builddic.Click += new System.EventHandler(this.button_builddic_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 332);
            this.Controls.Add(this.button_builddic);
            this.Controls.Add(this.panel_dics);
            this.Controls.Add(this.textBox_threadnum);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_target);
            this.Controls.Add(this.button_startscan);
            this.Name = "MainForm";
            this.Text = "wwwscan gui——by luciker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_startscan;
        private System.Windows.Forms.TextBox textBox_target;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.TextBox textBox_threadnum;
        private System.Windows.Forms.Panel panel_dics;
        private System.Windows.Forms.Button button_builddic;
    }
}

