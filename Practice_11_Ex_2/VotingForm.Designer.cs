namespace Practice_11_Ex_2
{
    partial class VotingForm
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
            this.lblBookList = new System.Windows.Forms.Label();
            this.btnVote = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.RemTimeTxtBox = new System.Windows.Forms.TextBox();
            this.pnlBookList = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblBookList
            // 
            this.lblBookList.AutoSize = true;
            this.lblBookList.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookList.ForeColor = System.Drawing.Color.Maroon;
            this.lblBookList.Location = new System.Drawing.Point(333, 22);
            this.lblBookList.Name = "lblBookList";
            this.lblBookList.Size = new System.Drawing.Size(105, 33);
            this.lblBookList.TabIndex = 0;
            this.lblBookList.Text = "Book List";
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(666, 408);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(75, 23);
            this.btnVote.TabIndex = 1;
            this.btnVote.Text = "Vote";
            this.btnVote.UseVisualStyleBackColor = true;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(13, 408);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(85, 13);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "Remaining time: ";
            // 
            // RemTimeTxtBox
            // 
            this.RemTimeTxtBox.Location = new System.Drawing.Point(104, 408);
            this.RemTimeTxtBox.Name = "RemTimeTxtBox";
            this.RemTimeTxtBox.ReadOnly = true;
            this.RemTimeTxtBox.Size = new System.Drawing.Size(170, 20);
            this.RemTimeTxtBox.TabIndex = 3;
            this.RemTimeTxtBox.TextChanged += new System.EventHandler(this.RemTimeTxtBox_TextChanged);
            // 
            // pnlBookList
            // 
            this.pnlBookList.AutoScroll = true;
            this.pnlBookList.Location = new System.Drawing.Point(63, 67);
            this.pnlBookList.Name = "pnlBookList";
            this.pnlBookList.Size = new System.Drawing.Size(678, 289);
            this.pnlBookList.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.RemTimeTxtBox_TextChanged);
            // 
            // VotingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.pnlBookList);
            this.Controls.Add(this.RemTimeTxtBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.lblBookList);
            this.Name = "VotingForm";
            this.Text = "Favorite Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookList;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox RemTimeTxtBox;
        private System.Windows.Forms.Panel pnlBookList;
        private System.Windows.Forms.Timer timer1;
    }
}