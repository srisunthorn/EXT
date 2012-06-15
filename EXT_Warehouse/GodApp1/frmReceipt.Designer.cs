namespace GodApp1
{
    partial class frmReceipt
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
            this.label1 = new System.Windows.Forms.Label();
            this.batch = new System.Windows.Forms.Label();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.zone = new System.Windows.Forms.Label();
            this.txtZone = new System.Windows.Forms.TextBox();
            this.channel = new System.Windows.Forms.Label();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.cmdConfirm = new System.Windows.Forms.Button();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Item No";
            // 
            // batch
            // 
            this.batch.Location = new System.Drawing.Point(12, 49);
            this.batch.Name = "batch";
            this.batch.Size = new System.Drawing.Size(100, 20);
            this.batch.Text = "Batch";
            // 
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(13, 66);
            this.txtBatch.MaxLength = 30;
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(214, 21);
            this.txtBatch.TabIndex = 3;
            this.txtBatch.TextChanged += new System.EventHandler(this.txtBatch_TextChanged);
            this.txtBatch.GotFocus += new System.EventHandler(this.txtBatch_GotFocus);
            this.txtBatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBatch_KeyDown);
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(13, 94);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(100, 20);
            this.qty.Text = "QTY";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(13, 109);
            this.txtQty.MaxLength = 6;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 21);
            this.txtQty.TabIndex = 5;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.GotFocus += new System.EventHandler(this.txtQty_GotFocus);
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            // 
            // zone
            // 
            this.zone.Location = new System.Drawing.Point(13, 136);
            this.zone.Name = "zone";
            this.zone.Size = new System.Drawing.Size(100, 20);
            this.zone.Text = "Zone";
            // 
            // txtZone
            // 
            this.txtZone.Location = new System.Drawing.Point(13, 150);
            this.txtZone.MaxLength = 6;
            this.txtZone.Name = "txtZone";
            this.txtZone.Size = new System.Drawing.Size(100, 21);
            this.txtZone.TabIndex = 7;
            this.txtZone.TextChanged += new System.EventHandler(this.txtZone_TextChanged);
            this.txtZone.GotFocus += new System.EventHandler(this.txtZone_GotFocus);
            this.txtZone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZone_KeyDown);
            // 
            // channel
            // 
            this.channel.Location = new System.Drawing.Point(13, 178);
            this.channel.Name = "channel";
            this.channel.Size = new System.Drawing.Size(100, 20);
            this.channel.Text = "Channel";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(13, 193);
            this.txtChannel.MaxLength = 6;
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(100, 21);
            this.txtChannel.TabIndex = 9;
            this.txtChannel.TextChanged += new System.EventHandler(this.txtChannel_TextChanged);
            this.txtChannel.GotFocus += new System.EventHandler(this.txtChannel_GotFocus);
            this.txtChannel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChannel_KeyDown);
            // 
            // cmdConfirm
            // 
            this.cmdConfirm.BackColor = System.Drawing.Color.Lime;
            this.cmdConfirm.Location = new System.Drawing.Point(13, 220);
            this.cmdConfirm.Name = "cmdConfirm";
            this.cmdConfirm.Size = new System.Drawing.Size(100, 45);
            this.cmdConfirm.TabIndex = 10;
            this.cmdConfirm.Text = "Receipt";
            this.cmdConfirm.Click += new System.EventHandler(this.cmdConfirm_Click);
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(13, 23);
            this.txtItemId.MaxLength = 30;
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(214, 21);
            this.txtItemId.TabIndex = 1;
            this.txtItemId.TextChanged += new System.EventHandler(this.txtItemId_TextChanged);
            this.txtItemId.GotFocus += new System.EventHandler(this.txtItemId_GotFocus);
            this.txtItemId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemId_KeyDown_1);
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.cmdClose.Location = new System.Drawing.Point(130, 220);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(97, 45);
            this.cmdClose.TabIndex = 16;
            this.cmdClose.Text = "Close";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdConfirm);
            this.Controls.Add(this.txtChannel);
            this.Controls.Add(this.channel);
            this.Controls.Add(this.txtZone);
            this.Controls.Add(this.zone);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.txtBatch);
            this.Controls.Add(this.batch);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "frmReceipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label batch;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.Label qty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label zone;
        private System.Windows.Forms.TextBox txtZone;
        private System.Windows.Forms.Label channel;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Button cmdConfirm;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Button cmdClose;
    }
}