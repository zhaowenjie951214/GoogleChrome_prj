using CefSharp;
using CefSharp.WinForms;
using GoogleChrome;
using GoogleChrome.Properties;
using NativeWifi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleChrome_prj
{

    public partial class MainA : Form
    {
        ChromiumWebBrowser WebBrowser;
        public String IP = GetAppConfig("SeverIp");
        public bool boolBetworkState = true;
        public bool boolOne = true;

        public string serverurl = "http://" + GetAppConfig("SeverIp") + ":" + GetAppConfig("SeverPort");
        // private String IP = System.Configuration.ConfigurationSettings.AppSettings["SeverIp"];

        public MainA()
        {
            InitializeComponent();

            CefSettings setting = new CefSettings();
            setting.Locale = "zh-CN";
            setting.CachePath = Directory.GetCurrentDirectory() + @"\CHBrowser\BrowserCache";//缓存路径
            setting.AcceptLanguageList = "zh-CN,zh;q=0.8";//浏览器引擎的语言
            //setting.LocalesDirPath = "CHBrowser/localeDir";//日志
            setting.LogFile = Directory.GetCurrentDirectory() + @"\CHBrowser\LogData";//日志文件
            setting.PersistSessionCookies = true;//
            setting.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";//浏览器内核
            setting.UserDataPath = Directory.GetCurrentDirectory() + @"\CHBrowser\userData";//个人数据
            setting.CefCommandLineArgs.Add("ppapi-flash-path", @"plugins\pepflashplayer32_32_0_0_114.dll");
            setting.CefCommandLineArgs.Add("ppapi-flash-version", "32.0.0.114");

            setting.CefCommandLineArgs.Add("enable-media-stream", "enable-media-stream");
            setting.IgnoreCertificateErrors = true;
            setting.LogSeverity = LogSeverity.Verbose;

            CefSharp.Cef.Initialize(setting);

            //string url = Application.StartupPath + @"\assets\loading.html";
            WebBrowser = new ChromiumWebBrowser(serverurl); //初始页
            /// WebBrowser.SendToBack();
            //label1.BringToFront();

            CefSharpSettings.LegacyJavascriptBindingEnabled = true;
            WebBrowser.RegisterJsObject("jsObj", new JsEvent(), new CefSharp.BindingOptions() { CamelCaseJavascriptNames = false }); //交互数据    
            WebBrowser.Dock = DockStyle.Fill;//铺满                                                                  
            this.panel3.Controls.Add(WebBrowser);//加入窗体
            //WebBrowserError = new ChromiumWebBrowser(Application.StartupPath + @"\assets\error.html"); //错误页                                                            
            //WebBrowserError.Dock = DockStyle.Fill;//铺满                                                                  
            //this.Controls.Add(WebBrowserError);//加入窗体
            //WebBrowserErrorHide();
        }


        public void WebBrowserErrorShow()
        {
            this.WebBrowser.BringToFront();

            boolBetworkState = false;
        }

        public void WebBrowserErrorHide()
        {

            WebBrowser.BringToFront();

            boolBetworkState = true;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await WebBrowser.GetBrowser().MainFrame.EvaluateScriptAsync("test_val =" + new Random().Next().ToString("F")); //设置页面上js的test_val变量为随机数
            await WebBrowser.GetBrowser().MainFrame.EvaluateScriptAsync("test()");//运行页面上js的test方法

        }

        private async void JSlocation(string Url)
        {
            await WebBrowser.GetBrowser().MainFrame.EvaluateScriptAsync("location('" + Url + "' )");//运行页面上js的testArg带参数的方法
        }

        public static MainA _this;
        public class JsEvent
        {

            public string MessageText { get; set; }

            public void ShowTest()
            {
                MessageBox.Show("this in C#." + MessageText);
            }
            public void ShowTestArg(string ss)
            {
                MessageBox.Show("收到JS带参数调用\n\r" + ss);
            }
            public void Close()
            {
                Application.Exit();
            }
            public void Min()
            {
                _this.WindowState = FormWindowState.Minimized;
            }

            public void btnMen()
            {
                _this.panel2.Visible = !_this.panel2.Visible;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _this = this;
            CheckForIllegalCrossThreadCalls = false;

            //this.TransparencyKey = Color.Red;
            //this.BackColor = Color.Red;
        }



        ///<summary> 
        ///返回*.exe.config文件中appSettings配置节的value项  
        ///</summary> 
        ///<param name="strKey"></param> 
        ///<returns></returns> 
        public static string GetAppConfig(string strKey)
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            foreach (string key in config.AppSettings.Settings.AllKeys)
            {
                if (key == strKey)
                {
                    return config.AppSettings.Settings[strKey].Value.ToString();
                }
            }
            return null;
        }


        private void pbsetup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定进入服务器IP、端口配置，修改后程序将重启？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Setup setup = new Setup();
                setup.ShowDialog();
            }

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (boolBetworkState)
            {
                WebBrowser.Reload();
                MessageBox.Show("刷新成功...");
            }
            else
            {
                MessageBox.Show("刷新成功......");
            }


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出程序吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxMax_Click(object sender, EventArgs e)
        {
            string winstatus = WindowState.ToString();
            switch (winstatus)
            {
                case "Maximized":
                    WindowState = FormWindowState.Normal;
                    pictureBoxMax.Image = GoogleChrome.Properties.Resources.norlmal;
                    break;
                case "Normal":
                    WindowState = FormWindowState.Maximized;
                    pictureBoxMax.Image = GoogleChrome.Properties.Resources.max;
                    break;
            }
        }




        Point downPoint;

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - downPoint.X,
                  this.Location.Y + e.Y - downPoint.Y);
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y);
        }


        private void Main_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(18, 150, 219)), 0, 0, this.Width - 1, this.Height - 1);
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            string winstatus = WindowState.ToString();
            switch (winstatus)
            {
                case "Maximized":
                    WindowState = FormWindowState.Normal;
                    pictureBoxMax.Image = GoogleChrome.Properties.Resources.norlmal;
                    break;
                case "Normal":
                    WindowState = FormWindowState.Maximized;
                    pictureBoxMax.Image = GoogleChrome.Properties.Resources.max;
                    break;
            }
        }
    }
}
