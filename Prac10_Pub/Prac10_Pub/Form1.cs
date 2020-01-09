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

namespace Prac10_Pub
{
    public partial class Form1 : Form  
    {
        private List<Drink> drinks = new List<Drink>();
        private List<Image> pictures = new List<Image>();
        private int numberOfPictures = 10;
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "drink_menu.txt";
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.FileName = "booking.txt";
        }
        //The pictures have to be loaded only once, so this is the loading.

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                    PicturesLoading();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error creating picture" + ex, "Error");
            }
        }
        private void PicturesLoading()
        {
            Image picture;
            for (int i = 0; i <= numberOfPictures; i++)
            {
                picture = Image.FromFile("picture" + i + ".jpg");
                pictures.Add(picture);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader streamReader = null;
                try
                {
                    string fileName = openFileDialog1.FileName;
                    streamReader = new StreamReader(fileName);
                    Input(streamReader);

                    drinkMenuMenuItem.Enabled = true;
                    saveToolStripMenuItem.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error message for programmer");
                }
                finally
                {
                    if (streamReader!=null)
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
                //create drink object and add to the drink list
                drinks.Add(new Drink(data[0], int.Parse(data[1])));
            }
        }

        private void drinkMenuMenuItem_Click(object sender, EventArgs e)
        {
            DrinkForm drinkForm = new DrinkForm();
            drinkForm.WriteDrinkMenu(drinks);
            drinkForm.ShowDialog();
        }
        //We allow the showing of gallery a time so the form is shown with the show() method after passing pictures.

        private void galleryMenuItem_Click(object sender, EventArgs e)
        {
            GalleryForm galleryForm = new GalleryForm();
            galleryForm.Pass(pictures);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamWriter streamWriter = null;
                try
                {
                    string fileName = saveFileDialog1.FileName;
                    streamWriter = new StreamWriter(fileName);
                    WriteToFile(streamWriter);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error in the file writing: " + ex.Message);
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

        private void WriteToFile(StreamWriter streamWriter)
        {
            foreach (Drink item in drinks)
            {
                streamWriter.WriteLine(item.ToBooking());
            }
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            new HelpForm().ShowDialog();
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made on programming 3 course", "Information");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
