using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;



namespace shopManager
{
    public partial class Form1 : Form
    {
        private static StackDataList dataList = new StackDataList();
        internal static StackDataList DataList
        {
            get { return dataList; }
        }
        public Form1()
        {
            InitializeComponent();
            dataGridView.CellContentClick += dataGridView_CellContentClick;
        }
        //Global variables for searching
        bool byName = false;
        bool byID = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load existing products into dataGridView
            LoadProductsToDataGridView();
            byName = true;
            bynameButton.BackColor = Color.Green;

        }
        List<Product> products = DataList.GetAllProducts();
        private void LoadProductsToDataGridView()
        {
            // Clear existing data
            dataGridView.Rows.Clear();

            // Get all products from the stack
            //List<Product> products = DataList.GetAllProducts();

            // Populate dataGridView with product data
            foreach (Product product in products)
            {
                dataGridView.Rows.Add(product.Name, product.ID, product.Category, product.Quantity, product.TotalPrice(), "Edit", "Delete");
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs dataGrid)
        {
            if (dataGrid.RowIndex >= 0)
            {
                int columnIndex = dataGrid.ColumnIndex;
                int rowIndex = dataGrid.RowIndex;

                // Check if the "Edit" button is clicked
                if (columnIndex == dataGridView.Columns["Column6"].Index)
                {
                    // Handle edit logic, for example, show a form for editing
                    // You can use the rowIndex to get the corresponding Product from the stack
                    // Update the product in the stack and reload data into the dataGridView
                    // Example:
                    // Product selectedProduct = dataList.GetProductAtIndex(rowIndex);
                    // ShowEditForm(selectedProduct);
                }
                // Check if the "Delete" button is clicked
                else if (columnIndex == dataGridView.Columns["Column7"].Index)
                {
                    string prodId = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                    DataList.RemovedSpesProduct(int.Parse(prodId));
                    LoadProductsToDataGridView();
                }
            }
        }

        //Search by name btn trigger
        private void bynameButton_Click(object sender, EventArgs e)
        {
            if (!byName)
            {
                byID = false;
                byidButton.BackColor = Color.FromArgb(42, 61, 85);
                bynameButton.BackColor = Color.Green;
                byName = true;
            }
        }
        //Search by ID btn trigger
        private void byidButton_Click(object sender, EventArgs e)
        {
            byName = false;
            byidButton.BackColor = Color.Green;
            bynameButton.BackColor = Color.FromArgb(42, 61, 85);
            byID = true;
        }

        //Searching 
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (byName)
            {
                foreach (Product product in products)
                {
                    if (product.Name.Trim().ToLower() == searchTextBox.Text.Trim().ToLower())
                    {
                        dataGridView.Rows.Clear();
                        dataGridView.Rows.Add(product.Name, product.ID, product.Category, product.Quantity, product.TotalPrice(), "Edit", "Delete");
                    }
                    if (searchTextBox.Text == "")
                    {
                        dataGridView.Rows.Clear();
                        for (int i = 0; i < products.Count; i++)
                        {
                            dataGridView.Rows.Add(products[i].Name, products[i].ID, products[i].Category, products[i].Quantity, products[i].TotalPrice(), "Edit", "Delete");
                        }
                    }
                }
            }
            else if (byID)
            {
                foreach (Product product in products)
                {
                    if (product.ID == int.Parse(searchTextBox.Text))
                    {
                        dataGridView.Rows.Clear();
                        dataGridView.Rows.Add(product.Name, product.ID, product.Category, product.Quantity, product.TotalPrice(), "Edit", "Delete");
                    }
                    if (searchTextBox.Text == "")
                    {
                        dataGridView.Rows.Clear();
                        for (int i = 0; i < products.Count; i++)
                        {
                            dataGridView.Rows.Add(products[i].Name, products[i].ID, products[i].Category, products[i].Quantity, products[i].TotalPrice(), "Edit", "Delete");
                        }
                    }
                }
            }
        }
        //Switch to add data form
        private void addBtn_Click(object sender, EventArgs e)
        {
            AddDataForm dataForm = new AddDataForm();
            this.Hide();
            dataForm.ShowDialog();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}