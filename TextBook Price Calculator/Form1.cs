using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBook_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        double total = 0;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double purchasedValue = 0;
            int age = 0;
            if (numericAge.Value >= 0 && numericPrice.Value >= 0 && //checking that neither are negative
                int.TryParse(numericAge.Value.ToString(), out age) && Double.TryParse(numericPrice.Value.ToString(), out purchasedValue)) 
                // using tryparse and converting age to an int and value to a double
            {
                double cost = calculateCurrentValue(purchasedValue, age); // calling calculate function with said values
                total += cost;
                labelOutput.Text = "Current Book Price: " + cost + "\nTotal Price is: " + total;
            }
            else
            {
                numericAge.Value = 0;
                numericPrice.Value = 0;
                MessageBox.Show("Your number must be 0 or above");
            }
        }
        double calculateCurrentValue(double purchasedValue, int age) // takes double and int, returns deprecation or 0
        {
            double deprecation = purchasedValue * 0.2 * age;
            if (deprecation > purchasedValue)
            {
                return 0;
            }
            return purchasedValue - deprecation;
        }
        private void btnEndQuote_Click(object sender, EventArgs e)
        {
            total = 0; // reset total and total text
            labelOutput.Text = "No Total Price Yet!";
        }








        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericAge_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericPrice_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
