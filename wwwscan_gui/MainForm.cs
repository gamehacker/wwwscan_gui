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
        private string _host = string.Empty;
        private string _subpath = string.Empty;
        private string _port = string.Empty;
        private string _ssl = string.Empty;
        private string _type = string.Empty;

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
            string[] files;
            try
            {
                files = Directory.GetFiles(_base_dicpath);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("未找到dic目录，请先使用倒入字典功能");
                return;
            }

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
                this.button_startscan.Enabled = true;
            }
        }

        /// <summary>
        /// 获取路径 
        /// 由于wwwscan不支持完整路径，必须把主机和路径分开
        /// 0为host，1为port,2为path，3为" -ssl "或空
        /// </summary>
        /// <returns></returns>
        private void SetPath()
        {
            var tar = this.textBox_target.Text.Trim();
            string target = string.Empty;
            if (tar.StartsWith("https://"))
            {
                _ssl = " -ssl ";
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
            var url = new Uri(target);
            _host = url.Host;
            _port = url.Port.ToString();
            var path = string.Empty;
            foreach (string item in url.Segments)
            {
                path += item;
            }
            _subpath = path;
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
                        _type = result;
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
            var report = Application.StartupPath + "\\" + this._host + ".html";
            var reportpath = Application.StartupPath + "\\reports";
            if (!Directory.Exists(reportpath))
            {
                Directory.CreateDirectory(reportpath);
            }
            if (File.Exists(report))
            {
                File.Move(report, reportpath + "\\" + this._host + "(" + this._type + ")" + ".html");
            }
            MessageBox.Show(this._host + _subpath + "\r\n扫描完毕,请查看程序目录下的报告");
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
            this.mainPanel.Controls.Clear();
            this.InitCtrls();
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
            this.SetPath();
            var threadnum = this.textBox_threadnum.Text;

            process.StartInfo.Arguments = _host
                + " -p " + _port
                + " -m " + threadnum
                + " -r " + _subpath
                + _ssl;
            process.EnableRaisingEvents = true;
            process.Exited += new EventHandler(this.p_Exited);
            process.Start();
        }
    }
}
