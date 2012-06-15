using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GodApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdReceipt_Click(object sender, EventArgs e)
        {
           
            frmReceipt receipt = new frmReceipt();
            receipt.Show();
        }

        private void cmdTransfer_Click(object sender, EventArgs e)
        {
            frmTransfer transfer = new frmTransfer();
            transfer.Show();
        }

        private void cmdTransaction_Click(object sender, EventArgs e)
        {
            frmTransaction transaction = new frmTransaction();
            transaction.Show();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }
    }
}