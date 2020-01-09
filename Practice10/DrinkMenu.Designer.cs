namespace Practice10
{
    partial class DrinkMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BillMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(30, 32);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(732, 310);
            this.pnlMenu.TabIndex = 0;
            // 
            // BtnOrder
            // 
            this.BtnOrder.CausesValidation = false;
            this.BtnOrder.ContextMenuStrip = this.contextMenuStrip;
            this.BtnOrder.Location = new System.Drawing.Point(352, 381);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(75, 23);
            this.BtnOrder.TabIndex = 1;
            this.BtnOrder.Text = "Order";
            this.BtnOrder.UseVisualStyleBackColor = true;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.AllowDrop = true;
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BillMenuItem,
            this.PayMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 70);
            // 
            // BillMenuItem
            // 
            this.BillMenuItem.Name = "BillMenuItem";
            this.BillMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BillMenuItem.Text = "Bill";
            this.BillMenuItem.Click += new System.EventHandler(this.BillMenuItem_Click);
            // 
            // PayMenuItem
            // 
            this.PayMenuItem.Name = "PayMenuItem";
            this.PayMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PayMenuItem.Text = "Pay";
            this.PayMenuItem.Click += new System.EventHandler(this.PayMenuItem_Click);
            // 
            // DrinkMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.pnlMenu);
            this.Name = "DrinkMenuForm";
            this.Text = "DrinkMenu";
            this.Load += new System.EventHandler(this.DrinkMenuForm_Load);
            this.ContextMenuStripChanged += new System.EventHandler(this.BtnOrder_Click);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem BillMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PayMenuItem;
    }
}