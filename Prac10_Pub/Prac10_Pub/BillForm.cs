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
    public partial class BillForm: Form
    {
        private RichTextBox rchTxtBill;

        public BillForm()
        {
            InitializeComponent();
        }


        internal void Write(List<Drink> drinks)
        {
            rchTxtBill.Clear();
            foreach (Drink item in drinks)
            {
                if (item.OrderedQuantity!=0)
                {
                    rchTxtBill.Text += item.ToString() + "\r\n";
                }
            }
        }

        private void InitializeComponent()
        {
            this.rchTxtBill = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchTxtBill
            // 
            this.rchTxtBill.Location = new System.Drawing.Point(64, 40);
            this.rchTxtBill.Name = "rchTxtBill";
            this.rchTxtBill.Size = new System.Drawing.Size(637, 220);
            this.rchTxtBill.TabIndex = 0;
            this.rchTxtBill.Text = "";
            // 
            // BillForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 347);
            this.Controls.Add(this.rchTxtBill);
            this.Name = "BillForm";
            this.ResumeLayout(false);

        }
    }
}
