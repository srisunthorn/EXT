using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlServerCe;//add referrence
using STM7700BCR;//1
using System.Runtime.InteropServices;//2
using Microsoft.WindowsCE.Forms;//3


namespace GodApp1
{
    public partial class frmReceipt : Form
    {
        public STMmsr stm_msr;
        public string textname;
        public int num;
      
        public frmReceipt()
        {
            InitializeComponent();
        }
       
        private void cmdConfirm_Click(object sender, EventArgs e)
        {
            receipt();

        }
        private void receipt()
        {
            //check empty
            if (string.IsNullOrEmpty(this.txtItemId.Text))
            {
                MessageBox.Show("Please input Item No ");
                this.txtItemId.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtBatch.Text))
            {
                MessageBox.Show("Please input Batch No ");
                this.txtBatch.Focus();
                return;
            }
            
            if (string.IsNullOrEmpty(this.txtQty.Text))
            {
                MessageBox.Show("Please input Qty  ");
                this.txtBatch.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtZone.Text))
            {
                MessageBox.Show("Please input Zone  ");
                this.txtBatch.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtChannel.Text))
            {
                MessageBox.Show("Please input Channel  ");
                this.txtBatch.Focus();
                return;
            }
            //Connect 
            SqlCeConnection myConnection = default(SqlCeConnection);
            myConnection = new SqlCeConnection("Data source="
                + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
                + "\\GodDB.sdf;"));
            myConnection.Open();
            //Command
            SqlCeCommand myCommand = myConnection.CreateCommand();
            // myCommand.CommandText = "Insert into [receipt] ([id],[itemId],[batch],[qty],[receiptBy],[receiptDate],[zone],[channel],[warehouse],[location],[job]) values('','"
            //   +this.txtItemId.Text+"','"+this.txtBatch.Text+"','"+this.qty.Text+"','Samano','"+DateTime.Today+"','"+this.zone.Text+"','"
            //+this.channel.Text+"','EXT','LC','')";
            // myCommand.CommandText = "insert into [member]([user],[pwd],[name]) values('samano','1234','Mr.Samano Srima')";
            myCommand.CommandText = "insert into [receipt]([itemid],[batch],[qty],[zone],[channel],[receiptdate],[receiptby]) "
                + "values('" + this.txtItemId.Text + "','" + this.txtBatch.Text + "'," + this.txtQty.Text + ",'"
                + this.txtZone.Text + "','" + this.txtChannel.Text + "','" + DateTime.UtcNow + "','Samano')";
            //myCommand.Parameters.Add(
            myCommand.CommandType = CommandType.Text;
            myCommand.ExecuteNonQuery();
           
            myConnection.Close();
            txtItemId.Focus();
            MessageBox.Show("Receipt Successfully");
            txtItemId.Text = "";
            txtBatch.Text = "";
            txtQty.Text = "";
            txtZone.Text = "";
            txtChannel.Text = "";
            


        }
        private void button1_Click(object sender, EventArgs e)
        {

            exedyWebservice.CalculatorService soa = new exedyWebservice.CalculatorService();
            MessageBox.Show(soa.Text());

           
        }

        private void txtItemId_KeyDown(object sender, KeyEventArgs e)
        {
            //string text = e.KeyData.ToString();
            //string strTxt;
           // strTxt += text.Substring(1,1);
           // txtItemId.Text = txtItemId.Text + text.Substring(1, 1);

        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            // STM7700BCRDLL.WJST_2DScannerInit(this.Handle);
            // STM7700BCRDLL.WM_COPYDATA =  COPYDATASTRUCT
            stm_msr = new STMmsr(this);
            {
                stm_msr.STMmsrOpen();
            }

        }//end confirm
        public void setValue(string txt)
        {

            string txt3 = txt.ToString();
            string[] aString = txt3.Split();
          
            //MessageBox.Show(aString[0].ToString() + " : " + aString[1].ToString());
            string txt2 = aString[1].ToString();
           // foreach (string item in aString)
          //  {
            //    char temp = (char)item;
            //    MessageBox.Show(temp.ToString());

          //  }

            //MessageBox.Show(Cursor.Current.ToString()+" : "+txt);
           // txtItemId.Text = txt;
           // MessageBox.Show(textname);
            switch (num)
            {
                case 1:
                    txtItemId.Text = txt2;
                    txtBatch.Focus();
                    break;
                case 2:
                    txtBatch.Text  = txt2;
                    txtQty.Focus();
                    break;
                case 3:
                    if (txt2.Length > 6)
                    {
                        txtQty.Focus();
                        MessageBox.Show("Qty over 6 digits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        txtQty.Text = txt2;
                        txtZone.Focus();
                    }
                    break;
                case 4:
                    if (txt2.Length > 6)
                    {
                        txtZone.Focus();
                        MessageBox.Show("Zone over 6 digits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        txtZone.Text = txt2;
                        txtChannel.Focus();
                    }
                    break;
                case 5:
                    if (txt2.Length > 6)
                    {
                        txtChannel.Focus();
                        MessageBox.Show("Channel over 6 digits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        txtChannel.Text = txt2;
                        receipt();
                    }
                   
                    break;
                default:
                    break;

            }

        }

        private void txtItemId_GotFocus(object sender, EventArgs e)
        {
            textname = "txtItemId";
            num = 1;
        }
       
        private void txtBatch_GotFocus(object sender, EventArgs e)
        {
            textname = "txtBatch";
            num = 2;
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            
         
        }

        private void txtZone_GotFocus(object sender, EventArgs e)
        {
            textname = "txtZone";
            num = 4;
        }

        private void txtChannel_GotFocus(object sender, EventArgs e)
        {
            textname = "txtChannel";
            num = 5;
        }

        private void txtItemId_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void txtBatch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtQty_GotFocus(object sender, EventArgs e)
        {
            textname = "txtQty";
            num = 3;
        }

        private void txtZone_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtChannel_TextChanged(object sender, EventArgs e)
        {
           
           // receipt();
        }

        private void txtItemId_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtItemId.TextLength > 30)
                {
                    MessageBox.Show("ItemId  length over 30 symbol");
                    txtItemId.Text = "";
                    txtItemId.Focus();
                }
                else
                {
                    txtBatch.Focus();
                }
            } 
        }

        private void txtBatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBatch.TextLength > 30)
                {
                    MessageBox.Show("Batch no length over 30 symbol");
                    txtBatch.Text = "";
                    txtBatch.Focus();
                }
                else
                {
                    txtBatch.Focus();
                }
                txtQty.Focus();
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtQty.TextLength > 6)
                {
                    MessageBox.Show("Qty length over 6 symbol");
                    txtQty.Text = "";
                    txtQty.Focus();
                }
                else
                {

                    txtZone.Focus();
                }
            }
        }

        private void txtZone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtZone.TextLength > 6)
                {
                    MessageBox.Show("Zone length over 6 symbols");
                    txtZone.Text = "";
                    txtZone.Focus();
                }
                else
                {
                    txtChannel.Focus();
                }
            }
        }

        private void txtChannel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtChannel.TextLength > 6)
                {
                    MessageBox.Show("Channel length over 6 symbols");
                    txtChannel.Text = "";
                    txtChannel.Focus();
                }
                else
                {
                    receipt();
                }
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        

       
    }
    //-------------------------------New class
    public struct COPYDATASTRUCT
    {
        public int dwData;
        public int cbData;
        public IntPtr lpData;
    }
    public class STMmsr : MessageWindow
    {
        private frmReceipt _scanclass = new frmReceipt();// = null;
        public void STMmsrOpen()
        {
            STM7700BCRDLL.WJST_2DScannerInit(this.Hwnd);
        }
        public void STMmsrClose()
        {
            STM7700BCRDLL.WJST_2DScannerDeInit();
        }
        public STMmsr(frmReceipt ScannerClass)
        {
            this._scanclass = ScannerClass;
        }
        protected override void WndProc(ref Message m)
        {
            //MessageBox.Show(m.ToString());
            switch (m.Msg)
            {
                case (int)STM7700BCRDLL.WM_COPYDATA:
                    COPYDATASTRUCT mystr = (COPYDATASTRUCT)Marshal.PtrToStructure(m.LParam, typeof(COPYDATASTRUCT));
                    string str = Marshal.PtrToStringUni(mystr.lpData);
                    _scanclass.setValue(str);
                    //MessageBox.Show(str);
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);
        }

    }
     

    //---------------------------------------
}