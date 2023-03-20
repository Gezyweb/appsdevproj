using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void wishlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionOutputBox.Text = wishlist.Text;
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            wishlist.Items.Add("House no roof");
            wishlist.Items.Add("faucet no water");
            wishlist.Items.Add("Bread");
            wishlist.Items.Add("100000 pesos");
            wishlist.Items.Add("Car no wheels");
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            wishlist.Sorted = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            wishlist.Items.Clear();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            countOutputBox.Text = Convert.ToString(wishlist.Items.Count);
        }

        private void selectionOutputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void countOutputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
