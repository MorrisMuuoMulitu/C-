namespace DateAndTimeManipulation
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskdTxtBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtYears = new System.Windows.Forms.MaskedTextBox();
            this.TxtDayName = new System.Windows.Forms.MaskedTextBox();
            this.lblCongratulation = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDayNumber = new System.Windows.Forms.MaskedTextBox();
            this.TxtDays = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtLater = new System.Windows.Forms.MaskedTextBox();
            this.BtnDisplay = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.MyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actual date and time:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(220, 32);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Birth date:";
            // 
            // mskdTxtBirthDate
            // 
            this.mskdTxtBirthDate.Location = new System.Drawing.Point(173, 71);
            this.mskdTxtBirthDate.Name = "mskdTxtBirthDate";
            this.mskdTxtBirthDate.Size = new System.Drawing.Size(100, 20);
            this.mskdTxtBirthDate.TabIndex = 3;
            this.mskdTxtBirthDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskdTxtBirthDate_KeyDown);
            this.mskdTxtBirthDate.Leave += new System.EventHandler(this.mskdTxtBirthDate_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "You are";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "years old.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Day name of your birth";
            // 
            // TxtYears
            // 
            this.TxtYears.Location = new System.Drawing.Point(120, 122);
            this.TxtYears.Name = "TxtYears";
            this.TxtYears.Size = new System.Drawing.Size(100, 20);
            this.TxtYears.TabIndex = 7;
            // 
            // TxtDayName
            // 
            this.TxtDayName.Location = new System.Drawing.Point(617, 129);
            this.TxtDayName.Name = "TxtDayName";
            this.TxtDayName.Size = new System.Drawing.Size(100, 20);
            this.TxtDayName.TabIndex = 8;
            // 
            // lblCongratulation
            // 
            this.lblCongratulation.AutoSize = true;
            this.lblCongratulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongratulation.ForeColor = System.Drawing.Color.Maroon;
            this.lblCongratulation.Location = new System.Drawing.Point(386, 182);
            this.lblCongratulation.Name = "lblCongratulation";
            this.lblCongratulation.Size = new System.Drawing.Size(70, 25);
            this.lblCongratulation.TabIndex = 9;
            this.lblCongratulation.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Choose a date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Day number of the year:";
            // 
            // TxtDayNumber
            // 
            this.TxtDayNumber.Location = new System.Drawing.Point(603, 229);
            this.TxtDayNumber.Name = "TxtDayNumber";
            this.TxtDayNumber.Size = new System.Drawing.Size(100, 20);
            this.TxtDayNumber.TabIndex = 12;
            this.TxtDayNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxtDayNumber_MaskInputRejected);
            // 
            // TxtDays
            // 
            this.TxtDays.Location = new System.Drawing.Point(330, 300);
            this.TxtDays.Name = "TxtDays";
            this.TxtDays.Size = new System.Drawing.Size(100, 20);
            this.TxtDays.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "days later.";
            // 
            // TxtLater
            // 
            this.TxtLater.Location = new System.Drawing.Point(603, 307);
            this.TxtLater.Name = "TxtLater";
            this.TxtLater.Size = new System.Drawing.Size(100, 20);
            this.TxtLater.TabIndex = 16;
            // 
            // BtnDisplay
            // 
            this.BtnDisplay.Location = new System.Drawing.Point(41, 394);
            this.BtnDisplay.Name = "BtnDisplay";
            this.BtnDisplay.Size = new System.Drawing.Size(75, 23);
            this.BtnDisplay.TabIndex = 17;
            this.BtnDisplay.Text = "Display";
            this.BtnDisplay.UseVisualStyleBackColor = true;
            this.BtnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(391, 409);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 18;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(687, 417);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 19;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // MyDateTimePicker
            // 
            this.MyDateTimePicker.Location = new System.Drawing.Point(35, 297);
            this.MyDateTimePicker.Name = "MyDateTimePicker";
            this.MyDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.MyDateTimePicker.TabIndex = 20;
            this.MyDateTimePicker.ValueChanged += new System.EventHandler(this.MyDateTimePicker_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 468);
            this.Controls.Add(this.MyDateTimePicker);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnDisplay);
            this.Controls.Add(this.TxtLater);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtDays);
            this.Controls.Add(this.TxtDayNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCongratulation);
            this.Controls.Add(this.TxtDayName);
            this.Controls.Add(this.TxtYears);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskdTxtBirthDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Date and time manipulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskdTxtBirthDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TxtYears;
        private System.Windows.Forms.MaskedTextBox TxtDayName;
        private System.Windows.Forms.Label lblCongratulation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox TxtDayNumber;
        private System.Windows.Forms.MaskedTextBox TxtDays;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox TxtLater;
        private System.Windows.Forms.Button BtnDisplay;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DateTimePicker MyDateTimePicker;
        private System.Windows.Forms.Timer timer1;
    }
}

