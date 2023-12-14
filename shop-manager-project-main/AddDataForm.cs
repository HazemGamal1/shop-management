using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopManager
{
    public partial class AddDataForm : Form
    {
        public AddDataForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 manage = new Form1();
            this.Hide();
            manage.ShowDialog();
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text.Trim();
            //Validate name
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a valid name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Validate category
            string category = categoryComboBox.Text;
            if (category != "Cameras" && category != "Phones" && category != "Accessories")
            {
                MessageBox.Show("Please select a valid category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate quantity
            int quantity;
            if (!int.TryParse(quantityNum.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity more than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate cost
            double cost;
            if (!double.TryParse(costTxt.Text, out cost) || cost <= 0)
            {
                MessageBox.Show("Please enter a valid cost more than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate profit
            double profit;
            if (!double.TryParse(profitTxt.Text, out profit) || profit < 0)
            {
                MessageBox.Show("Please enter a valid profit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Pushing Data To Form1 List
             Form1.DataList.PushNewProduct(nameTxt.Text, categoryComboBox.Text, int.Parse(quantityNum.Text), double.Parse(costTxt.Text), double.Parse(profitTxt.Text));


            //Clean Up
            ClearForm();

            //set focus to the first input field if needed
            nameTxt.Focus();
        }
        private void ClearForm()
        {
            nameTxt.Text = "";
            categoryComboBox.SelectedIndex = -1; // Reset category selection
            quantityNum.Value = 0;
            costTxt.Text = "";
            profitTxt.Text = "";
        }
        private void AddDataForm_Load(object sender, EventArgs e)
        {
            nameTxt.Focus();
        }
    }
}
