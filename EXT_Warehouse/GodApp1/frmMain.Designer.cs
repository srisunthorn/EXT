namespace GodApp1
{
    partial class frmMain
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
            this.cmdReceipt = new System.Windows.Forms.Button();
            this.cmdTransfer = new System.Windows.Forms.Button();
            this.cmdStock = new System.Windows.Forms.Button();
            this.cmdTransaction = new System.Windows.Forms.Button();
            this.mainMenu2 = new System.Windows.Forms.MainMenu();
            this.SuspendLayout();
            // 
            // cmdReceipt
            // 
            this.cmdReceipt.BackColor = System.Drawing.Color.Lime;
            this.cmdReceipt.Location = new System.Drawing.Point(24, 5);
            this.cmdReceipt.Name = "cmdReceipt";
            this.cmdReceipt.Size = new System.Drawing.Size(191, 55);
            this.cmdReceipt.TabIndex = 0;
            this.cmdReceipt.Text = "Receipt";
            this.cmdReceipt.Click += new System.EventHandler(this.cmdReceipt_Click);
            // 
            // cmdTransfer
            // 
            this.cmdTransfer.BackColor = System.Drawing.Color.Yellow;
            this.cmdTransfer.Location = new System.Drawing.Point(24, 71);
            this.cmdTransfer.Name = "cmdTransfer";
            this.cmdTransfer.Size = new System.Drawing.Size(191, 55);
            this.cmdTransfer.TabIndex = 1;
            this.cmdTransfer.Text = "Transfer";
            this.cmdTransfer.Click += new System.EventHandler(this.cmdTransfer_Click);
            // 
            // cmdStock
            // 
            this.cmdStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdStock.Location = new System.Drawing.Point(24, 138);
            this.cmdStock.Name = "cmdStock";
            this.cmdStock.Size = new System.Drawing.Size(191, 51);
            this.cmdStock.TabIndex = 2;
            this.cmdStock.Text = "Stock";
            // 
            // cmdTransaction
            // 
            this.cmdTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdTransaction.Location = new System.Drawing.Point(24, 204);
            this.cmdTransaction.Name = "cmdTransaction";
            this.cmdTransaction.Size = new System.Drawing.Size(191, 50);
            this.cmdTransaction.TabIndex = 3;
            this.cmdTransaction.Text = "Transaction";
            this.cmdTransaction.Click += new System.EventHandler(this.cmdTransaction_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.cmdTransaction);
            this.Controls.Add(this.cmdStock);
            this.Controls.Add(this.cmdTransfer);
            this.Controls.Add(this.cmdReceipt);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "frmMain";
            this.Text = "Warehouse System";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdReceipt;
        private System.Windows.Forms.Button cmdTransfer;
        private System.Windows.Forms.Button cmdStock;
        private System.Windows.Forms.Button cmdTransaction;
        private System.Windows.Forms.MainMenu mainMenu2;
    }
}