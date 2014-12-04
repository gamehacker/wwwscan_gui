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
            this.textBox_threadnum = new System.Windows.Forms.TextBox();
            this.button_builddic = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker_scan = new System.ComponentModel.BackgroundWorker();
            this.button_openstartup = new System.Windows.Forms.Button();
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
            this.textBox_target.Location = new System.Drawing.Point(12, 34);
            this.textBox_target.Name = "textBox_target";
            this.textBox_target.Size = new System.Drawing.Size(296, 21);
            this.textBox_target.TabIndex = 1;
            this.textBox_target.Text = "www.test.com/admin";
            // 
            // textBox_threadnum
            // 
            this.textBox_threadnum.Location = new System.Drawing.Point(314, 34);
            this.textBox_threadnum.Name = "textBox_threadnum";
            this.textBox_threadnum.Size = new System.Drawing.Size(39, 21);
            this.textBox_threadnum.TabIndex = 3;
            this.textBox_threadnum.Text = "10";
            this.textBox_threadnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThread_KeyPress);
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
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(12, 86);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(341, 205);
            this.mainPanel.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "目标";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "线程";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "目标类型";
            // 
            // backgroundWorker_scan
            // 
            this.backgroundWorker_scan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_scan_DoWork);
            this.backgroundWorker_scan.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_scan_RunWorkerCompleted);
            // 
            // button_openstartup
            // 
            this.button_openstartup.Location = new System.Drawing.Point(266, 297);
            this.button_openstartup.Name = "button_openstartup";
            this.button_openstartup.Size = new System.Drawing.Size(75, 23);
            this.button_openstartup.TabIndex = 20;
            this.button_openstartup.Text = "打开目录";
            this.button_openstartup.UseVisualStyleBackColor = true;
            this.button_openstartup.Click += new System.EventHandler(this.button_openstartup_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 332);
            this.Controls.Add(this.button_openstartup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.button_builddic);
            this.Controls.Add(this.textBox_threadnum);
            this.Controls.Add(this.textBox_target);
            this.Controls.Add(this.button_startscan);
            this.MaximumSize = new System.Drawing.Size(380, 370);
            this.MinimumSize = new System.Drawing.Size(380, 370);
            this.Name = "MainForm";
            this.Text = "wwwscan gui——by luciker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_startscan;
        private System.Windows.Forms.TextBox textBox_target;
        private System.Windows.Forms.TextBox textBox_threadnum;
        private System.Windows.Forms.Button button_builddic;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker_scan;
        private System.Windows.Forms.Button button_openstartup;
    }
}

