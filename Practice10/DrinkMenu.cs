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
    public partial class DrinkMenuForm : Form
    {
        public DrinkMenuForm()
        {
            InitializeComponent();
        }
        //The drinks list will be used in other methods too so we have to declare it here.
        private List<Drink> drinks = new List<Drink>();
        //They are used for ordering
        private List<CheckBox> chkBoxes = new List<CheckBox>();
        private List<TextBox> txtBoxes = new List<TextBox>();
        //The distance for the placement of the dynamic controls
        private int left = 10, top = 10, chkXSize = 250, chkYDistance = 40, txtXsize = 30, txtYSize = 17, txtBoxLblDistance = 5;

       

        private int maxQuantity = 999;

        private void DrinkMenuForm_Load(object sender, EventArgs e)
        {

        }

        internal void WriteDrinkMenu(List<Drink> drinks)
        {
            pnlMenu.Controls.Clear();
            chkBoxes.Clear();
            txtBoxes.Clear();

            this.drinks = drinks;
            CheckBox chkBox;
            TextBox txtBox;
            Label lbl;

            //Placement of the dynamic controls
            for (int i = 0; i < drinks.Count; i++)
            {
                //chkBox
                chkBox = new CheckBox();
                chkBox.Location = new Point(left, top + i * chkYDistance);
                chkBox.Size = new Size(chkXSize, txtYSize);
                chkBox.Text = drinks[i].ToPriceList();
                chkBox.TextAlign = ContentAlignment.MiddleLeft;
                chkBox.CheckedChanged += new EventHandler(this.chkBox_CheckedChanged);

                //txtBox
                txtBox = new TextBox();
                //Both of these locations are great
                //txtBox.Location=new Point(left+chkXSize,chkBox.Location.Y-2);
                txtBox.Location = new Point(left + chkXSize, chkBox.Location.Y - 2);
                txtBox.Size = new Size(txtXsize, txtYSize);

                //Lbl
                lbl = new Label();
                lbl.AutoSize = true;
                lbl.Location = new Point(txtBox.Location.X + txtXsize + txtBoxLblDistance, chkBox.Location.Y);
                lbl.Text = "pcs";

                //Put the controls on to the panel
                pnlMenu.Controls.Add(chkBox);
                pnlMenu.Controls.Add(txtBox);
                pnlMenu.Controls.Add(lbl);
                //Add the controls to their appropriate lists
                chkBoxes.Add(chkBox);
                txtBoxes.Add(txtBox);
            }
        }

        private void chkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkBox = (CheckBox)sender;
            if (!chkBox.Checked)
            {
                int i = chkBoxes.IndexOf(chkBox);
                txtBoxes[i].BackColor = Color.White;
                txtBoxes[i].Text = "";
            }
        }
        private void BtnOrder_Click(object sender, EventArgs e)
        {
            bool isSelected = false, isWrongPcs = false;
            int pcs = 0;
            for(int i = 0; i < chkBoxes.Count; i++)
            {
                if (chkBoxes[i].Checked)
                {
                    isSelected = true;
                    try
                    {
                        pcs = int.Parse(txtBoxes[i].Text);
                        if (pcs <= 0 || pcs > maxQuantity) throw new Exception();
                        drinks[i].Order(pcs);
                        txtBoxes[i].BackColor = Color.White;
                        chkBoxes[i].Checked = false;
                        txtBoxes[i].Clear();
                    }
                    catch (Exception)
                    {

                        txtBoxes[i].BackColor=Color.Salmon;
                        isWrongPcs = true;
                    }
                }
            }
            if (!isSelected)
            {
                MessageBox.Show("There are no selected items", "warning");
            }
            else if (isWrongPcs)
            {
                MessageBox.Show("The pieces colored by red are incorrect", "Warning");
            }

        }
        private void BillMenuItem_Click(object sender, EventArgs e)
        {
            BillForm billForm = new BillForm();
            billForm.Write(drinks);
            billForm.ShowDialog();
        }
        private void PayMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Drink item in drinks)
            {
                item.Pay();
            }
        }
    }
}
