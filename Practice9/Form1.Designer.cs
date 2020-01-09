namespace Practice9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lstOldestOnes = new System.Windows.Forms.ListBox();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.btnSelection = new System.Windows.Forms.Button();
            this.lstChosenOnes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(95, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSalmon;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(594, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chosen ones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSalmon;
            this.label5.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(594, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Oldest ones";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(535, 381);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(0, 13);
            this.lblStudent.TabIndex = 6;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(46, 381);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 7;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lstOldestOnes
            // 
            this.lstOldestOnes.FormattingEnabled = true;
            this.lstOldestOnes.Location = new System.Drawing.Point(538, 258);
            this.lstOldestOnes.Name = "lstOldestOnes";
            this.lstOldestOnes.Size = new System.Drawing.Size(286, 108);
            this.lstOldestOnes.TabIndex = 10;
            // 
            // pnlStudents
            // 
            this.pnlStudents.Location = new System.Drawing.Point(63, 101);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(258, 228);
            this.pnlStudents.TabIndex = 13;
            // 
            // btnSelection
            // 
            this.btnSelection.Location = new System.Drawing.Point(313, 380);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(75, 23);
            this.btnSelection.TabIndex = 14;
            this.btnSelection.Text = "Selection";
            this.btnSelection.UseVisualStyleBackColor = true;
            // 
            // lstChosenOnes
            // 
            this.lstChosenOnes.FormattingEnabled = true;
            this.lstChosenOnes.Location = new System.Drawing.Point(538, 91);
            this.lstChosenOnes.Name = "lstChosenOnes";
            this.lstChosenOnes.Size = new System.Drawing.Size(286, 95);
            this.lstChosenOnes.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(957, 491);
            this.Controls.Add(this.lstChosenOnes);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.lstOldestOnes);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " Students";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lstOldestOnes;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.ListBox lstChosenOnes;
    }
}

