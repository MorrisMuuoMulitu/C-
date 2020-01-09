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

namespace PizzaDynamicControl
{
    public partial class Form1 : Form
    {
        private bool visible;
        public Form1()
        {
            InitializeComponent();
            //We set the open file dialog initial Directory property
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
            //Set the central panel autoscroll property to true
            PnlCenter.AutoScroll = true;
            //Set the visible variable initial value
            visible=false;
            ModifyVisibility(visible);
        }
        //We create a list of controls.
        //The number of different controls will be the same as the number of pizzas we read from the file.
        private List<Pizza> pizzas = new List<Pizza>();
        private List<CheckBox> checkBoxes = new List<CheckBox>();
        private List<RadioButton> radioButtonsSmall = new List<RadioButton>();
        private List<RadioButton> radioButtonsLarge = new List<RadioButton>();
        //We need panel control for the radioButton pairs.
        private List<Panel> panels = new List<Panel>();
        private List<TextBox> txtPieces = new List<TextBox>();

        private void ModifyVisibility(bool visible)
        {
            
        }
    }
}
