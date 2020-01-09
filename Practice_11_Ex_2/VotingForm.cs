using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_11_Ex_2
{
    public partial class VotingForm : Form
    {
        
        public VotingForm()
        {
            InitializeComponent();
        }

        //The list of drinks will be used in other methods as well so we declare it on class level
        private List<Books> books = new List<Books>();
        private List<RadioButton> radioButtons = new List<RadioButton>();
        private List<TextBox> txtBoxes = new List<TextBox>();
        //The distance for the placement of dynamic controls
        //private int left = 10, top = 10, rbtYdistance = 40, rbtXSize = 250, txtXSize = 30, rbtYSize, rbtLblDistance = 5;

        internal void Vote(List<Books> books)
        {
            pnlBookList.Controls.Clear();
            radioButtons.Clear();
            txtBoxes.Clear();
            this.books = books;

            RadioButton radioButton;
            TextBox txtBox;

            //placement of dynamic controls
            for (int i = 0; i < books.Count; i++)
            {
                //Radiobutton
                radioButton = new RadioButton();
                //radioButton.Location = new Point(left, top + i * rbtYdistance); 
                //radioButton.Size = new Size(rbtXSize, rbtYSize);
                //radioButton.Text = books[i].ToBookList();
                //radioButton.TextAlign = ContentAlignment.MiddleLeft;

                radioButton.CheckedChanged += new EventHandler(this.radioButton_CheckedChanged);
                //txtBox
                txtBox = new TextBox();
               // txt.Location=new Point

                //Put controls on the panel
                pnlBookList.Controls.Add(radioButton);
                //Add the controls to their list
                radioButtons.Add(radioButton);

            }
            
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (!radioButton.Checked)
            {
                //int i = radioButton.IndexOf(radioButton);
               // txtBoxes[i].BackColor = Color.White;
               // txtBoxes[i].Text = "";
            }
        }

        private void RemTimeTxtBox_TextChanged(object sender, EventArgs e)
        {
           
        }
        int timeLeft = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (timeLeft>0)
            {
                btnVote.Enabled = true;
                timeLeft = timeLeft - 1;
                RemTimeTxtBox.Text = timeLeft + " seconds";
            }
            else
            {
                btnVote.Enabled = false;
                RemTimeTxtBox.Text = "Sorry. Time ended";
                
            }
           
            
        }
    }
}
