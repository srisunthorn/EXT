using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace EXT_AX2009_LOGIN
{
    public  class TestINI
    {
        string path;
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
          string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
          string key, string def, StringBuilder retVal,
          int size, string filePath);
        public TestINI(string path)//รับ path ของไฟล์ .ini เข้ามาทาง constructor
        {
            this.path = path;
        }
        public void IniWriteValue(string Section, string Key, string Value)//เขียนไฟล์
        {
            WritePrivateProfileString(Section, Key, Value, this.path);
        }

        public string IniReadValue(string Section, string Key)//อ่าน value จาก section และ key
        {
            StringBuilder sb = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", sb, 255, this.path);
            return sb.ToString();
        }

    }
}
