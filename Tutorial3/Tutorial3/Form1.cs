using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial3
{
    public partial class FormCalcSalePrice : Form
    {
        // Declare GLOBAL variables
        decimal originalPrice;
        decimal discountPercentage;
        decimal discountAmount;
        decimal salePrice;

        public FormCalcSalePrice()
        {
            InitializeComponent();
        }

        private void FormCalcSalePrice_Load(object sender, EventArgs e)
        {

        }

        private void textBoxOriginal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSale_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalcSalePrice_Click(object sender, EventArgs e)
        {

            // Data conversion statments
            originalPrice = decimal.Parse(textBoxOriginal.Text);
            discountPercentage = (decimal.Parse(textBoxDiscount.Text)) / 100;

            // Calculations
            discountAmount = discountPercentage * originalPrice;
            salePrice = originalPrice - discountAmount;

            // Define display type ("c" = currency; "n3" = 3 decimal places; "a" = number)
            textBoxSale.Text = salePrice.ToString("c");

      

            


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You save " + discountAmount.ToString("c") + ".");
            this.Close();
        }
    }
}
