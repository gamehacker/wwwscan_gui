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
        private string base_dicpath = Application.StartupPath + "\\dic\\";

        public MainForm()
        {
            InitializeComponent();
            InitCtrls();
        }

        private void InitCtrls()
        {
            var files = Directory.GetFiles(base_dicpath);
            if (files.Length == 0)
            {
                MessageBox.Show("无字典库，请先导入字典");
            }
            else
            {
                foreach (string item in files)
                {
                    var index = item.LastIndexOf('\\') + 1;
                    var filename = item.Substring(index, item.Length - index);
                    var radio = new RadioButton();
                    radio.Name = "radiobtn_" + filename;
                    radio.Text = filename;
                    this.mainPanel.Controls.Add(radio);
                }
                var radioall = new RadioButton();
                radioall.Name = "radiobtn_all";
                radioall.Text = "全部(较慢)";
                this.mainPanel.Controls.Add(radioall);
            }
        }


        private void InitCgilist()
        {
            var file = this.getType();
            if (file == string.Empty)
            {
                throw new ArgumentNullException("请勾选一个类型");
            }
            else if (file != "all")
            {
                FileInfo info = new FileInfo(this.base_dicpath + "\\" + file);
                if (System.IO.File.Exists(Application.StartupPath + "\\cgi.list"))
                {
                    System.IO.File.Delete(Application.StartupPath + "\\cgi.list");
                }
                info.CopyTo(Application.StartupPath + "\\cgi.list");
            }
            else
            {
                var factory = new TXTFactory();
                var newcgilist = new List<string>();
                var files = Directory.GetFiles(base_dicpath);
                foreach (var item in files)
                {
                    var dic = factory.ReadTXT(item);
                    if (dic.Count > 0)
                    {
                        newcgilist.AddRange(dic);
                    }
                }
                factory.WriteTXT("cgilist", newcgilist, true);
            }
        }


        /// <summary>
        /// 获取路径 
        /// 由于wwwscan不支持完整路径，必须把主机和路径分开
        /// 0为host，1为port,2为path，3为" -ssl "或空
        /// </summary>
        /// <returns></returns>
        private string[] getPath()
        {
            var result = new string[4];
            var tar = this.textBox_target.Text.Trim();
            string target = string.Empty;
            if (!tar.StartsWith("http"))
            {
                target = "http://" + tar;
            }
            if (tar.StartsWith("https://"))
            {
                result[3] = " -ssl ";
                target = tar;
            }


            try
            {
                var url = new Uri(target);
                result[0] = url.Host;
                result[1] = url.Port.ToString();
                var path = string.Empty;
                foreach (string item in url.Segments)
                {
                    path += item;
                }
                result[2] = path;

            }
            catch (UriFormatException)
            {
                result = null;
            }

            return result;
        }



        /// <summary>
        /// 获取勾选类型
        /// </summary>
        /// <returns></returns>
        private string getType()
        {
            var result = string.Empty;
            foreach (Control item in this.mainPanel.Controls)
            {
                if (item is RadioButton)
                {
                    var radio = item as RadioButton;
                    if (radio.Checked)
                    {
                        result = radio.Name != "radiobtn_all" ? radio.Text : "all";
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return result;
        }


        private void p_Exited(object sender, EventArgs e)
        {
            //MessageBox.Show(this.txtTarget.Text + "扫描完毕,请查看程序目录下的报告");
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
            try
            {
                this.InitCgilist();
                Process process = new Process
                {
                    StartInfo = { FileName = "wwwscan.exe" }
                    //   StartInfo = { FileName = Application.StartupPath + "\\..\\..\\wwwscan.exe" }
                };
                var target = this.getPath();
                if (target != null)
                {
                    //除非url不带端口，否则以url中的为准
                    var port = target[1];
                    var threadnum = this.textBox_threadnum.Text;
                    var ssl = (string.IsNullOrEmpty(target[3]) ? string.Empty : target[3]);

                    var args = target[0]
                        + " -p " + target[1]
                        + " -m " + threadnum
                        + " -r " + target[2]
                        + ssl;
                    process.StartInfo.Arguments = args;

                    process.EnableRaisingEvents = true;
                    process.Exited += new EventHandler(this.p_Exited);
                    process.Start();
                }
                else
                {
                    throw new ArgumentNullException("地址有误");
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_builddic_Click(object sender, EventArgs e)
        {
            var form = new BuildDictionaryForm();
            form.ShowDialog();
        }
    }
}
