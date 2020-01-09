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

namespace Practice10
{
    public partial class Form1 : Form
    {
        private List<Drink> drinks = new List<Drink>();
        private List<Image> pictures = new List<Image>();
        private int numberofPictures = 10;
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "drink_menu.txt";
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.FileName = "booking.txt";
        }
        //The pictures have to be loaded only once and this is the work of the form loading.

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                PicturesLoading();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error creating the picture" + ex, "Error");
            }
        }

        private void PicturesLoading()
        {
            Image picture;
            for (int i = 1; i <= numberofPictures; i++)
            {
                picture = Image.FromFile("picture" + i + ".jpg");
                pictures.Add(picture);
            }
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = null;
                try
                {
                    string filename = openFileDialog1.FileName;
                    streamReader = new StreamReader(filename);

                    Input(streamReader);

                    drinkMenuMenuItem.Enabled = true;

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

        private void Input(StreamReader streamReader)
        {
            string line;
            string[] data;
            while (!streamReader.EndOfStream)
            {
                line = streamReader.ReadLine();
                data = line.Split(';');
                //Shot of plum brandy;200
                drinks.Add(new Drink(data[0], int.Parse(data[1])));
            }
        }


        //We want one drink menu at a time, so the form is shown with the ShowDialog() method.
        //We pass the list of the drinks before.
        private void drinkMenuMenuItem_Click(object sender, EventArgs e)
        {
            DrinkMenuForm drinkMenuForm = new DrinkMenuForm();
            drinkMenuForm.WriteDrinkMenu(drinks);
            drinkMenuForm.ShowDialog();
        }
        //We allow to show more gallery at a time, so the form is shown with Show() method after passing pictures.
        private void GalleryMenuItem_Click(object sender, EventArgs e)
        {
            GalleryForm galleryForm = new GalleryForm();
            galleryForm.Pass(pictures);
            galleryForm.Show();
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = null;
                try
                {
                    string filename = saveFileDialog1.FileName;
                    streamWriter = new StreamWriter(filename);
                    writeToFile(streamWriter);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error in file writing","Error");
                }
                finally
                {
                    if (streamWriter != null)
                    {
                        streamWriter.Close();
                    }
                }
            }
        }

        private void writeToFile(StreamWriter streamWriter)
        {
            foreach (Drink item in drinks)
            {
                streamWriter.WriteLine(item.ToBooking());
            }
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            new HelpForm().ShowDialog();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Morris for C#" , "Information");
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
