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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
            CenterToScreen();
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.FileName = "result.txt";
        }
        private List<Competitor> competitors;

        internal void ListResults(List<Competitor> competitors)
        {
            this.competitors = competitors;
            foreach (Competitor item in competitors)
            {
                LstResult.Items.Add(item);
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            SaveResult();
        }

        private void SaveResult()
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamWriter streamWriter = null;
                try
                {
                    streamWriter = new StreamWriter(saveFileDialog1.FileName);
                    foreach (var item in competitors)
                    {
                        streamWriter.WriteLine(item.Name + ";" + item.NumberOfVotes);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (streamWriter!=null)
                    {
                        streamWriter.Close();
                    }
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveResult();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }
    }
}
