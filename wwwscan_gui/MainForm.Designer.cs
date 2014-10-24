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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_builddic = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox7);
            this.panel1.Controls.Add(this.checkBox8);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 193);
            this.panel1.TabIndex = 13;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(143, 88);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(60, 16);
            this.checkBox5.TabIndex = 22;
            this.checkBox5.Text = "backup";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(215, 121);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(48, 16);
            this.checkBox7.TabIndex = 21;
            this.checkBox7.Text = "edit";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(215, 88);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(54, 16);
            this.checkBox8.TabIndex = 20;
            this.checkBox8.Text = "other";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(131, 121);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(42, 16);
            this.checkBox4.TabIndex = 18;
            this.checkBox4.Text = "dir";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(131, 55);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(42, 16);
            this.checkBox6.TabIndex = 16;
            this.checkBox6.Text = "jsp";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(47, 121);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(42, 16);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "php";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(47, 88);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 16);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "aspx";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(47, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "html";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_threadnum);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_target);
            this.Controls.Add(this.button_startscan);
            this.Name = "MainForm";
            this.Text = "wwwscan gui——by luciker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_startscan;
        private System.Windows.Forms.TextBox textBox_target;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.TextBox textBox_threadnum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button button_builddic;
    }
}

