using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using System.Net;

namespace EXT_AX2009_LOGIN
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }
        Configuration config;
        string hname;
        string[] hostname;
        int num;
        private void frmConfig_Load(object sender, EventArgs e)
        {
            //IPHostEntry iphost = Dns.GetHostByName(Dns.GetHostName());

            //Hostname
            //MessageBox.Show("Hostname : " + iphost.HostName + "\r\n");
            //hname = iphost.HostName;
           // hostname = hname.Split('.');
            
            //foreach (string word in hostname)
           // {
              //  num++;
               
              //  if (hostname.Length == num)
              //  {
               //     MessageBox.Show(word.ToString());
               // }
           // }
            //MessageBox.Show(hostname[2].ToString());
           // config=ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
           // txtDomain.Text = config.AppSettings.Settings["domain"].Value;
           // txtIP.Text = config.AppSettings.Settings["axserverip"].Value;
           // txtPort.Text = config.AppSettings.Settings["axserverport"].Value;
            txtDomain.Text = SettingNew.Default.domain.ToString();
            txtIP.Text = SettingNew.Default.ip.ToString();
            txtPort.Text = SettingNew.Default.port.ToString();
            


        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            save();
        }
        private void save()
        {
            try
            {

               // config.AppSettings.Settings["domain"].Value = txtDomain.Text;
               // config.AppSettings.Settings["axserverip"].Value = txtIP.Text;
                //config.AppSettings.Settings["axserverport"].Value = txtPort.Text;
                // Save the configuration file.
                //config.Save(ConfigurationSaveMode.Modified);
                // Force a reload of a changed section.
                //ConfigurationManager.RefreshSection("appSettings");
                //MessageBox.Show(config.AppSettings.Settings["domain"].Value);
                SettingNew.Default.ip = txtIP.Text;
                SettingNew.Default.port = txtPort.Text;
                SettingNew.Default.domain = txtDomain.Text;
                SettingNew.Default.Save();
                this.Close();
                MessageBox.Show("Change completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }
        private void txtDomain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtIP.Focus();
            }
        }

        private void txtIP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPort.Focus();
            }
        }

        private void txtPort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                save();
            }
        }
    }
}
