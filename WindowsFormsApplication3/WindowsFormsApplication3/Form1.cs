using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void count_Click(object sender, EventArgs e)
        {

        }

        private void sortbtn_Click(object sender, EventArgs e)
        {
            wishList.Sorted = true;
        }

        private void wishList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionBox.Text = wishList.Text;
        }

        private void fillBtn_Click(object sender, EventArgs e)
        {
            wishList.Items.Add("House");
            wishList.Items.Add("Money");
            wishList.Items.Add("Car");
            wishList.Items.Add("Compound");
            wishList.Items.Add("Mansion");
            wishList.Items.Add("100,000,000");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            wishList.Items.Clear();
        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            countBox.Text = Convert.ToString(wishList.Items.Count);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
