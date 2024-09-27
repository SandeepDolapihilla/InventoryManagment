using InventoryManagment.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace InventoryManagment
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            LoadProductData();
        }

        public void LoadProductData()
        {
            using (var context = new MyDBContext())
            {
                var productList = context.Details.ToList();
                dataGridView1.DataSource = productList;
            }
        }
        public void ClearControls()
        {
            txtBrand.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtProductName.Clear();
            txtSearch.Clear();
            txtStkQnty.Clear();
            txtWeight.Clear();
            cmbxInventory.Text = "";
            lblShowCode.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var details = new Details
                {
                    ProductName = txtProductName.Text,
                    Brand = txtBrand.Text,
                    StockQuantity = txtStkQnty.Text,
                    Price = Convert.ToInt32(txtPrice.Text),
                    Inventory = cmbxInventory.Text,
                    Weight = Convert.ToInt32(txtWeight.Text),
                    Description = txtDescription.Text,
                };
                using (var context = new MyDBContext())
                {
                    context.Details.Add(details);
                    context.SaveChanges();
                }
                MessageBox.Show("Product Saved Successfully");
                LoadProductData();
                ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new MyDBContext())
                {
                    // Find the product by ProductID (assuming you get it from a textbox or another control)
                    int productId = Convert.ToInt32(txtSearch.Text);
                    var product = context.Details.FirstOrDefault(p => p.ProductID == productId);

                    if (product != null)
                    {
                        // Update the product details with form inputs
                        product.ProductName = txtProductName.Text;
                        product.Brand = txtBrand.Text;
                        product.StockQuantity = txtStkQnty.Text;
                        product.Price = Convert.ToInt32(txtPrice.Text);
                        product.Inventory = cmbxInventory.Text;
                        product.Weight = Convert.ToInt32(txtWeight.Text);
                        product.Description = txtDescription.Text;

                        // Save changes to the database
                        context.SaveChanges();
                        MessageBox.Show("Product updated successfully!");
                        LoadProductData();
                        ClearControls();
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new MyDBContext())
                {
                    int productId = Convert.ToInt32(txtSearch.Text);

                    var product = context.Details.FirstOrDefault(p => p.ProductID == productId);

                    if (product != null)
                    {
                        lblShowCode.Text = product.ProductID.ToString();
                        txtProductName.Text = product.ProductName;
                        txtBrand.Text = product.Brand;
                        txtStkQnty.Text = product.StockQuantity;
                        txtPrice.Text = product.Price.ToString();
                        cmbxInventory.Text = product.Inventory;
                        txtWeight.Text = product.Weight.ToString();
                        txtDescription.Text = product.Description;
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) // Proceed if the user clicks Yes
            {
                try
                {
                    using (var context = new MyDBContext())
                    {
                        // Get the ProductID from the input field
                        if (int.TryParse(txtSearch.Text, out int productId))
                        {
                            // Find the product by ProductID
                            var product = context.Details.FirstOrDefault(p => p.ProductID == productId);

                            if (product != null)
                            {
                                context.Details.Remove(product); // Remove the product from the database
                                context.SaveChanges();           // Save changes to the database
                                MessageBox.Show("Product deleted successfully!");
                                LoadProductData();
                                ClearControls();
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid Product ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];


                lblShowCode.Text = selectedRow.Cells["ProductID"].Value.ToString();
                txtProductName.Text = selectedRow.Cells["ProductName"].Value.ToString();
                txtBrand.Text = selectedRow.Cells["Brand"].Value.ToString();
                txtStkQnty.Text = selectedRow.Cells["StockQuantity"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
                cmbxInventory.Text = selectedRow.Cells["Inventory"].Value.ToString();
                txtWeight.Text = selectedRow.Cells["Weight"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["Description"].Value.ToString();
            }
        }
    }
}
