using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlTypes;

namespace GodApp1
{
    public partial class frmEditReceipt : Form
    {
        string strID;
        public frmEditReceipt()
        {
            InitializeComponent();
        }
        public string _strID
        {
            get { return strID; }
            set { strID = value; }
        }

        private void frmEditReceipt_Load(object sender, EventArgs e)
        {
            SqlCeConnection myConnection = default(SqlCeConnection);
            myConnection = new SqlCeConnection("Data source="
                + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
                + "\\GodDB.sdf;"));
            myConnection.Open();
            SqlCeCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandText = "Select [id],[itemid],[batch],[qty],[zone],[channel],[receiptdate],[receiptby] from [receipt] " +
                " where id = '" + strID + "'";
            myCommand.CommandType = CommandType.Text;
                

            DataTable dt = new DataTable();
            SqlCeDataAdapter Adapter = default(SqlCeDataAdapter);
            Adapter = new SqlCeDataAdapter(myCommand);
            Adapter.Fill(dt);

            myConnection.Close();
            if (dt.Rows.Count > 0)
            {
                this.txtItemId.Text = dt.Rows[0]["itemid"].ToString();
                this.txtBatch.Text = dt.Rows[0]["batch"].ToString();
                this.txtQty.Text = dt.Rows[0]["qty"].ToString();
                this.txtZone.Text = dt.Rows[0]["zone"].ToString();
                this.txtChannel.Text = dt.Rows[0]["channel"].ToString();
                this.txtReceiptDate.Text = dt.Rows[0]["receiptdate"].ToString();
                this.txtReceiptBy.Text = dt.Rows[0]["receiptby"].ToString();
            }
            dt = null;

        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            update();

        }
        private void update()
        {
            if (string.IsNullOrEmpty(this.txtItemId.Text))
            {
                MessageBox.Show("Please input (Item no)");
                this.txtItemId.Focus();
                return;
            }
            SqlCeConnection myConnection = default(SqlCeConnection);
            myConnection = new SqlCeConnection("Data source="
                + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
                + "\\GodDB.sdf;"));
            myConnection.Open();
            SqlCeCommand myCommand = myConnection.CreateCommand();

            myCommand.CommandText = "Update [receipt] SET [itemid] = '" + this.txtItemId.Text + "'" +
                ",[batch]= '" + this.txtBatch.Text + "'" +
                ",[qty] =" + this.txtQty.Text + "" +
                ",[zone]='" + this.txtZone.Text + "'" +
                ",[channel]='" + this.txtChannel.Text + "'" +
                //",[receiptdate]'"+this.txtReceiptDate.Text+"'"+
                //",[receiptby]'"+this.txtReceiptBy.Text+"'"+
                " where id ='" + strID + "'";
            myCommand.CommandType = CommandType.Text;
            myCommand.ExecuteNonQuery();
            myConnection.Close();

            MessageBox.Show("Update successfully");
            this.Close();
            // this.Close();
            //frmTransaction tr
            frmTransaction transaction = new frmTransaction();
            transaction.Show();


        }
        private void txtItemId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBatch.Focus();
            }
        }

        private void txtBatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQty.Focus();
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtZone.Focus();
            }
        }

        private void txtZone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtChannel.Focus();
            }
        }

        private void txtChannel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                update();
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}