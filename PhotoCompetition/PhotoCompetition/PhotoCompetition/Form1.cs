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

namespace PhotoCompetition
{
    public partial class Form1 : Form
    {
        private string fileName = "competitors.txt";
        private List<Competitor> competitors = new List<Competitor>();
        private List<PictureBox> imageBoxes = new List<PictureBox>();
        private List<RadioButton> radioButtons = new List<RadioButton>();

        private int columnNumber = 5;
        private int imageWidth = 80, imageHeight = 55, yDist = 30, left = 5, top = 5;

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                reader = new StreamReader(fileName);
                string name, imgName;
                while (!reader.EndOfStream)
                {
                    imgName = reader.ReadLine();
                    name = imgName.First().ToString().ToUpper() + imgName.Substring(1);
                    name = name.Replace('e', 'é');
                    //Create a new object and add it to the list.
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
                if (reader!=null)
                {
                    reader.Close();
                }
            }
            return success;

        }

        

        private void CreateLayout()
        {
            int rowNum = 0, colNum = 0;
            PictureBox picBox;
            RadioButton radioButton;

            int xDist = (PnlCenter.Size.Width - columnNumber * imageWidth - left) / columnNumber;
            int imgDistX = imageWidth + xDist;
            int imgDistY = imageHeight + yDist;

            foreach (var competitor in competitors)
            {
                //picturebox
                picBox = new PictureBox();
                picBox.Location = new Point(left + colNum * imgDistX, top + rowNum * imgDistY);
                picBox.Size = new Size(imageWidth, imageHeight);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox.Image = Image.FromFile(competitor.ImageName + ".jpg");
                picBox.Click += new EventHandler(this.picBox_Click);

                PnlCenter.Controls.Add(picBox);
                imageBoxes.Add(picBox);
                //Below everypicture we have a radio button
                radioButton = new RadioButton();
                radioButton.Location = new Point(left + colNum * imgDistX, top + imageHeight + rowNum * imgDistY);
                radioButton.AutoSize = true;
                radioButton.Text = competitor.Name;

                PnlCenter.Controls.Add(radioButton);
                radioButtons.Add(radioButton);

                colNum++;
                if (colNum%columnNumber==0)
                {
                    rowNum++;
                    colNum = 0;
                }
            }
        }

        private void PnlCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBox_Click(object sender, EventArgs e)
        {
            ImageForm imageForm = new ImageForm();
            Image picture = (sender as PictureBox).Image;
            imageForm.Showpicture(picture);
            imageForm.ShowDialog();
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
                    radioButtons[i].Checked=false;
                    break;
                }
            }
            if (!chosenOrNot)
            {
                MessageBox.Show("You have not chosen any picture buddy","Error");
            }
        }
        private void resultsMenuItem_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm();
            resultForm.ListResults(competitors);
            resultForm.ShowDialog();
        }
        private void informationMenuItem_Click(object sender, EventArgs e)
        {
            new InfoForm().ShowDialog();
        }

    }
}
