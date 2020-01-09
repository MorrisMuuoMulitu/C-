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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
        }
        //The distance from the lrft side of the panel
        private int distanceX = 10;
        //distance from the top of the panel
        private int distanceY = 10;
        //Distance between the checkboxes
        int chkYInterval = 40;

        private List<CheckBox> chkBoxes = new List<CheckBox>();
        private List<Student> students = new List<Student>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set the activity of the buttons
            SetButton(false);
        }

        private void SetButton(bool active)
        {
            btnInput.Enabled = !active;
            btnSelection.Enabled = active;
        }

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
                    PutStudentsOnPanel();
                    SetButton(true);
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

                //The structure of the data file.
                //Name;StudentCode;Year(integer)
                student = new Student(data[0], data[1], int.Parse(data[2]));
                students.Add(student);
            }
        }

        private void PutStudentsOnPanel()
        {
            CheckBox chkBox;
            for (int i = 0; i < students.Count; i++)
            {
                chkBox = new CheckBox();
                chkBox.AutoSize = true;
                chkBox.Location = new Point(distanceX, distanceY + i * chkYInterval);
                chkBoxes.Add(chkBox);
            }
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            Selecting();
        }

        private void Selecting()
        {
            bool isChosenOne = false;
            lstChosenOnes.Items.Clear();
            for(int i = 0; i < chkBoxes.Count; i++)
            {
                if (chkBoxes[i].Checked)
                {
                    lstChosenOnes.Items.Add(students[i]);
                    isChosenOne = true;
                }
            }
            if (!isChosenOne)
            {
                MessageBox.Show("Please select somebody!", "Error");
            }
            else
            {
                SearchingOldest();
            }
        }

        private void SearchingOldest()
        {
            lstOldestOnes.Items.Clear();
            int min = (lstChosenOnes.Items[0] as Student).BirthYear;
            foreach (Student student in lstChosenOnes.Items)
            {
                if (student.BirthYear < min) min = student.BirthYear;
            }
            foreach (Student student in lstChosenOnes.Items)
            {
                if (student.BirthYear == min) lstOldestOnes.Items.Add(student);
            }
        }

        private void lstChosenOnes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student student = (Student)lstChosenOnes.SelectedItem;
            if (student != null) lblStudent.Text = student + ", year of birth: " + student.BirthYear;
        }

        private void pnlStudents_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
