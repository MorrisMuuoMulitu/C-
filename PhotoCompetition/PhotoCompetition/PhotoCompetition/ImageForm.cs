using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoCompetition
{
    public partial class ImageForm : Form
    {
        public ImageForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        internal void Showpicture(Image picture)
        {
            pictureBox1.Image = picture;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
