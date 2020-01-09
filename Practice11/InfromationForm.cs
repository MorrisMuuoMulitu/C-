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
    public partial class InfromationForm : Form
    {
        public InfromationForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void InfromationForm_Load(object sender, EventArgs e)
        {
            rchTxtBox_Info.Text = "Welcome to my Info Page";
        }

        private void rchTxtBox_Info_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
