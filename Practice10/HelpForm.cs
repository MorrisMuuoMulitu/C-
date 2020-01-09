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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            rchTxtHelp.Text="File menu item:\r\nYou can open data file containing the drink list" +
                "\r\nand you can save the file containing the booking of pub " +
                "(name of drinks, total amount per drinks and income per drinks"+
                "\r\n\nDrink menu menu item:\r\n You can see the drink menu and order any drink"+
                "\r\n\nGallery menu item:\r\nYou can see the drink menu and order any drink"+
                "\r\n\nGallery menu item:\r\nYou can see pictures of the village" +
                " and the surrounding area. - " + " You can open it many times and multiple instances. ";
        }
    }
}
