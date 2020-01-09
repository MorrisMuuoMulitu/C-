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
    public partial class ResultsForm : Form
    {
        //We want to save the result of the votes into a text file therefore we add a save file dialog object to the form.
        //A list box control will contain the results of the votes.
        //When the user clicks on the save menu or on the save button we have to open the save file dialog to find a 
        //good folder to save the results.txt file content.
        public ResultsForm()
        {
            InitializeComponent();
            CenterToScreen();
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.FileName = "results.txt";
        }
        private List<Competitor> competitors = new List<Competitor>();

        internal void ListResult(List<Competitor> competitors)
        {
            this.competitors = competitors;
            foreach (var item in competitors)
            {
                lstResult.Items.Add(item);
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            SaveResult();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveResult();
        }

        private void SaveResult()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = null;
                try
                {
                    writer = new StreamWriter(saveFileDialog1.FileName);
                    foreach (var item in competitors)
                    {
                        writer.WriteLine(item.Name + ";" + item.NumberOfVotes);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                }
            }
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            Close();
        }
    }
}
