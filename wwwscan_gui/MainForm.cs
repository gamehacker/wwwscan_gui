using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wwwscan_gui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                //byte[] bytes = new WebClient().DownloadData("http://" + this.txtTarget.Text);
                //string str = Encoding.Default.GetString(bytes);
                //string[] strArray = new string[] { ".asp", ".aspx", ".php", ".jsp" };
                //for (int i = 0; i < 4; i++)
                //{
                //    if (str.IndexOf(strArray[i]) != -1)
                //    {
                //        this.lblType.Text = "可能为" + strArray[i].Substring(1);
                //        return;
                //    }
                //}
            }
            catch (Exception)
            {
                MessageBox.Show("不能确定脚本类型");
            }
        }



        private bool changeList()
        {
            FileInfo info = new FileInfo(this.getType());
            if (System.IO.File.Exists("cgi.list"))
            {
                System.IO.File.Delete("cgi.list");
            }
            info.CopyTo("cgi.list");
            return true;
        }


        private string getPath()
        {
            //if (this.rBmain.Checked)
            //{
            //    return "";
            //}
            //return ("/" + this.cBPath.Text + "/");
            throw new NotImplementedException();
        }

        private int getPort()
        {
            //return int.Parse(this.txtPort.Text);
            throw new NotImplementedException();
        }

        private int getThread()
        {
            return int.Parse(this.textBox_threadnum.Text);
        }

        private string getType()
        {
            //int count = this.groupBox2.Controls.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    if (((RadioButton)this.groupBox2.Controls[i]).Checked)
            //    {
            //        return ("dic/" + ((RadioButton)this.groupBox2.Controls[i]).Text + ".list");
            //    }
            //}
            //return "";
            throw new NotImplementedException();
        }


        private void p_Exited(object sender, EventArgs e)
        {
            //MessageBox.Show(this.txtTarget.Text + "扫描完毕,请查看程序目录下的报告");
        }

        private void rBmain_CheckedChanged(object sender, EventArgs e)
        {
            //this.cBPath.Enabled = false;
        }

        private void rBOther_CheckedChanged(object sender, EventArgs e)
        {
            //this.cBPath.Enabled = true;
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar == '\b') || char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("端口号只能是数字");
            }
        }

        private void txtThread_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar == '\b') || char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("线程数只能是数字");
            }
        }

        private void button_startscan_Click(object sender, EventArgs e)
        {
            this.changeList();
            Process process = new Process
            {
                StartInfo = { FileName = "wwwscan.exe" }
            };
            if (this.getPath() == "")
            {
                //process.StartInfo.Arguments = this.txtTarget.Text + " -p " + this.txtPort.Text + " -m " + this.txtThread.Text;
            }
            else
            {
                //process.StartInfo.Arguments = this.txtTarget.Text + " -r " + this.getPath() + " -p " + this.txtPort.Text + " -m " + this.txtThread.Text;
            }
            process.EnableRaisingEvents = true;
            process.Exited += new EventHandler(this.p_Exited);
            process.Start();
        }

        private void button_builddic_Click(object sender, EventArgs e)
        {
            var form = new BuildDictionaryForm();
            form.ShowDialog();
        }
    }
}
