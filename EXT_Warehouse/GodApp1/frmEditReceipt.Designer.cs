namespace GodApp1
{
    partial class frmEditReceipt
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
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReceiptDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReceiptBy = new System.Windows.Forms.TextBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(20, 23);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(206, 21);
            this.txtItemId.TabIndex = 0;
            this.txtItemId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemId_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Item no";
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdUpdate.Location = new System.Drawing.Point(22, 233);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(99, 35);
            this.cmdUpdate.TabIndex = 2;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(20, 68);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(207, 21);
            this.txtBatch.TabIndex = 4;
            this.txtBatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBatch_KeyDown);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Batch no";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(20, 113);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 21);
            this.txtQty.TabIndex = 6;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "QTY";
            // 
            // txtZone
            // 
            this.txtZone.Location = new System.Drawing.Point(20, 158);
            this.txtZone.Name = "txtZone";
            this.txtZone.Size = new System.Drawing.Size(100, 21);
            this.txtZone.TabIndex = 8;
            this.txtZone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZone_KeyDown);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "Zone";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(126, 158);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(100, 21);
            this.txtChannel.TabIndex = 10;
            this.txtChannel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChannel_KeyDown);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(126, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "Channel";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(21, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.Text = "Receipt date";
            // 
            // txtReceiptDate
            // 
            this.txtReceiptDate.Enabled = false;
            this.txtReceiptDate.Location = new System.Drawing.Point(21, 206);
            this.txtReceiptDate.Name = "txtReceiptDate";
            this.txtReceiptDate.Size = new System.Drawing.Size(100, 21);
            this.txtReceiptDate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(128, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.Text = "Receipt by";
            // 
            // txtReceiptBy
            // 
            this.txtReceiptBy.Enabled = false;
            this.txtReceiptBy.Location = new System.Drawing.Point(128, 207);
            this.txtReceiptBy.Name = "txtReceiptBy";
            this.txtReceiptBy.Size = new System.Drawing.Size(100, 21);
            this.txtReceiptBy.TabIndex = 15;
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.cmdClose.Location = new System.Drawing.Point(128, 233);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(100, 35);
            this.cmdClose.TabIndex = 16;
            this.cmdClose.Text = "Close";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmEditReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.txtReceiptBy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReceiptDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtChannel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtZone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBatch);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemId);
            this.Menu = this.mainMenu1;
            this.Name = "frmEditReceipt";
            this.Text = "Receipt modify";
            this.Load += new System.EventHandler(this.frmEditReceipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReceiptDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReceiptBy;
        private System.Windows.Forms.Button cmdClose;
    }
}