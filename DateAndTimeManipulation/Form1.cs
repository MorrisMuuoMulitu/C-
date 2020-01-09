using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace DateAndTimeManipulation
{
    public partial class Form1 : Form
    {
        private DateTime today = DateTime.Now;
        private DateTime birthDate;
        private DateTime chosenDate;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e) 
        {
            lblDate.Text = today.ToString("F");
            //Sets the focus to the masked textbox.
            this.ActiveControl = mskdTxtBirthDate;
            chosenDate = MyDateTimePicker.Value;
            TxtDayNumber.Text = chosenDate.DayOfYear.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("F");
        }

        private void mskdTxtBirthDate_Leave(object sender, EventArgs e)
        {
            Congratulation();
        }

        private void Congratulation()
        {
            try
            {
                if (!mskdTxtBirthDate.MaskFull) throw new Exception();
                else
                {
                    birthDate = DateTime.Parse(mskdTxtBirthDate.Text);
                    if (birthDate > today) throw new Exception();
                    if (birthDate.Month == today.Month && birthDate.Day == today.Day)
                    {
                        lblCongratulation.Text = "Happy Birthday Morris";
                    }
                    else
                    {
                        lblCongratulation.Text = "Have a nice weekend buddy!";
                    }
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Wrong date", "Error");
                mskdTxtBirthDate.Focus();
            }
        }

        private void mskdTxtBirthDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Congratulation();
           
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            TxtYears.Text = (today.Year - birthDate.Year).ToString();
            TxtDayName.Text = birthDate.DayOfWeek.ToString();
            string dayNameInYourLanguage = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(birthDate.DayOfWeek);
            TxtDayName.Text = dayNameInYourLanguage;
        }

        private void MyDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            chosenDate = MyDateTimePicker.Value;
            TxtDayNumber.Text = chosenDate.DayOfYear.ToString();
        }

        private void TxtDayNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox) ((TextBox)item).Clear();
            }
            lblCongratulation.Text = "";
            mskdTxtBirthDate.Clear();
            MyDateTimePicker.Value = today;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to quit?", "Confirmation", MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
