namespace Practice11
{
    partial class InfromationForm
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
            this.rchTxtBox_Info = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchTxtBox_Info
            // 
            this.rchTxtBox_Info.Location = new System.Drawing.Point(52, 41);
            this.rchTxtBox_Info.Name = "rchTxtBox_Info";
            this.rchTxtBox_Info.Size = new System.Drawing.Size(686, 329);
            this.rchTxtBox_Info.TabIndex = 0;
            this.rchTxtBox_Info.Text = "";
            this.rchTxtBox_Info.TextChanged += new System.EventHandler(this.rchTxtBox_Info_TextChanged);
            // 
            // InfromationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rchTxtBox_Info);
            this.Name = "InfromationForm";
            this.Text = "InfromationForm";
            this.Load += new System.EventHandler(this.InfromationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtBox_Info;
    }
}