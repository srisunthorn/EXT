using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlServerCe;


namespace GodApp1
{
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            BindDataGrid();
        }
        private void BindDataGrid()
        {
            SqlCeConnection myConnection = default(SqlCeConnection);
            DataTable dt = new DataTable();
            SqlCeDataAdapter Adapter = default(SqlCeDataAdapter);
            myConnection = new SqlCeConnection("Data source="
            +(System .IO.Path.GetDirectoryName(System .Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
            +"\\GodDB.sdf;"));
            myConnection.Open();
            SqlCeCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandText = "select [id],[itemId],[batch],[qty],[zone],[channel],[receiptdate],[receiptby] from [receipt]";
            myCommand.CommandType = CommandType.Text;
            Adapter = new SqlCeDataAdapter(myCommand);
            Adapter.Fill(dt);
            myConnection.Close();
            
            DataGridTableStyle tableStyle = new DataGridTableStyle();
            tableStyle.MappingName = dt.TableName;
          
            DataGridTextBoxColumn column = new DataGridTextBoxColumn();
            column.MappingName = "id";
            column.HeaderText = "ID";
            column.Width = 20;
            
            tableStyle.GridColumnStyles.Add(column);

            column = new DataGridTextBoxColumn();
            column.MappingName = "itemid";
            column.HeaderText = "Item no";
            column.Width = 150;
            tableStyle.GridColumnStyles.Add(column);

            column = new DataGridTextBoxColumn();
            column.MappingName = "batch";
            column.HeaderText = "Batch";
            column.Width = 150;
            tableStyle.GridColumnStyles.Add(column);

            column = new DataGridTextBoxColumn();
            column.MappingName = "qty";
            column.HeaderText = "QTY";
            column.Width = 60;
            tableStyle.GridColumnStyles.Add(column);

            column = new DataGridTextBoxColumn();
            column.MappingName = "zone";
            column.HeaderText = "Zone";
            column.Width = 60;
            tableStyle.GridColumnStyles.Add(column);

            column = new DataGridTextBoxColumn();
            column.MappingName = "channel";
            column.HeaderText = "Channel";
            column.Width = 60;
            tableStyle.GridColumnStyles.Add(column);

            column = new DataGridTextBoxColumn();
            column.MappingName = "receiptdate";
            column.HeaderText = "Receipt date";
            column.Width = 150;
            tableStyle.GridColumnStyles.Add(column);

            column = new DataGridTextBoxColumn();
            column.MappingName = "receiptby";
            column.HeaderText = "Receipt by";
            column.Width = 100;
            tableStyle.GridColumnStyles.Add(column);
            

            this.dgData.DataSource = dt;
            this.dgData.TableStyles.Clear();
            this.dgData.TableStyles.Add(tableStyle);
            dt = null;










        }

        private void cmdDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete?", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string strID = this.dgData[this.dgData.CurrentRowIndex, 0].ToString();
                SqlCeConnection myConnection = default(SqlCeConnection);
                myConnection = new SqlCeConnection("Data source="+
                    (System .IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)+
                    "\\GodDB.sdf;"));
                myConnection.Open();
                SqlCeCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = "Delete from [receipt] WHERE id = '" + strID + "'";
                myCommand.CommandType = CommandType.Text;
                myCommand.ExecuteNonQuery(); 
                myConnection.Close();
                MessageBox.Show("Delete succesfully");
                BindDataGrid();
            }
        }

        private void frmTransaction_KeyDown(object sender, KeyEventArgs e)
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

        private void menuSync_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Sync data successfully");
            this.Close();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEditReceipt editReceipt = new frmEditReceipt();
            editReceipt._strID = this.dgData[this.dgData.CurrentRowIndex, 0].ToString();
            editReceipt.Show();
        }

       
       

        private void menuBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuRefresh_Click_1(object sender, EventArgs e)
        {
            BindDataGrid();
        }
    }
}