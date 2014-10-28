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
        private readonly string _base_dicpath = Application.StartupPath + "\\dic\\";
        private readonly string _dicname = "cgi.list";
        private string host = string.Empty;
        private string type = string.Empty;

        public MainForm()
        {
            InitializeComponent();
            InitCtrls();
        }

        private void ControlsDisable(bool turnon)
        {
            foreach (Control item in this.Controls)
            {
                item.Enabled = turnon;
            }
        }


        private void InitCtrls()
        {
            var files = Directory.GetFiles(_base_dicpath);
            if (files.Length == 0)
            {
                MessageBox.Show("无字典库，请先导入字典");
            }
            else
            {
                for (int i = 0; i < files.Length; i++)
                {
                    var index = files[i].LastIndexOf('\\') + 1;
                    var filename = files[i].Substring(index, files[i].Length - index);
                    var radio = new RadioButton();
                    radio.Name = "radiobtn_" + filename;
                    radio.Text = filename;
                    radio.Checked = i == 0;
                    this.mainPanel.Controls.Add(radio);
                }
                var radioall = new RadioButton();
                radioall.Name = "radiobtn_all";
                radioall.Text = "全部(很慢)";
                this.mainPanel.Controls.Add(radioall);
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
            if (tar.StartsWith("https://"))
            {
                result[3] = " -ssl ";
                target = tar;
            }
            else if (!tar.StartsWith("http"))
            {
                target = "http://" + tar;
            }
            else
            {
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
        /// 获取勾选类型,返回all为特殊处理
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
                        type = result;
                        break;
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
            var report = Application.StartupPath + "\\" + this.host + ".html";
            if (File.Exists(report))
            {
                File.Move(report, Application.StartupPath + "\\" + this.host + "(" + this.type + ")" + ".html");
            }
            MessageBox.Show("主机:" + this.host + "\r\n扫描完毕,请查看程序目录下的报告");
            Action<bool> act = new Action<bool>(ControlsDisable);
            var objs = new object[] { true };
            this.Invoke(act, objs);
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
            ControlsDisable(false);
            this.backgroundWorker_scan.RunWorkerAsync();
        }

        private void button_builddic_Click(object sender, EventArgs e)
        {
            var form = new BuildDictionaryForm();
            form.ShowDialog();
        }

        private void backgroundWorker_scan_DoWork(object sender, DoWorkEventArgs e)
        {
            ///准备字典
            try
            {
                var file = this.getType();
                if (file == string.Empty)
                {
                    throw new ArgumentNullException("请勾选一个类型");
                }
                else if (file != "all")
                {
                    FileInfo info = new FileInfo(this._base_dicpath + "\\" + file);
                    var cgipath = Application.StartupPath + "\\" + _dicname;
                    if (System.IO.File.Exists(cgipath))
                    {
                        System.IO.File.Delete(cgipath);
                    }
                    info.CopyTo(cgipath);
                }
                else
                {
                    var factory = new TXTFactory();
                    var newcgilist = new List<string>();
                    var files = Directory.GetFiles(_base_dicpath);
                    foreach (var item in files)
                    {
                        var dic = factory.ReadTXT(item);
                        if (dic.Count > 0)
                        {
                            newcgilist.AddRange(dic);
                        }
                    }
                    factory.WriteTXT(_dicname, newcgilist, true);
                }

            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backgroundWorker_scan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //准备命令行参数
            Process process = new Process
            {
                StartInfo = { FileName = "wwwscan.exe" }
                //   StartInfo = { FileName = Application.StartupPath + "\\..\\..\\wwwscan.exe" }
            };
            var target = this.getPath();
            if (target != null)
            {
                this.host = target[0];//以后传给exited
                var port = target[1];
                var threadnum = this.textBox_threadnum.Text;
                var ssl = (string.IsNullOrEmpty(target[3]) ? string.Empty : target[3]);

                process.StartInfo.Arguments = target[0]
                    + " -p " + target[1]
                    + " -m " + threadnum
                    + " -r " + target[2]
                    + ssl;
                process.EnableRaisingEvents = true;
                process.Exited += new EventHandler(this.p_Exited);
                process.Start();
            }
            else
            {
                throw new ArgumentNullException("地址有误");
            }
        }
    }
}
