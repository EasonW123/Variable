using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Wayne_Click(object sender, EventArgs e)
        {
            // Variable declared 
            double WayneNumber;

            // the number the variable is storing
            WayneNumber = 99;

            //When button is clicked this starts 
            OutPutLabel.Text = "Wayne Gretzky Number Is " + WayneNumber;
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            // Variable declared 
            double Radius, Pi, Product;

            //giving the variable numbers
            Radius = 15;
            Pi = 3.14;

            //when button is clicked it calculates 
            Product = Radius * Radius * Pi;
            OutPutLabel.Text = "The Area of a Circle with a 15cm ";
            OutPutLabel.Text += "\n Radius is: " + Product;

        }

        private void Carpet_Click(object sender, EventArgs e)
        {
            // declare the variables
            double Length, Width;
            double Product, Price;

            //giving the variable stuff to store
            Length = 8.5;
            Width = 6;
            Price = 19.95;
            Product = Length * Width * Price;

            // putting it on the screen
            OutPutLabel.Text = "The Area Of A Room With Dimensions ";
            OutPutLabel.Text += "\n 8.5m x 6m Is 51m^2 ";
            OutPutLabel.Text += "\n\n The Cost to Carpet This Area At $19.95 ";
            OutPutLabel.Text += "\n Per Square Metre Is $" + Product;
        }

        private void Sale_Click(object sender, EventArgs e)
        {
            // declare the variable 
            double shirt, tax;
            double total, tendered, change;

            //giving variables stuff to store
            shirt = 12.49;
            tax = shirt * .13;
            total = shirt + tax;
            tendered = 20;
            change = tendered - total;

            //showing on the program 
            OutPutLabel.Text = "Bill of sale";
            OutPutLabel.Text += "\n\nShirt:    $" + shirt;
            OutPutLabel.Text += "\n\nTax:      $" + tax;
            OutPutLabel.Text += "\nTotal:      $" + total;
            OutPutLabel.Text += "\n\nTendered: $" + tendered;
            OutPutLabel.Text += "\n change:    $" + change;
        }
    }
}
