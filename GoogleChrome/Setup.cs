using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleChrome
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }


     
        private void Setup_Load(object sender, EventArgs e)
        {

            txtServerIP.Text = ConfigurationManager.AppSettings["SeverIp"];
            txtSeverPort.Text = ConfigurationManager.AppSettings["SeverPort"];
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string txtServerIPs = ConfigurationManager.AppSettings["SeverIp"];
            string txtSeverPorts = ConfigurationManager.AppSettings["SeverPort"];

            //获取Configuration对象
            Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["SeverIp"].Value = txtServerIP.Text;
            config.AppSettings.Settings["SeverPort"].Value = txtSeverPort.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show("修改成功，程序将重新启动。");
            Application.ExitThread();
            Application.Exit();
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
