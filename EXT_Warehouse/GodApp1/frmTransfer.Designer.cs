namespace GodApp1
{
    partial class frmTransfer
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
            this.item = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.batch = new System.Windows.Forms.Label();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.zone = new System.Windows.Forms.Label();
            this.txtFromZone = new System.Windows.Forms.TextBox();
            this.channel = new System.Windows.Forms.Label();
            this.txtFromChannel = new System.Windows.Forms.TextBox();
            this.toZone = new System.Windows.Forms.Label();
            this.txtToZone = new System.Windows.Forms.TextBox();
            this.toChannel = new System.Windows.Forms.Label();
            this.txtToChannel = new System.Windows.Forms.TextBox();
            this.cmdConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // item
            // 
            this.item.Location = new System.Drawing.Point(14, 6);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(100, 20);
            this.item.Text = "Item No";
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(16, 26);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(202, 21);
            this.txtItemId.TabIndex = 1;
            // 
            // batch
            // 
            this.batch.Location = new System.Drawing.Point(16, 51);
            this.batch.Name = "batch";
            this.batch.Size = new System.Drawing.Size(100, 20);
            this.batch.Text = "Batch";
            // 
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(16, 66);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(202, 21);
            this.txtBatch.TabIndex = 3;
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(16, 92);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(100, 20);
            this.qty.Text = "QTY";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(16, 107);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 21);
            this.txtQty.TabIndex = 5;
            // 
            // zone
            // 
            this.zone.Location = new System.Drawing.Point(16, 135);
            this.zone.Name = "zone";
            this.zone.Size = new System.Drawing.Size(76, 18);
            this.zone.Text = "From zone";
            // 
            // txtFromZone
            // 
            this.txtFromZone.Location = new System.Drawing.Point(16, 152);
            this.txtFromZone.Name = "txtFromZone";
            this.txtFromZone.Size = new System.Drawing.Size(100, 21);
            this.txtFromZone.TabIndex = 7;
            // 
            // channel
            // 
            this.channel.Location = new System.Drawing.Point(121, 135);
            this.channel.Name = "channel";
            this.channel.Size = new System.Drawing.Size(100, 20);
            this.channel.Text = "channel";
            // 
            // txtFromChannel
            // 
            this.txtFromChannel.Location = new System.Drawing.Point(122, 151);
            this.txtFromChannel.Name = "txtFromChannel";
            this.txtFromChannel.Size = new System.Drawing.Size(100, 21);
            this.txtFromChannel.TabIndex = 9;
            // 
            // toZone
            // 
            this.toZone.Location = new System.Drawing.Point(16, 177);
            this.toZone.Name = "toZone";
            this.toZone.Size = new System.Drawing.Size(100, 20);
            this.toZone.Text = "To zone";
            // 
            // txtToZone
            // 
            this.txtToZone.Location = new System.Drawing.Point(16, 195);
            this.txtToZone.Name = "txtToZone";
            this.txtToZone.Size = new System.Drawing.Size(100, 21);
            this.txtToZone.TabIndex = 11;
            // 
            // toChannel
            // 
            this.toChannel.Location = new System.Drawing.Point(123, 176);
            this.toChannel.Name = "toChannel";
            this.toChannel.Size = new System.Drawing.Size(100, 20);
            this.toChannel.Text = "channel";
            // 
            // txtToChannel
            // 
            this.txtToChannel.Location = new System.Drawing.Point(123, 194);
            this.txtToChannel.Name = "txtToChannel";
            this.txtToChannel.Size = new System.Drawing.Size(100, 21);
            this.txtToChannel.TabIndex = 13;
            // 
            // cmdConfirm
            // 
            this.cmdConfirm.BackColor = System.Drawing.Color.Yellow;
            this.cmdConfirm.Location = new System.Drawing.Point(16, 221);
            this.cmdConfirm.Name = "cmdConfirm";
            this.cmdConfirm.Size = new System.Drawing.Size(207, 43);
            this.cmdConfirm.TabIndex = 14;
            this.cmdConfirm.Text = "Transfer";
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.cmdConfirm);
            this.Controls.Add(this.txtToChannel);
            this.Controls.Add(this.toChannel);
            this.Controls.Add(this.txtToZone);
            this.Controls.Add(this.toZone);
            this.Controls.Add(this.txtFromChannel);
            this.Controls.Add(this.channel);
            this.Controls.Add(this.txtFromZone);
            this.Controls.Add(this.zone);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.txtBatch);
            this.Controls.Add(this.batch);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.item);
            this.Menu = this.mainMenu1;
            this.Name = "frmTransfer";
            this.Text = "Transfer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label item;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label batch;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.Label qty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label zone;
        private System.Windows.Forms.TextBox txtFromZone;
        private System.Windows.Forms.Label channel;
        private System.Windows.Forms.TextBox txtFromChannel;
        private System.Windows.Forms.Label toZone;
        private System.Windows.Forms.TextBox txtToZone;
        private System.Windows.Forms.Label toChannel;
        private System.Windows.Forms.TextBox txtToChannel;
        private System.Windows.Forms.Button cmdConfirm;
    }
}