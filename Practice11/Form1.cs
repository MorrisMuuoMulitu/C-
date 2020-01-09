using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practice11
{
    public partial class Form1 : Form
    {
        private string filename = "competitors.txt";
        private List<Competitor> competitors = new List<Competitor>();
        private List<PictureBox> imageBoxes = new List<PictureBox>();
        private List<RadioButton> radioButtons = new List<RadioButton>();

        private int columnNumber = 5;
        private int imageLine = 80, imageHeight = 55, yDist = 30, left = 5, top = 5;

        

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
             if (ReadingData())
            {
                CreateLayout();
            }
        }

        

        private bool ReadingData()
        {
            bool success = false;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(filename);
                string name, imgName;
                while (!reader.EndOfStream)
                {
                    imgName = reader.ReadLine();
                    name = imgName.First().ToString().ToUpper() + imgName.Substring(1);
                    name = name.Replace('e', 'é');
                    competitors.Add(new Competitor(name, imgName));
                }
                success = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return success;
        }

        

        private void CreateLayout()
        {
            //In this method we have to create picture box objects and radio button objects and set their properties.
            //According to the task’s text we have to define the click event handler of pictures, because when the user clicks 
            //on the picture the program opens a new window and shows the picture in larger size.
            //We need the rownum and colnum variables also, because we want to arrange the pictures in a matrix shape.
            //We need radio button control to choose one picture and then the user votes to this picture clicking on the vote button.
            //add the created controls to the control collections of the panel control
            //You have to add the picture box control and the radio button control to the picture box list and the radio button list also.
            int rownum = 0, colnum = 0;
            PictureBox picBox;
            RadioButton radioButton;
            int xDist = (pnlPicture.Size.Width - columnNumber * imageLine - left) / columnNumber;
            int imgDistX = imageLine + xDist;
            int imgDistY = imageHeight + yDist;

            foreach (var competitor in competitors)
            {
                //PictureBox
                picBox = new PictureBox();
                picBox.Location = new Point(left + colnum * imgDistX, top + rownum * imgDistY);
                picBox.Size = new Size(imageLine, imageHeight);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox.Click += new System.EventHandler(this.picBox_Click);

                pnlPicture.Controls.Add(picBox);
                imageBoxes.Add(picBox);

                //RadioButton
                radioButton = new RadioButton();
                radioButton.Location = new Point(left + colnum * imgDistX, top + imageHeight + rownum * imgDistY);
                radioButton.AutoSize = true;
                radioButton.Text = competitor.Name;
                pnlPicture.Controls.Add(radioButton);
                radioButtons.Add(radioButton);

                colnum++;
                if (colnum%columnNumber==0)
                {
                    rownum++;
                    colnum = 0;
                }

            }
        }

        private void pnlPicture_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBox_Click(object sender, EventArgs e)
        {
            ImageForm frmImage = new ImageForm();
            Image picture = (sender as PictureBox).Image;
            frmImage.ShowDialog();
            //frmImage.Size=80,50;
        }
        private void BtnVote_Click(object sender, EventArgs e)
        {
            bool chosenOrNot = false;
            for (int i = 0; i < radioButtons.Count; i++)
            {
                if (radioButtons[i].Checked)
                {
                    competitors[i].GetVotes();
                    chosenOrNot = true;
                    radioButtons[i].Checked = false;
                    break;
                }
            }
            if (!chosenOrNot)
            {
                MessageBox.Show("You have not chosen any picture!", "Error");
            }
        }
        private void resultsMenuItem_Click(object sender, EventArgs e)
        {
            ResultsForm frmResult = new ResultsForm();
            frmResult.ListResult(competitors);
            frmResult.ShowDialog();
        }
        private void informationMenuItem_Click(object sender, EventArgs e)
        {
           
           
            new InformationForm().ShowDialog();

        }
    }
}
