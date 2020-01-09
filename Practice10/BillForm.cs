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
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }
       
internal void Write(List<Drink> drinks)
        {
            rchTxtBill.Clear();
            foreach (Drink item in drinks)
            {
                if (item.OrderedQuantity != 0)
                {
                    rchTxtBill.Text += item.ToString() + "\r\n";
                }
            }
        }
    }
}
