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

namespace Practice_11_Ex_2
{
    public partial class Form1 : Form
    {
        private string filename = "books.txt";
        private List<Books> books = new List<Books>();
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }



        private void readDataMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = null;
                try
                {
                    string filename = openFileDialog1.FileName;
                    streamReader = new StreamReader(filename);
                    ReadingData(streamReader);

                    votingMenuItem.Enabled = true;
                    helpMenuItem.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error message for the programmer");
                }
                finally
                {
                    if (streamReader != null)
                    {
                        streamReader.Close();
                    }
                }
            }
        }

        private void ReadingData(StreamReader streamReader)
        {
            string line;
            string[] data;
            while (!streamReader.EndOfStream)
            {
                line = streamReader.ReadLine();
                data = line.Split(';');
                //create a book item and add to the book list
                books.Add(new Books(data[0], data[1], int.Parse(data[2])));
            }
        }

        private void votingMenuItem_Click(object sender, EventArgs e)
        {
            VotingForm votingForm = new VotingForm();
            votingForm.Vote(books);
            votingForm.ShowDialog();
        }
        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            new HelpForm().ShowDialog();
        }
    }
        
}
