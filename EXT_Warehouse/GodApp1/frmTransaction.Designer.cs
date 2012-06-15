namespace GodApp1
{
    partial class frmTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.dgData = new System.Windows.Forms.DataGrid();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdDel = new System.Windows.Forms.Button();
            this.mainMenu2 = new System.Windows.Forms.MainMenu();
            this.cmdSync = new System.Windows.Forms.Button();
            this.menuRefresh = new System.Windows.Forms.MenuItem();
            this.menuBack = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuRefresh);
            this.mainMenu1.MenuItems.Add(this.menuBack);
            // 
            // dgData
            // 
            this.dgData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgData.Location = new System.Drawing.Point(3, 3);
            this.dgData.Name = "dgData";
            this.dgData.PreferredRowHeight = 30;
            this.dgData.Size = new System.Drawing.Size(234, 215);
            this.dgData.TabIndex = 0;
            // 
            // cmdEdit
            // 
            this.cmdEdit.BackColor = System.Drawing.Color.Yellow;
            this.cmdEdit.Location = new System.Drawing.Point(3, 224);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(71, 40);
            this.cmdEdit.TabIndex = 1;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdDel
            // 
            this.cmdDel.BackColor = System.Drawing.Color.Red;
            this.cmdDel.Location = new System.Drawing.Point(84, 225);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(66, 39);
            this.cmdDel.TabIndex = 2;
            this.cmdDel.Text = "Delete";
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
            // 
            // cmdSync
            // 
            this.cmdSync.BackColor = System.Drawing.Color.Lime;
            this.cmdSync.Location = new System.Drawing.Point(162, 224);
            this.cmdSync.Name = "cmdSync";
            this.cmdSync.Size = new System.Drawing.Size(72, 40);
            this.cmdSync.TabIndex = 3;
            this.cmdSync.Text = "Sync";
            // 
            // menuRefresh
            // 
            this.menuRefresh.Text = "Refresh";
            this.menuRefresh.Click += new System.EventHandler(this.menuRefresh_Click_1);
            // 
            // menuBack
            // 
            this.menuBack.Text = "Back";
            this.menuBack.Click += new System.EventHandler(this.menuBack_Click);
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.cmdSync);
            this.Controls.Add(this.cmdDel);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.dgData);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "frmTransaction";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTransaction_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dgData;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdDel;
        private System.Windows.Forms.MainMenu mainMenu2;
        private System.Windows.Forms.Button cmdSync;
        private System.Windows.Forms.MenuItem menuRefresh;
        private System.Windows.Forms.MenuItem menuBack;
    }
}