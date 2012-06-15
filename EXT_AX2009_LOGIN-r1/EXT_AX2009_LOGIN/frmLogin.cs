using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Data.SqlClient;
using VastAbyss;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;

namespace EXT_AX2009_LOGIN
{
    public partial class frmLogin : Form
    {
        //SqlConnection Conn;
        //string strConn;

        [DllImport("kernel32.dll")]
        private static extern bool GetVersionEx(ref OSVERSIONINFOEX osVersionInfo);
        [StructLayout(LayoutKind.Sequential)]
        private struct OSVERSIONINFOEX
        {
            public int dwOSVersionInfoSize;
            public int dwMajorVersion;
            public int dwMinorVersion;
            public int dwBuildNumber;
            public int dwPlatformId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szCSDVersion;
            public short wServicePackMajor;
            public short wServicePackMinor;
            public short wSuiteMask;
            public byte wProductType;
            public byte wReserved;
        }
        string User;
        string Pwd;
        string Domain;
        string Cmd;
        Process proc;
        string Path;
        string spath;
        //TestINI config;
        //Configuration config;
        string ip;
        string port;
        System.OperatingSystem osInfo = System.Environment.OSVersion;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           // config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
          //  ip = config.AppSettings.Settings["axserverip"].Value;
           // port = config.AppSettings.Settings["axserverport"].Value;
           // Domain = config.AppSettings.Settings["domain"].Value;
           
            //--------------------------
            //----------------------Find Drive
            string[] drives = Environment.GetLogicalDrives();
            // Loop into the string array
            foreach (string strDrive in drives)
            {
                // Add items (drives) to the list
                //MessageBox.Show(strDrive.ToString());
                
                Path = strDrive.ToString()+"Program Files\\Microsoft Dynamics AX\\50\\Client\\Bin\\Ax32.exe";
                spath = strDrive.ToString() + "Program Files (x86)\\Microsoft Dynamics AX\\50\\Client\\Bin\\Ax32.exe";
                if (File.Exists(Path))
                {
                    //MessageBox.Show("1" +Path);
                    Cmd = strDrive.ToString() + "Program Files\\Microsoft Dynamics AX\\50\\Client\\Bin\\Ax32.exe -aos2=" + ip + ":" + port;
                }
                else
                {
                    if (File.Exists(spath))
                    {
                        //MessageBox.Show("2" +spath);
                        Cmd = strDrive.ToString() + "Program Files (x86)\\Microsoft Dynamics AX\\50\\Client\\Bin\\Ax32.exe -aos2=" + ip + ":" + port;
                    }
                }
            }

            //------------------------end find
            try
            {
               
                Ping ping = new Ping();
                PingReply pingreply = ping.Send("192.168.1.141");
                //lblPing.Text +="Address: " + pingreply.Address + "\r";
                //lblPing.Text += "Roundtrip Time: " + pingreply.RoundtripTime + "\r";
                //lblPing.Text += "TTL (Time To Live): " + pingreply.Options.Ttl + "\r";
                //lblPing.Text += "Buffer Size: " + pingreply.Buffer.Length.ToString() + "\r";

            }
            catch (Exception err)
            {
                lblPing.Text = "Please contact admin because Network problem "+err.Message;
            }
            // Determine the platform.
            OSVERSIONINFOEX osVersionInfo = new OSVERSIONINFOEX();
            osVersionInfo.dwOSVersionInfoSize = Marshal.SizeOf(typeof(OSVERSIONINFOEX));

            GetVersionEx(ref osVersionInfo);
            byte productType = osVersionInfo.wProductType;
            switch (osInfo.Platform)
            {
                // Platform is Windows 95, Windows 98, 
                // Windows 98 Second Edition, or Windows Me.
                case System.PlatformID.Win32Windows:

                    switch (osInfo.Version.Minor)
                    {
                        case 0:
                            //MessageBox.Show("Windows 95");
                            break;
                        case 10:
                            if (osInfo.Version.Revision.ToString() == "2222A"){
                                //MessageBox.Show("Windows 98 Second Edition");
                            }else{
                                //MessageBox.Show("Windows 98");
                            }
                            break;
                        case 90:
                            //MessageBox.Show("Windows Me");
                            break;
                    }
                    break;

                // Platform is Windows NT 3.51, Windows NT 4.0, Windows 2000,
                // or Windows XP.
                case System.PlatformID.Win32NT:

                    switch (osInfo.Version.Major)
                    {
                        case 3:
                            //MessageBox.Show("Windows NT 3.51");
                            break;
                        case 4:
                            //MessageBox.Show("Windows NT 4.0");
                            break;
                        case 5:
                            if (osInfo.Version.Minor == 0)
                            {
                                //MessageBox.Show("Windows 2000");
                            }
                           if (osInfo.Version.Minor == 2)
                            {
                                
                                //Cmd = "C:\\Program Files\\Microsoft Dynamics AX\\50\\Client\\Bin\\Ax32.exe -aos2=192.168.1.141:2715";
                            }
                            if(osInfo.Version.Minor == 1)
                            {
                                //MessageBox.Show("Windows XP");
                                //Cmd = "C:\\Program Files\\Microsoft Dynamics AX\\50\\Client\\Bin\\Ax32.exe -aos2=192.168.1.141:2715";
                            }
                                break;
                        case 6:
                                if (osInfo.Version.Minor == 1 && productType == 1)
                                {
                                    //MessageBox.Show("Windows 7");
                                    //Cmd = "C:\\Program Files (x86)\\Microsoft Dynamics AX\\50\\Client\\Bin\\Ax32.exe -aos2=192.168.1.141:2715";
                                }
                                else if (osInfo.Version.Minor == 1 && productType == 3)
                                {
                                    //MessageBox.Show("Windows 8");
                                    //Cmd = "C:\\Program Files (x86)\\Microsoft Dynamics AX\\50\\Client\\Bin\\Ax32.exe -aos2=192.168.1.141:2715";
                                }
                                else
                                {


                                }
                                break;
                    } break;
            }
            //try
            //{
            //    strConn  = DBConn.strConn;
            //    Conn = new SqlConnection();
            //    if (Conn.State == ConnectionState.Open)
            //    {
            //        Conn.Close();
            //    }
            //    Conn.ConnectionString = strConn;
            //    Conn.Open();
            //}
            //catch
            //{
            //    MessageBox.Show("ไม่สามารถติดต่อ Server ได้", "Can not Connect to Server!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //}
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPwd.Focus();
                txtPwd.SelectAll();
            }
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Login()
        {
            ip = SettingNew.Default.ip.ToString();
            port = SettingNew.Default.port.ToString();
            Domain = SettingNew.Default.domain.ToString();
            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("คุณลืมใส่ Username!", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUser.Focus();
                txtUser.SelectAll();
                return;
            }
            if (txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("คุณลืมใส่ Password!", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPwd.Focus();
                txtPwd.SelectAll();
                return;
            }
            User = txtUser .Text ;
            Pwd = txtPwd .Text ;
            //Domain = "exedy-thai";//"exedy-thai";
            
            
            try
            {
                
                //if (FindAndKillProcess("Ax32"))
                //{
                //    proc = RunAs.StartProcess(txtUser.Text, Domain, Pwd, Cmd);

                //}
                //else if (FindAndKillProcess("Ax32") == false)
                //{

                //    proc = RunAs.StartProcess(txtUser.Text, Domain, Pwd, Cmd);
                //}
                if (FindAndKillProcess("Ax32"))
                {
                    proc = RunAs.StartProcess(txtUser.Text, Domain, Pwd, Cmd);
                    try
                    {
                        proc.EnableRaisingEvents = true;
                        
                    }
                    catch
                    {

                        
                    }
                }
                else
                {
                    proc = RunAs.StartProcess(txtUser.Text, Domain, Pwd, Cmd);
                    try
                    {
                        proc.EnableRaisingEvents = true;
                        
                    }
                    catch
                    {

                    }
                }


                this.Close();

            
                
            }
            catch( Exception ex)
            {
               
                MessageBox.Show("กรุณาปิดโปรแกรม AX2009 ก่อน!","ผลการทำงาน",MessageBoxButtons .OK,MessageBoxIcon.Exclamation );
            }
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }

        }
        public bool FindAndKillProcess(string name)
        {
            //here we're going to get a list of all running processes on
            //the computer
            foreach (Process clsProcess in Process.GetProcesses())
            {
                //now we're going to see if any of the running processes
                //match the currently running processes by using the StartsWith Method,
                //this prevents us from incluing the .EXE for the process we're looking for.
                //. Be sure to not
                //add the .exe to the name you provide, i.e: NOTEPAD,
                //not NOTEPAD.EXE or false is always returned even if
                //notepad is running
                if (clsProcess.ProcessName.StartsWith(name))
                {
                    //since we found the proccess we now need to use the
                    //Kill Method to kill the process. Remember, if you have
                    //the process running more than once, say IE open 4
                    //times the loop thr way it is now will close all 4,
                    //if you want it to just close the first one it finds
                    //then add a return; after the Kill
                    clsProcess.Kill();
                    //process killed, return true
                    return true;
                }
            }
            //process not found, return false
            return false;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void tsToolbar_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            admin.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            // IPAddress
           // foreach (IPAddress ipaddress in iphost.AddressList)
           //{
            //    MessageBox.Show("IPAddress : " + ipaddress.ToString() + "\r\n");
           // }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            Login();
        } 

    }
}
