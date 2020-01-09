namespace PizzaDynamicControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblSmall = new System.Windows.Forms.Label();
            this.LblLarge = new System.Windows.Forms.Label();
            this.PnlCenter = new System.Windows.Forms.Panel();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnLoadData = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPayable = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // LblSmall
            // 
            this.LblSmall.AutoSize = true;
            this.LblSmall.Location = new System.Drawing.Point(97, 39);
            this.LblSmall.Name = "LblSmall";
            this.LblSmall.Size = new System.Drawing.Size(46, 13);
            this.LblSmall.TabIndex = 0;
            this.LblSmall.Text = "LblSmall";
            // 
            // LblLarge
            // 
            this.LblLarge.AutoSize = true;
            this.LblLarge.Location = new System.Drawing.Point(379, 53);
            this.LblLarge.Name = "LblLarge";
            this.LblLarge.Size = new System.Drawing.Size(48, 13);
            this.LblLarge.TabIndex = 1;
            this.LblLarge.Text = "LblLarge";
            // 
            // PnlCenter
            // 
            this.PnlCenter.AutoScroll = true;
            this.PnlCenter.Location = new System.Drawing.Point(49, 104);
            this.PnlCenter.Name = "PnlCenter";
            this.PnlCenter.Size = new System.Drawing.Size(446, 123);
            this.PnlCenter.TabIndex = 2;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(49, 264);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 3;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(48, 313);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(76, 26);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // BtnLoadData
            // 
            this.BtnLoadData.Location = new System.Drawing.Point(224, 313);
            this.BtnLoadData.Name = "BtnLoadData";
            this.BtnLoadData.Size = new System.Drawing.Size(91, 25);
            this.BtnLoadData.TabIndex = 5;
            this.BtnLoadData.Text = "Load Data";
            this.BtnLoadData.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(407, 313);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(88, 26);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Payable";
            // 
            // TxtPayable
            // 
            this.TxtPayable.Location = new System.Drawing.Point(286, 246);
            this.TxtPayable.Name = "TxtPayable";
            this.TxtPayable.Size = new System.Drawing.Size(100, 20);
            this.TxtPayable.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.TxtPayable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnLoadData);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.PnlCenter);
            this.Controls.Add(this.LblLarge);
            this.Controls.Add(this.LblSmall);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza with Dynamic Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSmall;
        private System.Windows.Forms.Label LblLarge;
        private System.Windows.Forms.Panel PnlCenter;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnLoadData;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPayable;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

