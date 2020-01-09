namespace Practice10
{
    partial class BillForm
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
            this.rchTxtBill = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchTxtBill
            // 
            this.rchTxtBill.Location = new System.Drawing.Point(31, 13);
            this.rchTxtBill.Name = "rchTxtBill";
            this.rchTxtBill.Size = new System.Drawing.Size(686, 391);
            this.rchTxtBill.TabIndex = 0;
            this.rchTxtBill.Text = "";
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.rchTxtBill);
            this.Name = "BillForm";
            this.Text = "BillForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtBill;
    }
}