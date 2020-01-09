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

namespace PizzaSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
        }
        private int sizeSmall = 32, sizeLarge = 45;
        private List<Pizza> pizzas = new List<Pizza>();

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            visibilitySet(false);
        }

        private void visibilitySet(bool visibleOrNot)
        {
            foreach (Control item in this.Controls)
            {
                item.Visible = visibleOrNot;
            }
            BtnLoadData.Visible = !visibleOrNot;
        }

        private void BtbLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputData())
                {
                    DisplayControls();
                    visibilitySet(true);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private bool InputData()
        {
            DialogResult result = openFileDialog1.ShowDialog();
            bool success = false;
            if (result==DialogResult.OK)
            {
                StreamReader reader = null;
                try
                {
                    string filename = openFileDialog1.FileName;
                    reader = new StreamReader(filename);
                    ReadingData(reader);
                    success = true;
                }
                catch (Exception)
                {

                    MessageBox.Show("There is an error when we read the file", "Error");
                    success = false;
                }
                finally
                {
                    if (reader!=null)
                    {
                        reader.Close();
                    }
                }
            }
            return success;
        }

        private void ReadingData(StreamReader reader)
        {
            string dataLine;
            while (!reader.EndOfStream)
            {
                dataLine = reader.ReadLine();
                string[] data = dataLine.Split(';');
                pizzas.Add(new Pizza(data[0], int.Parse(data[1]), int.Parse(data[2])));
            }
        }

        

        private void DisplayControls()
        {
            LblSmall.Text = sizeSmall + " cm ";
            LblLarge.Text = sizeLarge+ " cm ";
            checkBox1.Text = pizzas[0].Name;
            rdBtn1Small.Text = pizzas[0].SmallSizePrice + " Ft ";
            rdBtn1Large.Text = pizzas[0].LargeSizePrice + " Ft ";
            checkBox2.Text = pizzas[1].Name;
            rdBtn2Small.Text = pizzas[1].SmallSizePrice + " Ft ";
            rdBtn2Large.Text = pizzas[1].LargeSizePrice + " Ft ";
           
            
        }

        

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int sum = 0, price = 0, piece = 0;
                //if the user chooses the first pizza
                if (checkBox1.Checked)
                {
                    if (rdBtn1Small.Checked) price = pizzas[0].SmallSizePrice;
                    else if (rdBtn1Large.Checked) price = pizzas[0].LargeSizePrice;
                    else throw new MissingFieldException("Choose size!");
                    piece = int.Parse(TxtPizza1.Text);
                    if (piece <= 0) throw new ArgumentOutOfRangeException("Not a negative value");
                    sum += price * piece;
                }
                //if the user selects the second checkbox
                if (checkBox2.Checked)
                {
                    if (rdBtn2Small.Checked) price = pizzas[1].SmallSizePrice;
                    else if (rdBtn2Large.Checked) price = pizzas[1].LargeSizePrice;
                    else throw new MissingFieldException("Choose a size");
                    piece = int.Parse(TxtPizza2.Text);
                    if (piece <= 0) throw new ArgumentOutOfRangeException("Do not give a negative value");
                    sum += price * piece;
                }
                if (!checkBox1.Checked && !checkBox2.Checked) throw new MissingFieldException("Choose a pizza");
                TxtPayable.Text = sum + "Ft";
            }
            catch (FormatException)
            {
                MessageBox.Show("The number of pieces of pizza is a wrong value");
            }
            catch(ArgumentOutOfRangeException aox)
            {
                MessageBox.Show(aox.Message, "Error");
            }
            catch(MissingFieldException mex)
            {
                MessageBox.Show(mex.Message, "Error");
            }
            catch (Exception)
            {

                MessageBox.Show("Some error was", "Error");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is CheckBox) (item as CheckBox).Checked = false;
                if (item is TextBox) (item as TextBox).Clear();
                if (item.HasChildren)
                {
                    foreach(Control child in item.Controls)
                    {
                        if (child is RadioButton) (child as RadioButton).Checked = false;
                    }
                }
            }
        }
    }
}
