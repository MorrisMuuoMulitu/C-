using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac10_Pub
{
    public partial class DrinkForm : Form
    {
        public DrinkForm()
        {
            InitializeComponent();
        }
        //The list of drinks will be used in other methods as well so we have to declare it on class level
        private List<Drink> drinks = new List<Drink>();
        //They are used for ordering.
        private List<CheckBox> checkBoxes = new List<CheckBox>();
        private List<TextBox> txtBoxes = new List<TextBox>();


        //The distances for placement of dynamic controls
        private int left = 10, top = 10, chkXSize = 250, chkYdistance = 40, txtXSize = 30, txtYSize = 17, txtBoxLblDistance = 5;

        

        private int maxQuantity = 999;
        internal void WriteDrinkMenu(List<Drink> drinks)
        {
            pnlMenu.Controls.Clear();
            checkBoxes.Clear();
            txtBoxes.Clear();
            this.drinks = drinks;

            CheckBox chkBox;
            TextBox txtBox;
            Label lbl;
            //Placementof dynamic controls
            for (int i = 0; i < drinks.Count; i++) 
            {
                //Checkbox
                chkBox = new CheckBox();
                chkBox.Location = new Point(left, top + i * chkYdistance);
                chkBox.Size = new Size(chkXSize, txtYSize);
                chkBox.Text = drinks[i].ToPriceList();
                chkBox.TextAlign = ContentAlignment.MiddleLeft;

                chkBox.CheckedChanged += new EventHandler(this.chkBox_CheckedChanged);

                //TextBoxes
                txtBox = new TextBox();
                txtBox.Location = new Point(left + chkXSize, chkBox.Location.Y - 2);
                txtBox.Size = new Size(txtXSize, txtYSize);

                //Label
                lbl = new Label();
                lbl.AutoSize = true;
                lbl.Location = new Point(txtBox.Location.X + txtXSize + txtBoxLblDistance, chkBox.Location.Y);
                lbl.Text = "pcs";
                //put the controls on the panel
                pnlMenu.Controls.Add(chkBox);
                pnlMenu.Controls.Add(txtBox);
                pnlMenu.Controls.Add(lbl);

                //Add the controls to the appropriate list
                checkBoxes.Add(chkBox);
                txtBoxes.Add(txtBox);
            }
        }

        private void chkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkBox = (CheckBox)sender;
            if (!chkBox.Checked)
            {
                int i = checkBoxes.IndexOf(chkBox);
                txtBoxes[i].BackColor = Color.White;
                txtBoxes[i].Text = "";
            }
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            //Ordering
            bool isSelected = false, isWrongPcs = false;
            int pcs = 0;
            for (int i = 0; i < checkBoxes.Count; i++)
            {
                if (checkBoxes[i].Checked)
                {
                    isSelected = true;
                    try
                    {
                        pcs = int.Parse(txtBoxes[i].Text);
                        if (pcs <= 0 || pcs > maxQuantity) throw new Exception();
                        drinks[i].Order(pcs);
                        txtBoxes[i].BackColor = Color.White;
                        checkBoxes[i].Checked = false;
                        txtBoxes[i].Clear();
                        {

                        }
                    }
                    catch (Exception)
                    {

                        txtBoxes[i].BackColor = Color.Salmon;
                        isWrongPcs = true;
                    }
                }
            }
            if (!isSelected)
            {
                MessageBox.Show("There is no selected item", "Warning");
            }
            else if (isWrongPcs)
            {
                MessageBox.Show("The pieces colored in red are incorrect", "Warning");
            }
        }
        private void billMenuItem_Click(object sender, EventArgs e)
        {
            BillForm billForm = new BillForm();
            billForm.Write(drinks);
            billForm.ShowDialog();
        }
        private void payMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Drink item in drinks)
            {
                item.Pay();
            }
        }

        private void DrinkForm_Load(object sender, EventArgs e)
        {

        }
    }
}
