using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice10
{
    public partial class GalleryForm : Form
    {
        public GalleryForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }
        private List<Image> pictures = new List<Image>();
        private int currentIndex;

        internal void Pass(List<Image> pictures)
        {
            this.pictures = pictures;
            pictureBox1.Image = pictures[currentIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0) currentIndex--;
            else currentIndex = pictures.Count - 1;
            pictureBox1.Image = pictures[currentIndex];
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (currentIndex < pictures.Count - 1) currentIndex++;
            else currentIndex = 0;
            pictureBox1.Image = pictures[currentIndex];
        }
    }
}
