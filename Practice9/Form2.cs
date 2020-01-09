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

namespace Practice9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
        }
        private int distanceX = 10, distanceY = 10, btnXInterval = 80;
        private List<int> years = new List<int>();
        private List<Button> btnYears = new List<Button>();

        private void btnInput_Click(object sender, EventArgs e)
        {
            Input();
        }

        private void Input()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                StreamReader streamReader = null;
                try
                {
                    streamReader = new StreamReader(filename);
                    ReadData(streamReader);
                    PutYearsOnPanel();
                    btnInput.Enabled = false;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString(), "Exception");
                }
                finally
                {
                    if (streamReader != null) streamReader.Close();
                }
            }
        }

        private void ReadData(StreamReader streamReader)
        {
            string dataLine;
            string[] data;

            Student student;
            while (!streamReader.EndOfStream)
            {
                dataLine = streamReader.ReadLine();
                data = dataLine.Split(';');
                //the structure of the data file
                //Name;StudentCode;Year(integer)
                student = new Student(data[0], data[1], int.Parse(data[2]));
            }
            streamReader.Close();
        }

        private void PutYearsOnPanel()
        {
            Button btn;
            //Sorts the years in increasing order
            //The sort() method can be used, because of the elements of the years list are simple int values
            years.Sort();
            for (int i = 0; i < years.Count; i++)
            {
                btn = new Button();
                btn.Location = new Point(distanceX + i * btnXInterval, distanceY);
                btn.Text = years[i].ToString();
                //The selection method has to be assignrd to the button click event 
                //The easiest way is to generate this method
                btn.Click += new System.EventHandler(Selection);
                //Put the button on the panel
                pnlYears.Controls.Add(btn);
                //Add the button to the buttons' list
                btnYears.Add(btn);
            }
        }

        

        private void Selection(object sender, EventArgs e)
        {
            //The value of year is the text of clicked button
            int year = int.Parse((sender as Button).Text);
            lstSelected.Items.Clear();
            foreach (Student student in lstStudents.Items)
            {
                if (student.BirthYear == year) lstSelected.Items.Add(student);
            }
        }
        private void lstSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student student = (Student)lstSelected.SelectedItem;
            if (student != null) lblStudent.Text = student + " , year of birth: " + student.BirthYear;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
