using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice11
{
    public partial class ImageForm : Form
    {
        public ImageForm()
        {
            InitializeComponent();
            CenterToScreen();

        }
        internal void ShowPicture(Image picture)
            //This method is called from the Form1 and it contains the setting of the property values of the picture box.
        {
            pictureBox1.Image = picture;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            //When we click on the picture box object its click event handler will close the form.
        }
    }
}
