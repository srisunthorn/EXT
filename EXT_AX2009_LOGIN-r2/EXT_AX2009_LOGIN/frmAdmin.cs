using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EXT_AX2009_LOGIN
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        public void login()
        {
            if (txtUser.Text == "axadmin" && txtPwd.Text == "123456")
            {
                frmConfig con = new frmConfig();
                con.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("User name and password incorrect!");
            }
        }
        private void cmdLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPwd.Focus();
            }
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
