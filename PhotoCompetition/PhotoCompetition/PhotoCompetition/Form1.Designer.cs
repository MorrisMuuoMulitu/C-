namespace PhotoCompetition
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resultsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlCenter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVote = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultsMenuItem,
            this.informationMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resultsMenuItem
            // 
            this.resultsMenuItem.Name = "resultsMenuItem";
            this.resultsMenuItem.Size = new System.Drawing.Size(56, 20);
            this.resultsMenuItem.Text = "Results";
            this.resultsMenuItem.Click += new System.EventHandler(this.resultsMenuItem_Click);
            // 
            // informationMenuItem
            // 
            this.informationMenuItem.Name = "informationMenuItem";
            this.informationMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationMenuItem.Text = "Information";
            this.informationMenuItem.Click += new System.EventHandler(this.informationMenuItem_Click);
            // 
            // PnlCenter
            // 
            this.PnlCenter.Location = new System.Drawing.Point(23, 64);
            this.PnlCenter.Name = "PnlCenter";
            this.PnlCenter.Size = new System.Drawing.Size(430, 250);
            this.PnlCenter.TabIndex = 1;
            this.PnlCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlCenter_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(181, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Photo Competition";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnVote
            // 
            this.BtnVote.Location = new System.Drawing.Point(187, 322);
            this.BtnVote.Name = "BtnVote";
            this.BtnVote.Size = new System.Drawing.Size(117, 23);
            this.BtnVote.TabIndex = 3;
            this.BtnVote.Text = "Vote";
            this.BtnVote.UseVisualStyleBackColor = true;
            this.BtnVote.Click += new System.EventHandler(this.BtnVote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(477, 357);
            this.Controls.Add(this.BtnVote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlCenter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Photo Competition";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resultsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationMenuItem;
        private System.Windows.Forms.Panel PnlCenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVote;
    }
}

