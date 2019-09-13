using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        public object ComboBox1 { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            string order = orderComboBox.Text;
            int productQuantity = Convert.ToInt32(quantityTextBox.Text);
            int ProAmount = 0;

            if (orderComboBox.Text == "Black-120") {
                ProAmount = 120;
            }
            else if (orderComboBox.Text== "Cold-100") {
                ProAmount = 100;
            }
            else if (orderComboBox.Text == "Hot-90")
            {
                ProAmount = 90;
            }
            else if (orderComboBox.Text == "Reguler-80")
            {
                ProAmount = 80;
            }
            int totalPrice = ProAmount * productQuantity;

            richTextBox1.Text = "Customer Name: "+ CusNameTextBox.Text + "\n" +
               "Contact Number: " + contactTextBox.Text+ "\n" +
               "Address: " + addressTextBox.Text+ "\n " +
               "Order Amount:" + orderComboBox.SelectedItem + "\n" +
               "Quantity Value: " + quantityTextBox.Text+ "\n" +
               "Total Price: "+ totalPrice;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
